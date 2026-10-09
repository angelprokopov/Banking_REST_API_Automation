using Banking_REST_API_Automation_Framework.Clients;
using Banking_REST_API_Automation_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Banking_REST_API_Automation_Framework.Tests
{
    public class AuthenticationTests
    {
        private AuthClient _client = null;
        private AccountClient _accountClient;

        [SetUp]
        public void Setup()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("")
            };

            var apiClient = new ApiClients(httpClient);

            _client = new AuthClient(apiClient);
        }

        [Test]
        public async Task ValidLogin_ShouldReturn200()
        {
            var request = new LoginRequest
            {
                Username = "",
                Password = ""
            };

            var response = await _client.LoginAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task InvalidLogin_ShouldReturn401()
        {
            var request = new LoginRequest
            {
                Username = "invalid.user",
                Password = "WrongPassword"
            };

            var response = await _client.LoginAsync(request);

            Assert.That(
                response.StatusCode,
                Is.EqualTo(HttpStatusCode.Unauthorized));
        }

        [Test]
        public async Task GetExistingAccount_ShouldReturn200()
        {
            var response = await _accountClient.GetAccountAsync(1001);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task GetNonExistingAccount_ShouldReturn404()
        {
            var response = await _accountClient.GetAccountAsync(99999);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }

        [Test]
        public async Task GetAccount_ShouldReturnCorrectAccount()
        {
            var response = await _accountClient.GetAccountAsync(1001);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            var json = await response.Content.ReadAsStringAsync();

            using var document = JsonDocument.Parse(json);

            var accountId = document.RootElement.GetProperty("accountId").GetInt32();

            Assert.That(accountId, Is.EqualTo(1001));
        }             
    }
}
