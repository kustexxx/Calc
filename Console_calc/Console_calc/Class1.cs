using Console_calc;
using System;

namespace Console_calc
{
    internal class Class1
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b, out string errorMessage)
        {
            errorMessage = "";
            if (!CheckData.CheckDivision(b, out errorMessage))
            {
                return 0;
            }
            return a / b;
        }
    }
}

