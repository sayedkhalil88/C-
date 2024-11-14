using System;
using System.Runtime.Serialization;

namespace methods._1
{
   public class Program
    {
        static void Main(string[] args)
        {

            demo obj = new demo();

            obj.printAllEven(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }); 
            //int res = obj.sum(out num); 
            //  Console.WriteLine(res);
            //Console.WriteLine(num);    
            // Console.ReadKey();  
        }
    }
  public class demo
    {
       public void printAllEven(int [] arr)
        {
            foreach (var i in  arr){
                if (IsEven(i)) {
                    Console.WriteLine(i);
                }
            }
             bool IsEven(int num) => num % 2 == 0;

        }
       
    }
}
