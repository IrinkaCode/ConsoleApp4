﻿//Тема 13 Урок 1

//Random random = new Random();
//int num = random.Next(1,6) ;
//int i= 1;
//Console.Write("Угадайте число от 1 до 5 загаданное компьютером\nПопробуйте угадать его за три попытки:  \nВведите число: ");
//int a = int.Parse(Console.ReadLine());
//while (i <= 3)
//{
//    if (num == a)
//    {
//        Console.Write($"Да!Компьютер загадал число {num}"); break;
//    }
//    else
//    {
//        i++;
//        if (i == 4)
//        {
//            Console.Write($"Вы не угадали.Компьютер загадал число {num}"); break;
//        }
//        Console.Write("Вы не угадали.У вас есть еще попытка.\nВведите число: ");
//        a = int.Parse(Console.ReadLine());
//    }
//}
//    Console.ReadLine();


//тема 13 Урок 2
//задача 1

//Random random = new Random();
//int num = random.Next(1, 11);
//Console.WriteLine(num);
//int i = 1;
//while (i <=7)
//{
//    if (num == 7) break;
    
//    Console.WriteLine(i++);    
//}


//задача 2
Console.WriteLine("Введите число: ");
int num=int.Parse(Console.ReadLine());
int i = 0;
while (i >= num)
{
    if (i == 0) break;
    Console.WriteLine(i);
}













