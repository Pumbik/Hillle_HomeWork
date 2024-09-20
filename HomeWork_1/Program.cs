using HomeWork_1;

CalculateApp calculateApp = new CalculateApp();

#region Самий простий
//Console.Write("Введіть перше число: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.Write("Введіть друге число: ");
//double b = Convert.ToDouble(Console.ReadLine());


//Console.WriteLine($"Результат додавання: {calculateApp.Add(a, b)}");

//Console.WriteLine($"Результат віднімання: {calculateApp.Sub(a, b)}");

//Console.WriteLine($"Результат множення: {calculateApp.Mult(a, b)}");

//Console.WriteLine($"Результат ділення: {calculateApp.Div(a, b)}");

#endregion

double a = GetNumber("Введіть перше число: ");
double b = GetNumber("Введіть друге число: ");

Console.Write("Виберіть дію (+, -, *, /): ");
string operation = Console.ReadLine();

bool validOperation = true;
double result = 0;

if (operation == "+")
{
    result = calculateApp.Add(a, b);
}
else if (operation == "-")
{
    result = calculateApp.Div(a, b);
}
else if (operation == "*")
{
    result = calculateApp.Mult(a, b);
}
else if (operation == "/")
{
    try
    {
        result = calculateApp.Div(a, b);
    }
    catch (DivideByZeroException ex) 
    {
        Console.WriteLine(ex.Message);
        validOperation = false;
    }
}
else
{
    Console.WriteLine("Невірна операція. Будьте уважні при виборі операції!");
    validOperation = false;
}
if (validOperation)
{
    Console.WriteLine($"Результат операції {a} {operation} {b} = {result}");
}

// перевірка введення числа
static double GetNumber(string question)
{
    double result;

    while (true)
    {
        Console.Write(question);
        string input = Console.ReadLine();

        bool valid = double.TryParse(input, out result);

        if (valid)
        {
            return result;
        }
        else
        {
            Console.WriteLine("Некоректне введення!!! Введіть число");
        }
    }
}