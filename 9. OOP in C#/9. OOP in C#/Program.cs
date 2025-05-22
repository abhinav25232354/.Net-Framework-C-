using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.OOP_in_C_
{
    class Student
    {
        public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "Abhinav";
            Console.WriteLine(s.name);
        }
    }
}
