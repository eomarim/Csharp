using System;
using Heranca.Entities;
using System.Collections.Generic;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //var acc = new Account(1, "Eduardo Marim", 100.00); Nao pode criar instancias de classes abstratas
            
            var accB = new BussinessAccount(2, "Renata Esperandio", 3000000.00, 20000.00);

            Account savings = new SavingsAccount(10, "Moacir Marim", 100.00, 0.01);
 
            //UPCASTING
            Account ac2 = accB;
            Account ac3 = new BussinessAccount();

            //DOWNCASTING - E necessario o casting explicito.
            BussinessAccount accB2 = ac3 as BussinessAccount;// usando o as ou...
            BussinessAccount accB3 = (BussinessAccount)ac3; //outra forma de casting
            
            if(accB is SavingsAccount){ //Verifica se o tipo e do tipo...
                
                //SavingsAccount scv = (SavingsAccount)accB;
                System.Console.WriteLine(accB.GetType() + " e uma instancia de Account");
            }
            
            //acc.Witdraw(10);
            //System.Console.WriteLine(acc);

            savings.Witdraw(10);
            System.Console.WriteLine(savings);

             List<Account> lstAccount = new List<Account>();

            lstAccount.Add(new BussinessAccount(10, "Eduardo Marim", 500.00, 20.00));
            lstAccount.Add(new BussinessAccount(11, "Renata Sperandio", 400.00, 25.00));
            lstAccount.Add(new SavingsAccount(12, "Luzia Odete", 450.00, 0.02));

            double totalBalanceHolders = 0.00;
            foreach (Account item in lstAccount)
            {
                totalBalanceHolders+= item.Balance;
                System.Console.WriteLine($"Account:{item.Number}, Holder:{item.Holder}, Balance:{item.Balance.ToString("F2")}");
            }
            System.Console.WriteLine($"Total Balance Accounts: {totalBalanceHolders.ToString("F2")}");

            foreach (Account item in lstAccount)
            {
                item.Witdraw(10);
            }
                totalBalanceHolders = 0.00;
            foreach (Account item in lstAccount)
            {
                totalBalanceHolders+= item.Balance;
                System.Console.WriteLine($"Account:{item.Number}, Holder:{item.Holder}, Balance:{item.Balance.ToString("F2")}");
            }
            System.Console.WriteLine(value: $"Total Balance Accounts: {totalBalanceHolders.ToString("F2")}");
        }
    }
}
