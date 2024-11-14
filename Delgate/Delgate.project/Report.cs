using System;

namespace Delgate.project
{
    public class Report
    {
        public delegate bool Sales(Employee e ); 
        public void ProceessEmployee(Employee[] employees, string title ,Sales empSalary )
        {
            foreach (Employee emp in employees)
            {
                if (empSalary (emp))
                    Console.WriteLine($"Id ={emp.Id} | Name ={emp.Name} | Salary {emp.TotalSalary} | Gender = {emp.Gender}");
            }
        }
    }
}

