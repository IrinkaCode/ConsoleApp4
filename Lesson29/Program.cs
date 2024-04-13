//Память.Понятие стека и кучи

// дописать
//int x = 10;
//int y = 15;
//int S = x + y;
//Console.WriteLine(S);
//int[]mas = new int[5];
//Array.Fill()


//1
//1.Задача на использование ключевого слова ref:
//Напишите метод Swap, который принимает две переменные типа int по ссылке (используя ключевое слово ref) и меняет их значения местами.
//Продемонстрируйте использование этого метода, передавая две переменные и выводя измененные значения.

//Console.Write("Введите 1 число: ");
//int x;
//int.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите 2 число: ");
//int y;
//int.TryParse(Console.ReadLine(), out y);
//Console.WriteLine(x+" "+y);
//Change
//void Change(int x, int y);
//{
//    int temp = x;
//    x = y;
//    y= temp;
//}


//2
//Задача на использование ключевого слова out:
//Напишите метод Divide, который принимает два целых числа и возвращает результат деления первого числа на второе. Используйте ключевое слово out, чтобы вернуть результат деления, а также проверьте возможность деления на ноль. В основном коде вызовите метод Divide с различными аргументами и выведите результаты на консоль

//void Divide(int x, int y,out int result)

//{
//    if(y==0)
//    {
//        Console.WriteLine("Делить на ноль нельзя");
//        result = 0;
//    }
//    else
//    {
//        result = x / y;
//    }
//}
//int div;
//Console.Write("Введите 1 число: ");
//int x;
//int.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите 2 число: ");
//int y;
//int.TryParse(Console.ReadLine(), out y);
//Divide(x,y,out div);
//Console.WriteLine($"{x}/{y}={div}");


//3
//Задача на использование ключевого слова params:
//Напишите метод CalculateAverage, который принимает переменное количество аргументов типа double с помощью ключевого слова params.Метод должен вычислять и возвращать среднее арифметическое переданных чисел. Проверьте работу метода, вызывая его с различным числом аргументов и выводя результаты

//double CalculateAverage(params double[] mas);
//{
//    double s = 0;

//}

//4
//Задача, комбинирующая ключевые слова ref, out и params:
//Напишите метод ModifyArray, который принимает массив целых чисел по ссылке (с использованием ref) и изменяет значения элементов массива на их квадраты. Метод также должен возвращать количество элементов,значения которых были изменены. Используйте ключевое слово out,чтобы вернуть это значение. В основном коде объявите и инициализируйте массив, вызовите метод ModifyArray, и выведите измененный массив и количество измененных элементов на консоль.

//void ModifyArray(int[] mas, out int count)
//{
//    count = 0;
//  for (int i = 0;i<mas.Length;i++)
//    {
//        mas[i] = mas[i] * mas[i];
//        count++;
//    }
//}
//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//int[]newMas = new int[10];
//Array.Copy(mas,newMas,mas.Length);
//int count;
//ModifyArray(mas, out count);
//Console.WriteLine("count="+count);
//for (int i = 0;i < mas.Length;i++)
//{
//    Console.Write(mas[i]+" ");
//}


//14.22
//120,300,125,64,5

//bool IsStep5(int n)
//{
//    bool isTrue = true;
//    while (n != 1) 
//    {
//        if(n%5!=0) 
//        {
//            isTrue = false;
//        break;
//        }
//        n /= 5;
//    }
//    return isTrue;
//}
//int[] mas = new int[6];
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите элемент массива: ");
//    mas[i] = int.Parse(Console.ReadLine());
//    if (IsStep5(mas[i])) count++;
//}
//Console.WriteLine(count);

//14.24
//bool IsSimple(int n)
//{
//    bool IsTrue = true;
//    for (int i = 2; i < n; i++)
//    {
//        if (n % i == 0)
//        {
//            IsTrue = false;
//            break;
//        }

//    }
//    return IsTrue;
//}
//bool ISPair(int a, int b)
//{
//    if(IsSimple(a)&&IsSimple(b)&&Math.Abs(b-a)==2) return true;
//    return false;
//}
//for (int i = 2;i<=200;i++)
//{
//    if(ISPair(i,i-2)) Console.WriteLine((i-2)+" "+i);
//}


//14.28
//using System.Diagnostics;

//int Sum(int p)
//{
//    int s=0;
//    while(p!=0)
//    {
//        s += p % 10;
//        p /= 10;
//    }
//    return s;
//}
//Stopwatch stopwatch = new Stopwatch();
//stopwatch.Start();
//int count = 0;
//for(int i=100000; i<1000000;i++)
//{
//    if(Sum(i%1000)==Sum(i / 1000))
//    {
//        Console.WriteLine(i);
//        count++;
//    }
        
//}
//Console.WriteLine(count);
//stopwatch.Stop();
//Console.WriteLine("Stopwatch: " +(stopwatch.ElapsedMilliseconds/1000.0).ToString());


