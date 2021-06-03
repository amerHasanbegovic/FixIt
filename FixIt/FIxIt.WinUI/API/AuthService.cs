using FixIt.WinUI.Properties;

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

        //public async Task<T> Get<T>(object searchModel = null)
        //{
        //    var query = "";
        //    if (searchModel != null)
        //        query = await searchModel?.ToQueryString();

        //    var list = await $"{endpoint}{_resource}?{query}".GetJsonAsync<T>();

        //    return list;
        //}

        //public async Task<T> Login<T>(object loginModel)
        //{
        //    return await $"{endpoint}{_resource}/login".PostUrlEncodedAsync(new LoginModel
        //    {

        //    });
        //}
    }
}
