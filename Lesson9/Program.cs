//int a = 16;
//int b = 7;
//Console.WriteLine(a&b);

Console.Write("Введите число:");
int a =int.Parse(Console.ReadLine());
if (a % 2 >= 0)
    Console.WriteLine("Четное");
else
    Console.WriteLine("Нечетное");