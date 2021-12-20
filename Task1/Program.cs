Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Square of number is " + (number*number));