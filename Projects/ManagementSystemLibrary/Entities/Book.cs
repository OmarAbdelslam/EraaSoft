using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemLibrary.Entities
{
    internal class Book
    {

        public Book(string title , string auther
            , string isbn,bool availability) 
        {
            this.Title = title;
            this.Auther = auther;
            this.ISBN = isbn;
            this.Availability = availability;
        }
        public string Title { get; set; }

        public string Auther { get; set; }

        public string ISBN { get; set; }

        public bool Availability { get; set; }

        public override string ToString()
        {
            return $"Title Book : {Title}\nAuther : {Auther}\nISBN : {ISBN}\nAvailability : {Availability}\n";
        }

    }
}
