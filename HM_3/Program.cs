using HM_3;


int[] arr = { 1, 6, 4, 23, 5 };

MyArray myArray	= new MyArray(arr);

myArray.Show();
myArray.Show($"This my array: ");

Console.WriteLine(new string('*', 30));

int valueToSearch = 25;

Console.WriteLine($"Max array value: {myArray.Max()}");
Console.WriteLine($"Min array value: {myArray.Min()}");
Console.WriteLine($"Avarege array value: {myArray.Avg()}");
Console.WriteLine($"Will the values {valueToSearch} in the array: {myArray.Search(valueToSearch)}");

Console.WriteLine(new string('*', 30));

myArray.SortAsc();
myArray.SortDesc();
myArray.SortByParam(true);

