using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdvanceUI.ConnectApi
{
    public class GenericService
    {
        private readonly HttpClient _httpClient;

        public GenericService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task<TResult> SendRequest<TResult, TObject>(string url, TObject data, HttpMethod method, string token = "", string mediaType = null) where TResult : class, new()
        {
            var jsonContent = JsonConvert.SerializeObject(data);
            var content = new StringContent(jsonContent);
            content.Headers.ContentType = new MediaTypeHeaderValue(mediaType ?? "application/json");

            HttpRequestMessage request = new HttpRequestMessage(method, "https://localhost:44302/api/" + url);
            request.Content = content;

            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResult>(responseContent);
            }

            return null;
        }

        public async Task<TResult> GetDatas<TResult>(string url, string token="") where TResult : class, new()
        {
            return await SendRequest<TResult, object>(url, null, HttpMethod.Get, token: token);
        }

        public async Task<TResult> PostDatas<TResult, TObject>(string url, TObject data, string token = "") where TResult : class, new()
        {
            return await SendRequest<TResult, TObject>(url, data, HttpMethod.Post, token: token);
        }
    }
}
