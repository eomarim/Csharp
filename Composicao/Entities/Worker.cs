using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Composicao.Entities.Enums;

namespace Composicao.Entities{
    public class Worker{
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }

        public List <HourContract> HourContracts { get; set; }

        public Department Department { get; set; }

        public void addContract(HourContract hourContract){
            this.HourContracts.Add(hourContract);
        }
        public void RemoveContract(HourContract hourContract){
            this.HourContracts.Remove(hourContract);                          
        }
        public double Income(int year, int month){
           List<HourContract> lstHourContract =  HourContracts.FindAll(x => x.Date.Year == year && x.Date.Month == month);

            double resultado = 0.00;
           foreach (HourContract item in lstHourContract)
           {
               resultado += item.TotalValue();
           }
            return resultado;
        }

        public override string ToString()
        {
            string msg = string.Empty;
            foreach (HourContract item in HourContracts)
            {
                msg+= "Date:" + item.Date;
                msg+= ", Hours:" + item.Hours;   
                msg+= ", Value per Hour:" + item.ValuePerHour;
                msg+= "; ";
            }

            return $"Name: {Name}, Base Salary: {BaseSalary}, " 
            + $"Level: {Level}, Department: {Department}, Hour Contract: {msg}";
        }
    }
}