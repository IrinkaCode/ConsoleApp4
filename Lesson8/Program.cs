//int x = 5;
//Console.WriteLine(x++);
//Console.WriteLine(x);
//Console.WriteLine(++x);

//Console.WriteLine(--x);
//Console.WriteLine(x--);
//Console.WriteLine(x);

//int x = 11;
//Console.WriteLine(x++*2);
//Console.WriteLine(x);
//Console.WriteLine(++x*2);

//int x = 0;
//Console.WriteLine(x);
//x = x + 46;
//Console.WriteLine(x);
//x = x + 12;
//Console.WriteLine(x);
//x = x + 4;
//Console.WriteLine(x);
//x = x + 8;
//Console.WriteLine(x);
//x = x + 15;
//Console.WriteLine(x);


//int a = 28;
//int b = 24;
//int c = 18;
//int d = c - (a - b);
//Console.WriteLine(d);
//int e = 24 - (a - c);
//Console.WriteLine(e);

//decimal all = 56000;
//decimal part = all / 8;
//Console.WriteLine($"{part*5}:{part*2}:{part}");

//double s = 240;
//double v1 = 3;
//double v2 = 2;
//Console.WriteLine(Math.Abs((s / v1) - (s / v2)));

//Console.WriteLine("Введите x:");
//int x= int.Parse(Console.ReadLine());
//Console.WriteLine(x-x%100/10*10);

//int firstNum = 15;
//firstNum = firstNum + 6;
//int secondNum = -firstNum;
//int result = -firstNum - 2 * secondNum;
//Console.WriteLine(result);

decimal butter = 150;
decimal bread = 50;
decimal tea = 40;
Console.Write("Введите количество монет: ");
decimal money= decimal.Parse(Console.ReadLine());
Console.WriteLine($"Хлеб:{bread}\nМасло:{butter}\nЧай:{tea}");
Console.Write("Введите количество хлеба:");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество масла:");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество чая:");
int n3 = int.Parse(Console.ReadLine());
Console.WriteLine($"{"Хлеб",-10} {bread,-8} {n1,-8} {n1 * bread}");
Console.WriteLine($"Масло {butter,-10} {n2,-8} {n2 * butter}");
Console.WriteLine($"Чай {tea,-10} {n3,-8} {n3 * bread}");
Console.WriteLine($"Итого \t {n1 * bread + n2 * butter + n3 * tea}");






