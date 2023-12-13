using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AdvanceUI.ConnectApi
{
    public class GenericService<T> where T: class, new()
    {
        private readonly HttpClient _client;
        public GenericService(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> Add(string apiPath,string token, T dto)
        {
            var str = new StringContent(JsonConvert.SerializeObject(dto));
            str.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var response = await _client.PostAsync(apiPath, str);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == null ? "Ekleme işlemi sırasında bir hata oluştu!" : "Eklendi.";
            }
            return null;
        }

        public async Task<string> Delete(string apiPath,string token, int id)
        {
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await _client.DeleteAsync($"{apiPath}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == null ? "Silme işlemi sırasında bir hata oluştu!" : "Silindi.";
            }
            return null;
        }

        public async Task<List<T>> GetAll(string apiPath, string token)
        {
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await _client.GetAsync(apiPath);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<T>>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<T> GetByID(string apiPath,string token, int id)
        {
            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var response = await _client.GetAsync($"{apiPath}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

        public async Task<string> Update(string apiPath, T dto)
        {
            var str = new StringContent(JsonConvert.SerializeObject(dto));
            str.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _client.PostAsync(apiPath, str);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result == null ? "Güncelleme işlemi sırasında bir hata oluştu!" : "Güncellendi.";
            }
            return null;
        }
    }
}
