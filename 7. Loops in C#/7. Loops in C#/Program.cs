using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Loop
            Console.WriteLine("For Loop");
            for (int i=0; i<=10; i++)
            {
                Console.WriteLine(i);
            }

            // While Loop
            Console.WriteLine("While Loop");
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }

            // do-while loop
            // runs Once retrictly the checks for condition in while block
            Console.WriteLine("Do-While Loop");
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x<=10);

            // List Iteration
            string[] List = {"John", "Happy", "Tom"};
            foreach (var L in List)
            {
                Console.WriteLine(L);
            }
        }
    }
}
