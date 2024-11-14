using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._1
{
    public class Employee
    {
        public static double TAX = 0.03;  
        public string fname;
        public string lname;
        public double wage;
        public double loggedHours;

        private double Calcukate() =>  wage* loggedHours;
        private double CalculateTAX() => Calcukate() * TAX; 
        private double CalculateNetSalary () => Calcukate() -CalculateTAX();

        public string PrintAll()
        {
            return ($"\n first name is {fname}") +
                   ($"\n last name is {lname}") +
                   ($"\n the wage = {wage}") +
                   ($"\n the logged hours = {loggedHours}") +
                   ($"\n---------------------------------- !")+
                   ($"\n the salary = {Calcukate()}") +
                   ($"\n the tax = {CalculateTAX()}") +
                   ($"\n the net salary = {CalculateNetSalary()}");

        }

    } 
     
   
}
