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
        public UserViewModel Profile { get; set; }
        public Command LoadProfileCommand { get; }

        public ProfileViewModel()
        {
            Title = "Profile";
            Profile = new UserViewModel();
            LoadProfileCommand = new Command(async () => await ExecuteLoadProfileCommand());
        }

        private async Task ExecuteLoadProfileCommand()
        {
            IsBusy = true;
            try
            {
                //Profile.Clear();
                var profile = await _authService.GetCurrentUser<UserViewModel>();
                Profile = profile;
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
