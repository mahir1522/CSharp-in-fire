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
            int[] luckyNumber = { 3, 4, 6,55, 8, 5 };

            for(int i = 0; i <luckyNumber.Length; i++)
            {
                Console.WriteLine(luckyNumber[i]);

            }
            Console.ReadLine();
        }

    }
}
