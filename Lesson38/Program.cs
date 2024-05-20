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

//int[,] mas = new int[5, 5]
//{
//    {1, 2, 3, 4, 8},
//    {5, -10, 11, -2, 7},
//    {-9, -1, 5, -3, 8},
//    {4, -5, 3, 6, 10},
//    {-10, 2, 4, 6, 8}
//};
//int sum = 0;
//int sum1 = 0;
//for (int i = 0; i < 5; i++)
//{
//    sum += mas[i, i];
//    sum1 += mas[i, 4 - i];
//}
//Console.WriteLine("Сумма элементов по диагонали матрицы: " + sum);
//Console.WriteLine("Сумма элементов по диагонали матрицы: " + sum1);

//28
// Создать массив массивов
//int[][] mas = new int[4][];

//mas[0] = new int[] { 7, -4, 22, -12 };
//mas[1] = new int[] { 1 };
//mas[2] = new int[] { 13, -20, -6,-9 };
//mas[3] = new int[] { 0, 16, 5 };
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.WriteLine(string.Join(", ", mas[i]));
//}

//29
//Найти среднее арифметическое для каждого подмассива.
//int[][] mas = new int[4][];
//mas[0] = new int[] { 7, -4, 22, -12 };
//mas[1] = new int[] { 1 };
//mas[2] = new int[] { 13, -20, -6, -9 };
//mas[3] = new int[] { 0, 16, 5 };
//for (int i = 0; i < mas.Length; i++)
//{
//    int sum = 0;
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        sum += mas[i][j];
//    }
//    double avg = (double)sum / mas[i].Length;
//    Console.WriteLine($"Среднее арифметическое подмассива {i + 1}: {avg}");
//}


//30
//Поменять местами строки в подмассивах.
//int[][] mas = new int[4][];
//mas[0] = new int[] { 7, -4, 22, -12 };
//mas[1] = new int[] { 1 };
//mas[2] = new int[] { 13, -20, -6, -9 };
//mas[3] = new int[] { 0, 16, 5 };
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.WriteLine(string.Join(", ", mas[i]));
//}

//int[] temp = mas[0];
//mas[0] = mas[1];
//mas[1] = temp;
//temp = mas[2];
//mas[2] = mas[3];
//mas[3] = temp;
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();
//}

//31
//Найти наибольший и наименьший элементы в каждом подмассиве.
//int[][] mas = new int[4][];
//mas[0] = new int[] { 7, -4, 22, -12 };
//mas[1] = new int[] { 1 };
//mas[2] = new int[] { 13, -20, -6, -9 };
//mas[3] = new int[] { 0, 16, 5 };
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.WriteLine(string.Join(", ", mas[i]));
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    int min = mas[i][0];
//    int max = mas[i][0];

//    for (int j = 1; j < mas[i].Length; j++)
//    {
//        if (mas[i][j] < min)
//        {
//            min = mas[i][j];
//        }
//        if (mas[i][j] > max)
//        {
//            max = mas[i][j];
//        }
//    }

//    Console.WriteLine($"Подмассив {i + 1}:");
//    Console.WriteLine($"Наименьший элемент: {min}");
//    Console.WriteLine($"Наибольший элемент: {max}");
//}

//32
//Написать локальную функцию принимающую два числа и возвращающую их произведение.
//double Mult(double a, double b)
//{
//    return a * b;
//}

//double a, b;
//Console.Write("Введите а: ");
//double.TryParse(Console.ReadLine(), out a);
//Console.Write("Введите b: ");
//double.TryParse(Console.ReadLine(), out b);
//Console.WriteLine($"Произведение чисел {a} и {b} равно {Mult(a,b)}");


//33
//Реализовать локальную функцию для проверки, является ли число простым.
//int number;
//Console.Write("Введите а: ");
//int.TryParse(Console.ReadLine(), out number);
//bool IsPrime(int number)
//{
//    if (number <= 1) return false;
//    if (number == 2) return true;
//    if (number % 2 == 0) return false;

//    var boundary = (int)Math.Floor(Math.Sqrt(number));

//    for (int i = 3; i <= boundary; i += 2)
//        if (number % i == 0)
//            return false;

