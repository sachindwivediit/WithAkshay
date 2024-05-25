using static SolidConcept.Account;

namespace SolidConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeLSP employee = new EmployeeLSP(); //parenmt
            PermanantEmployee permanantEmployee = new PermanantEmployee(); //child

            EmployeeLSP obj = new PermanantEmployee(); // casting + overriding ===calling child class  

            ContraactEmployee contractEmployee = new ContraactEmployee();

            Console.WriteLine(contractEmployee.CalculateSalary());
            Console.WriteLine(contractEmployee.CalculateBonus());

        }
    }

    // SOLID is a set of five design principles to make software designs more
    //  1. Readable
    //  2. Extensable
    //  3. Maintable
    //  4. Testable 

    //S - Single responsibilty priciple 
    // A class should single resposniblity 
    //Which means a class should have one reason to change 
    class Employee
    {
        void Log()
        {
            Console.WriteLine("Logger Succesfully");
        }
        void save()
        {
            Console.WriteLine("Data saved Successfully");
        }

        void Print()
        {
            Console.WriteLine("Document Print successfully Successfully");
        }
    }

    class Repository
    {
        void Save()
        {
            Console.WriteLine("Logger Succesfully");
        }
    }
    class Logger
    {
        void Log()
        {
            Console.WriteLine("Logger Succesfully");
        }
    }

    class PrintDocument
    {
        void Print()
        {
            Console.WriteLine("Document Print successfully Successfully");
        }
    }


    //OCP - Class should have open for extension but closed for modification 
    // before this its should SRP 

    //Problem
    class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int phoneno { get; set; }
        public double Balance { get; set; }
        public double CalcuateInterest(string accountType)
        {
            if (accountType == "Saving")
            {
                return Balance * 5;
            }
            else if (accountType == "Current")
            {
                return Balance * 6;
            }
            else if (accountType == "Coporate") //Added later this account after implementation of function and test cases 
            {
                return Balance * 7;
            }
            else
            {
                return Balance * 8;
            }
        }

        //OCP Solution 
        public class Account1
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public int phoneno { get; set; }
            public double Balance { get; set; }

        }
        public interface IAccount
        {
            public double CalcuateInterest(Account1 account);
        }

        public class SavingAccount : IAccount
        {
            public virtual double CalcuateInterest(Account1 account)
            {
                return account.Balance * 6;
            }
        }

        public class CurrentAccount : IAccount
        {
            public double CalcuateInterest(Account1 account)
            {
                return account.Balance * 7;
            }
        }

        public class CoporateAccount : IAccount
        {
            public double CalcuateInterest(Account1 account)
            {
                return account.Balance * 8;
            }
        }


        //Liskov Substion principle 
        // It states that an object of a child class must be able to replace an object of parent class without breaking the application  

        //All the base class must be applicable for the derived class 


        //inheritance with ovcerrideing 
        //inhgeritance with abstract class 
        public class EmployeeLSP : ISalaryBonus
        {
            public virtual int CalculateSalary()
            {
                return 10000;
            }
            public int CalculateBonus()
            {
                return 1000;
            }
        }

       interface ISalaryBonus
        {
             int CalculateBonus();
        }

        public class PermanantEmployee  : EmployeeLSP, ISalaryBonus
        {
            public override int CalculateSalary()
            {
                return 500;
            }
            public int CalculateBonus()
            {
                return 50;
            }
        }

        public class ContraactEmployee : EmployeeLSP
        {
            public override int CalculateSalary()
            {
                return 500000;
            }
        }



    }
}
