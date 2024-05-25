using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithAkshay
{
    //An abstract class is half defined/partial base or parent class and full definition provided by the child class .
    //Abstract class are inheritance.
    //Abstract class cannot be instantiated 
    //You can't do multiple inheritance with abstract class .


    //Interface is a contract b/w two parties and the parties means whatever you declare in base in must implemnted by any child class
    //You can do multiple inheritance with interface 
    //Interface helps to identify Abstraction.
    internal class PuraAbstraction
    {

    }

    interface ICRUD
    {
        void add();
        void sub();
    }

    abstract class Crud 
    {
        abstract public void add();
        abstract public void sub();
        //
    }
}
