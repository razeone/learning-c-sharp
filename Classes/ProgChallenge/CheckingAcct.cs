using System;

namespace ProgChallenge {
    class CheckingAcct : BankAccount {
        private const decimal OVERDRAW_CHARGE = 35.0m;

        public CheckingAcct(string fname, string lname, decimal initial=0.0m) : base(fname, lname, initial) {
        }

        public override void Withdraw(decimal amount) {
            if (amount > Balance) {
                Balance += OVERDRAW_CHARGE;
            }
            base.Withdraw(amount);
        }

    }
}