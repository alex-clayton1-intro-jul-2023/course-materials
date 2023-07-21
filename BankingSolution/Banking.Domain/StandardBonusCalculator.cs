namespace Banking.Domain
{
    public class StandardBonusCalculator
    {
        private readonly IProvideTheBusinessClock _businessClock;

        public StandardBonusCalculator(IProvideTheBusinessClock businessClock)
        {
            _businessClock = businessClock;
        }


        // can't write unit tests that use the clock, use the network, use the file system, or use databases. Those things always change
        // Want to write tests that make code pure and predictable.
        public decimal CalculateBonusForDeposit(decimal balanceOnAccount, decimal amountOfDeposit)
        {
            // Write the Code You Wish You Had (WTCYWYH)
            decimal bonusMultiplier = _businessClock.IsDuringBusinessHours() ? .10M : .05M;
            return balanceOnAccount >= 6000M ? amountOfDeposit * bonusMultiplier : 0;
        }
    }
}