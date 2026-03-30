using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class overrideoperators
    {

        public int id { get; set; }

        public string Name { get; set; }

        public overrideoperators(int _id ,string _Name)
        {
            id = _id;
            Name = _Name;
        }

        public static bool operator <=(overrideoperators lhs, overrideoperators rhs)
        {
             return lhs.id <= rhs.id && lhs.Name == rhs.Name;
        }

        public static bool operator >=(overrideoperators lhs, overrideoperators rhs) 
        {
            return lhs.id >= rhs.id && lhs.Name == rhs.Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is overrideoperators rhs && (this.id == rhs.id && this.Name == rhs.Name);
        }
    }
}
