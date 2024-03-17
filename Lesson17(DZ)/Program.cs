////Урок 1 - готово
//int[][] mas = new int[3][];
//mas[0] = new int[] { 1, 2, 3 };
//mas[1] = new int[] { 4, 5, 6 };
//mas[2] = new int[] { 7, 8, 9 };
//Console.WriteLine(mas);
//Console.Write("Введите число 200: ");
//int num = int.Parse(Console.ReadLine());
//mas[2][2] = num;

//foreach (int[] i in mas)
//{
//    foreach (int n in i)
//    {
//        Console.Write(n + " ");
//    }
//    Console.WriteLine();
//}


////Урок 2 -готово
//int[][] mas = new int[3][];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = new int[random.Next(1, 10)];
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        mas[i][j] = random.Next(1, 10);
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//// общее количество элементов всех массивов
//int amount = 0;
//// общая сумма элементов всех массивов
//int overallSum = 0;
//// цикл по массивам
//for (int k = 0; k < mas.Length; k++)
//{
//    // суммируем количество элементов в массиве
//    amount += mas[k].Length;
//    // суммируем только в пределах массива k
//    int masSum = 0;
//    // цикл по элементам массива k
//    for (int n = 0; n < mas[k].Length; n++)
//    {
//        // суммируем элемент массива
//        masSum += mas[k][n];
//    }
//    // выводим сумму массива k
//    Console.WriteLine($"{k} sum: {masSum}");
//    // добавляем сумму k в общую сумму элементов всех массивов
//    overallSum += masSum;
//}
//Console.WriteLine();
//// среднее арифметическое - делим общею сумму на количество элементов
//Console.WriteLine($"avg: {overallSum / amount}");


//Неправильные варианты
//int[,] mas = new int[4, 3];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas.Length; j++)
//    {
//        mas[i,j] = random.Next(1, 10);
//        Console.Write(mas[i,j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Введите число 200: ");
//int k = int.Parse(Console.ReadLine());
//int index = int.Parse(Console.ReadLine());
//mas[index,0] = k;
////Вывести новый массив на экран
//Console.Write("Новый массив: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas.Length; j++)
//    {
//        Console.Write(mas[index,0] + " ");
//    }
//    Console.WriteLine();
//}

//2
//int[,] mas = new int[4,3];
//Random random = new Random();

////for (int i = 0; i < mas.Length; i++)
////{
////    mas[i,j] = new int[random.Next(1, 10)];
////}
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas.Length; j++)
//    {
//        mas[i,j] = random.Next(1, 10);
//        Console.Write(mas[i,j] + " ");
//    }
//    Console.WriteLine(mas);
//}
//Console.WriteLine();
//Console.WriteLine("Введите число 200: ");
//int userInput = int.Parse(Console.ReadLine());
//mas[2,2] = userInput;

////mas[5][0] = userInput;
//Console.WriteLine("Новый массив: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas.Length; j++)
//    {
//        Console.Write(mas[i,j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();


//3
//int[,] mas = new int[4, 3];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    //mas[i,j] = new int[random.Next(1, 10)];
//    for (int j = 0; j < mas.Length; j++)
//    {
//        mas[i, j] = random.Next(1, 10);
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.Write("Введите число 200:");
//int userInput = int.Parse(Console.ReadLine());
//int randomIndex = random.Next(0, mas.Length);
//int[] mas2 = new int[] { userInput };

//Console.WriteLine("Новый массив: ");
//for (int i = 0; i < mas2.Length; i++)
//{
//    for (int j = 0; j < mas2.Length; j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}




//int[,] mas = new int[4, 3];
//Random random = new Random();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = int.Parse(Console.ReadLine());
//    }
//    //Console.WriteLine(mas);
//}
////Console.WriteLine(mas);


//Console.Write("Введите число:");
//int c = int.Parse(Console.ReadLine());
//mas[2, 2] = c;

//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}



