using FixIt.Mobile.Services;
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
    public class ProfileViewModel : BaseViewModel
    {
        private AuthService _authService = new AuthService("Auth");
        private APIService _apiService = new APIService("User");
        public ObservableCollection<UserViewModel> Profile { get; set; }
        public Command LoadProfileCommand { get; }

        public ProfileViewModel()
        {
            Title = "Profile";
            Profile = new ObservableCollection<UserViewModel>();
            LoadProfileCommand = new Command(async () => await ExecuteLoadProfileCommand());
        }

        private async Task ExecuteLoadProfileCommand()
        {
            IsBusy = true;
            try
            {
                Profile.Clear();
                var profile = await _authService.GetCurrentUser<UserViewModel>();
                var user = await _apiService.GetById<UserViewModel>(profile.Id);
                Profile.Add(user);
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
