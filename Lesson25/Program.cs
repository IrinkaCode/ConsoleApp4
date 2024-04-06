﻿//1
// Создайте функцию, которая принимает строку и возвращает количество слов в этой строке. Напишите программу, которая использует эту функцию для подсчета количества слов во введенном пользователем предложении.

//int CountWords(string text)
//{
//    string[] mas = text.Split(' ');
//    return mas.Length;
//}
//Console.Write("Введите предложение: ");
//string str = Console.ReadLine();
//Console.WriteLine(CountWords(str));

//2
//Создайте функцию, которая принимает целое число и
//возвращает его факториал (произведение всех чисел от 1 до этого числа).
//Напишите программу, которая использует эту функцию для вычисления
//факториала числа, введенного пользователем.

//long Factorial(int x)
//{
//    long F = 1;
//    for (int i = 1; i <= x; i++) F *= i;
//        return F;
//}
//Console.Write("Введите число: ");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine($"Факториал {n}:{Factorial(n)}");

//3
//Создайте функцию, которая принимает двумерный массив
//целых чисел и выводит на экран его элементы в виде матрицы. Напишите
//программу, которая использует эту функцию для вывода элементов
//двумерного массива, заполненного пользователем.

//void PrintMatrix(int[,]mas)
//{
//	for (int i = 0; i < mas.GetLength(0); i++)
//	{
//		for (int j = 0; j < mas. GetLength(1); j++)
//		{
//			Console.Write(mas[i,j]+" ");
//        }
//		Console.WriteLine();
//	}
//}
//Random random = new Random();
//int[,] mas= new int[random.Next(5,10),random.Next(5,10)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] =random.Next(10,100);
//    } 
//}
//PrintMatrix(mas);

//4
// Создайте функцию, которая принимает массив строк и
//возвращает новый массив, содержащий только уникальные элементы.
//Напишите программу, которая использует эту функцию для удаления
//дубликатов из списка строк, заполненного пользователем.

//string[] UniqueWords(string[]text)
//{
//    string[] result = new string[text.Length];
//    int i = 0;
//    foreach(var item in text)
//    {
//        if(!result.Contains(item))
//            result[i++] = item;

//    }
//    return result;
//}
//string[] mas = new string[6];
//Console.WriteLine("Введите слова: ");
//for (int i = 0;i<mas.Length;i++)
//{
//    mas[i] = Console.ReadLine();
//}
//string[] res = UniqueWords(mas);
//foreach(string s in res) Console.Write(s+" ");
//Console.WriteLine();

//5
//Создайте функцию, которая принимает длину сторон
//треугольника и возвращает его площадь. Напишите программу, которая
//использует эту функцию для вычисления площади треугольника с
//заданными сторонами, введенными пользователем.

//double Square(double a, double b,double c)
//{
//    double pp=(a+b+c)/2;
//    return Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
//}
//Console.Write("Введите a: ");
//double a, b, c;
//double.TryParse(Console.ReadLine(), out a);
//Console.Write("Введите b: ");
//double.TryParse(Console.ReadLine(), out b);
//Console.Write("Введите c: ");
//double.TryParse(Console.ReadLine(), out c);
//Console.WriteLine($"Площадь: {Square(a, b, c):F2}");

//double Square(int a, double b, float c)
//{
//    double pp = (a + b + c) / 2;
//    return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
//}
//Console.Write("Введите a: ");
//double b;
//int a;
//float c;
//int.TryParse(Console.ReadLine(), out a);
//Console.Write("Введите b: ");
//double.TryParse(Console.ReadLine(), out b);
//Console.Write("Введите c: ");
//float.TryParse(Console.ReadLine(), out c);
//Console.WriteLine($"Площадь: {Square(a: a, b: b, c: c):F2}"); // именованные параметры


//double Square(int a, double b, float c,double d=0)
//{
//    if (d == 0)
//    {
//    double pp = (a + b + c) / 2;
//    return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
//    }
//    else
//    {
//        return a+ b + c + d;
//    }
//}
//Console.Write("Введите a: ");
//double y,w;
//int x;
//float z;
//int.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите b: ");
//double.TryParse(Console.ReadLine(), out y);
//Console.Write("Введите c: ");
//float.TryParse(Console.ReadLine(), out z);
//Console.Write("Введите d: ");
//double.TryParse(Console.ReadLine(), out w);
//Console.WriteLine($"Площадь трехугольника: {Square(b:y,c:z,a:x):F2}");
//Console.WriteLine($"Площадь четырехуголдьник: {Square(b:y,c:z,a:x,d:w):F2}");


