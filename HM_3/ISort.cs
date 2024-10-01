using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_3
{
	public interface ISort
	{
		void SortAsc();
		void SortDesc();
		void SortByParam(bool isAsc);
		//Якщо isAsc дорівнює true, сортуємо за зростанням.
		//Якщо isAsc дорівнює false, сортуємо за зменшенням
	}
}
