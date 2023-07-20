
using Banking.Domain;

namespace Banking.UnitTests.BankAccounts;

public class MakingDeposits
{

    [Fact]
    public void DepositsIncreaseTheBalance() 
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100.23m;


        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit
            , account.GetBalance()); // Don't hard code tests

    }
      

}
