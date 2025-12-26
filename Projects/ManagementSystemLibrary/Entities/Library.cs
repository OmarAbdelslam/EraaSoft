using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary.Entities
{
    internal class Library
    {
        public Library()
        {
            books = new List<Book>();
        }
        public ICollection<Book> books { get; set; }


        public void AddBook(Book book)
        {
            if (books == null) {return; }
            books.Add(book);
        }

        public Book GetBook(string title)
        {
            var result = books.FirstOrDefault(x => x.Title == title);
            return result;
        }

        public bool Isborrow(string title)
        {
            var result = GetBook(title);
            if (result == null) return false;

            if(result.Availability == true)
            {
                result.Availability = false;
                return true;
            }

            return false;
        }

        public bool Returnbook(string title)
        {
            var book = GetBook(title);
            if (book == null) return false;
            if(book.Availability == false)
            {
                book.Availability = true;
                return true;
            }

            return false;
        }
    }
}
