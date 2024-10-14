using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{

	public class Matrix
	{
		// Поле для зберігання елементів матриці
		private double[,] elements;

		// Властивості для отримання кількості рядків і стовпців
		public int Rows { get; private set; }
		public int Columns { get; private set; }

		// Конструктор, який ініціалізує матрицю заданих розмірів
		public Matrix(int rows, int columns)
		{
			Rows = rows;
			Columns = columns;
			elements = new double[rows, columns];
		}

		// Індексатор для доступу до елементів матриці
		public double this[int row, int column]
		{
			get { return elements[row, column]; }
			set { elements[row, column] = value; }
		}

		// Перевантаження оператора додавання
		public static Matrix operator +(Matrix a, Matrix b)
		{
			if (a.Rows != b.Rows || a.Columns != b.Columns)
				throw new InvalidOperationException("Матриці повинні бути однакового розміру для додавання!");

			Matrix result = new Matrix(a.Rows, a.Columns);
			for (int i = 0; i < a.Rows; i++)
			{
				for (int j = 0; j < a.Columns; j++)
				{
					result[i, j] = a[i, j] + b[i, j];
				}
			}
			return result;
		}

		// Перевантаження оператора віднімання
		public static Matrix operator -(Matrix a, Matrix b)
		{
			if (a.Rows != b.Rows || a.Columns != b.Columns)
				throw new InvalidOperationException("Матриці повинні бути однакового розміру для віднімання!");

			Matrix result = new Matrix(a.Rows, a.Columns);
			for (int i = 0; i < a.Rows; i++)
			{
				for (int j = 0; j < a.Columns; j++)
				{
					result[i, j] = a[i, j] - b[i, j];
				}
			}
			return result;
		}

		// Перевантаження оператора множення матриці на матрицю
		public static Matrix operator *(Matrix a, Matrix b)
		{
			if (a.Columns != b.Rows)
				throw new InvalidOperationException("Кількість стовпців першої матриці повинна дорівнювати кількості рядків другої матриці для множення!");

			Matrix result = new Matrix(a.Rows, b.Columns);
			for (int i = 0; i < a.Rows; i++)
			{
				for (int j = 0; j < b.Columns; j++)
				{
					for (int k = 0; k < a.Columns; k++)
					{
						result[i, j] += a[i, k] * b[k, j];
					}
				}
			}
			return result;
		}

		// Перевантаження оператора множення матриці на число
		public static Matrix operator *(Matrix a, double scalar)
		{
			Matrix result = new Matrix(a.Rows, a.Columns);
			for (int i = 0; i < a.Rows; i++)
			{
				for (int j = 0; j < a.Columns; j++)
				{
					result[i, j] = a[i, j] * scalar;
				}
			}
			return result;
		}

		// Перевантаження оператора рівності
		public static bool operator ==(Matrix a, Matrix b)
		{
			if (a.Rows != b.Rows || a.Columns != b.Columns)
				return false;

			for (int i = 0; i < a.Rows; i++)
			{
				for (int j = 0; j < a.Columns; j++)
				{
					if (a[i, j] != b[i, j])
						return false;
				}
			}
			return true;
		}

		// Перевантаження оператора нерівності
		public static bool operator !=(Matrix a, Matrix b)
		{
			return !(a == b);
		}

		// Перевизначений метод Equals
		public override bool Equals(object obj)
		{
			if (obj is Matrix)
			{
				return this == (Matrix)obj;
			}
			return false;
		}

		// Перевизначений метод GetHashCode
		public override int GetHashCode()
		{
			return elements.GetHashCode();
		}

		// Метод для виведення матриці на екран
		public void Print()
		{
			for (int i = 0; i < Rows; i++)
			{
				for (int j = 0; j < Columns; j++)
				{
					Console.Write(elements[i, j] + "\t");
				}
				Console.WriteLine();
			}
		}
	}

}
