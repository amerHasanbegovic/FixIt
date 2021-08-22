using FixIt.Mobile.Services;
using FixIt.Models.Models.ServiceRequest;
using FixIt.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FixIt.Mobile.ViewModels
{
    public class HistoryViewModel : BaseViewModel
    {
        private AuthService _authService = new AuthService("Auth");
        private APIService _apiService = new APIService("User");
        public ObservableCollection<ServiceRequestViewModel> History { get; set; }
        public Command LoadHistoryCommand { get; }

        private string _notFound;
        public string NotFound
        {
            get { return _notFound; }
            set { SetProperty(ref _notFound, value); }
        }
        public HistoryViewModel()
        {
            Title = "Historija";
            History = new ObservableCollection<ServiceRequestViewModel>();
            LoadHistoryCommand = new Command(async () => await ExecuteLoadHistoryCommand());
        }

        private async Task ExecuteLoadHistoryCommand()
        {
            IsBusy = true;
            try
            {
                History.Clear();
                var profile = await _authService.GetCurrentUser<UserViewModel>();
                var history = await _apiService.GetById<UserViewModel>(profile.Id);
                if (history != null)
                    if (history.ServiceRequests != null)
                        foreach (var h in history.ServiceRequests)
                        {
                            History.Add(h);
                        }
                if (History.Count == 0)
                    NotFound = "Još uvijek niste poslali nijedan zahtjev.";
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
