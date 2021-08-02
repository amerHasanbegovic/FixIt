using FixIt.Mobile.Services;
using FixIt.Mobile.Views;
using FixIt.Models.Models.Auth;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FixIt.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public Command RegisterCommand { get; }
        private readonly AuthService _authService = new AuthService("Auth");
        
        string _firstName = string.Empty;
        public string FirstName { get { return _firstName; } set { SetProperty(ref _firstName, value); } }

        string _lastName = string.Empty;
        public string LastName { get { return _lastName; } set { SetProperty(ref _lastName, value); } }

        string _username = string.Empty;
        public string Username { get { return _username; } set { SetProperty(ref _username, value); } }

        string _email = string.Empty;
        public string Email { get { return _email; } set { SetProperty(ref _email, value); } }
        
        string _password = string.Empty;
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }

        public RegisterViewModel() => RegisterCommand = new Command(async () => await Register());

        private async Task Register()
        {
            IsBusy = true;
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) 
                || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Username) 
                || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert(null, "Sva polja su obavezna", "Pokušajte ponovo");
                return;
            }
            RegisterModel registerModel = new RegisterModel()
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                UserName = Username,
                Password = Password
            };
            var response = await _authService.Register<ResponseModel>(registerModel);
            if (response != null)
            {
                await Application.Current.MainPage.DisplayAlert(null, $"{response.Message}", "OK");
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}
