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
            string phrase = "Hello world";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper() );
            Console.WriteLine(phrase.ToLower() );
            Console.WriteLine(phrase.Contains("asdgg") );
            Console.WriteLine(phrase[6]);
            Console.WriteLine(phrase.IndexOf("a"));
            Console.WriteLine(phrase.Substring(6,3));

            Console.ReadLine();
        }
    }
}
