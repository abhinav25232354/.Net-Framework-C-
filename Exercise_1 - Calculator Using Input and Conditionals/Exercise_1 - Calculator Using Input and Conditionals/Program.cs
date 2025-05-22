using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Calculator_Using_Input_and_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculator Using Input and Conditionals

            // Welcome and Template
            while (true) { // Infinite Loop
            Console.WriteLine("<< Calculator By Abhinav >>");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
            Console.Write("\nEnter Choice: ");
            string choice_str = Console.ReadLine();

            if (choice_str == "1") { Console.WriteLine("Addition"); }
            else if (choice_str == "2") { Console.WriteLine("Subtraction"); }
            else if (choice_str == "3") { Console.WriteLine("Multiplcation"); }
            else if (choice_str == "4") { Console.WriteLine("Division"); }
            else if (choice_str == "5") { Console.WriteLine("Exiting..."); }
            int choice = Convert.ToInt32(choice_str);

                // Condition Checking for Operation
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter Num1: ");
                        string add1_str = Console.ReadLine();
                        int add1 = Convert.ToInt32(add1_str);
                        Console.Write("Enter Num2: ");
                        string add2_str = Console.ReadLine();
                        int add2 = Convert.ToInt32(add2_str);
                        Console.WriteLine($"Result: {add1 + add2}\n");
                        break;
                    case 2:
                        Console.Write("\nEnter Num1: ");
                        string sub1_str = Console.ReadLine();
                        int sub1 = Convert.ToInt32(sub1_str);
                        Console.Write("Enter Num2: ");
                        string sub2_str = Console.ReadLine();
                        int sub2 = Convert.ToInt32(sub2_str);
                        Console.WriteLine($"Result: {sub1 - sub2}\n");
                        break;
                    case 3:
                        Console.Write("\nEnter Num1: ");
                        string mul1_str = Console.ReadLine();
                        int mul1 = Convert.ToInt32(mul1_str);
                        Console.Write("Enter Num2: ");
                        string mul2_str = Console.ReadLine();
                        int mul2 = Convert.ToInt32(mul2_str);
                        Console.WriteLine($"Result: {mul1 * mul2}\n");
                        break;
                    case 4:
                        Console.Write("\nEnter Num1: ");
                        string div1_str = Console.ReadLine();
                        int div1 = Convert.ToInt32(div1_str);
                        Console.Write("Enter Num2: ");
                        string div2_str = Console.ReadLine();
                        int div2 = Convert.ToInt32(div2_str);
                        Console.WriteLine($"Result: {div1 / div2}\n");
                        break;
                    case 5:
                        Console.WriteLine("\nThanks for Using Calculator By Abhinav\n");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input !");
                        break;
                }
            }

        }
    }
}
