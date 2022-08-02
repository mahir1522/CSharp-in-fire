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
            Chef chef = new Chef();
            chef.MakeSpecialDish(); 
            
            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeSpecialDish();


            Console.ReadLine();
        }
    }
}
