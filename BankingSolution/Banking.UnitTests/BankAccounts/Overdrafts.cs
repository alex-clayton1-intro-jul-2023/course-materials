namespace Banking.UnitTests.BankAccounts;

public class Overdrafts
{


    [Fact]
    public void DoesNotDecreaseBalanceAndThrowsException() 
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + .01M;


        Assert.Throws<AccountOverdraftException>(() => // This makes sure that the exception is thrown, but also makes the statement compute
        {
            account.Withdraw(amountToWithdraw);

        });

        Assert.Equal(openingBalance, account.GetBalance());

    }




}
