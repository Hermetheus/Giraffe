using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef(); //Chef is the Superclass, Italian chef is the Sub-Class
            chef.MakeChicken();
            chef.MakeSalad();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();//Only italian chef can make pasta
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
