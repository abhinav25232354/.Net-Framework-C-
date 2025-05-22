using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Functions_and_Methods
{
    internal class Program
    {
        static void Greet()
        {
            Console.WriteLine("Good Morning");
        }
        static float avg(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum/3;
        }
        static void Main(string[] args)
        {
            // Functions and Methods in C#
            // Functions are just a compilation of a block which we can use with a single line calling.
            // Helpful in Large Programs and projects for sticking on DRY principle.
            Greet();
            Console.WriteLine(avg(1, 4, 6));
        }
    }
}
