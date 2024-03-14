//int[][] mas = new int[10][];
//Random random = new Random();

//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = new int[random.Next(1, 10)];
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        mas[i][j] = random.Next(1, 10);
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.Write("Введите строку, которую хотите заменить: ");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите столбец,который хотите заменить: ");
//int m = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число 200");
//int k = int.Parse(Console.ReadLine());
//int index=int.Parse(Console.ReadLine());
//mas[index][0] = k;
//// Вывести новый массив на экран
//Console.Write("Новый массив: ");
//for (int i = 0; i <mas.Length; i++)
//{ 
//    Console.Write(mas[i][0]+" ");   
//}

//2
//int[][] mas = new int[10][];
//Random random = new Random();

//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = new int[random.Next(1, 10)];
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        mas[i][j] = random.Next(1, 10);
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Введите число 200:");
//int userInput = int.Parse(Console.ReadLine());
//mas[random.Next(0, mas.Length)] = mas[userInput];

////mas[5][0] = userInput;
//Console.WriteLine("Новый массив: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas.Length; j++)
//    {
//        Console.Write(mas[i][j] + " ");
//    }

//}


//3
//int[][] mas = new int[10][];
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

//Console.Write("Введите число 200:");
//int userInput = int.Parse(Console.ReadLine());
//int randomIndex = random.Next(0, mas.Length);
//mas[randomIndex] = new int[] { userInput };

//Console.WriteLine("Новый массив: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();
//}

//Урок 2
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