//массив параметров params неопределенное количество параметров
//int Sum(params int[] numbers)
//{
//    int s = 0;
//    foreach(int n in numbers) s+= n;
//    return s;
//}
//Console.WriteLine(Sum(1,3,4,6));
//Console.WriteLine(Sum(4,23,5,7,4,3,5,6));   

//Задача 1. Функция поиска слова.
//Напишите программу, в которой будет использоваться булевая функция,
//для поиска слова.
//В качестве параметров передаются 2 аргумента: текст и слово которое
//нужно найти.
//Если слово присутствует, функция вернет true, в противном случае - false.

//bool FindWord(string text,string word)
//{
//    return text.Contains(word);
//}
//Console.Write("Введите текст: ");
//string text=Console.ReadLine();
//Console.Write("Введите слово для поиска: ");
//string word = Console.ReadLine();
//Console.WriteLine(FindWord(text,word));

//Задача 2. Обработка массива.
//Напишите программу, в которой будут присутствовать функции,
//обрабатывающие массивы.
//Одна из функций будет возвращать тип массива, его максимальный
//элемент и сортировать его по возрастанию.
//Вторая будет сращивать 2 массива в 1.
//Третья будет переворачивать массив из предыдущей функции и выводить
//на экран его значение.

//Random random = new Random();               
//Random random = new Random();
//int[] mas1 = new int[random.Next(5, 10)];
//int[] mas2 = new int[random.Next(5, 10)];
//void FillArray(int[] mas)
//{
//	for (int i = 0; i < mas.Length; i++) 
//		mas[i] = random.Next(10, 100);
//}
//void Print(string nameMas, int[] mas)
//{
//    Console.WriteLine(nameMas);
//    for (int i = 0; i < mas.Length; i++)
//        Console.Write(mas[i]+" ");
//    Console.WriteLine();
//}
//string[] GetTypeAndMax(int[] mas)
//{
//    string[] result = new string[2];
//    result[0] = mas.GetType().ToString();
//    Array.Sort(mas);
//    result[1] = mas[mas.Length - 1].ToString();
//    return result;
//}
//int[] SumMas(int[] m1, int[] m2)
//{
//    int[] mas = new int[m1.Length + m2.Length];
//    int i = 0;
//    foreach (var item in m1) mas[i++] = item;
//    foreach (var item in m2) mas[i++] = item;
//    return mas;
//}
//void ReverseMas(int[] mas)
//{
//    Array.Reverse(mas);
//}
//FillArray(mas1);
//Print("mas1",mas1);
//Print("mas3",mas3);
//FillArray(mas2);
//Print("mas2",mas2);
//Console.WriteLine($"type={GetTypeAndMax(mas1)[0]} " +
//    $"max={GetTypeAndMax(mas1)[1]}");
//Print("Отсортированный mas1:",mas1);
//int[] mas3 = SumMas(mas1, mas2);
//Print("mas3",mas3);
//ReverseMas(mas3);



//Задача 3. Расчеты.
//Напишите череду функций, которые будут выполнять различные
//математические расчеты.
double getDiskriminant(double a, double b, double c)
{
    return b * b - 4 * a * c;
}
void TwoSquare(double d, double a, double b)
{
    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"x1={x1:F2} x2={x2:F2}");
}
void OneSquare(double a, double b)
{
    double x = -b / (2 * a);
    Console.WriteLine($"x1={x:F2}");
}
void NoSquare()
{
    Console.WriteLine($"Корней нет");
}
void Relation(double d, double a, double b)
{
    if (d > 0) TwoSquare(d, a, b);
    else if (d == 0) OneSquare(a, b);
    else NoSquare();
}


double a, b, c;
Console.Write("Введите а:");
double.TryParse(Console.ReadLine(), out a);
Console.Write("Введите b:");
double.TryParse(Console.ReadLine(), out b);
Console.Write("Введите c:");
double.TryParse(Console.ReadLine(), out c);
Relation(getDiskriminant(a, b, c), a, b);