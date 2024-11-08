//using HW_7_Barber;


using System.Runtime.InteropServices;

class Program
{
	[DllImport("kernel32.dll")]
	private static extern bool SetConsoleOutputCP(uint wCodePageID);
	static void Main(string[] args)
	{
		SetConsoleOutputCP(1251);

		Barbershop barbershop = new Barbershop(3); // 3 місця в очікувальній кімнаті
		Thread barberThread = new Thread(barbershop.CutHair);
		barberThread.Start();

		for (int i = 1; i <= 10; i++)
		{
			Customer customer = new Customer($"Відвідувач {i}");
			Thread.Sleep(new Random().Next(500, 1000)); // Симуляція часу прибуття відвідувачів
			barbershop.Enter(customer);
		}

		barberThread.Join(); // Чекаємо завершення потоку перукаря (необхідно для коректного завершення програми)
	}
}