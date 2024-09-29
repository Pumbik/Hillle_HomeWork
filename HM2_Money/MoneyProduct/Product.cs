using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2_Money.MoneyProduct
{
    public class Product
    {
        public string Name { get; set; }

        public Money? Money { get; set; }

        public void ShowProduct()
        {
            Console.WriteLine($"Наименование товара: {Name} стоимость {Money?.WholePart} грн. {Money?.FractionalPart} коп.");
        }
    }
}
