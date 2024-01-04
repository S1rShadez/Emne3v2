using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("MegaFancy Bibliotek");
            library.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", "9780316769488", 1951), library);
            library.AddBook(new Book("The Catcher of std's", "Harry Potter", "9780316769999", 2051), library);
            library.AddBook(new Book("The Rye", "Salinger", "916769488", 1851), library);
            library.AddEBook(new EBook("The Catcher", "J.D. Salinger", "9780769488", 1952, 25), library);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            library.ListBooks();

            library.UserAddBook(library);

            Library.SaveBooks(library);
        }
    }
}
