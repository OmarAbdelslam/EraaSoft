using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoultionSessionDec27
{
    public abstract class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public abstract string Read();


    }
}
