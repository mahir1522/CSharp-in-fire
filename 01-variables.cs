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
            string name = "Mahir";
            int age;
            age = 61;

            Console.WriteLine("There once was a man named " + name);
            Console.WriteLine("He was " + age + " years old");

            name = "rohan";
            Console.WriteLine("He really liked the name " + name);
            Console.WriteLine("But didn't like being "+ age);


            Console.ReadLine();
        }
    }
}
