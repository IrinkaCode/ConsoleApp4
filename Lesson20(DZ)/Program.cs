//Напишите функцию,которая принимает два числа и выводит на экран их сумму.Числа передаются пользователем в переменные,которые затем передаются в функцию.Функция должна возвращать результат,который в последствии выводится на консоль.
//Урок 1
//Console.Write("Введите первое число: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int num2 = int.Parse(Console.ReadLine());

//int sum = SumNumbers(num1, num2);

//Console.WriteLine($"Сумма чисел {num1} и {num2} равна: {sum}");

//int SumNumbers(int num1, int num2)
//{
//    return num1 + num2;
//}

//Урок 2
//Напишите функцию, которая принимает массив целых чисел и возвращает среднее значение элементов массива. Массив задать явно. Функция должна возвращать результат, который в последствии выводится на консоль.
//int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//double avg = Average(mas);
//Console.WriteLine("Среднее значение элементов массива: " + avg);
//    double Average(int[] mas)
//{
//    int sum = 0;
//    foreach (int num in mas)
//    {
//        sum += num;
//    }
//    return (double)sum / mas.Length;
//}

//Урок 3
//Напишите программу, которая выполняет логическое побитовое умножение, сложение, шифрование по ключу и инверсию.
//Пользователь вводит число, затем вид операции с числом и получает результат в зависимости от своего выбора.

//Console.Write("Введите целое число: ");
//int number = int.Parse(Console.ReadLine());

//Console.WriteLine("Выберите операцию:");
//Console.WriteLine("1 - Логическое побитовое умножение");
//Console.WriteLine("2 - Логическое побитовое сложение");
//Console.WriteLine("3 - Шифрование по ключу");
//Console.WriteLine("4 - Инверсия");

//int choice = int.Parse(Console.ReadLine());

//switch (choice)
//{
//    case 1:
//        Console.Write("Введите число для умножения: ");
//        int multiplication = int.Parse(Console.ReadLine());
//        int resultMultiply = number & multiplication;
//        Console.WriteLine($"Результат умножения: {resultMultiply}");
//        break;

//    case 2:

//        Console.Write("Введите число для сложения: ");
//        int addend = int.Parse(Console.ReadLine());
//        int resultAdd = number | addend;
//        Console.WriteLine($"Результат сложения: {resultAdd}");
//        break;

//    case 3:
//        Console.Write("Введите ключ шифрования: ");
//        int key = int.Parse(Console.ReadLine());
//        int encryption = number ^ key;
//        Console.WriteLine($"Зашифрованное число: {encryption}");
//        break;

//    case 4:
//        int inversion = ~ number;
//        Console.WriteLine($"Инверсия числа: {inversion}");
//        break;

//    default:
//        Console.WriteLine("Некорректный выбор операции.");
//        break;
//}

//Урок 4
//Проинициализируйте вручную два массива 4х4, значениями от -50 до 50.
//Напишите функции:
//1.Суммирующую массивы и возвращающую в качестве результата новый массив суммы.
//2.Поиска максимального значения массива.


int[,] mas1 = new int[4, 4]
{
    {10, 20, 30, 40},
    {5, -10, 15, 25},
    {-20, -25, 50, -30},
    {45, -5, 35, -15}
};

int[,] mas2 = new int[4, 4]
{
    {5, 15, 25, 35},
    {-10, 20, -30, 40},
    {0, -5, 10, 15},
    {25, -20, 30, -5}
};

int[,] sumMas = SumMas(mas1, mas2);
Console.WriteLine("Массив суммы двух предыдущих: ");
PrintArray(sumMas);

int maxVal = FindMaxValue(sumMas);
Console.WriteLine($"Максимальное значение массива: {maxVal}");


int[,] SumMas(int[,] mas1, int[,] mas2) //функция принимает два массива в качестве аргументов и возвращает новый массив, который представляет собой сумму элементов соответствующих позиций из двух входных массивов.
{
    int n = mas1.GetLength(0);
    int m = mas1.GetLength(1);
    int[,] sumMas = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sumMas[i, j] = mas1[i, j] + mas2[i, j];
        }
    }

    return sumMas;
}

int FindMaxValue(int[,] NewMas)      //максимальное значение в новом двумерном массиве.
{
    int maxVal = NewMas[0, 0];
    int n = NewMas.GetLength(0);
    int m = NewMas.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (NewMas[i, j] > maxVal)
            {
                maxVal = NewMas[i, j];
            }
        }
    }

    return maxVal;
}

void PrintArray(int[,]  NewMas)       //выводит новый двумерный массив на консоль.
{
    int n = NewMas.GetLength(0);
    int m = NewMas.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(NewMas[i, j] + " ");
        }
        Console.WriteLine();
    }
}