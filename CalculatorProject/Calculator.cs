﻿using System;
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

        public void name()
        {
            Console.WriteLine("My name is Shaista!!!");
        }
        public void Test()
        {
            Console.WriteLine("Tested new function.........");
        }
        public void Func1()
        {
            Console.WriteLine("Func 1....");

        }
        public void Func2()
        {
            Console.WriteLine("Func 2....");
        }
        public void AzureDevopsFunc3()
        {
            Console.WriteLine("Func 3");
        }
        public void Func4()
        {
            Console.WriteLine("Func 4");
        }
    }

   
}
