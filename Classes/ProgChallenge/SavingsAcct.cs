using System;

namespace ProgChallenge {
    class SavingsAcct : BankAccount {
        private int _withdrawaccount = 0;
        private const decimal WITHDRAW_CHARGE = 2.0m;
        private const int WITHDRAW_LIMIT = 3;

        public SavingsAcct(string fname, string lname, decimal interest, decimal initial=0.0m) : base(fname, lname, initial) {
            InterestRate = interest;
        }

        public decimal InterestRate { get; set; }

        public void ApplyInterest() {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(decimal amount) {
            if (amount > Balance) {
                Console.WriteLine("Attempt to overdraw savings - denmied");
            }
            else {
                base.Withdraw(amount);
                _withdrawaccount++;
                if (_withdrawaccount > WITHDRAW_LIMIT) {
                    Console.WriteLine("Withdrawal limit reached - charge applied");
                    base.Withdraw(WITHDRAW_CHARGE);  
                }   
            }
        }

    }
}