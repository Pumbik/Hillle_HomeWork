using HM2_Money;
using HM2_Money.MoneyProduct;
using HM2_Money.MusicInstruments;
using HM2_Money.TensNumber;
using System.Text;


Console.OutputEncoding = Encoding.UTF8;

#region Money
//Money money = new Money();

//money.SetMoney(12, 56);

//money.ShowMoney();

//money.SetMoney(12, 100);
//money.ShowMoney();


//var myProd = new Product
//{
//    Money = new Money
//    {
//        WholePart = 59,
//        FractionalPart = 99
//    },
//    Name = "Chips"
//};

//myProd.ShowProduct();

//Console.WriteLine("---------------------");

#endregion

#region MusicInstruments

//Trombone trombone = new Trombone("Тромбон", "музичний інструмент сімейства мідних духових", 
//                                "Тромбон – слово італійського походження (італ. trombe – означає труба, trombone – велика труба).");

//Violin violin = new Violin("Скріпка", "струнно-смичковий інструмент", "Скрипка вперше згадана в 1520-х роках і була нащадком ребека та віоли");

//Ukulele ukulele = new Ukulele("Укулета", "чотириструнний щипковий музичний інструмент", 
//                                "Перші згадки про нього датуються 1880 роком, коли цей інструмент нагадував невелику гітару -" +
//                                " Брагін, яка з'явилася в 1850-х роках в Португалії");

//Cello cello = new Cello("Віолончель", "струнний смичковий інструмент", "Поява віолончелі сягає початку XVI століття");

//trombone.Show();
//trombone.Desc();
//trombone.History();
//trombone.Sound();

//Console.WriteLine("---------------------");

//ukulele.Show();
//ukulele.Desc();
//ukulele.History();
//ukulele.Sound();

//Console.WriteLine("---------------------");

#endregion

#region TensNumber

TensNumber number = new TensNumber(255);

number.ShowDecimal();

Console.WriteLine($"Двійкова система: {number.ToBinary()}");
Console.WriteLine($"Вісімкова система: {number.ToOctal()}");
Console.WriteLine($"Шістнадцяткова система: {number.ToHex()}");

#endregion