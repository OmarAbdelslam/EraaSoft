using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoultionSessionDec27
{
    internal class EBook : Book, IDawnloadable
    {
        public string Download()
        {
            return "Downloading the e-book.";
        }

        public override string Read()
        {
            return "Reading a physical e-book.";
        }

        public override string ToString()
        {
            return Download() +"\n"+ Read();
        }
    }
}
