using System;
using System.Collections.Generic;
using System.Threading;

class Barbershop
{
	private Queue<Customer> waitingRoom = new Queue<Customer>();
	private readonly int waitingSeats;
	private bool isBarberSleeping = true;
	private readonly object lockObject = new object();

	public Barbershop(int seats)
	{
		waitingSeats = seats;
	}

	public void Enter(Customer customer)
	{
		lock (lockObject)
		{
			if (waitingRoom.Count < waitingSeats)
			{
				waitingRoom.Enqueue(customer);
				Console.WriteLine($"{customer.Name} зайняв місце в очікувальній кімнаті.");
				Monitor.Pulse(lockObject); // Будимо перукаря
			}
			else
			{
				Console.WriteLine($"{customer.Name} пішов, оскільки немає вільного місця.");
			}
		}
	}

	public void CutHair()
	{
		while (true)
		{
			Customer? customer = null;

			lock (lockObject)
			{
				while (waitingRoom.Count == 0)
				{
					Console.WriteLine("Перукар спить...");
					isBarberSleeping = true;
					Monitor.Wait(lockObject); // Чекаємо нових відвідувачів
				}

				customer = waitingRoom.Dequeue();
				isBarberSleeping = false;
				Console.WriteLine($"Перукар починає стрижку {customer.Name}.");
			}

			// Симуляція процесу стрижки
			Thread.Sleep(2000);
			Console.WriteLine($"Перукар закінчив стрижку {customer.Name}.");
		}
	}
}

class Customer
{
	public string Name { get; }

	public Customer(string name)
	{
		Name = name;
	}
}