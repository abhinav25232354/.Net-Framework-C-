using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Taking_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taking User Input
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.Write("How Many Candies Do you want?: ");
            string candies = Console.ReadLine();
            Console.WriteLine("You will get 4 more candies (bonus): " + (Convert.ToInt32(candies) + 4));
        }
    }
}
