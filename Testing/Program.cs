using System.Threading.Channels;

Message mes1 = Hello.Display;
Message mes2 = new Welcome().Welc;

Welcome pr = new Welcome();
mes2 += pr.Welc;
mes2 += Hello.Display;


mes1();
mes2();


delegate void Message();

public class Hello()
{
	public static void Display() => Console.WriteLine("Hello!");
}

public class Welcome()
{
	public void Welc() => Console.WriteLine("Welcome!!!");
}