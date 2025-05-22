using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2___Finding_Square_Root_of_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Finding square root of a number using built-in Math function
            while (true) { // Infinite Loop
            Console.WriteLine("<< Square root Finder by Abhinav >>");
            Console.Write("\nEnter Number (q to Exit): ");

            // Number Preprocessing
            string num_str = Console.ReadLine();
            if (num_str == "q") { Console.WriteLine("Thanks for Using Square Root Finder by Abhinav\nExiting.."); Environment.Exit(0); }
            int number = Convert.ToInt32(num_str);

            // Finding Square Root
            double Root = Math.Sqrt(number);
            Console.WriteLine($"Square Root of {number}: {Root}");
            }
        }
    }
}
