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

const int TEMP = 20;

Console.Write("Введите текущую температуру:");
int temp = int.Parse(Console.ReadLine());

if (temp == TEMP) Console.WriteLine("На прогулку можно выпустить только кенгуру");
else if (temp > TEMP) Console.WriteLine("Можно выпустить на прогулку слонов, жирафов и львов");
else Console.WriteLine("Можно выпустить на прогулку медведей,волков и пингвинов");