//    return true;
//}
//if (IsPrime(number))
//{
//    Console.WriteLine($"{number} - простое число");
//}
//else
//{
//    Console.WriteLine($"{number} - не является простым числом");
//}


//34
//Написать локальную функцию для проверки, является ли строка палиндромом
//using System;

//bool IsPalindrome(string str)
//{
//    int left = 0;
//    int right = str.Length - 1;
//    while (left < right)
//    {
//        if (str[left] != str[right])
//        {
//            return false;
//        }
//        left++;
//        right--;
//    }
//    return true;
//}
//Console.Write("Введите строку: ");
//string str = Console.ReadLine()!;
//bool isPalindrome = IsPalindrome(str);

//if (isPalindrome)
//{
//    Console.WriteLine($"Строка '{str}' является палиндромом.");
//}
//else
//{
//    Console.WriteLine($"Строка '{str}' не является палиндромом.");
//}


//35
//Написать локальную функцию для вычисления факториала числа
//long Factorial(int x)
//{
//    long F = 1;
//    for (int i = 1; i <= x; i++) F *= i;
//    return F;
//}
//Console.Write("Введите число: ");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine($"Факториал {n}:{Factorial(n)}");

//36
//Создать локальную функцию для нахождения наибольшего общего делителя двух чисел.
//int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        var t = b;
//        b = a % b;
//        a = t;
//    }
//    return a;
//}
//Console.Write("Введите первое число: ");
//int a = int.Parse(Console.ReadLine()!);
//Console.Write("Введите второе число: ");
//int b = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"Наибольший общий делитель чисел {a} и {b} равен {GCD(a, b)}");

//37
//Создать класс для представления геометрической фигуры (например, прямоугольника) и методы для вычисления ее периметра и площади.
//Console.Write("Введите x: ");
//double x, y;
//double.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите y: ");
//double.TryParse(Console.ReadLine(), out y);
//Calculator calc = new Calculator(x, y);
//Console.WriteLine(calc.Perimetr());
//Console.WriteLine(calc.Square());
//class Calculator
//{
//    private double X;
//    private double Y;

//    public Calculator(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }
//    public double Perimetr()
//    {
//        return (X + Y)*2;
//    }
//    public double Square() 
//    {
//        return (X * Y);
//    }
//}

//38
//Реализовать класс для работы с числами и методы для выполнения арифметических операций.

//Console.Write("Введите x: ");
//double x, y;
//double.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите y: ");
//double.TryParse(Console.ReadLine(), out y);
//Calculator calc = new Calculator(x, y);
//Console.WriteLine(calc.Add());
//Console.WriteLine(calc.Sub());
//Console.WriteLine(calc.Mult());
//Console.WriteLine(calc.Div());

//class Calculator
//{
//    private double X;
//    private double Y;

//    public Calculator(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }
//    public double Add()
//    {
//        return X + Y;
//    }
//    public double Mult()
//    {
//        return X * Y;
//    }
//    public double Div()
//    {
//        return X / Y;
//    }
//    public double Sub() => X - Y;

//}


//39
//Написать класс для управления банковским счетом с методами для пополнения и снятия средств.

//using System;
//public class BankAccount
//{
//    private decimal balance;
//    public BankAccount(decimal Balance)
//    {
//        if (balance < 0)
//        {
//            throw new ArgumentException("Баланс не может быть отрицательным!");
//        }

//        balance = Balance;
//    }
//    public void Deposit(decimal amount)
//    {
//        if (amount < 0)
//        {
//            throw new ArgumentException("Баланс не может быть отрицательным!");
//        }

//        balance += amount;
//    }
//    public bool Withdraw(decimal amount)
//    {
//        if (amount < 0)
//        {
//            throw new ArgumentException("Баланс не может быть отрицательным!");
//        }

//        if (balance >= amount)
//        {
//            balance -= amount;
//            return true;
//        }

//        return false;
//    }
//    public decimal GetBalance()
//    {
//        return balance;
//    }

//    public void PrintAccountInfo()
//    {
//        Console.WriteLine($"Банковский счет: {balance} рублей");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        BankAccount account = new BankAccount(1000);
//        account.PrintAccountInfo();

