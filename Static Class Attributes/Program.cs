using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {

            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Song.songCount); //static belongs to the class
            Console.WriteLine(kashmir.title);
            Console.WriteLine(kashmir.getSongCount());
            Console.ReadLine();
        }
    }
}
