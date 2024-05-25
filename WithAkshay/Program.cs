using System.Net.Http.Headers;

namespace WithAkshay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method Hiding 
            //method Overloading
            //Method Overriding 


            //Base obj2 = new Base();
            //obj2.CalcualteSalary();
            //obj2.CalcualteBonus();


            //Child obj1 = new Child();
            //obj1.CalcualteSalary();
            //obj1.CalcualteBonus();

            Console.WriteLine("Via reference ");
            //via reference 
            //you can create child object and aissng to base class

            //Base obj3 = new Child(); // implicit casting
            //obj3.CalcualteSalary();
            //obj3.CalcualteBonus();


            //Base obj5 = new grandchild();
            //obj5.CalcualteSalary();
            //obj5.CalcualteBonus();

            //Child obj10 = new grandchild();
            //obj10.CalcualteSalary();
            //obj10.CalcualteBonus();

            //Rule 1 : Thy Object thy method 
            //Rule 2 : Casting + override ------> call child 
            //Rule 3 :if method not present in child then call base 


            //runtime polymorphism : overriding you can acheive via virtual /override

            //same method implemntation in child class gives you warning 


            //virtual can be override 
            //We start to study overrloading

           Child obj = new Child();
           obj.Print("akshy");
           obj.Print(30);


            grandchild obj3 = new grandchild(); // implicit casting
            obj3.Print("akshy");
            obj3.Print(30);

        }

        class Base
        {
            public virtual void CalcualteSalary()
            {
                Console.WriteLine($"Base : 1000 ");
            }
            virtual public void CalcualteBonus()
            {
                Console.WriteLine($"Base : 200 ");
            }
            public void Print(string message)
            {
                Console.WriteLine(message);
            }

            // overroloding doesnt depent on return type of method 
            //public int Print(string message)
            //{
            //    return 0;
            //}
        }


        class Child : Base
        {
            public override void CalcualteSalary()
            {
                Console.WriteLine($"Child : 5000 ");
            }
            public override void CalcualteBonus()
            {
                Console.WriteLine($"Child : 2000 ");
            }
            public void Print(int age)
            {
                Console.WriteLine(age);
            }
        }

        class grandchild : Child
        {
            public  void CalcualteSalary()
            {
                Console.WriteLine($"grandchild : 500000 ");
            }
            public  void CalcualteBonus()
            {
                Console.WriteLine($"grandchild : 200000 ");
            }
        }



    }
}
