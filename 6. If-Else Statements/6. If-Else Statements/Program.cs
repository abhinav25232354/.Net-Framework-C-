using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.If_Else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If-Else Conditionals
            Console.Write("Enter Your Age: ");
            string a = Console.ReadLine();
            int age = Convert.ToInt32(a);
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible for Driving License :)");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are not Eligible for Driving License :(");
            }
            else
            {
                Console.WriteLine("Invalid Age")
            }
        }
    }
}
