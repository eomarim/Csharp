using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = new Account(1, "Eduardo Marim", 100.00);
            
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
            
            acc.Witdraw(10);
            System.Console.WriteLine(acc);

            savings.Witdraw(10);
            System.Console.WriteLine(savings);

            

        }
    }
}
