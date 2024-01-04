using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public int PublicationYear;

        public Book(string title, string author, string isbn, int pubYear)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = pubYear;
        }

        public virtual void PrintBook()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Publication year: {PublicationYear}");
        }
    }

    public class EBook : Book
    {
        public int FileSizeInMB;
        public EBook(string title, string author, string isbn, int pubYear, int fileSizeInMB) : base(title, author, isbn, pubYear)
        {
            FileSizeInMB = fileSizeInMB;
        }

        public override void PrintBook()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Publication year: {PublicationYear}, size in MB: {FileSizeInMB}");
        }
    }
}
