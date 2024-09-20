using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    public class CalculateApp
    {
        public double Add(double a, double b) 
        { 
            return (a + b); 
        }

        public double Sub(double a, double b) 
        { 
            return (a - b); 
        }

        public double Mult(double a, double b)
        {
            return (a * b);
        }

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ділення на нуль не допустиме");
            }
            return (a / b);
        }
    }
}
