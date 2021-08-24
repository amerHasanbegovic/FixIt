using FixIt.Mobile.Services;
using FixIt.Models.Models.Payment;
using FixIt.Models.Models.PaymentType;
using FixIt.Models.Models.Service;
using FixIt.Models.Models.ServiceRequest;
using FixIt.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FixIt.Mobile.ViewModels
{
    public class ServiceRequestsViewModel : BaseViewModel
    {
        private APIService _apiService = new APIService("PaymentType");
        private APIService _paymentService = new APIService("Payment");
        private AuthService _authService = new AuthService("Auth");
        private APIService _requestService = new APIService("ServiceRequest");
        public ServiceViewModel Service { get; set; }
      
        public Command LoadDataCommand { get; set; }
        public Command SendRequestCommand { get; set; }

        private string _jobDescription = string.Empty;
        private string _cardNumber = string.Empty;
        private string _fullName = string.Empty;
        private string _cvv = string.Empty;
        private DateTime _cardDate = DateTime.Now;
        //private PaymentTypeViewModel _onlinePayment;
        //private PaymentTypeViewModel _reguralPayment;
        private List<PaymentTypeViewModel> _paymentTypes;
        private int _paymentTypeId = 0;

        public string CardNumber
        {
            get { return _cardNumber; }
            set { SetProperty(ref _cardNumber, value); }
        }
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }
        public string CVV
        {
            get { return _cvv; }
            set { SetProperty(ref _cvv, value); }
        }
        public string JobDescription
        {
            get { return _jobDescription; }
            set { SetProperty(ref _jobDescription, value); }
        }
        public DateTime CardDate
        {
            get { return _cardDate; }
            set { SetProperty(ref _cardDate, value); }
        }
        //public PaymentTypeViewModel OnlinePayment
        //{
        //    get { return _onlinePayment; }
        //    set { SetProperty(ref _onlinePayment, value); }
        //}
        //public PaymentTypeViewModel RegularPayment
        //{
        //    get { return _reguralPayment; }
        //    set { SetProperty(ref _reguralPayment, value); }
        //}
        public List<PaymentTypeViewModel> PaymentTypes
        {
            get { return _paymentTypes; }
            set { SetProperty(ref _paymentTypes, value); }
        }
        public int PaymentTypeId
        {
            get { return _paymentTypeId; }
            set { SetProperty(ref _paymentTypeId, value); }
        }
        public ServiceRequestsViewModel()
        {
            //PaymentTypes = new List<PaymentTypeViewModel>();
            //LoadDataCommand = new Command(async () => await LoadData());
            //await LoadData();
            Load();
            SendRequestCommand = new Command(async () => await SendRequeest());
        }

        private async void Load()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            IsBusy = true;
            try
            {
                //PaymentTypes.Clear();
                var types = await _apiService.Get<List<PaymentTypeViewModel>>();
                //foreach (var t in types)
                //{
                //    PaymentTypes.Add(t);
                //}
                //if (types != null)
                //{
                //    OnlinePayment = types[0];
                //    RegularPayment = types[1];
                //}
                if(types != null)
                    PaymentTypes = types;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async Task SendRequeest()
        {
            if(PaymentTypeId == 0)
            {
                await Application.Current.MainPage.DisplayAlert("", "Niste odabrali način plaćanja!", "OK");
                return;
            }
            if (PaymentTypeId == 1)
            {
                if (string.IsNullOrWhiteSpace(FullName))
                {
                    await Application.Current.MainPage.DisplayAlert("", "Ime i prezime je obavezno polje!", "OK");
                    return;
                }
                if (FullName.Any(char.IsDigit))
                {
                    await Application.Current.MainPage.DisplayAlert("", "Brojevi u imenu i prezimenu nisu dozovljeni!", "OK");
                    return;
                }

                if (string.IsNullOrWhiteSpace(CardNumber))
                {
                    await Application.Current.MainPage.DisplayAlert("", "Broj računa je obavezno polje!", "OK");
                    return;
                }
                if (!CardNumber.Any(char.IsDigit))
                {
                    await Application.Current.MainPage.DisplayAlert("", "Slova u broju računa nisu dozvoljena!", "OK");
                    return;
                }
                if (CardNumber.Length != 16)
                {
                    await Application.Current.MainPage.DisplayAlert("", "Broj računa mora imati 16 cifara!", "OK");
                    return;
                }
                if (string.IsNullOrWhiteSpace(CVV))
                {
                    await Application.Current.MainPage.DisplayAlert("", "CVV kod je obavezno polje!", "OK");
                    return;
                }
                if (CVV.Length != 3)
                {
                    await Application.Current.MainPage.DisplayAlert("", "CVV kod mora imati 3 cifre!", "OK");
                    return;
                }
                if(CardDate.Date < DateTime.Now)
                {
                    await Application.Current.MainPage.DisplayAlert("", "Datum važenja kartice nije validan!", "OK");
                    return;
                }
            }

            PaymentInsertModel paymentModel = new PaymentInsertModel()
            {
                CreditCardNumber = CardNumber,
                PaymentTypeId = PaymentTypeId,
                CVV = CVV,
                FullName = FullName,
                PaymentDate = DateTime.Now,
                Total = Service.Price,
                CardExpirationDate = CardDate
            };

            var payment = await _paymentService.Insert<PaymentViewModel>(paymentModel);
            if(payment != null)
            {
                var user = await _authService.GetCurrentUser<UserViewModel>();
                ServiceRequestInsertModel requestModel = new ServiceRequestInsertModel()
                {
                    JobDescription = JobDescription,
                    RequestDate = DateTime.Now,
                    ServiceId = Service.Id,
                    UserId = user.Id,
                    PaymentId = payment.Id
                };
                var request = await _requestService.Insert<ServiceRequestViewModel>(requestModel);   
                
                if(request != null)
                {
                    await Application.Current.MainPage.DisplayAlert("", "Uspješno ste poslali zahtjev!", "OK");
                    await Application.Current.MainPage.Navigation.PopToRootAsync();
                }
            }
        }
    }
}
