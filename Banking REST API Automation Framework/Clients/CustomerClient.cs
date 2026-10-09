using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_REST_API_Automation_Framework.Clients
{
    public class CustomerClient
    {
        private readonly ApiClients _apiClients;
        public CustomerClient(ApiClients apiClients)
        {
            _apiClients = apiClients;
        }

        public async Task<HttpResponseMessage> GetCustomerAsync(int customerId)
        {
            return await _apiClients.GetAsync($"/api/customer/{customerId}");
        }
    }
}
