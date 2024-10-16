using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
	public class ThePlay: IDisposable
	{
		private string	_title;
		private string	_author;
		private string	_genre;
		private int		_year;

        public ThePlay(string title, string author, string genre, int year)
        {
            _title	= title;
			_author = author;
			_genre	= genre;
			_year	= year;
        }


		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		public string Author
		{
			get { return _author; }
			set { _author = value; }
		}

		public string Genre
		{
			get { return _genre; }
			set { _genre = value; }
		}

		public int Year
		{
			get { return _year; }
			set { 
				if (value > 0)
					_year = value;
				else
					Console.WriteLine("Рік має бути додатним числом.");
				
			}
		}

		public void Info()
		{
			Console.WriteLine($"Назва п'єси: {Title}");
			Console.WriteLine($"Автор: {Author}");
			Console.WriteLine($"Жанр: {Genre}");
			Console.WriteLine($"Рік: {Year}");
		}

		public void Dispose()
		{
			Console.WriteLine("П'єсу закрито! Dispose\n"); 
		}

		~ThePlay()
		{
			Console.WriteLine("П'єсу закрито! ~ThePlay\n");
		}


	}
}
