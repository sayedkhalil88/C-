using System;

namespace conv_cast.p
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] s = { "49", "73", "73", "61", "6D" };
            foreach (var hex in s)
            {
                int value = Convert.ToInt32(hex , 16 );
                string hexChar = char.ConvertFromUtf32(value);
                var ch =(char) value ;  
                Console.Write(hexChar) ;
                Console.WriteLine(ch);

            }
            Console.ReadKey();
        }
    }
}

