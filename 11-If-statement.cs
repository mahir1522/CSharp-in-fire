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
            bool isMale = true;
            bool isTall = false;

             if (isMale && isTall)
             {
                 Console.WriteLine("You are a tall male");
             }else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
             else if(!isMale && isTall)
            {
                Console.WriteLine("You are tall but not a male");
            }
             else{
                 Console.WriteLine("You are either not male or not tall or both");
             }

             Console.ReadLine();

            
            /* Console.Write("Enter your age: " );
            int num = Convert.ToInt16(Console.ReadLine());

            if(num <= 18)
            {
                Console.WriteLine("You cannot drive a car");
            }
            else
            {
                Console.WriteLine("You can drive a car");
            }
            Console.ReadLine(); */
        }



    }
}
