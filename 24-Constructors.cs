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
            Book book1 = new Book("Harry potter", "Jk Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

            book2.title = "The Hobbit";

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }


    }
}
