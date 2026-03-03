Console.WriteLine("What is your name?");
string name = Console.ReadLine();

Console.WriteLine("Hello " + name + "! Welcome to C#.");
Console.WriteLine("How old are you?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Next year, you will be " + (age + 1));
Console.WriteLine("Where do you stay?");
string address = Console.ReadLine();
Console.WriteLine("i stay around " + address + "in  Lagos, Nigeria");