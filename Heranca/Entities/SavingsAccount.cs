using System;

namespace Heranca.Entities
{   
    public class SavingsAccount: Account{

        public double InterestRate { get; set; }

        public SavingsAccount(){}

        public SavingsAccount(int number, string holder, double balance, double interestRate):base(number, holder, balance){
            
            this.InterestRate = interestRate;
        }

        public void UpdateBalance(){
            base.Balance += Balance * this.InterestRate;
        }

        public sealed override void Witdraw(double amount)
        {
            base.Witdraw(amount);
            Balance -= 2.00;
        }

    }
}