using FixIt.Models;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FixIt.Mobile.Services
{
    public class APIService
    {
        private readonly string _resource;
        public string endpoint = "https://localhost:5001/api";

        public static string token { get; set; }
        public static DateTime expiration { get; set; }

        public APIService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> Get<T>(object searchModel = null)
        {
            var query = "";
            if (searchModel != null)
                query = await searchModel?.ToQueryString();

            var list = await $"{endpoint}/{_resource}?{query}".WithOAuthBearerToken(token).GetJsonAsync<T>();

            return list;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{endpoint}/{_resource}/{id}";
            return await url.WithOAuthBearerToken(token).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{endpoint}/{_resource}";

            try
            {
                return await url.WithOAuthBearerToken(token).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> Update<T>(string id, object model)
        {
            try
            {
                var url = $"{endpoint}/{_resource}/{id}";

                return await url.WithOAuthBearerToken(token).PutJsonAsync(model).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

        public async Task<T> Delete<T>(int id)
        {
            try
            {
                var url = $"{endpoint}/{_resource}/{id}";
                return await url.WithOAuthBearerToken(token).DeleteAsync().ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> GetRecommendedServicesForUser<T>(string userId)
        {
            var list = await $"{endpoint}/{_resource}/{userId}/recommend".WithOAuthBearerToken(token).GetJsonAsync<T>();
            return list;
        }
    }
}

