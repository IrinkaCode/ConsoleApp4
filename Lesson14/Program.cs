//for (int i=35;i<87;i++)
//{
//    if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5) Console.Write(i + " ");
//}

//for(; ; ) Console.WriteLine("aa");
//int k = 0;
//for (;true;k++) Console.WriteLine(k);

//Console.WriteLine("Введите n:");
//int n=int.Parse(Console.ReadLine());
//int s = 0;
//for (int i = 1; i <= n; s += i, i++) ;
//Console.WriteLine(s);

//1
//Console.WriteLine("Введите строку: ");
//string str = Console.ReadLine();
//for (int i = str.Length - 1; i >= 0; i--) Console.WriteLine(str[i]);

//2
//Console.WriteLine("Введите строку: ");
//string str=Console.ReadLine();
//string rts = "";
//for (int i = str.Length - 1; i >= 0; i--) rts += str[i];
//if (str == rts) Console.WriteLine("Палиндром");
//else Console.WriteLine("Не палиндром");

//6
//Console.WriteLine("Введите целое число: ");
//int n=int.Parse(Console.ReadLine());
//for (int i = 1; i <=n; i++)
//{
//    if (n % i == 0) Console.WriteLine(i + " ");
//}

//7
//Console.WriteLine("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//int k = 0;//количество делителей
//for (int i =2; i < n; i++)
//{
//    if (n % i == 0) k++;
//}
//if (k == 0) Console.WriteLine("Простое число");
//else Console.WriteLine("Не простое число");

//8
//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    int k = 0; //количество делителей
//    for (int j = 2; j < i; j++) if(i%j==0) k++;
//    if (k == 0) Console.WriteLine(i + " ");
//}

//8 другой вариант
//int i = 1;
//while(i<=n)
//{
//    int k = 0;
//    int j = 2; //внутренни счетчик,перебор делителей
//    while(j<i)
//    {
//        if (i % j == 0) k++;
//        j++;
//    }
//    if(k==0) Console.Write(i+" ");
//    i++;
//}

//9
//Console.Write("Введите целое число: ");
//int n = int.Parse(Console.ReadLine());
//string str = "";
//while (n != 1)
//{
//    int temp = n % 2;
//    str += temp;
//    n /= 2;//счетчик
//}
//str += "1";

//for (int i=str.Length-1; i>=0; i--)
//    Console.Write(str[i]);

//то же самое
//for (; n != 1; str += n % 2, n /= 2) ;
//str += "1";
//for (int i = str.Length - 1; i >= 0; i--)
//    Console.Write(str[i]);

//1
//Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine());
//long Fact = 1;

//for (int i = 1; i <= n; i++)
//{
//    Fact *= i;
//}
//Console.WriteLine($"факториал {n}={Fact}");

//for(int i=1;i<=n;f*=i++);

//2
//Console.Write("Введите первое число a: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число b: ");
//int b = int.Parse(Console.ReadLine());


//for (int i=a;i<=b;i++)
//{
//    if (i%3 == 0||i%5==0) Console.WriteLine(i+" ");
//}

//3
Console.WriteLine("Введите целое число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
for (int j = 1; j <= n; j += i)
{
    Console.WriteLine(j + " ");
    i = j - i;
}