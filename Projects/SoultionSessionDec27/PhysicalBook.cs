using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoultionSessionDec27
{
    internal class PhysicalBook : Book
    {
        public override string Read()
        {
            return "Reading a physical book.";
        }

        public override string ToString()
        {
            return Read();
        }
    }
}
