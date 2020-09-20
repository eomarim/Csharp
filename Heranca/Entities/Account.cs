using System;

namespace Heranca.Entities
{
    public abstract class Account{
        public int Number { get; private set; }
        public string Holder { get; private set; }

        public double Balance { get; protected set; }

        public Account(){}
        public Account(int number, string holder, double balance){
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        public virtual void Witdraw(double amount){
            this.Balance -= (amount + 5);
        }
        public virtual void Deposit(double amount){
            this.Balance += amount;
        }
        public override string ToString()
        {
            return $"Number:{this.Number}, Holder:{this.Holder}, Balance:{this.Balance}";
        }
    }
}