//Урок 10 

Console.Write("Введите значение катета: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите значение гипотенузы:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"{Math.Sqrt(b * b - a * a):F2}");