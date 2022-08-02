using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }
        //virtual is for specialdish which help to change method 
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ ribs");
        }
    }
}
