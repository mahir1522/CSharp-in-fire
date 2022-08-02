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
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "DOG");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
