////1
//Напишите программу, которая выводит на экран "Hello, World!".
//Console.WriteLine("Hello, World!");

//2
//Напишите программу, которая запрашивает у пользователя его имя и выводит на экран приветствие с использованием введенного имени.

//Console.Write("введите свое имя: ");
//string name = Console.ReadLine();
//Console.WriteLine("Здравствуйте, " + name);

//3
//Напишите программу, которая запрашивает у пользователя его имя и выводит на экран приветствие с использованием введенного имени.

//Console.Write("Введите первое число: ");
//double num1=double.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число: ");
//double num2 = double.Parse(Console.ReadLine()!);
//double sum=num1 + num2;
//Console.Write($"Сумма чисел {num1} и {num2} равна: {sum}");

//4
// Напишите программу, которая определяет, является ли введенное пользователем число четным или нечетным.

//Console.Write("Введите число: ");
//double num=double.Parse(Console.ReadLine()!);
//if (num % 2 == 0)
//{
//    Console.WriteLine("Число четное");
//}
////else
//{
//    Console.WriteLine("Число нечетное");
//}

//5
//Напишите программу, которая находит наибольшее число из трех введенных пользователем чисел и выводит его на экран.

//Console.Write("Введите первое число: ");
//double num1 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число: ");
//double num2 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите третье число: ");
//double num3 = double.Parse(Console.ReadLine()!);

//double max = num1;
//if (num2 > max) max = num2;
//if (num3 > max) max = num3;

//Console.WriteLine("Наибольшее число: " + max);

//6
//Напишите программу, которая вычисляет факториал введенного пользователем числа и выводит результат на экран.
//Console.Write("Введите число: ");
//double n=double.Parse(Console.ReadLine()!);
//long Fact = 1;

//for (int i = 1; i <= n; i++)
//{
//    Fact *= i;
//}
//Console.WriteLine($"факториал {n}={Fact}");

//7
//Напишите программу, которая находит сумму всех чисел от 1 до 100 и выводит результат на экран.

//int[] mas = new int[100];
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = i + 1;
//    sum += mas[i];
//}
//Console.WriteLine("Сумма всех чисел от 1 до 100: " + sum);


//8
//Напишите программу, которая считывает строку с клавиатуры и выводит на экран количество символов в этой строке
//Console.Write("Введите строку: ");
//string str = Console.ReadLine();
//int count = str.Length;
//Console.WriteLine("Количество символов в строке: " + count);


//9
// Напишите программу, которая проверяет, является ли введенное пользователем число простым (имеет только два делителя - 1 и само число).

//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//bool isPrime = true;
//if (number <= 1)
//{
//    isPrime = false;
//}
//else
//{
//    for (int i = 2; i * i <= number; i++)
//    {
//        if (number % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//}

//if (isPrime)
//{
//    Console.WriteLine($"{number} - простое число.");
//}
//else
//{
//    Console.WriteLine($"{number} - не является простым числом.");
//}


//10
//Напишите программу, которая находит среднее арифметическое трех чисел, введенных пользователем, и выводит результат на экран.

//Console.Write("Введите первое число: ");
//double num1 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число: ");
//double num2 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите третье число: ");
//double num3 = double.Parse(Console.ReadLine()!);

//double avg = (num1 + num2+num3)/3;
//Console.Write($"Среднее арифметическое трех чисел {num1}, {num2} и {num3} равна: {avg}");


//11
//Напишите программу, которая находит наименьшее число из трех введенных пользователем чисел и выводит его на экран.

//Console.Write("Введите первое число: ");
//double num1 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число: ");
//double num2 = double.Parse(Console.ReadLine()!);
//Console.Write("Введите третье число: ");
//double num3 = double.Parse(Console.ReadLine()!);

//double min = num1;
//if (num2 < min) min = num2;
//if (num3 < min) min = num3;

//Console.WriteLine("Наименьшее число: " + min);

//12
//Напишите программу, которая выводит строку введенную пользователем в обратном порядке.

//Console.Write("Введите строку: ");
//string str = Console.ReadLine();
//for (int i = str.Length - 1; i >= 0; i--)
//    Console.Write(str[i]);

//13
//Напишите программу, которая определяет, является ли введенное пользователем число палиндромом (читается одинаково слева направо и справа налево).

//Console.Write("Введите число: ");
//string  num = Console.ReadLine();
//bool IsPalindrome = true;
//int length = num.Length;

//for (int i = 0; i < length / 2; i++)
//{
//    if (num[i] != num[length - 1 - i])
//    {
//        IsPalindrome = false;
//        break;
//    }
//}
//if (IsPalindrome)
//{
//    Console.WriteLine("Число является палиндромом.");
//}
//else
//{
//    Console.WriteLine("Число не является палиндромом.");
//}


//14
//Напишите программу, которая определяет, является ли введенное пользователем число совершенным (сумма всех делителей числа равна самому числу).

//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine()!);
//int sum = 0;
//for (int i = 1; i <= num / 2; i++)
//{
//    if (num % i == 0)
//    {
//        sum += i;
//    }
//}
//if (sum == num)
//{
//    Console.WriteLine($"{num} является совершенным числом.");
//}
//else
//{
//    Console.WriteLine($"{num} не является совершенным числом.");
//}

