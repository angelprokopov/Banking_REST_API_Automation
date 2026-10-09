using Banking_REST_API_Automation_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_REST_API_Automation_Framework.Clients
{
    public class TransactionClient
    {
        private readonly ApiClients _apiClient;

        public TransactionClient(ApiClients apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<HttpResponseMessage> CreateTransactionAsync(
            TransactionRequest request)
        {
            return await _apiClient.PostAsync(
                "/api/transactions",
                request);
        }
    }
}
