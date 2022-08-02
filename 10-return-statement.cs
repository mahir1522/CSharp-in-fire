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
            int answer = cube(4);
            Console.WriteLine(answer);

            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }


    }
}
