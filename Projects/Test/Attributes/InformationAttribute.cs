using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Attributes
{

    public class InformationAttribute : Attribute
    {
        public InformationAttribute() { }

        public InformationAttribute(int a,int b, int c)
        {
            
        }

        public int first { get; private set; }
        public int second { get; set; }
        public int Therd { get; set; }

        public bool isvalid(object obj)
        {
            var a = (int)obj;
            return 
        }

    }
}
