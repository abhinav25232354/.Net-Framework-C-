using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Typecasting__Implicit_and_Explicit_Typecasting_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Two Types of typecasting
            // 1. Implicit typecasting (Done by compiler using promition table)
            // char -> int -> long -> float -> double
            // 2. Explicit typecasting (Done on purpose by programmer)

            // Implicit Casting
            char a = 'a';
            int b = a; // Automatically typecasted to char because of promotion table

            // Explicit Casting
            Console.Write("Enter A: ");
            string number1 = Console.ReadLine();
            Console.Write("Enter B: ");
            string number2 = Console.ReadLine();

            int x = Convert.ToInt32(number1);
            int y = Convert.ToInt32(number2);

            // Conver.ToDouble
            // Conver.ToString

            Console.Write("Addition: " + (x + y));

        }
    }
}
