//Тема 11. Урок 1

//Console.Write("Введите первое число:");
//int number1 = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число:");
//int number2 = int.Parse(Console.ReadLine());
//Console.Write("Введите третье число:");
//int number3 = int.Parse(Console.ReadLine());
//Console.Write("Введите четвертое число:");
//int number4 = int.Parse(Console.ReadLine());
//Console.Write("Введите пятое число:");
//int number5 = int.Parse(Console.ReadLine());
//Console.Write("Введите шестое число:");
//int number6 = int.Parse(Console.ReadLine());
//Console.Write("Введите седьмое число:");
//int number7 = int.Parse(Console.ReadLine());
//Console.Write("Введите восьмое число:");
//int number8 = int.Parse(Console.ReadLine());
//Console.Write("Введите девятое число:");
//int number9 = int.Parse(Console.ReadLine());
//Console.Write("Введите десятое число:");
//int number10 = int.Parse(Console.ReadLine());

//int summ = number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8 + number9 + number10;
//Console.WriteLine(summ);

//int counter = 0;
//int result;

//result = number1 > 10 ? ++counter : counter;
//result = number2 > 10 ? ++counter : counter;
//result = number3 > 10 ? ++counter : counter;
//result = number4 > 10 ? ++counter : counter;
//result = number5 > 10 ? ++counter : counter;
//result = number6 > 10 ? ++counter : counter;
//result = number7 > 10 ? ++counter : counter;
//result = number8 > 10 ? ++counter : counter;
//result = number9 > 10 ? ++counter : counter;
//result = number10 > 10 ? ++counter : counter;

//Console.WriteLine($"Количество чисел, больших 10 будет {result}");

//int counter2 = 0;
//int result2;

//if (number1 < -10)
//{
//    result2 = ++counter2;
//    Console.WriteLine($"Количество чисел, меньше -10 будет {result2}");
//}

//if (number2 < -10)
//{
//    result2 = ++counter2;

//}

//if (number3 < -10)
//{
//    result2 = ++counter2;

//}

//if (number4 < -10)
//{
//    result2 = ++counter2;

//}

//if (number5 < -10)
//{
//    result2 = ++counter2;

//}

//if (number6 < -10)
//{
//    result2 = ++counter2;

//}

//if (number7 < -10)
//{
//    result2 = ++counter2;

//}

//if (number8 < -10)
//{
//    result2 = ++counter2;

//}

//if (number9 < -10)
//{
//    result2 = ++counter2;

//}


//if (number10 < -10)
//{
//    result2 = ++counter2;

//}

//else
//{
//    result2 = counter2;

//}

//Console.WriteLine($"Количество чисел, меньших -10 будет {result2}");

//Console.WriteLine($"Среднее арифметическое всех десяти чисел будет {summ / 10}");

//int resultMax1 = Math.Max(number1, number2);
//resultMax1 = Math.Max(resultMax1, number3);
//resultMax1 = Math.Max(resultMax1, number4);
//resultMax1 = Math.Max(resultMax1, number5);
//resultMax1 = Math.Max(resultMax1, number6);
//resultMax1 = Math.Max(resultMax1, number7);
//resultMax1 = Math.Max(resultMax1, number8);
//resultMax1 = Math.Max(resultMax1, number9);
//resultMax1 = Math.Max(resultMax1, number10);

//Console.WriteLine($"Максимальное значение в списке {resultMax1}");

//int resultMin1 = Math.Min(number1, number2);
//resultMin1 = Math.Min(resultMin1, number3);
//resultMin1 = Math.Min(resultMin1, number4);
//resultMin1 = Math.Min(resultMin1, number5);
//resultMin1 = Math.Min(resultMin1, number6);
//resultMin1 = Math.Min(resultMin1, number7);
//resultMin1 = Math.Min(resultMin1, number8);
//resultMin1 = Math.Min(resultMin1, number9);
//resultMin1 = Math.Min(resultMin1, number10);

//Console.WriteLine($"Минимальное значение с списке {resultMin1}");


//Тема 11 урок 2

//const int TEMP = 20;

//Console.Write("Введите текущую температуру:");
//int temp = int.Parse(Console.ReadLine());

//if (temp == TEMP) Console.WriteLine("На прогулку можно выпустить только кенгуру");
//else if (temp > TEMP) Console.WriteLine("Можно выпустить на прогулку слонов, жирафов и львов");
//     else if (temp< TEMP) Console.WriteLine("Можно выпустить на прогулку медведей,волков и пингвинов");
//else Console.WriteLine("Температура не входит ни в один из указанных диапазонов");


//Тема 11 Урок 3
//1
//Random random = new Random();
//int number = random.Next(0, 6);
//Console.WriteLine(number);
//Console.Write("Введите число от 0 до 5: ");
//int userNumber =int.Parse(Console.ReadLine());

//if (number == userNumber) Console.WriteLine("Победа");
//else  Console.WriteLine("Поражение");

//2
//Console.Write("Введите номер текущего месяца: ");
//int month = int.Parse(Console.ReadLine());

