using System;

namespace OOP._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] allEmployees = new Employee[2];
            Employee emp1 =new Employee();
            Employee emp2 =new Employee();

            Console.Write("first name : ");
            emp1.fname =Console.ReadLine();
            Console.Write("last name : ");
            emp1.lname = Console.ReadLine();
            Console.Write("wage : ");
            emp1.wage = Convert.ToDouble(Console.ReadLine());   
            Console.Write("LOgged Hours : ");
            emp1.loggedHours=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the TAX :  ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine()); 
            
            allEmployees [0] = emp1;
            allEmployees[1] = emp2;

            Console.Write("first name : ");
            emp2.fname = Console.ReadLine();
            Console.Write("last name : ");
            emp2.lname = Console.ReadLine();
            Console.Write("wage : ");
            emp2.wage = Convert.ToDouble(Console.ReadLine());
            Console.Write("LOgged Hours : ");
            emp2.loggedHours = Convert.ToDouble(Console.ReadLine());
          
            foreach (Employee emp in allEmployees)
            {
               Console.WriteLine(emp.PrintAll());
               
            }

        }
    }
}
