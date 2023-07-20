using Banking.Domain;

namespace Banking.UnitTests.BankAccounts; // File scope name space

public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveCorrectOpeningBalance()
    {
        var account = new BankAccount();

        decimal balance = account.GetBalance();

        Assert.Equal(7000, balance);
    }
}
