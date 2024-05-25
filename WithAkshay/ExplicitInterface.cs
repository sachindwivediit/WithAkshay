using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithAkshay
{
    internal class ExplicitInterface
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.CalculaterSalary();


            IPernanentEmployee objpermanetEmployee = new Test();
            objpermanetEmployee.CalculateSalary();
            objpermanetEmployee.DisplayName();



            IContractEmployee objContractEmployee = new Test();
            objContractEmployee.CalculateSalary();
            objContractEmployee.CalcualteBonus();
        }
    }

    interface IPernanentEmployee
    {
        void CalculateSalary();

        void DisplayName();
    }

    interface IContractEmployee
    {
        void CalculateSalary();

        void CalcualteBonus();
    }

    class Test : IPernanentEmployee, IContractEmployee
    {
        void IPernanentEmployee.CalculateSalary()
        {
            Console.WriteLine("Pernanet Employee 1000");
        }

        void IPernanentEmployee.DisplayName()
        {
            Console.WriteLine("Pernanet Employee Akshay Verma");
        }
        void IContractEmployee.CalcualteBonus()
        {
            Console.WriteLine("ContractEmployee CalcualteBonus 2000");
        }
        void IContractEmployee.CalculateSalary()
        {
            Console.WriteLine("ContractEmployee CalculateSalary 500");
        }

        public void CalculaterSalary()
        {
            Console.WriteLine("Class specific CalculaterSalary");
        }

       
    }
}
