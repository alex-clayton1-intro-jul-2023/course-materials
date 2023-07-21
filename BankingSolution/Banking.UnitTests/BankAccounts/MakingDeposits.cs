
namespace Banking.UnitTests.BankAccounts;

public class MakingDeposits
{

    [Fact]
    public void DepositsIncreaseTheBalance() 
    {
        // Given - arrange
        // This mock is a dummy thing that returns the basic thing each time without having to declare a dummy.
        var account = new BankAccount(new Mock<ICanCalculateBonusesForBankAccountDeposits>().Object);
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100.23m;


        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit
            , account.GetBalance()); // Don't hard code tests

    }
      

}


public class DummyBonusCalculator : ICanCalculateBonusesForBankAccountDeposits
{
    public decimal CalculateBonusForDeposit(decimal balance, decimal amountToDeposit)
    {
        return 0;
    }
}