//if (month == 1) Console.WriteLine("Январь");
//else if (month == 2) Console.WriteLine("Февраль");
//else if (month == 3) Console.WriteLine("Март");
//else if (month == 4) Console.WriteLine("Апрель");
//else if (month == 5) Console.WriteLine("Май");
//else if (month == 6) Console.WriteLine("Июнь");
//else if (month == 7) Console.WriteLine("Июль");
//else if (month == 8) Console.WriteLine("Август");
//else if (month == 9) Console.WriteLine("Сентябрь");
//else if (month == 10) Console.WriteLine("Октябрь");
//else if (month == 11) Console.WriteLine("Ноябрь");
//else if (month == 12) Console.WriteLine("Декабрь");

//if (month > 12 || month == 0) Console.WriteLine("Такого месяца нет");


//Console.Write("Введите среднюю температуру:");
//int temp = int.Parse(Console.ReadLine());
//{
//    if (month <= 2 || month == 12)
//    {
//        if (temp > 0) Console.WriteLine("Дождивая зима");
//    }
//    else
//    {
//        Console.WriteLine("Классная погода");
//    }
//}


//Тема 11 Урок 4

//Console.Write("Введите ваш возраст: ");
//int age=int.Parse(Console.ReadLine());
//if (age < 18) Console.WriteLine("Вы слишком молоды для участия в выборах");
//else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете учавствовать в выборах в качестве депутата");
//else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете учавствовать в выборах в качестве кандидата в президенты");
//else Console.WriteLine("Ваш возраст слишком велик для участия в выборах");

//Console.WriteLine("За кого вы будете болеть,если проиграете или не будете допущены к участию в выборах?\n" + "1- Незнайка\n" + "2-Лунтик\n" + "3-Карлсон\n" + "4-Дядя Федор\n");
//Console.Write("Введите номер кандидата: ");
//int number = int.Parse(Console.ReadLine());
//if (number == 1) Console.WriteLine("Незнайка - А у тебя в животе арбуз вырастет!!!");
//else if (number == 2) Console.WriteLine("Лунтик - Жизнь - это одно большое приключение");
//else if (number == 3) Console.WriteLine("Карлсон - Спокойствие!Только спокойствие!");
//else if (number == 4) Console.WriteLine("Дядя Федор - Чтобы продать что то ненужное,надо купить что то нужное,а у нас денег нет");


//Доп.задание - доделать
////1
//Random random = new Random();
//int month = random.Next(1, 4);
//Console.WriteLine(month);
//Console.WriteLine("Введите число месяца от 1 до 3:\n" + "1-Январь\n" + "2-Февраль\n" + "3-Март\n");
//int userNumber = int.Parse(Console.ReadLine());
//Console.Write("Угадайте сколько дней в этом месяце? ");
////int userDay = int.Parse(Console.ReadLine());

//string day = Console.ReadLine();

//if (month == 1) day = "31";
//else if (month == 2) day = "28 или 29";
//else if (month == 3) day = "31";

//string userDay = Console.ReadLine();
//if (userDay == day) Console.WriteLine("Победа");
//else Console.Write($"Не правильно.В этом месяце {day} дней");



//2
//Random random = new Random();
//int month = random.Next(1, 13);
//Console.WriteLine(month)
//if (month == 1) Console.WriteLine("Январь");
//else if (month == 2) Console.WriteLine("Февраль");
//else if (month == 3) Console.WriteLine("Март");
//else if (month == 4) Console.WriteLine("Апрель");
//else if (month == 5) Console.WriteLine("Май");
//else if (month == 6) Console.WriteLine("Июнь");
//else if (month == 7) Console.WriteLine("Июль");
//else if (month == 8) Console.WriteLine("Август");
//else if (month == 9) Console.WriteLine("Сентябрь");
//else if (month == 10) Console.WriteLine("Октябрь");
//else if (month == 11) Console.WriteLine("Ноябрь");
//else if (month == 12) Console.WriteLine("Декабрь");


//1
using System.Security.Cryptography;

Random random = new Random();
int month = random.Next(1, 4);
Console.WriteLine(month);

if (month == 1) Console.WriteLine("Январь");
else if (month == 2) Console.WriteLine("Февраль");
else if (month == 3) Console.WriteLine("Март");
Console.Write("Угадайте сколько дней в этом месяце? ");
int day = int.Parse(Console.ReadLine());

if (month == 1 && day == 31) Console.WriteLine("Победа");
else Console.WriteLine("Не правильно.В этом месяце 31 день");
if (month == 2 && day == 28) Console.WriteLine("Победа");
else Console.WriteLine("Не правильно.В этом месяце 28 дней");
if (month == 3 && day == 31) Console.WriteLine("Победа");
else Console.WriteLine("Не правильно.В этом месяце 31 день");


//if (month == userDay) Console.WriteLine("Победа");
//else if (month != userDay) Console.Write($"Не правильно.В этом месяце {day} дней");


