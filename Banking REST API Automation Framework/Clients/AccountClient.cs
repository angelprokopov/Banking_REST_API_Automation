using Banking_REST_API_Automation_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_REST_API_Automation_Framework.Clients
{
    public class AccountClient
    {
        private readonly ApiClients _clients;

        public AccountClient(ApiClients clients)
        {
            _clients = clients;
        }

        public async Task<HttpResponseMessage> GetAccountAsync(int accountId)
        {
            return await _clients.GetAsync($"/api/accounts/{accountId}");
        }

    }
}
