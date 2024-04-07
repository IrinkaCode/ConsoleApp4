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
int[] mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
double avg = Average(mas);
Console.WriteLine("Среднее значение элементов массива: " + avg);
    double Average(int[] mas)
{
    int sum = 0;
    foreach (int num in mas)
    {
        sum += num;
    }
    return (double)sum / mas.Length;
}

//Урок 3
