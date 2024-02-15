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
//     n = int.Parse(Console.ReadLine());
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
//Console.WriteLine("Sum="+Sum);



