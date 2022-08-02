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
            SayHi("Rohan", 34);
            SayHi("Mohan", 45);
            SayHi("Sohan", 32);
            Console.ReadLine();
        }

        static void SayHi(String name, int age)
        {
            Console.WriteLine("Hello " + name + ", your age is " + age);

        }
    }
}
