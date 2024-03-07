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

//Урок 1 
//1

//Random random = new Random();
//double[,] mas = new double[3, 3];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.NextDouble() * 20;
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}
//int n, m;
//Console.Write($"Введите номер строки <= {mas.GetLength(1)}:");
//do
//{
//    n = int.Parse(Console.ReadLine());
//    if (n > mas.GetLength(0)) Console.Write($"Введите номер строки <= {mas.GetLength(1)}:");
//}
//while (n > mas.GetLength(1));
//m = int.Parse(Console.ReadLine());
//double val = double.Parse(Console.ReadLine());
//mas[n - 1, m - 1] = val;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}


//2
// Создаем двумерный массив 5x2
char[,] mas = new char[5, 2];

// Заполняем массив символами в разнобой
mas[0, 0] = 'H';
mas[0, 1] = 'o';
mas[1, 0] = 'w';
mas[1, 1] = ' ';
mas[2, 0] = 'a';
mas[2, 1] = 'r';
mas[3, 0] = 'e';
mas[3, 1] = ' ';
mas[4, 0] = 'y';
mas[4, 1] = 'o';

// Выводим массив на экран в виде слова
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(mas[i, j]);
    }
}
