using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using AdvanceUI.DTOs.Employee;

namespace AdvanceUI.ConnectApi
{
    public class AuthService
    {
        private readonly HttpClient _client;

        public AuthService(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<EmployeeSelectDTO> Login(EmployeeLoginDTO employeeLoginDTO)
        {
            var str = new StringContent(JsonConvert.SerializeObject(employeeLoginDTO));
            str.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _client.PostAsync("Auth/Login", str);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<EmployeeSelectDTO>(await response.Content.ReadAsStringAsync());
            }
            return null;
        }

		public async Task<bool> Register(EmployeeRegisterDTO employeeRegisterDTO)
		{
			var str = new StringContent(JsonConvert.SerializeObject(employeeRegisterDTO));
			str.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			var response = await _client.PostAsync("Auth/Register", str);

			if (response.IsSuccessStatusCode)
			{
                return true;
			}
			return false;
		}
	}
}
