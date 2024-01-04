using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace ParProg
{
    public class Library
    {
        public string LibraryName;
        public List<Book> BookLibrary = new List<Book>();
        public List<EBook> EBookLibrary = new List<EBook>();

        public Library(string libName)
        {
            LibraryName = libName;
        }

        public void ListBooks()
        {
            BookLibrary.ForEach(book => book.PrintBook());
            EBookLibrary.ForEach(book => book.PrintBook());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void AddBook(Book book, Library library)
        {
            BookLibrary.Add(book);
            Console.WriteLine($"Book successfully added to {library.LibraryName}");
        }

        public void AddEBook(EBook ebook, Library library)
        {
            EBookLibrary.Add(ebook);
            Console.WriteLine($"EBook successfully added to {library.LibraryName}");
        }

        public void UserAddBook(Library library)
        {
            Console.WriteLine("Add book:");
            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Author:");
            string author = Console.ReadLine();
            Console.WriteLine("ISBN:");
            string ISBN = Console.ReadLine();
            Console.WriteLine("Publication year:");
            int PublicationYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is it an EBook? (Y/N)");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.WriteLine("Size in MB:");
                int sInMB = Convert.ToInt32(Console.ReadLine());
                EBook ebook = new EBook(title, author, ISBN, PublicationYear, sInMB);
                AddEBook(ebook, library);
            }
            else
            {
                Book book = new Book(title, author, ISBN, PublicationYear);
                AddBook(book, library);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void SaveBooks(Library library)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
            var json = JsonConvert.SerializeObject(library, settings);
            //Console.WriteLine(json);
            File.WriteAllText("C:\\Users\\S1rShadez\\Documents\\GitHub\\Emne3v2\\Uke7\\ParProg\\library.json", json);
        }
    }
}
