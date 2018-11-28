using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Classes_and_Objects.Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Classes_and_Objects.Book();
            book1.title = "Lord of the Rings";
            book1.author = "Tolkien";
            book1.pages = 700;

            Console.WriteLine(book1.pages);


            Console.ReadLine();
        }
    }
}
