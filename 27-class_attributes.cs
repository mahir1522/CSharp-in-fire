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
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);

            Song kashmir = new Song("Kashmir", "Led Zeeppelin", 150);
            Console.WriteLine(kashmir.GetSongCount());


            Console.ReadLine();
        }
    }
}
