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
            int num = 6;
            --num;
            Console.WriteLine(num);
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine( 5.0 + 8.34 );
            Console.WriteLine( 5/2.008);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3.6,2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(3.6, 2));
            Console.WriteLine(Math.Min(3.6, 2));
            Console.WriteLine(Math.Round(3.6));

            Console.ReadLine();
        }
    }
}
