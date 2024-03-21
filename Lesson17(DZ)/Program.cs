////Урок 1 
///Вариант 1
//int[][] mas = new int[3][];
//mas[0] = new int[] { 1, 2, 3 };
//mas[1] = new int[] { 4, 5, 6 };
//mas[2] = new int[] { 7, 8, 9 };
//Console.WriteLine(mas);
//Console.Write("Введите число 200: ");
//int num = int.Parse(Console.ReadLine());
//mas[2][2] = num;

//foreach (int[] i in mas)
//{
//    foreach (int n in i)
//    {
//        Console.Write(n + " ");
//    }
//    Console.WriteLine();
//}


//Вариант 2
//int[,] mas = new int[4, 3];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = int.Parse(Console.ReadLine());
//    }
//}
//Console.Write("Введите число:");
//int c = int.Parse(Console.ReadLine());
//mas[2, 2] = c;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " "); ;
//    }
//    Console.WriteLine();
//}


////Урок 2 
int[][] mas = new int[3][];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new int[random.Next(1, 10)];
    for (int j = 0; j < mas[i].Length; j++)
    {
        mas[i][j] = random.Next(1, 10);
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int amount = 0;
int sum = 0;
for (int k = 0; k < mas.Length; k++)
{
    amount += mas[k].Length;
    int masSum = 0;
    for (int n = 0; n < mas[k].Length; n++)
    {
        masSum += mas[k][n];
    }
    Console.WriteLine($"{k} sum: {masSum}");
    
    sum += masSum;
}
Console.WriteLine();
Console.WriteLine($"avg: {sum / amount}");


