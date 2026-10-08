# REST API Test Automation Framework – C#

A REST API automation framework built with C#, NUnit
and HttpClient for testing a simulated banking API.

## Technologies

- C#
- .NET
- NUnit
- HttpClient
- REST API
- JSON
- HTTP/HTTPS
- GitHub Actions

## Test Coverage

### Authentication
- Valid login
- Invalid credentials
- Missing credentials
- Unauthorized access

### Customers
- Get existing customer
- Get non-existing customer
- Validate customer response

### Accounts
- Get account
- Validate account data
- Invalid account ID

### Transactions
- Create transaction
- Invalid amount
- Zero amount
- Invalid transaction type
- Missing account
- Data-driven transaction tests

## HTTP Status Codes

200 OK
201 Created
400 Bad Request
401 Unauthorized
404 Not Found

## Architecture

Tests
  ↓
API Clients
  ↓
HttpClient
  ↓
REST API
  ↓
JSON Response
  ↓
Assertions