//15
//Напишите программу, которая находит все простые числа от 1 до 100 и выводит их на экран

//Console.Write("Простые числа от 1 до 100: ");

//for (int i = 2; i <= 100; i++)
//{
//    if (IsPrime(i))
//    {
//        Console.Write(i + " ");
//    }
//}
//static bool IsPrime(int number)
//{
//    if (number <= 1)
//    {
//        return false;
//    }

//    for (int i = 2; i * i <= number; i++)
//    {
//        if (number % i == 0)
//        {
//            return false;
//        }
//    }

//    return true;
//}

//16
//Напишите программу, которая находит сумму всех четных чисел от 1 до 100 и выводит результат на экран.

//int sum = 0;
//for (int i = 2; i <= 100; i += 2)
//{
//    sum += i;
//}
//Console.WriteLine("Сумма всех четных чисел от 1 до 100: " + sum);

//17
//Напишите программу, которая проверяет, является ли введенное пользователем слово панграммой (содержит все буквы алфавита). 

//Console.Write("Введите слово: ");
//string word = Console.ReadLine().ToLower();
//bool isPangram = IsPangram(word);

//if (isPangram)
//{
//    Console.WriteLine("Введенное слово является панграммой.");
//}
//else
//{
//    Console.WriteLine("Введенное слово не является панграммой.");
//}
//static bool IsPangram(string word)
//{
//    string alphabet = "abcdefghijklmnopqrstuvwxyz";
//    foreach (char letter in alphabet)
//    {
//        if (!word.Contains(letter))
//        {
//            return false;
//        }
//    }
//    return true;
//}

//18
//Напишите программу, которая находит наименьшее общее кратное двух чисел, введенных пользователем, и выводит результат на экран 

//Console.Write("Введите первое число: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int num2 = int.Parse(Console.ReadLine());

//int lcm = FindLCM(num1, num2);

//Console.WriteLine($"Наименьшее общее кратное чисел {num1} и {num2} равно: {lcm}");


//static int FindLCM(int a, int b)
//{
//    int max = Math.Max(a, b);
//    int min = Math.Min(a, b);

//    int lcm = max;

//    while (true)
//    {
//        if (lcm % min == 0)
//        {
//            return lcm;
//        }
//        lcm += max;
//    }
//}


//19
// Напишите программу, которая считывает числа с клавиатуры, пока пользователь не введет отрицательное число, и выводит сумму введенных положительных чисел на экран.
//int sum = 0;
//while (true)
//{
//    Console.Write("Введите число: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    if (number < 0)
//        break;
//    sum += number;
//}
//Console.WriteLine("Сумма введенных положительных чисел: " + sum);


//20
//Создайте одномерный массив длиной 8 элементов, вручную заполните его числами от -10 до 10

//int[] mas = { 4, -7, 3, 9, 2, -5, 8, 10};

//21
//Найти сумму элементов в массиве.

//int[] mas = { 4, -7, 3, 9, 2, -5, 8, 10 };
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    sum += mas[i];
//}
//Console.WriteLine("Сумма элементов массива: " + sum);


//22
//Посчитать количество четных чисел в массиве.

//int[] mas = { 4, -7, 3, 9, 2, -5, 8, 10 };
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("Количество четных чисел в массиве: " + count);


//23
//Определить наибольший и наименьший элемент в массиве.

//int[] mas = { 4, -7, 3, 9, 2, -5, 8, 10 };
//int min = mas[0], max = mas[0];
//double sum = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] > max) max = mas[i];
//    if (mas[i] < min) min = mas[i];
//    sum += mas[i];
//}
//Console.WriteLine("Max=" + max);
//Console.WriteLine("Min=" + min);

//24
//Проверить, является ли массив “палиндромом”.

//int[] mas = { 4, -7, 3, 9, 2, -5, 8, 10 };
//bool IsPalindrome = true;
//for (int i = 0; i < mas.Length / 2; i++)
//{
//    if (mas[i] != mas[mas.Length - 1 - i])
//    {
//        IsPalindrome = false;
//        break;
//    }
//}
//if (IsPalindrome)
//{
//    Console.WriteLine("Массив является палиндромом");
//}
//else
//{
//    Console.WriteLine("Массив не является палиндромом");
//}


//25
//Создайте двумерный массив длиной 5х5 элементов, вручную заполните его числами от -10 до 10.
//int[,] mas = new int[5, 5]
//{
//    {1, 2, 3, 4, 8},
//    {5, -10, 11, -2, 7},
//    {-9, -1, 5, -3, 8},
//    {4, -5, 3, 6, 10},
//    {-10, 2, 4, 6, 8}
//};


//26
//Вычислить сумму элементов в каждой строке

//int[,] mas = new int[5, 5]
//{
//    {1, 2, 3, 4, 8},
//    {5, -10, 11, -2, 7},
//    {-9, -1, 5, -3, 8},
//    {4, -5, 3, 6, 10},
//    {-10, 2, 4, 6, 8}
//};
//for (int i = 0; i < 5; i++)
//{
//    int sum = 0;
//    for (int j = 0; j < 5; j++)
//    {
//        sum += mas[i, j];
//    }
//    Console.WriteLine($"Сумма элементов в строке {i + 1}: {sum}");
//}

//27
//Найти сумму элементов по диагонали матрицы.

