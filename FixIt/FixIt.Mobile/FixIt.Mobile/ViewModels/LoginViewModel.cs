using FixIt.Mobile.Services;
using FixIt.Mobile.Views;
using FixIt.Models.Models.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FixIt.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        private readonly AuthService _authService = new AuthService("Auth");

        string _username = string.Empty;
        public string Username { get { return _username; } set { SetProperty(ref _username, value); } }

        string _password = string.Empty;
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }

        public LoginViewModel() => LoginCommand = new Command(async () => await Login());

        private async Task Login()
        {
            IsBusy = true;
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert(null, "Oba polja su obavezna", "Pokušajte ponovo");
                return;
            }
            LoginModel loginModel = new LoginModel()
            {
                UserName = Username,
                Password = Password
            };
            var response = await _authService.Login<LoginResponseModel>(loginModel);
            if (response != null)
            {
                APIService.token = response.token;
                Application.Current.MainPage = new AppShell();
            }
        }
    }
}
