using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Banking_REST_API_Automation_Framework.Models;

namespace Banking_REST_API_Automation_Framework.Clients
{
    public class AuthClient
    {
        private readonly ApiClients _apiClient;

        public AuthClient(ApiClients api)
        {
            _apiClient = api;
        }

        public async Task<HttpResponseMessage> LoginAsync(LoginRequest request)
        {
            return await _apiClient.PostAsync("/api/auth/login", request);
        }
    }
}
