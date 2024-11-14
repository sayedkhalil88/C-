using System;

namespace properties.project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar =new Dollar(1.34m);
            dollar.Amount = 1;
            Console.WriteLine(dollar.Amount);
            
        }
    }

    public class Dollar
    {
        private decimal _amount; 
        public decimal Amount
        {
             get { return _amount;
            }
            set { 
                // validation 
               this._amount = ProcessValue(value);
            }
        }
        public Dollar(decimal amount  ) {
           this._amount = ProcessValue( amount );
        }
        public decimal ProcessValue(decimal value) => value < 0 ? 0 :Math.Round ( value , 2);  
    }
    
}
