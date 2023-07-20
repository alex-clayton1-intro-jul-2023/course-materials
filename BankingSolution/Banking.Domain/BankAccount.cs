namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance = 5000; // class level variables are private by default
        public void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
        }


        public decimal GetBalance()
        {
            //JFHCI: Just ... hard code it
            return _balance;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            _balance -= amountToWithdraw;
        }
    }
}