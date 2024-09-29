using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2_Money.TensNumber
{
    struct TensNumber
    {
        public int Number {  get; private set; }

        public TensNumber(int number) 
        {
            Number = number; 
        }

        public string ToBinary() 
        { 
            //return Number.ToString();
            return Convert.ToString(Number, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(Number, 8);
        }

        public string ToHex()
        {
            return Convert.ToString(Number, 16);
        }

        public void ShowDecimal()
        {
            Console.WriteLine($"Десяткове число: {Number}");
        }
    }
}
