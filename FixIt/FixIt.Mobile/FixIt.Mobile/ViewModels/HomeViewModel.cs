using FixIt.Mobile.Services;
using FixIt.Models.Models.Service;
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
    public class HomeViewModel : BaseViewModel
    {
        private AuthService _authService = new AuthService("Auth");
        private APIService _apiService = new APIService("User");

        public ObservableCollection<ServiceViewModel> RecommendedServices { get; }
        public Command LoadRecommendedServicesCommand { get; }

        public HomeViewModel()
        {
            RecommendedServices = new ObservableCollection<ServiceViewModel>();
            LoadRecommendedServicesCommand = new Command(async () => await ExecureLoadRecommendedServicesCommand());
        }

        private async Task ExecureLoadRecommendedServicesCommand()
        {
            IsBusy = true;
            try
            {
                RecommendedServices.Clear();
                var user = await _authService.GetCurrentUser<UserViewModel>();
                if (user != null)
                {
                    var services = await _apiService.GetRecommendedServicesForUser<List<ServiceViewModel>>(user.Id);
                    if(services.Count > 0)
                    foreach (var service in services)
                    {
                        RecommendedServices.Add(service);
                    }
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
