using Flurl.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FixIt.Mobile.Services
{
    public class AuthService
    {
        private string _resource;
        public string endpoint = "https://localhost:5001/api";

        public AuthService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> Login<T>(object loginModel)
        {
            var url = $"{endpoint}/{_resource}/login";
            try
            {
                return await url.PostJsonAsync(loginModel).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string>>();

                //if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                //{
                //    await Application.Current.MainPage.DisplayAlert("Error", "Wrong username or password", "Try again");
                //}
                //throw;
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Pogrešno korisničko ime ili password!");

                await Application.Current.MainPage.DisplayAlert(null, stringBuilder.ToString(), "Pokušajte ponovo");
                return default(T);
            }
        }
        public async Task<T> Register<T>(object registerModel)
        {
            try
            {
                return await $"{endpoint}/{_resource}/register".PostJsonAsync(registerModel).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string>>();

                var stringBuilder = new StringBuilder();
                foreach (var x in errors)
                    stringBuilder.AppendLine($"{x.Value}");

                return default(T);
            }
        }
    }
}
