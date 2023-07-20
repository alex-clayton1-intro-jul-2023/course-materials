﻿
using Banking.Domain;

namespace Banking.UnitTests.BankAccounts;

public class MakingWithdrawls
{

    [Fact]
    public void MakingWithdrawlsDecreaseTheBalance()
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToWithdraw = 1.01M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance- amountToWithdraw,
            account.GetBalance());


    }

    [Fact]
    public void CanTakeEntireBalance()
    {

        var account = new BankAccount();
        account.Withdraw(account.GetBalance()); 
        Assert.Equal(0, account.GetBalance());  
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-4)]
    public void InvalidAmountsAreNotAllowed(decimal amount)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        Assert.Throws<InvalidBankAccountTransactionAmountException>(() =>
        {
            account.Withdraw(amount);
        });

        Assert.Equal(openingBalance, account.GetBalance());

    }


}
