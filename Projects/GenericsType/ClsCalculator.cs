using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericsType
{
    internal class ClsCalculator
    {
        public static bool AreEqual<T>(T p1 ,T p2)
        {
            if (p1 == null || p2 == null) return false;
            if (p1.Equals(p2)) return true;
            return false;
        }

    }
}
