using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "OOP";
            book1.Author = "Ahmad";
            book1.Genre = "CS Book";
            book1.PublicationYears = 2024;
            

            Book book2 = new Book();
            book2.Title = "C#";
            book2.Author = "Ahsan";
            book2.Genre = "SE Book";
            book2.PublicationYears = 2023;

            Library library_object = new Library();
            library_object.Addbook(book1);
            library_object.Addbook(book2);

            library_object.ListallBooks();
            string Query = "Ahmad";
            library_object.Searchbooks(Query);

        }
    }
}
