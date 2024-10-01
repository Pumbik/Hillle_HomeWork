using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HM_3
{
	public class MyArray : IOutput, IMath, ISort
	{
		private int[] infoArray;

		public MyArray(int[] arr)
		{
			infoArray = arr;
		}

		#region імплементування інтерфейсу IMath
		public float Avg()
		{
			return (float)infoArray.Average(); // Average() return double
		}

		public int Max()
		{
			return infoArray.Max();
		}

		public int Min()
		{
			return infoArray.Min();
		}

		public bool Search(int valueToSearch)
		{
			bool result = false;
			foreach (var item in infoArray)
			{
				if (item == valueToSearch)
					result = true;
			}
			return result;
		}
		#endregion

		#region імплементування інтерфейсу IOutput
		public void Show()
		{
           // Console.Write("its array elements --> ");
			foreach (int i in infoArray) 
			{
				Console.Write(i + " ");
			}
            Console.WriteLine();
		}

		public void Show(string info)
		{
            Console.Write(info);
			Show();

		}
		#endregion

		#region імплементування інтерфейсу ISort.
		public void SortAsc()
		{
			Array.Sort(infoArray);
			Show("Sorting in ascending order: ");
		}

		public void SortByParam(bool isAsc)
		{
			if (isAsc)
			{
				SortAsc();
			}
			else
			{
				SortDesc();
			}
		}

		public void SortDesc()
		{
			Array.Sort(infoArray);
			Array.Reverse(infoArray);
			Show("Sorting in descending order: ");
		}
		#endregion
	}
}
