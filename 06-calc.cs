using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());   
            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
