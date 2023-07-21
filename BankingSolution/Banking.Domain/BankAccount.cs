namespace Banking.Domain
{
    public class BankAccount
    {
        private readonly ICanCalculateBonusesForBankAccountDeposits _bonusCalculator;

        public BankAccount(ICanCalculateBonusesForBankAccountDeposits bonusCalculator)
        {
            _bonusCalculator = bonusCalculator;
        }

        private decimal _balance = 5000; // class level variables are private by default
        public void Deposit(decimal amountToDeposit)
        {

            GuardCorrectTransactionAmount(amountToDeposit);
  
            var bonus = _bonusCalculator.CalculateBonusForDeposit(_balance, amountToDeposit);


            _balance += amountToDeposit + bonus;
        }


        public decimal GetBalance()
        {
            return _balance; //JFHCI: Just ... hard code it (at first)
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            GuardCorrectTransactionAmount(amountToWithdraw);// Verifies
            GuardHasSufficientBalance(amountToWithdraw);
            _balance -= amountToWithdraw;
        }




        private void GuardHasSufficientBalance(decimal amountToWithdraw) // how would you write test for a private method? you cant, dont do it. It was in the method first and got cleaned up to look better, so no need to test.
        {
            if (amountToWithdraw > _balance)
            {
                throw new AccountOverdraftException();
            }
        }

        private void GuardCorrectTransactionAmount(decimal amountToWithdraw)
        {
            if (amountToWithdraw <= 0)
            {
                throw new InvalidBankAccountTransactionAmountException();
            }
        }
    }
}
