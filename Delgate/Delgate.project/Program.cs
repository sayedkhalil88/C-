using System;

namespace Delgate.project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee[] emp = new Employee[]
            {
                new Employee {Id=1 , Name="Sayed" , Gender="male" , TotalSalary=65000m },
                new Employee {Id=2 , Name="Mohamed" , Gender="male" , TotalSalary=50000m },
                new Employee {Id=3 , Name="Ali" , Gender="male" , TotalSalary=65000m },
                new Employee {Id=4 , Name="Ahmed" , Gender="male" , TotalSalary=40000m },
                new Employee {Id=5 , Name="Alaa" , Gender="female " , TotalSalary=42000m },
                new Employee {Id=6 , Name="Sara" , Gender="female" , TotalSalary=30000m },
                new Employee {Id=7 , Name="Adel" , Gender="male" , TotalSalary=16000m },
                new Employee {Id=8 , Name="Khalid" , Gender="male" , TotalSalary=15000m }
            };

            Report report =new Report();
            report.ProceessEmployee(emp ,"Employee >= 6000$" , IsGreaterThan60000);
            report.ProceessEmployee(emp, " 30000$ < Employee < 6000$" , IsBetween30000And5999); 
            report.ProceessEmployee(emp , "Employee > 6000$"  , IsLessThan30000);


             bool IsGreaterThan60000(Employee emp) => emp.TotalSalary >= 60000;
             bool IsBetween30000And5999(Employee emp) => emp.TotalSalary >= 30000 && emp.TotalSalary < 60000;
             bool IsLessThan30000(Employee emp) => emp.TotalSalary < 30000; 
        }
 

    }
}
