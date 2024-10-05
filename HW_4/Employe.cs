using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
	internal class Employe
	{
		public int EmplCode { get; set; } // employee code
		public string LastName {  get; set; }
		public string FirstName { get; set; }
		public string Departmen { get; set; }
		public string Position {  get; set; }
		public int Status { get; set; } = 0; // 0 - work, 1- fired
		public decimal Salary { get; set; } = 150; // minimal salary

		public Employe(int code, string lastname, string firstname, string dep, string pos, decimal salary)
		{
			EmplCode = code;
			LastName = lastname;
			FirstName = firstname;
			Departmen = dep;
			Position = pos;
			Salary = salary;
		} 

		public void EmplInfo()
		{
            Console.WriteLine($"Сотрудник: {LastName} {FirstName}");
            Console.WriteLine($"Работае в {Departmen} на должности {Position}");
            Console.WriteLine($"Зарплата: ${Salary}\n");
		}

		public static Employe operator +(Employe employe, decimal amount)
		{
			employe.Salary += amount;
			return employe;
		}

		public static Employe operator -(Employe employe, decimal amount) 
		{
			if (employe.Salary - amount <= 0)
			{
				Console.WriteLine($"Некоректное действие, зарплата не может быть ноль или меньше ноля");
				return employe;
			}
			employe.Salary -= amount;
			return employe;
		}

		public static bool operator ==(Employe emp1, Employe emp2)
		{
			return emp1.Salary == emp2.Salary;
		}

		public static bool operator !=(Employe emp1, Employe emp2)
		{
			return emp1.Salary != emp2.Salary;
		}

		public static bool operator >(Employe emp1, Employe emp2)
		{
			return emp1.Salary > emp2.Salary;
		}

		public static bool operator <(Employe emp1, Employe emp2)
		{
			return emp1.Salary < emp2.Salary;
		}

		public override bool Equals(object? obj)
		{
			if (obj is Employe)
			{
				Employe emp = (Employe)obj;
				return this.Salary == emp.Salary;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return Salary.GetHashCode();
		}
	}
}
