using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Calculator
    {
        public void Add()
        {
            int x=5;
            int y=6;
            int result=x+y;
            Console.WriteLine("Addition = {0}", result);

        }
        public void sub()
        {
            Console.WriteLine("Enter 1st number");
           int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int y = int.Parse(Console.ReadLine());

            int result = x - y;
            Console.WriteLine("Sub: " + result);
        }

        public void division()
        {
            Console.WriteLine("Enter 1st number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int y = int.Parse(Console.ReadLine());

            double result = x / y;
            Console.WriteLine("Division: " + result);
        }
    }
}
