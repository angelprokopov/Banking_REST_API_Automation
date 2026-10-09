using Banking_REST_API_Automation_Framework.Models;

namespace RestApiTests.TestData;

public static class TestTransactions
{
    public static TransactionRequest ValidCreditTransaction => new()
    {
        AccountId = 1001,
        TransactionType = "CREDIT",
        Amount = 500.00m,
        ReferenceNumber = "TEST-CREDIT-001"
    };

    public static TransactionRequest ValidDebitTransaction => new()
    {
        AccountId = 1001,
        TransactionType = "DEBIT",
        Amount = 100.00m,
        ReferenceNumber = "TEST-DEBIT-001"
    };

    public static TransactionRequest ZeroAmountTransaction => new()
    {
        AccountId = 1001,
        TransactionType = "CREDIT",
        Amount = 0.00m,
        ReferenceNumber = "TEST-ZERO-001"
    };

    public static TransactionRequest NegativeAmountTransaction => new()
    {
        AccountId = 1001,
        TransactionType = "CREDIT",
        Amount = -100.00m,
        ReferenceNumber = "TEST-NEGATIVE-001"
    };
}