// this is a class and object
// the class is located in diffirent file... Check it out Book.cs


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
            Book book1 = new Book();
            book1.title = "Harry potter";
            book1.author = "Jk Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.ReadLine();
        }


    }
}
