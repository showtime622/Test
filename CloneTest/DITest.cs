using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTest
{
    class DITest
    {
        public void test(iT i)
        {
            i.test();
        }
        
    }

    public class D1 : iT
    {
        public string name;

        public void test()
        {
            Console.Write("I am in d1");
        }
    }

    public class D2 : iT
    {
        public string name;

        public void test()
        {
            Console.Write("I am in d2");
        }
    }

    public  interface iT
    {
        void test();
    }
}
