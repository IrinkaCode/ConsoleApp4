//Урок 1
//Создайте строковый массив, размеров в 10 ячеек.Заполните его словами в следующем порядке:
//“освоении”, “остальное”, “по плечу”, “сложный”, “но если”,“программирования”, “многие бросают”, “остальное будет”, “освоить их,”,“этап в”, “на этом этапе,”, “Массивы -” Соберите в новом массиве полноценную фразу.

//string[] mas = new string[10];
//string[] mas2 = ["освоении", "остальное", "по плечу.", "сложный", ",но если", "программирования,", "многие бросают", "остальное будет", "освоить их,", "этап в", "на этом этапе,", "Массивы -"];

//Console.WriteLine(mas2[11] + " " + mas2[3] + " " + mas2[9] + " " + mas2[0] + " " + mas2[5] + " " + mas2[10] + " " + mas2[6] + " " + mas2[4] + " " + mas2[8] + " " + mas2[1] + " " + mas2[7] + " " + mas2[2]);

//Урок 2
//1.Создайте пустой числовой массив размером в 10 ячеек.
//2. Заполните его случайными числами используя класс Random и цикл For.
//3. С помощью следующего цикла for выведите на экран все числа массива.
//4. Составьте цикл, проверяющий количество четных чисел.
//5. Выведите на экран количество четных чисел массива.

//int[] mas = new int[10];
//Random random = new Random();
//int counter = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(0, 9);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//for (int i = 0; i < mas.Length; i++)
//{
//    {
//        if (mas[i] == 0) continue;
//    }
//    if (mas[i] % 2 == 0) counter++;
//    else
//    {
//        continue;
//    }
//}
//Console.WriteLine(counter);

//Урок 3
//Напишите программу, которая запрашивает у пользователя 10 целых
//чисел и сохраняет их в массиве. Затем программа сортирует массив по
//возрастанию и выводит отсортированный массив на экран. Далее
//программа запрашивает у пользователя число и находит его индекс в
//массиве. Если число не найдено, программа выводит сообщение об
//ошибке.

//Random random = new Random();
//int[] mas = new int[10];

//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//Array.Sort(mas);
//for (int i = 0; i < mas.Length; i++)
//{

//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//Console.Write("Введите число: ");
//int m = int.Parse(Console.ReadLine());
////Console.WriteLine(Array.IndexOf(mas, m));
//int index = Array.IndexOf(mas, m);

//if (index >= 0)
//{
//    Console.WriteLine($"Индекс числа {m}: {index}");
//}
//else Console.WriteLine("Ошибка.Число не найдено.");



//Урок 4
//Создать 4 массива. Заполнить их случайными числами.Конечным результатом должен быть, выведенный на консоль, массив,хранящий следующее:Произведение средних арифметических (1и2) и (3и4) массивов поиндексно.
//Random random = new Random();
//int[] mas1 = new int[1];
//int[] mas2 = new int[1];
//int[] mas3 = new int[1];
//int[] mas4 = new int[1];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(1,10);
//    Console.Write(mas1[i] + " ");
//}
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i] = random.Next(1,10);
//    Console.Write(mas2[i] + " ");
//}
//for (int i = 0; i < mas3.Length; i++)
//{
//    mas3[i] = random.Next(1,10);
//    Console.Write(mas3[i] + " ");
//}
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i] = random.Next(1,10);
//    Console.Write(mas4[i] + " ");
//}
//Console.WriteLine();

//double avg12 = ((mas1.Sum() + mas2.Sum()) / 2);
//double avg34 = ((mas3.Sum() + mas4.Sum()) / 2);
//double productMas = avg12 * avg34;

//Console.WriteLine($"Среднее арифметическое 1 и 2 массивов = {avg12}");
//Console.WriteLine($"Среднее арифметическое 3 и 4 массивов = {avg34}");

//Console.WriteLine($"Произведение средних арифметических (1 и 2) и (3 и 4) массивов = {productMas}"); 



