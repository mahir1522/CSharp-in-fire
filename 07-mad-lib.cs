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
            Console.Write("Enter color name: ");
            string color = Console.ReadLine();
            Console.Write("Enter noun: ");
            string noun = Console.ReadLine();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(noun + " are blue");
            Console.WriteLine("I love " + name);


            Console.ReadLine();
        }
    }
}
