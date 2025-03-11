using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Library
    {
        private Book[] books; //storing objects
        private int bookcount;
        public Library()
        {
            books = new Book[200];
            bookcount = 0;
        }
        public void Addbook(Book book1)
        {
            books[bookcount] = book1;
            bookcount++;
            Console.WriteLine("Book Added Done");
        }
        public void ListallBooks()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\tAll Books Available in Library");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine("Title: " + books[i].Title);
                Console.WriteLine("Author: " + books[i].Author);
                Console.WriteLine("Genre: " + books[i].Genre);
                Console.WriteLine("Publication Year: " + books[i].PublicationYears);
                Console.WriteLine(" ");


            }
        }
        public void Searchbooks(string keyword)
        {
            Console.WriteLine($"Search Values for the Keyword = {keyword}");
            for (int i = 0; i < bookcount; i++)
            {
                if (books[i].Title == keyword || books[i].Author == keyword || books[i].Genre == keyword)
                {
                    Console.WriteLine("Title: " + books[i].Title);
                    Console.WriteLine("Author: " + books[i].Author);
                    Console.WriteLine("Genre: " + books[i].Genre);
                    Console.WriteLine("Publication Year: " + books[i].PublicationYears);
                    break;
                }
            }
        }
    }
}
