﻿//Console.Write( "Введите а: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b: ");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите c: ");
//double c = double.Parse(Console.ReadLine());
//double D = b * b - 4 * a * c;
//if (D > 0)
//{
//    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
//    Console.WriteLine($"x1={x1:F2} x2={x2:F2}");
//}
//else if (D == 0)
//{
//    double x = -b / (2 * a);
//    Console.WriteLine($"x={x:F2}");
//}
//else Console.WriteLine("Корней нет");

//задача 1
//Console.Write("Введите год рождения:");
//int year= int.Parse(Console.ReadLine());
//if (year % 4 == 0) Console.WriteLine("Високосный");
//else Console.WriteLine("Не високосный");

//2
//Console.Write("Введите число: ");
//double x = double.Parse(Console.ReadLine());
//if (x >= 10 && x <= 100) Console.WriteLine("Лежит");
//else Console.WriteLine("Не лежит");

//5
//Random random = new Random();
//int x = random.Next(1,11);
//Console.Write("Введите число от 1 до 10:");
//int a = int.Parse(Console.ReadLine());
//if (x == a) Console.WriteLine("Вы угадали!");
//else if (a < x) Console.WriteLine("Вы ввели число меньше");
//     else Console.WriteLine("Вы ввели число больше");

//Random random = new Random();
//double x = random.NextDouble() * 10;
//Console.WriteLine(x);

//тема 11 урок 4


//const string LOGIN1 = "administrator";
//const string LOGIN2 = "администратор";
//const string LOGIN3 = "Богдан";
//const string LOGIN4 = "Дмитрий";
//const int PASSWORD1 = 2897988;
//const int PASSWORD3 = 27111095;
//const int PASSWORD4 = 12021917;

//Console.WriteLine("Введите логин:");
//string login= Console.ReadLine();
//if (login == LOGIN1 || login == LOGIN2)
//{
//    Console.Write("Введите пароль:");
//    int pasword = int.Parse(Console.ReadLine);
//    if (pasword == PASSWORD1) Console.WriteLine("Пароль верен. Добро пожаловать!");
//    else Console.WriteLine("Вы ввели неправильный пароль");
//}
//else if (login == LOGIN4) 
//{
//    Console.Write("Введите пароль:");
//    int password = int.Parse(Console.ReadLine);
//    if (password == PASSWORD4) Console.WriteLine("Пароль верен.Добро пожаловать!");
//    else Console.WriteLine("Вы ввели неправильны пароль");

//}
//else if (login==LOGIN3)
//{
//    Console.Write("Введите пароль:");
//    int password = int.Parse(Console.ReadLine);
//    if (password == PASSWORD3) Console.WriteLine("Пароль верен.Добро пожаловать!");
//    else Console.WriteLine("Вы ввели неправильны пароль");

//}
//else Console.WriteLine("Такого логина нет");

//1
//Console.ForegroundColor=ConsoleColor.Red;
//Console.WriteLine("fugkh");
//Console.ForegroundColor = ConsoleColor.Gray;
//Console.WriteLine("utgfi");

//Random random = new Random();
//int intColor = random.Next(3);
//string Color;
//if (intColor == 0) Color = "красный";
//else if (intColor == 1) Color = "зеленый";
//else Color = "синий";
//Console.Write("Введите цвет:");
//string userColor=Console.ReadLine();
//if (userColor == Color) Console.WriteLine("Победа");
//else
//{
//    if (userColor == "красный") Console.WriteLine("раньше");
//    else if (userColor == "зеленый")
//    {
//        if (Color == "красный") Console.WriteLine("Позже");
//        else Console.WriteLine("Раньше");
//    }
//    else Console.WriteLine("Позже");
//}

//2
//Random random = new Random();
//int year = random.Next(1900, 2024);
//Console.WriteLine(year);
//string result = (year % 4 == 0) ? "да" : "нет";
//Console.Write("Год високосный (да/нет):");
//string answer=Console.ReadLine();
//if(answer==result) Console.WriteLine("Победа");
//else
//{
//    if (year % 4 == 0) Console.WriteLine("Високосный");
//    else Console.WriteLine("Не високосный");
//}


//3
//Random random = new Random();
//int week = random.Next(1, 8);
//string day;
//if (week == 1) day = "Понедельник";
//else if (week == 2) day = "Вторник";
//     else if (week == 3) day = "Среда";
//          else if (week == 4) day = "Четверг";
//               else if (week == 5) day = "Пятница";
//                    else if (week == 6) day = "Суббота";
//                         else day = "Воскресенье";
//Console.WriteLine("Введите день недели с заглавной буквы:");
//string userDay = Console.ReadLine();

//if (userDay == day) Console.WriteLine("Верно");
//else Console.WriteLine(day);

//2.8
Console.Write("Введите число от 1 до 365:");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите день недели 1 января от 1 до 7:");
int d = int.Parse(Console.ReadLine());
int week = k % 7 + d-1;
if (week == 1) Console.WriteLine("Понедельник");
else if (week == 2) Console.WriteLine("Вторник");
else if (week == 3) Console.WriteLine("Среда");
else if (week == 4) Console.WriteLine("Четверг");
else if (week == 5) Console.WriteLine("Пятница");
else if (week == 6) Console.WriteLine("Суббота");
else Console.WriteLine("Воскресенье");