//Двумерные массивы
//int[,] mas=new int[3,4]
//int[,] mas2 = { { 1, 2, 3 },
//                { 4,5,6 },
//                { 7, 8, 9 } };

//Console.Write("Введите число строк: ");
//int n=int.Parse(Console.ReadLine());
//Console.Write("Введите число столбцов: ");
//int m = int.Parse(Console.ReadLine());
//int[,] mas = new int[n, m];
//Random random = new Random();
//for (int i = 0; i < mas.GetUpperBound(0)+1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1)+1; j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}

//1

//Random random = new Random();
//int n = random.Next(1, 10);//количество строк
//int m = random.Next(1, 10);//количество столбцов
//int[,] mas = new int[n, m];
//int sum = 0;
//long P = 1;
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        sum += mas[i, j];
//        P *= mas[i, j];
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Sum="+sum);
//Console.WriteLine($"Произведение={P:F2}");

//3
//Random random = new Random();
//int n = random.Next(1, 10);//количество строк
//int m = random.Next(1, 10);//количество столбцов
//int[,] mas = new int[n, m];
//int count = 0;
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        for(int k = 0;k<count;k++) Console.Write(" ");
//        Console.WriteLine(mas[i, j] + " ");
//        count++;
//    }
//}

//4
//string[,] mas = { {"Tom" ,"6598416","Tom@gmail.com"},
//                  {"Jerry","654916","Jerry@mail.ry"},
//                  {"Bob","6535432","Bob@mail.dt" } };
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.Write("Введите имя: ");
//string  name=Console.ReadLine();
//bool isTrue = false;
//for(int i = 0;i<mas.GetUpperBound(0)+1;i++)
//{
//    if (mas[i,0]==name)
//    {
//        isTrue = true;
//        Console.WriteLine(mas[i,0]+" " + mas[i,1]+" " + mas[i,2]);
//    }
//}
//if (isTrue==false) Console.WriteLine("Элемента нет");

//2

//Random random = new Random();
//int n = random.Next(1, 10);
//int m = random.Next(1, 10);
//int[,] mas = new int[n, m];
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    double sum = 0;
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        sum += mas[i, j];
//    }
//    Console.WriteLine($"{sum / mas.GetUpperBound(1) + 1:F2}");
//}

//4
//Random random = new Random();
//int n = random.Next(5, 10);
//int m = random.Next(5, 10);
//int[,] mas1 = new int[n, m];
//int[,] mas2 = new int[m, n];
//for (int i = 0; i < mas1.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas1.GetUpperBound(1) + 1; j++)
//    {
//        mas1[i, j] = random.Next(10, 100);
//        Console.Write(mas1[i, j] + " ");
//        mas2[j, i] = mas1[i, j];
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas1.GetUpperBound(1) + 1; j++)
//    {
//        Console.WriteLine(mas2[i,j]+" ");
//    }
//    Console.WriteLine();
//}


//Random random = new Random();
//double[,] mas = new double[3, 3];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.NextDouble() * 20;
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}
//int n, m;
//Console.Write($"Введите номер строки <= {mas.GetLength(1)}:");
//do
//{
//    n = int.Parse(Console.ReadLine());
//    if (n > mas.GetLength(0)) Console.Write($"Введите номер строки <= {mas.GetLength(1)}:");
//}
//while (n > mas.GetLength(1));
//m = int.Parse(Console.ReadLine());
//double val = double.Parse(Console.ReadLine());
//mas[n - 1, m - 1] = val;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}


//Урок 1тема 16 задача 2
//// Создать массив символов 5x2
//char[,] array = new char[5, 2];

//// Заполнить массив символами в разнобой
//Random random = new Random();
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, j] = (char)random.Next(65, 91); // Генерировать случайные заглавные буквы
//    }
//}

//// Вывести массив на экран
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//// Составить слово из символов массива
//string word = "";
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        word += array[i, j];
//    }
//}

//// Вывести составленное слово
//Console.WriteLine("Составленное слово: " + word);


//Урок 1 тема 16
//Random random = new Random();
//double[,] mas = new double[3, 3];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.NextDouble() * 20;
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}
//int n, m;
//Console.Write($"Введите номер строки <= {mas.GetLength(1)}:");
//do
//{
//    n = int.Parse(Console.ReadLine());
//    if (n > mas.GetLength(0)) Console.Write($"Введите номер строки <= {mas.GetLength(1)}:");
//}
//while (n > mas.GetLength(1));
//m = int.Parse(Console.ReadLine());
//double val = double.Parse(Console.ReadLine());
//mas[n - 1, m - 1] = val;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}