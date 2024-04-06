//Локальные функции

//расчитать значение функции
//1
//double x = (Math.Sqrt(6) + 6) / 2 + (Math.Sqrt(13) + 13) / 2 + (Math.Sqrt(21) + 21) / 2;
//Console.WriteLine($"{x:F2}");

////2
//x = Func(6) + Func(13) + Func(21);
//double Func(int x)
//{
//    return (Math.Sqrt(x) + x) / 2;
//}

//Console.Write("Введите а: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите b: ");
//int b = int.Parse(Console.ReadLine());
//int z = int.Max(a, 2 * b) * int.Max(2 * a - b, b);
//Console.WriteLine(z);
//Console.WriteLine(sign(a)+sign(b));

//int Max(int x, int y)
//{
//    if (x > y) return x;
//    else if (y > x) return y;
//    return x;
//}
//int sign(double a)
//{
//    if (a < 0) return -1;
//    else if (a>0) return 1;
//    return 0;
//}


//10.6
//Console.Write("Введите а: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b: ");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите d: ");
//double d = double.Parse(Console.ReadLine());
//double c = gipothenus(a, b);
//double e=gipothenus(c,d);
//Console.WriteLine($"P={a+b+d+e:F2}");
//double gipothenus(double x, double y)
//{
//    return Math.Sqrt(x * x + y * y);
//}

//10.15
//for (int i = 0; i < 1000; i++)
//{
//     if(IsSimple(i)==true) Console.Write(i +" ");
//}
//bool IsSimple(int x)
//{
//    int k = 0;
//    for(int i=2; i<x; i++)
//    {
//        if(x%i==0) k++;
//    }
//    if(k==0) return true;
//    return false;
//}

//10.17
//long Fact(int x)
//{
//    long f = 1;
//	for (int i = 1; i <= x; i++) f *= i;
//	return f;
//}
//double y = (2.0 * Fact(5) + 3 * Fact(8) / (Fact(6) + Fact(4)));
//Console.WriteLine(y.ToString("F2"));

//10.33
//void Draw ()
//{
//	for (int i = 0; i < 80; i++)
//	{
//        Console.Write("*");
//    }
//}
//Draw();

//Дописать из гитхаба
//рамка
//void Draw()
//{
//    for(int k=0;k<Console.WindowHeight;k++)
//    {
//        for (k== 0|| i< Console.WindowHeight)
//        {

//        }
//    }
//    for (int i = 0; i < Console.WindowWidth; i++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();

//    for (int i = 0; i < Console.WindowWidth; i++)
//    {
//        if (i==0||i==Console.WindowWidth-1) Console.Write("*");
//        else Console.Write(" ");
//    }
//}
//Draw();

//2
//double Avg(int[]mas)
//{
//    double s=0;
//    foreach (var item in mas) s += item;
//    return s/mas.Length;
//}
//Random random = new Random();
//int[] mas = new int[random.Next(10, 20)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(100);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Console.WriteLine(Avg(mas).ToString("F2"));

//3
//string Reverse(string str)
//{
//    string res = "";
//    for (int i = str.Length - 1; i >= 0; i--) res += str[i];
//    return res;
//}
//Console.Write("Введите строку: ");
//string str=Console.ReadLine();
//Console.WriteLine(Reverse(str));

//5
//bool IsAnogram(string str1, string str2)
//{
//    string withOutRepeat = "";
//    for (int i = 0; i < str1.Length; i++)
//    {
//        if (!withOutRepeat.Contains(str1[i])) withOutRepeat += str1[i];
//    }
//    int l1 = withOutRepeat.Length;
//    for (int i = 0; i < str2.Length; i++)
//    {
//        if (!withOutRepeat.Contains(str2[i])) withOutRepeat += str1[i];
//    }
//    int l2 = withOutRepeat.Length;
//    if (l1 == l2) return true;
//    return false;
//}
//Console.Write("Введите первую строку: ");
//string str1 = Console.ReadLine();
//Console.Write("Введите вторую строку: ");
//string str2 = Console.ReadLine();
//if (IsAnogram(str1, str2)) Console.WriteLine("Анограммы");
//Console.WriteLine("Не анограммы");

//void Swap(ref int a,ref int b )//ref - передача по ссылке
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//int func ( in int x )//in - входной
//{
//    return 2 * x + 1;
//}
//void Add ( int x, int y, out int s )
//{
//    s = x + y;
//}
//int x = 7, y = 9;
//Console.WriteLine(x+" "+y);
//Swap(ref x,ref y);
//Console.WriteLine(x + " " + y);
//x = 10;
//Console.WriteLine(func(x));

//int s = 0;
//Add(x, y, out s);
//Console.WriteLine(s);

int n;
int.TryParse(Console.ReadLine(), out n);
Console.WriteLine(n);

