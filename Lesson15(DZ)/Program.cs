﻿//Урок 1
//Создайте строковый массив, размеров в 10 ячеек.Заполните его словами в следующем порядке:
//“освоении”, “остальное”, “по плечу”, “сложный”, “но если”,“программирования”, “многие бросают”, “остальное будет”, “освоить их,”,“этап в”, “на этом этапе,”, “Массивы -” Соберите в новом массиве полноценную фразу.

//string[] mas = new string[10];
//string[] mas2 = ["освоении","остальное","по плечу.","сложный","но если","программирования","многие бросают","остальное будет","освоить их,","этап в","на этом этапе,","Массивы -"];

//Console.WriteLine(mas2[11] + " " + mas2[3] + " " + mas2[9] + " " + mas2[0] + " " + mas2[5] + " " + mas2[10] + " " + mas2[6] + " " + mas2[4] + " " + mas2[8] + " " + mas2[1] + " " + mas2[7] + " " + mas2[2]);

//Урок 2
//1.Создайте пустой числовой массив размером в 10 ячеек.
//2. Заполните его случайными числами используя класс Random и цикл
//For.
//3. С помощью следующего цикла for выведите на экран все числа
//массива.
//4. Составьте цикл, проверяющий количество четных чисел.
//5. Выведите на экран количество четных чисел массива.

//int[] mas = new int[10];
//Random random = new Random();
//int counter = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(0,9);
//    Console.Write(mas[i]+" ");
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

