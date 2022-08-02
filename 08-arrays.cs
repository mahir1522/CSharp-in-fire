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
            int[] luckyNumbers = { 21, 232, 33, 324, 52, 16};
            string[] friends = new string[4];
            friends[0] = "Rohan";
            friends[1] = "Sohan";
            friends[2] = "Mohan";
            friends[3] = "Kohan";

            luckyNumbers[1] = 99;
            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}
