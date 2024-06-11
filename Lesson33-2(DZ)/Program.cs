//Задача 1
//Сортировка в обратном порядке
//Измените один из алгоритмов сортировки так, чтобы он сортировал элементы в обратном порядке (от наибольшего к меньшему)
using System;

int[] arr = { 5, 2, 8, 1, 9 };

BubbleSort(arr);
Console.Write("Отсортированный массив в обратном порядке: ");
foreach (int num in arr)
{
    Console.Write(num + " ");
}

static void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] < arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}



//задача 2
//Реализация алгоритма сортировки, который сортирует список чисел таким образом, что четные числа идут в начале, а нечетные в конце:

//List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 3, 6, 4, 7 };

//numbers.Sort((a, b) =>
//{
//    if (a % 2 == 0 && b % 2 == 0)
//        return a.CompareTo(b);

//    if (a % 2 != 0 && b % 2 != 0)
//        return a.CompareTo(b);

//    // Если одно число четное, а другое нечетное, то четное идет раньше
//    if (a % 2 == 0)
//        return -1;
//    else
//        return 1;
//});

//foreach (int num in numbers)
//    Console.Write(num + " ");

