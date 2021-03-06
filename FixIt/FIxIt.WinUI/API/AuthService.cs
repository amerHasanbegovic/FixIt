using FixIt.WinUI.Properties;
using Flurl.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixIt.WinUI.API
{
    public class AuthService
    {
        private string _resource;
        public string endpoint = $"{Resources.ApiUrl}";

        public AuthService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> Login<T>(object loginModel)
        {
            try
            {
                return await $"{endpoint}/{_resource}/login-admin".PostJsonAsync(loginModel).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string>>();

                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Pogrešno korisničko ime ili password!");

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }
        public async Task<T> Register<T>(object registerModel)
        {
            try
            {
                return await $"{endpoint}/{_resource}/register-admin".PostJsonAsync(registerModel).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string>>();

                var stringBuilder = new StringBuilder();
                foreach (var x in errors)
                    stringBuilder.AppendLine($"{x.Value}");

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }
    }
}
