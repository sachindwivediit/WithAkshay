using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithAkshay
{
    public class AbstractConcept
    {
        static void Main(string[] args)
        {
            Base obj = new Child();
            obj.Project();


        }
    }


    //virtual can be override 
    //abstract must override 

    //point 1 : abstract class cannot instantiated directly but you achieve this via implicit casting Base obj = new Child();
    //Point 2 : the soul purpose of abtract is meant for inheritance so you can get run time behaviour 
    //Point 3 : Yes we have constructor in abstract class
    //Point 4 : Yes we have parameterized constructor in abstract class
    //Point 5 : how to call cabstract class cosntrucor  Base obj = new Child();
    //calling cycle : child to parent but execution cycle parent to child 

    //you can not do multiple inheritance with abstract class 
    abstract public class Base
    {

        static Base()
        {
            Console.WriteLine("Static ctor");
        }
        protected Base()
        {
            Console.WriteLine("Hello");
        }
        protected Base(int num)
        {
            Console.WriteLine(num);
        }
        public abstract void Project();

        public abstract void Manager();

        //Non abstract method 
        public void Role()
        {
            Console.WriteLine("SSE");
        }
    }

    class Child : Base
    {
        public Child() 
        {
            Console.WriteLine("child constructor");
        }
        public override void Manager()
        {
            Console.WriteLine("Krisahna");
        }

        public override void Project()
        {
            Console.WriteLine("Barkclay");
        }
    }


    //interface segeration 
    interface IRepo
    {
        void Create();
        void Delte();
        void Update();
    }
    interface IAdditinalCOntract
    {
        void Print();
    }

    class Employee : IRepo
    {
        public void Create()
        {
            Console.WriteLine("Create");
        }

        public void Delte()
        {
            Console.WriteLine("Update");
        }

        public void Update()
        {
            Console.WriteLine("Update");
        }
    }

    class Salary : IRepo, IAdditinalCOntract
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delte()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        //Interface segeration(ISP) states that a class should npt be forced to implement interface that doesnt required
        //its  a betther to have multiple smaller interface rather than larger interface 


        //dependecy inversion principle(dip) states that a high level class must not depend on a lower level class
        //class Employee
        //{  //Employee is High level

        //    FileLogging obj = new Loggint(); //FileLogging is Low Level class 
        //    save();

        //}

    }



}
