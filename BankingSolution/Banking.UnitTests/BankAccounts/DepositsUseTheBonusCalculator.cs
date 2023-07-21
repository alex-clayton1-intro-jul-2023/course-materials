
namespace Banking.UnitTests.BankAccounts;

public class DepositsUseTheBonusCalculator
{
    // Example of stubbing
    // This test is used to test the bank account.
    // Setup a scenario of where the BankAccount is using its dependency properly, Everytime you do a deposit,
    // you want to make sure it uses the bonus calculator
    [Fact]
    public void BonusCalculatorIsUsedAndBonusAppliedToBalance()
    {
        // Given
        var stubbedBonusCalculator = new Mock<ICanCalculateBonusesForBankAccountDeposits>();
        var account = new BankAccount(stubbedBonusCalculator.Object);

        var openingBalance = account.GetBalance();
        var amountToDeposit = 112.23M;
        var amountOfBonusToReturn = 69.23M;
        // Basically says if it calls CalculateBonusForDeposit with openingBalance and amountToDeposit (being the exact values), then it will return amountOfBonusToReturn.
        stubbedBonusCalculator.Setup(b => b.CalculateBonusForDeposit(
            openingBalance, 
            amountToDeposit)
        ).Returns(amountOfBonusToReturn); // Basically says that it will return 69.23M if it has that opening balance and amtToDeposit.

        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(
            openingBalance +
            amountOfBonusToReturn + 
            amountToDeposit,
            account.GetBalance());

    }
}
