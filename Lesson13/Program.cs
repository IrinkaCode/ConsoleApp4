//int i = 5;
//while(i>0)
//{
//    Console.WriteLine(i--);
//}

//Console.Write("Введите число: ");
//int n=int.Parse(Console.ReadLine());
//long Fact = 1;
//int i = 1;
//while(i<=n)
//{
//    Fact *= i++;
//}
//Console.WriteLine($"факториал {n}={Fact}");

//int a;
//double Sum = 0;
//int CountGreat10 = 0;
//int CountLess10 = 0;
//double avg = 0;
//int min=int.MaxValue;
//int max=int.MinValue;
//int i = 1;
//while (i<=10)
//{
//    Console.WriteLine($"Введите {i} число");
//    a=int.Parse(Console.ReadLine());
//    Sum += a;
//    if(a>10) CountGreat10++;
//    if (a<10 ) CountLess10++;
//    if (a > max) max = a;
//    if (a < min) min = a;
//    i++;
//}
//Console.WriteLine("Sum=" + Sum);
//Console.WriteLine("Count>10"+ CountGreat10);
//Console.WriteLine("count<10"+CountLess10);
//Console.WriteLine("min=" + min);
//Console.WriteLine("max=" + max);
//Console.WriteLine($"avg={Sum / 10}");


//int n;
//do
//{
//    Console.Write("Введите положительное число: ");
//    n = int.Parse(Console.ReadLine());
//    //if(n<=0) Console.WriteLine("Введите положительное число: ");
//}
//while (n <= 0);
//int Sum = 0;
//int i = 1;
//do
//{
//    Sum += i++;
//}
//while (i <= n);
//Console.WriteLine("Sum=" + Sum);
//Console.WriteLine("Введите y/n:");
//char answer = char.Parse(Console.ReadLine());
//if (answer == 'y') break;
//}

//while (true) ;


//int s = 0;
//int i = 1;
//Random random = new Random();
//while(i<=50)
//{
//    int a=random.Next(1,50);
//    if (a % 2 != 0) continue;
//    Console.WriteLine(a+" ");
//    s += a;
//    i++;
//}
//Console.WriteLine();


//2
//int a;
//int b;
//do
//{
//    Console.WriteLine("Введите два различных числа: ");
//    a = int.Parse(Console.ReadLine());
//    b = int.Parse(Console.ReadLine());
//}
//while (a == b);
//if (a<b)
//{
//    int i = a;
//    while(i<=b)
//    {
//        Console.Write(i+" ");
//        i++;
//    }
//}
//else
//{
//    int i = a;
//    while (i>=b)
//    {
//        Console.Write(i+" ");
//        i--;
//    }
//}


//3
//Console.Write("Введите число: ");
//int n=int.Parse(Console.ReadLine());
//int i = 1;
//while (i<=n)
//{
//    if(i%2!=0) Console.Write(i+" ");
//    i++;
//}

//4
//Console.Write("Введите число: ");
//int n=int.Parse(Console.ReadLine());
//int i = 1;
//while(i<=10)
//{
//    Console.Write($"{n}*{i}={n*i} ");
//    i++;
//}

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

