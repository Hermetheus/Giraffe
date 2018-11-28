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
            Book book1 = new Classes_and_Objects.Book("harry Potter", "JK Rowling", 400);


            Book book2 = new Classes_and_Objects.Book("Lord of the Rings", "Tolkien", 700);

            book2.title = "The Hobbit";

            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}
