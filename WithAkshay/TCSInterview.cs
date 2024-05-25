using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithAkshay
{
    internal class TCSInterview
    {
        static void Main(string[] args)
        {
            Derived2 d = new Derived2();
            d.fun();
        }
    }


    class Baseclass
    {
        public void fun()
        {
            Console.Write("Base class" + " ");
        }
    }


    class Derived1 : Baseclass
    {
        new void fun()
        {
            Console.Write("Derived1 class" + " ");
        }
    }


    class Derived2 : Derived1
    {
        new void fun()
        {
            Console.Write("Derived2 class" + " ");
        }
    }


}
