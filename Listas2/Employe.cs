using System.Globalization;
using System;

namespace Listas2
{
    public class Employe
    {
        internal Employe(){}
        internal Employe(int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;

        } 
        internal int Id { get; set; }
        internal String Name { get; set; }
        internal double Salary { get; set; }

        public double IncreaseSalary(double percentualIncrease){
            return Salary += (Salary * (percentualIncrease/100));    
        }

        public override string ToString()
        {
            return $" Id: {Id}, Name: {Name}, Salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

