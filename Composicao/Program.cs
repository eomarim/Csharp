using System;
using Composicao.Entities;
using Composicao.Entities.Enums;
using System.Collections.Generic;

namespace Composicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var worker = new Worker(){
                Name = "Marim",
                BaseSalary = 10000.00,
                Department = (new Department(){Name = "Diretoria"}),
                Level = WorkerLevel.SENIOR
                };

                List<HourContract> lstContracts = new List<HourContract>();
                lstContracts.Add(new HourContract(){Date = DateTime.Parse("2000-09-10"), Hours = 200, ValuePerHour = 500.00});
                lstContracts.Add(new HourContract(){Date = DateTime.Parse("2020-08-10"), Hours = 300, ValuePerHour = 700.00});

                worker.HourContracts = lstContracts;

                System.Console.WriteLine(worker); 

               System.Console.WriteLine($"Total do Contrato: " + worker.Income(2020, 08));

                var hour = new HourContract(){
                    Date = DateTime.Parse("2008-05-03 11:00"),
                    Hours = 120,
                    ValuePerHour = 300    
                };

               worker.addContract(hour);

               System.Console.WriteLine(worker);
               
               worker.RemoveContract(hour);

               System.Console.WriteLine(worker);

                

        }
    }
}

