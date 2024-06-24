using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWT_TestedProject
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double MultiplyDouble(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public int RemainingDiv(int a, int b) 
        {
            return a % b;
        }

        public bool? PartialCodeCoverage(int i)
        {
            if (i > 10)
                return true;
            else if (i is < 9 and > 0)
                return false;
            
            return null;
        }
        
        public string AddEurToCalculation(Func<int, int, int> func, int a, int b) => $"{func(a,b)}€";
    }
}
