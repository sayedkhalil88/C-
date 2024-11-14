using System;

namespace Constructor.project
{
   public class Program

    {
        public static void Main(string[] args)
        {
            Employee emp = Employee.Create(23, "sayed", "mohamed");
            Console.WriteLine(emp.DisplayName()); 
           //Employee e1 = new Employee ("SS11")
           //{
               
           //    fName = "sayed",
           //    lname="mohamed"
           //};
           // Console.WriteLine(e1.fName);
            //Date d1 = new Date(30, 2, 2005);
            //Console.WriteLine(d1.GetDate()); 
        }
        
        
    }

    public class Employee
    {
       private int  id; 
       private string fname;
       private string lname;
        
       private Employee() { }
        private Employee(int id , string fname , string lname ) { 
            this.id = id;
            this.fname = fname;
            this.lname = lname;
        }
        public static Employee Create(int id , string fname , string lname ) { 
            return new Employee(id , fname , lname );
        }
        public string DisplayName() {
            return $"{fname} {lname} -> {id} ";
        }
    }
    //public class Date
    //{
    //    private  readonly int day = 01;
    //    private  readonly int month = 01;
    //    private  readonly int year = 01 ;
    //   private readonly int[]   monthsNotLeap = { 0, 31, 28, 30, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    //    private readonly int[] monthsLeap = { 0, 31, 29, 30, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    //    public Date(int day, int month, int year)
    //    {
    //        bool isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 != 0);
    //        if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
    //        {
    //            int[] days = isLeap ? monthsLeap : monthsNotLeap;
    //            if (day >= 1 && day <= days[month])
    //            {
    //                this.day = day;
    //                this.month = month;
    //                this.year = year;
    //            }
                
    //        }
           
    //    }
    //    public string GetDate() => $"{day.ToString().PadLeft(2, '0')} / {month.ToString().PadLeft(2, '0')} / {year.ToString().PadLeft(4, '0')} ";



    //}

}
