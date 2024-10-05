using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
	internal class City
	{
		public string Name {  get; set; }
		public int NumberOfInhabitants { get; set; }

		public City(string name, int inhabitans)
		{
			Name = name;
			NumberOfInhabitants = inhabitans;
		}

		public void CityInfo()
		{
            Console.WriteLine($"Население города {Name} - {NumberOfInhabitants} жителей.\n");
		}
		
		public static City operator +(City city ,int quantity)
		{
			city.NumberOfInhabitants += quantity;
			return city;
		}

		public static City operator -(City city, int quantity)
		{ 
			city.NumberOfInhabitants -= quantity;
			return city;
		}

		public static bool operator ==(City city1, City city2)
		{
			return city1.NumberOfInhabitants == city2.NumberOfInhabitants;
		}

		public static bool operator !=(City city1, City city2)
		{ 
			return !(city1 == city2);
		}

		public static bool operator >(City city1, City city2)
		{
			return city1.NumberOfInhabitants > city2.NumberOfInhabitants;
		}

		public static bool operator <(City city1, City city2)
		{
			return city1.NumberOfInhabitants < city2.NumberOfInhabitants;
		}

		public override bool Equals(object? obj)
		{
			if(obj is City)
			{
				City city = (City)obj;
				return this.NumberOfInhabitants == city.NumberOfInhabitants;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return NumberOfInhabitants.GetHashCode();
		}
	}
}
