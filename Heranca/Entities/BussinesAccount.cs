using System;

namespace Heranca.Entities
{
    public class BussinessAccount : Account{   
        public double LoanLimit { get; set; }
        
        public BussinessAccount(){}

        public BussinessAccount(int number, string holder, double balance, double loanLimit)
        :base(number, holder, balance){
           
            this.LoanLimit = loanLimit;

        }
        public void Loan(double amount){
            
            if(amount <= this.LoanLimit)
                base.Balance += amount;
        }
       public override string ToString()
        {
            return $"Number:{base.Number}, Holder:{base.Holder}, Balance:{base.Balance}, Loan:{this.LoanLimit}";
        }
    }
}