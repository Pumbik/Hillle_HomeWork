using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2_Money.MoneyProduct
{
    public class Money
    {
        private int _wholePart;
        private int _fractionalPart;

        public int WholePart
        {
            get
            {
                return _wholePart;
            }
            set
            {
                // if (_wholePart > 0)
                _wholePart = value;
            }
        }

        public int FractionalPart
        {
            get
            {
                return _fractionalPart;
            }
            set
            {
                // if (_fractionalPart > 0)
                _fractionalPart = value;
            }
        }

        public void SetMoney(int wholePart, int fractionalPart)
        {
            if (fractionalPart >= 100)
            {
                WholePart = wholePart + fractionalPart / 100;
                FractionalPart = fractionalPart % 100;
            }
            else
            {
                WholePart = wholePart;
                FractionalPart = fractionalPart;
            }
        }

        public void ShowMoney()
        {
            Console.WriteLine($"{_wholePart} грн {_fractionalPart:D2} коп.");
        }
    }
}
