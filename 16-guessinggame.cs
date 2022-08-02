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
            int num = 44;
            int[] numbers = { 22, 33, 44, 55, 66, 77, 88, 99 };

            Console.WriteLine("22,33,44,55,66,77,88,99");
            int index = 0;

            while (index <= 2)
            {
                Console.Write("Choose your number: ");
                int fav_num = Convert.ToInt16(Console.ReadLine());

                if (num == fav_num)
                {
                    Console.WriteLine("Your win");
                    break;
                }
                else if (num != fav_num)
                {
                    Console.WriteLine("Your loss");
                }
                index++;
            }


            Console.ReadLine();
        }

    }
}
