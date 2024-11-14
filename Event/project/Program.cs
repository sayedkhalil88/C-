using System;
using System.Reflection.Metadata.Ecma335;

namespace project
{
    public class Program  //subscriber 
    {
        static void Main(string[] args)
        {
            Stock stock =new Stock ("NETFLIX");
            stock.Price = 100;
            stock.OnPriceChange += Stock_OnPriceChange;
            stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.02m);
            stock.ChangeStockPriceBy(0m);
        }

        private static void Stock_OnPriceChange (Stock stock, decimal oldprice)
        {
            string state = "";
            if (stock.Price > oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                state = "UP";
            }
            else if (stock.Price < oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                state = "DOWN";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                state = "NOTHING"; 
            }

            Console.WriteLine($"{stock.Name} : {stock.Price} - {state}"); 
        }
    }

    public delegate void StockDelegate (Stock stock , decimal oldprice );

    public class Stock //publisher 
    {
        private string name;
        private decimal price;

        public event StockDelegate OnPriceChange; 

        public string Name => this.name;
        public decimal Price { get => this.price; set { this.price = value; } }

        public Stock(string name)
        {
            this.name = name;
        }
        public void ChangeStockPriceBy( decimal percent )
        {
            decimal oldPrice = this.price; 
            this.price += Math.Round(this.price * percent, 2);
            if (OnPriceChange != null)
            {
                OnPriceChange(this, oldPrice); //FIRING THE EVENT  
            }
        }
    }

}

