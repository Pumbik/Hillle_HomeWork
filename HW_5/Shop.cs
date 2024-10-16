using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
	public enum ShopType
	{
		Grocery,        // Продовольчий
		Household,      // Господарський
		Clothing,       // Одяг
		Footwear        // Взуття
	}

	public class Shop: IDisposable
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _adress;

		public string Adress
		{
			get { return _adress; }
			set { _adress = value; }
		}

		private ShopType _type;

		public ShopType Type
		{
			get { return _type; }
			set { _type = value; }
		}

        public Shop(string name, string adress, ShopType shopType)
        {
            _name = name;
			_adress = adress;	
			_type = shopType;
        }

		public void ShowShopInfo()
		{
            Console.WriteLine($"Shop {Name} is located at {Adress}");
            Console.WriteLine($"Store type {Type}");
		}

		public void Dispose()
		{
            Console.WriteLine($"Shop is closed\n");
		}

		~Shop() 
		{
			Console.WriteLine($"Shop is closed indefinitely\n");
		}
	}
}
