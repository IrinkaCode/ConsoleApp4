Console.Write("Введите радиус окружности:");
double radius = double.Parse(Console.ReadLine());
const double PI = 3.14;
Console.WriteLine($"{PI*radius*radius:F2}");