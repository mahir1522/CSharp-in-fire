using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Chef making pasta for you");
        }
        //override is for overwrite the special Dish of Chef
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
