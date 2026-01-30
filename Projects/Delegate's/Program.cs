
using System.Collections;
using System.Numerics;

namespace Delegate_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.ReadKey();
        }
    }

    public class Test : IEnumerable
    {
        public int[] ints;

        public Test(int [] arr)
        {
            ints = arr;
        }

        public IEnumerator GetEnumerator() => new Enumrable(this);


        class Enumrable : IEnumerator
        {
            int currentindex = -1;
            Test test;
            public Enumrable(Test obj)
            {
                test = obj;
            }

            object IEnumerator.Current()
            {
                get{  return test; }
            }

            public bool MoveNext()
            {
                if()

                        return true;
                return false;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }

}
