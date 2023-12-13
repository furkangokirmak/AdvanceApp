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
    public class GenericService
    {
        private readonly HttpClient _httpClient;

        public GenericService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task<TResult> SendRequest<TResult, TObject>(string url, TObject data, HttpMethod method, string mediaType = null) where TResult : class, new()
        {
            var jsonContent = JsonConvert.SerializeObject(data);
            var content = new StringContent(jsonContent);
            content.Headers.ContentType = new MediaTypeHeaderValue(mediaType ?? "application/json");

            HttpRequestMessage request = new HttpRequestMessage(method, "https://localhost:44302/api/" + url);
            request.Content = content;

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResult>(responseContent);
            }

            return null;
        }

        public async Task<TResult> GetDatas<TResult>(string url) where TResult : class, new()
        {
            return await SendRequest<TResult, object>(url, null, HttpMethod.Get);
        }

        public async Task<TResult> PostDatas<TResult, TObject>(string url, TObject data, string mediaType = null) where TResult : class, new()
        {
            return await SendRequest<TResult, TObject>(url, data, HttpMethod.Post, mediaType);
        }

        public async Task<TResult> PutDatas<TResult, TObject>(string url, TObject data, string mediaType = null) where TResult : class, new()
        {
            return await SendRequest<TResult, TObject>(url, data, HttpMethod.Put, mediaType);
        }
    }
}