//        account.Deposit(500);
//        account.PrintAccountInfo();

//        account.Withdraw(200);
//        account.PrintAccountInfo();

//        bool success = account.Withdraw(2000);
//        Console.WriteLine($"Снятие денежных средств: {success}");
//        account.PrintAccountInfo();
//    }
//}


//40
//Реализовать класс для работы с матрицами и методы для выполнения операций сложения, умножения и транспонирования.

//using System;
//namespace MatrixMxN
//{
//    class Matrix
//    {
//        int[,] data = new int[1, 1];
//        int m = 1;
//        int n = 1;
//        public Matrix(int m, int n)
//        {
//            Generate(m, n);
//        }
//        public void Generate(int m, int n)
//        {
//            this.m = m;
//            this.n = n;
//            data = new int[m, n]; //создаем пустой массив
//            Random random = new Random();
//            //заполняем массив данными
//            for (int i = 0; i < m; i++)
//                for (int j = 0; j < n; j++)
//                {
//                    data[i, j] = random.Next(10, 100);
//                }
//        }
//        public int[,] Transpose()
//        {
//            int[,] transpose = new int[n, m];
//            for (int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    transpose[j, i] = data[i, j];
//                }
//            }
//            return transpose;
//        }
//        public float Average()
//        {
//            if (data == null)
//            {
//                Console.WriteLine("Матрица не существует!");
//                return -1;
//            }

//            float sum = 0;
//            for (int i = 0; i < m; i++)
//            {
//                for (int j = 0; j < n; j++)
//                {
//                    sum += data[i, j];
//                }
//            }
//            return sum / (data.GetLength(0) * data.GetLength(1));
//        }
//        public string GetInfo(bool isTranspose, bool needAlInfo)
//        {
//            string matrix = isTranspose ? "----Транспонированная матрица------\n" : "----Исходная матрица------\n";
//            var array = isTranspose ? Transpose() : data;
//            int row = isTranspose ? n : m;
//            int col = isTranspose ? m : n;

//            if (needAlInfo)
//            {
//                matrix += isTranspose ? $"Размеры: {n}x{m}\n" : $"Размеры: {m}x{n}\n";
//                matrix += $"Среднее значение {Average()} \n";
//            }

//            for (int i = 0; i < row; i++)
//            {
//                for (int j = 0; j < col; j++)
//                {
//                    matrix += array[i, j].ToString() + "\t";
//                }
//                matrix += "\n";
//            }
//            return matrix;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int m = 0;
//            int n = 0;
//            int errors = 0;
//            while ((m == 0) && (n == 0))
//            {
//                Console.WriteLine("Введите желаемую размерность матрицы в формате MхN, где M и N - целые числа");
//                Console.WriteLine("Например, 10x5");
//                Console.Write("Размерность матрицы: ");
//                string[] strings = Console.ReadLine().Split('x');
//                if ((strings.Length < 2) || (int.TryParse(strings[0], out m) == false) || (int.TryParse(strings[1], out n) == false))
//                {
//                    errors++;
//                    Console.WriteLine($"Допущено ошибок ввода: {errors}");
//                    if ((errors > 1) && (errors < 4))
//                    {
//                        Console.Beep();
//                        Console.ForegroundColor = ConsoleColor.Blue;
//                        Console.WriteLine("Не издевайся надо мной! Пиши так: целое число, затем - маленький ИКС (английская раскладка!), затем - опять целое число. Пробелы ставить не надо");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        continue;
//                    }
//                    else
//                        if (errors == 4)
//                    {
//                        Console.Beep();
//                        Console.Beep();
//                        Console.ForegroundColor = ConsoleColor.Red;
//                        Console.WriteLine("Ты безнадежен, человек. Закрой программу и иди домой");
//                        Console.ForegroundColor = ConsoleColor.White;
//                        break;
//                    }
//                }
//            }

//            if (errors < 4)
//            {
//                Matrix matrix = new Matrix(m, n);
//                Console.WriteLine(matrix.GetInfo(false, true));
//                Console.WriteLine(matrix.GetInfo(true, false));
//            }
//        }
//    }
//}


