using HW_5;

// The Play

ThePlay play = new ThePlay("Гамлет", "В.Шекспір", "трагедія", 1600);
play.Info();

play.Title = "Король Лір";
play.Author = "Вільям Шекспір";
play.Year = 1606;

Console.WriteLine("\nОновлена інформація про п'єсу:");
play.Info();
GC.Collect();   // что то не совсем понял про диструктор 

Console.WriteLine("-------------");

using (ThePlay play2 = new ThePlay("Гамлет", "В.Шекспір", "трагедія", 1600))
{
	play2.Info();
}

//Shop

using (Shop atb = new Shop("ATB", "Kreshatik st. 1", ShopType.Grocery))
{
	atb.ShowShopInfo();
}


Shop intertop = new Shop("Intertop", "Peremogyi Avenue. 23", ShopType.Footwear);

intertop.ShowShopInfo();
GC.Collect();