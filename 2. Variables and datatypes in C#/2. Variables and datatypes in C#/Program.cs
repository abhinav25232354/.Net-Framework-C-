using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Variables_and_datatypes_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables are like container which are used to store values
            // There are different types of values which is seperated by data types
            var a = 10; // A Variable storing value 10
            Console.WriteLine(a);

            // Data Types
            int integer = 90;
            float floating_point = 4.90F;
            double dou = 9.798D;
            char character = 'a';
            string name = "Abhinav";
            bool boolean = true; // or false (just two values)
            Console.WriteLine(integer);
            Console.WriteLine(dou);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine(boolean);
        }
    }
}
