
using HW_4;

Employe employe_01 = new Employe(01, "Иванов", "Иван", "ЙТ", "Разработчик", 500);

employe_01.EmplInfo();

Employe employe_02 = new Employe(02, "Дужова", "Инна", "Бухгалтерия", "Бухгалтер", 450);

employe_02.EmplInfo();

employe_01 += 100;
employe_01.EmplInfo();

Console.WriteLine(employe_01 == employe_02);
Console.WriteLine(employe_01 > employe_02);
employe_02 -= 500;
Console.WriteLine(employe_01.Equals(employe_02));

// *****************

City city = new City("Киев", 250000);
city.CityInfo();
city += 100;
city.CityInfo();

// *****************

CreditCard card1 = new CreditCard("UA3489889034834", "2620-4441-4567-3421", 233, 2500);
card1.CreditCardInfo();

CreditCard card2 = new CreditCard("UA538785887345", "2600-3441-5557-1421", 233, 13500);
card2.CreditCardInfo();

Console.WriteLine(card1 == card2);