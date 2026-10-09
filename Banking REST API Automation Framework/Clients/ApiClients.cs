using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Banking_REST_API_Automation_Framework.Clients
{
    public class ApiClients
    {
        private readonly HttpClient _httpClient;

        public ApiClients(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetAsync(string endpoint)
        {
            return await _httpClient.GetAsync(endpoint);
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string endpoint, T request)
        {
            return await _httpClient.PostAsJsonAsync(endpoint, request);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string endpoint, T request)
        {
            return await _httpClient.PutAsJsonAsync(endpoint,request);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string endpoint) 
        { 
            return await _httpClient.DeleteAsync(endpoint);
        }
    }
}