//Последняя задача - МАГИЧЕСКИЙ КВАДРАТ
//Дан массив чисел 3Х3 со значениями от 1 до 10.
//Задача:
//Написать метод проверяющий, является ли данный числовой массив - магическим квадратом и возвращающий true если это так и false в противном случае.
//Магический квадрат - матрица (или массив), в котором:суммы всех элементов каждой из строк, суммы всех элементов каждого столбца и суммы диагоналей равны.

////1 вариант
//Console.Write("Строка: ");
//int m = int.Parse(Console.ReadLine()!);
//Console.Write("Столбец: ");
//int k = int.Parse(Console.ReadLine()!);


//int[,] matr = new int[m, k]; //матрица 3х3
//int i, j; //переменные для счетчиков
//int p;
//p = m + k + 2;

//int[] summ = new int[p]; //массив для записей различных сумм (строк, столбцов, диагоналей)
//for (i = 0; i < p; i++) summ[i] = 0; //все суммы обнуляем

////забиваем массив числами
//for (i = 0; i < m; i++)
//    for (j = 0; j < k; j++)
//    {
//        Console.Write("matr[" + i + "][" + j + "] = ");
//        matr[i, j] = int.Parse(Console.ReadLine()!);
//        summ[i] += matr[i, j]; //суммы строк
//        summ[j + m] += matr[i, j]; //суммы столбцов
//        if (i == j) summ[p - 2] += matr[i, j]; //сумма главной диагонали
//        if (i + j == (m - 1)) summ[p - 1] += matr[i, j]; //сумма побочной диагонали
//    }

////считаем все суммы
//for (i = 0; i < m; i++)
//{
//    for (j = 0; j < k; j++)
//        Console.Write(matr[i, j] + "\t");
//    Console.WriteLine();
//}

//string result = "Магический квадрат!!!";
//for (i = 0; i < (p - 1); i++)
//{
//    Console.WriteLine("summ[" + i + "] = " + summ[i]); //выводим суммы на экран
//    if (summ[i] != summ[i + 1])  //проверяем равенство текущей и следующей
//        result = "Не является магическим квадратом";
//}
//Console.WriteLine("summ[" + (p - 1) + "] = " + summ[p - 1]); //выводим на экран последний элемент массива с суммами (не выводили в цикле, что за границы массива не улететь)
//Console.WriteLine(result); //выводим на экран строку с результатом



//2 вариант
//using System;
//public class MagicSquareChecker
//{
//    public static bool IsMagicSquare(int[,] square)
//    {
//        // Сумма элементов магического квадрата
//        int magicSum = 0;
//        // Вычисление суммы элементов первой строки для определения магической суммы
//        for (int i = 0; i < 3; i++)
//        {
//            magicSum += square[0, i];
//        }
//        // Проверка суммы элементов по строкам
//        for (int row = 0; row < 3; row++)
//        {
//            int rowSum = 0;
//            for (int col = 0; col < 3; col++)
//            {
//                rowSum += square[row, col];
//            }
//            if (rowSum != magicSum)
//            {
//                return false;
//            }
//        }
//        // Проверка суммы элементов по столбцам
//        for (int col = 0; col < 3; col++)
//        {
//            int colSum = 0;
//            for (int row = 0; row < 3; row++)
//            {
//                colSum += square[row, col];
//            }
//            if (colSum != magicSum)
//            {
//                return false;
//            }
//        }
//        // Проверка суммы элементов по диагоналям
//        int diag1Sum = 0; // Главная диагональ
//        int diag2Sum = 0; // Побочная диагональ
//        for (int i = 0; i < 3; i++)
//        {
//            diag1Sum += square[i, i];
//            diag2Sum += square[i, 2 - i];
//        }

//        if (diag1Sum != magicSum || diag2Sum != magicSum)
//        {
//            return false;
//        }
//        // Если все суммы совпали, то это магический квадрат
//        return true;
//    }
//    public static void Main()
//    {
//        int[,] square = {
//            { 2, 7, 6 },
//            { 9, 5, 1 },
//            { 4, 3, 6 }
//        };

//        bool isMagic = IsMagicSquare(square);
//        Console.WriteLine("Is the square a magic square? " + (isMagic ? "Yes" : "No"));
//    }
//}

