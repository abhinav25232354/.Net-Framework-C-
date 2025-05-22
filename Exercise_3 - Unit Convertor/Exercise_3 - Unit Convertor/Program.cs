using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___Unit_Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             << Unit Converter by Abhinav >>
            1. Convert Kilometers to Miles
            2. Convert Celsius to Fahrenheit
            3. Convert Kilograms to Pounds
            4. Exit
             */

            // Unit Converter
            while (true)
            {
                Console.WriteLine("<< Unit Converter By Abhinav >>");
                Console.WriteLine("1. Convert Kilometers to Miles\n2. Convert Celsius to Fahrenheit\n3. Convert kilograms to Pounds\n4. Exit");
                Console.Write("\nEnter Choice: ");
                string choice_str = Console.ReadLine();
                int choice = Convert.ToInt32(choice_str);
                if (choice == 1) { Console.WriteLine("\nConvert Kilometers to Miles"); }
                else if (choice == 2) { Console.WriteLine("\nConvert Celcius to Fahrenheit"); }
                else if (choice == 3) { Console.WriteLine("\nConvert Kilograms to Pounds"); }
                else if (choice == 4) { Console.WriteLine("\nExiting..."); }
                else { Console.WriteLine("Invalid Input!"); }

                // Switch Case Conditionals
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Kilometer: ");
                        string km_str = Console.ReadLine();
                        double km = Convert.ToDouble(km_str);
                        double miles = km * 0.621371;
                        Console.WriteLine($"{km} in miles is: {miles}");
                        break;
                    case 2:
                        Console.Write("Enter Celcius: ");
                        string celcius_str = Console.ReadLine();
                        double celcius = Convert.ToDouble(celcius_str);
                        double fahrenheit = (celcius * 9 / 5) + 32;
                        Console.WriteLine($"{celcius} in Fahrenheit is: {fahrenheit}");
                        break;
                    case 3:
                        Console.Write("Enter KiloGram: ");
                        string kg_str = Console.ReadLine();
                        double kg = Convert.ToDouble(kg_str);
                        double pounds = kg * 2.20462;
                        Console.WriteLine($"{kg} in pounds is: {pounds}");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input! ");
                        break;
                }
            }
        }
    }
}
