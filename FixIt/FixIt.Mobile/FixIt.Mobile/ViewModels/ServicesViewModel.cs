using FixIt.Mobile.Services;
using FixIt.Models.Models.Service;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FixIt.Mobile.ViewModels
{
    public class ServicesViewModel : BaseViewModel
    {
        private APIService _apiService = new APIService("Service");
        public ObservableCollection<ServiceViewModel> Services { get; }
        public Command LoadServicesCommand { get; }
        public Command AddItemCommand { get; }
        public Command<ServiceViewModel> ServiceTapped { get; }

        public ServicesViewModel()
        {
            Title = "Usluge";
            Services = new ObservableCollection<ServiceViewModel>();
            LoadServicesCommand = new Command(async () => await ExecuteLoadServicesCommand());

            //ServiceTapped = new Command<ServiceViewModel>(OnItemSelected);
        }

        private async Task ExecuteLoadServicesCommand()
        {
            IsBusy = true;

            try
            {
                Services.Clear();
                var services = await _apiService.Get<List<ServiceViewModel>>(null);
                foreach (var service in services)
                {
                    Services.Add(service);
                }
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
    }
}
