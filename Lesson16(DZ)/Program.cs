//Урок 1 
//задача 1
//// Создать двумерный массив 3x3
//double[,] mas = new double[3, 3];
//// Заполнить массив дробными числами от 0 до 20
//Random random = new Random();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.NextDouble() * 20;
//    }
//}
//// Вывести массив на экран
//Console.WriteLine("Исходный массив:");
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write($"{mas[i, j]:F2}  ");
//    }
//    Console.WriteLine();
//}
//// Заменить значения по запросу пользователя
//Console.Write("Введите строку, которую хотите заменить от 0 до 2: ");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите столбец,который хотите заменить от 0 до 2: ");
//int m = int.Parse(Console.ReadLine());
//Console.Write("Введите новое дробное значение от 0 до 20: ");
//double newValue = double.Parse(Console.ReadLine());
//mas[n, m] = newValue;
//// Вывести новый массив на экран
//Console.WriteLine("Новый массив: ");
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}


//задача 2
//// Создаем двумерный массив 5x2
//char[,] mas = new char[5, 2];

//// Заполняем массив символами в разнобой
//mas[0, 0] = 'H';
//mas[0, 1] = 'E';
//mas[1, 0] = 'L';
//mas[1, 1] = 'L';
//mas[2, 0] = 'O';
//mas[2, 1] = 'W';
//mas[3, 0] = 'O';
//mas[3, 1] = 'R';
//mas[4, 0] = 'L';
//mas[4, 1] = 'D';

//// Выводим массив на экран в виде слова
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write(mas[i, j]);
//    }
//}
//// Составить слово из символов массива
//string word = "";
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        word += mas[i, j];
//    }
//}
//Console.WriteLine();
//// Вывести составленное слово
//Console.WriteLine("Составленное слово: " + word);


//Урок 2 Управление лампочкой
//string[,] mas ={
//    {"","","x","x","",""},
//    {"","x","","","x",""},
//    {"x","","","","","x"},
//    {"","x","x","x","x",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","","x","x","",""},
//    {"","x","x","x","x",""}};
//string answer = "no"; bool isChecked = false; do
//{
//    Console.Clear();
//    for (int j = 0; j < mas.GetUpperBound(0) + 1; j++)
//    {
//        for (int l = 0; l < mas.GetUpperBound(1) + 1; l++)
//        {
//            if (mas[j, l] != null)
//            {
//                Console.Write($"{mas[j, l],2}");
//            }
//        }
//        Console.WriteLine();
//    }
//    if (isChecked == false) Console.Write("Включить лампочку?");
//    else Console.Write("Выключить лампочку?"); answer = Console.ReadLine()!;
//    if (answer == "yes") isChecked = !isChecked; if (isChecked)
//    {
//        mas[1, 2] = "x"; mas[1, 3] = "x";
//        mas[2, 2] = "x"; mas[2, 3] = "x"; mas[2, 1] = "x"; mas[2, 4] = "x";
//    }
//    else
//    {
//        mas[1, 2] = ""; mas[1, 3] = "";
//        mas[2, 2] = ""; mas[2, 3] = ""; mas[2, 1] = ""; mas[2, 4] = "";
//    }
//}
//while (true);


//Урок 3 - урок 4
//Консольный планировщик

//Console.Write("Введите максимальное количество задач:");
//int n = int.Parse(Console.ReadLine());
//string[,] mas = new string[n, 4];
//int count = 0;//количество задач
//int number;
//bool start = true;
//string search = "";
//do
//{
//    Console.Clear();
//    Console.WriteLine($"Всего задач {n}, свободных {n - count}");
//    Console.WriteLine("Меню:");
//    Console.WriteLine("1. Добавить задачу\n" +
//        "2. Удалить задачу\n" +
//        "3. Перезаписать задачу\n" +
//        "4. Поиск\n" +
//        "5. Выход");
//    if (search != "")
//    {
//        for (int i = 0; i < count; i++)
//        {
//            if (mas[i, 0].StartsWith(search))
//                Console.WriteLine($"{i + 1,-3}{mas[i, 0],-20}{mas[i, 1],-10}" +
//                    $"{mas[i, 2],-10}{mas[i, 3],5}");
//        }
//    }
//    else
//    {
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine($"{i + 1,-3}{mas[i, 0],-20}{mas[i, 1],-10}" +
//                $"{mas[i, 2],-10}{mas[i, 3],5}");
//        }
//    }
//    try
//    {
//        Console.Write("Введите действие:");
//        number = int.Parse(Console.ReadLine());

//        switch (number)
//        {
//            case 1:
//                {
//                    if (count < n)
//                    {
//                        Console.Write("Введите название задачи:");
//                        string name = Console.ReadLine();
//                        Console.Write("Введите дату задачи:");
//                        string date = Console.ReadLine();
//                        Console.Write("Введите время задачи:");
//                        string time = Console.ReadLine();
//                        Console.Write("Введите приоритет задачи:");
//                        string priority = Console.ReadLine();
//                        mas[count, 0] = name;
//                        mas[count, 1] = date;
//                        mas[count, 2] = time;
//                        mas[count, 3] = priority;
//                        count++;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Нет свободных мест");
//                        Console.ReadKey();
//                    }
//                }
//                break;
//            case 2:
//                {
//                    Console.Write("Введите номер задачи для удаления:");
//                    int m = int.Parse(Console.ReadLine());
//                    for (int i = 0; i < mas.GetLength(1); i++)
//                    {
//                        mas[m - 1, i] = "";
//                    }
//                }
//                break;
//            case 3:
//                {
//                    Console.Write("Введите номер задачи для изменения:");
//                    int m = int.Parse(Console.ReadLine());
//                    Console.Write("Введите название задачи:");
//                    string name = Console.ReadLine();
//                    Console.Write("Введите дату задачи:");
//                    string date = Console.ReadLine();
//                    Console.Write("Введите время задачи:");
//                    string time = Console.ReadLine();
//                    Console.Write("Введите приоритет задачи:");
//                    string priority = Console.ReadLine();
//                    mas[m, 0] = name;
//                    mas[m, 1] = date;
//                    mas[m, 2] = time;
//                    mas[m, 3] = priority;
//                }
//                break;
//            case 4:
//                {
//                    Console.Write("Введите задачу для поиска:");
//                    search = Console.ReadLine();
//                }
//                break;
//            case 5:
//                start = false;
//                break;
//            default:
//                Console.WriteLine("Введите правильное действие");
//                Console.ReadKey();
//                break;
//        }
//    }
//    catch
//    {

//    }
//}
//while (start);



