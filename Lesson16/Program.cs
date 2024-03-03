//9
//Создайте массив из 12 случайных целых чисел и найдите в нем 
//наибольший элемент, наименьший элемент и среднее арифметическое 
//всех элементов.

//int[] mas = new int[15];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i]=random.Next(10,100);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//int min = mas[0], max = mas[0];
//double sum = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] > max) max = mas[i];
//    if (mas[i] < min) min = mas[i];
//    sum += mas[i];
//}
//Console.WriteLine("Max="+max);
//Console.WriteLine("Min="+min);
//Console.WriteLine($"Avg ={sum / mas.Length:F2}");


//10
//Создайте массив из 8 строк и найдите в нем самую короткую и 
//самую длинную строку, а также выведите на экран все строки,
//содержащие букву "а". 

//string[] mas = new string[8];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    string temp = "";
//    for (int j = 0; j < random.Next(1, 20); j++)
//    {
//        temp += (char)random.Next(97, 123);
//    }
//    mas[i] = temp;
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//int max = mas[0].Length, min = mas[0].Length;
//string minStr = mas[0], maxStr = mas[0];
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Length > max)
//    {
//        max = mas[i].Length;
//        maxStr = mas[i];
//    }
//    if (mas[i].Length < min)
//    {
//        min = mas[i].Length;
//        minStr = mas[i];
//    }
//    if (mas[i].Contains("a")) Console.WriteLine(mas[i]+" ");
//}
//Console.WriteLine("max=" + maxStr);
//Console.WriteLine("min=" + minStr);


//Сортировка массива
//Random random = new Random();
//int[] mas = new int[random.Next(20)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i]= random.Next(1,100);
//    Console.Write(mas[i]+" ");
//}
//for (int i = 0;i < mas.Length-1; i++) //опорные элементы
//{
//    for (int j = i+1; j < mas.Length; j++) 
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//Console.WriteLine();
//foreach (int i in mas)
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();


//11
//Создайте массив из 30 случайных целых чисел и выведите на экран 
//все элементы, которые встречаются в массиве больше одного раза.

//int[] mas = new int[30];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(20);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//Array.Sort(mas);
//foreach (int item in mas)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine();
//int count = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] == mas[i - 1]) count++;

//    else if (mas[i] != mas[i - 1])
//    {
//        if (count > 0)
//        {
//            Console.Write(mas[i - 1] + " ");
//            count = 0;
//        }
//    }
//    if (i == mas.Length - 1)
//    {
//        if (count > 0)
//        {
//            Console.Write(mas[i] + " ");
//        }
//    }
//}