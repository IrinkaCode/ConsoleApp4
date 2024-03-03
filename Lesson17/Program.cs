//int[] mas = new int[5];
//Console.WriteLine(mas.Length); //длина массива
//Console.WriteLine(mas.Rank);//размерность

//Random random = new Random();
//for (int  i = 0;  i < mas.Length;  i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Console.WriteLine(mas[2]);
//Console.WriteLine(mas.GetValue(2));//свойство
//mas[3] = 6;
//mas.SetValue(6, 3);//свойство поменять значение
//Console.WriteLine(mas[3]);

////copy
//int[] mas2 = { 3, 2, 1, 7, 2, 8 };
//int[] mas3 = new int[6];
//mas2.CopyTo(mas3, 0);
//foreach(int i in mas3)
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();

////сортировка массива
//Array.Sort(mas3);
//foreach(int item in mas3)
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
//string[] strMas = { "qwerty", "lilo", "sdytyu" };
//Array.Sort(strMas);
//foreach (string i in strMas)
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();

////reverse
//Array.Reverse(mas3);
//foreach(var item in mas3)
//{
//    Console.Write(item+" ");
//}
//Console.WriteLine();
////indexOf, LastIndexOf,BinarySearch
//Console.WriteLine(Array.IndexOf(mas2,2)); //с начала
//Console.WriteLine(Array.LastIndexOf(mas2, 2));//с конца
//Console.WriteLine(Array.LastIndexOf(mas2, 5)); //несуществующий элемент
//Console.WriteLine(Array.BinarySearch(mas3, 7));//бинарный поиск,ищет в отсортированнном массиве
//Console.WriteLine(Array.BinarySearch(mas3, 5));

////Concat
//int[] sumMas = mas.Concat(mas2).ToArray();
//foreach(var i in sumMas)
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();

////Clear()
//Array.Clear(sumMas);
//foreach(var i in sumMas) Console.Write(i+" ");
//Console.WriteLine();
//Console.WriteLine(sumMas.Length);

////Resize
//Array.Resize(ref mas2, 8);
//foreach (var i in mas2) Console.Write(i + " ");
//Console.WriteLine();

//1
//Random random = new Random();
//int[] mas = new int[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next();
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Array.Reverse(mas);
//foreach(int i in mas) Console.WriteLine(i+" ");
//Console.WriteLine();


//2
//string[] mas = new string[5];

//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write("Введите "+(i+1)+" слово:");
//    mas[i] = Console.ReadLine();
//}
//foreach (string i in mas) Console.Write(i+" ");
//Console.WriteLine();
//int max = mas[0].Length;
//string res = mas[0];
//for  (int i = 0;i< mas.Length;i++)
//{
//    if (mas[i].Length > max)
//    {
//        max = mas[i].Length;
//        res = mas[i];
//    }
//}
//Console.WriteLine(res);

//3
//Random random = new Random();
//int[] mas1=new int[5];
//int[] mas2=new int[4];
//for(int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(10);
//    Console.Write(mas1[i]+" ");
//}
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas1[i] = random.Next(10);
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//int[] mas3=mas1.Concat(mas2).ToArray();
//double sum = 0;
//foreach(int i in mas3)
//{
//    sum += i;
//    Console.Write(i+" ");
//}
//Console.WriteLine();
//Console.WriteLine($"Avg:{sum/mas3.Length:F2}");

//4
//int[] mas= new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine(mas.Max());
//Console.WriteLine(mas.Min());

//5
//string[] mas = new string[5];
//for (int i = 0; i< mas.Length; i++)
//{
//    Console.Write("Введите " + (i + 1) + " слово:");
//    mas[i] = Console.ReadLine();
//}
//foreach(string i in mas) Console.Write(i+" ");
//Console.WriteLine();
//Console.Write("Введите символ: ");
//char c = char.Parse(Console.ReadLine());
//foreach (string i in mas)
//{
//    if (Array.IndexOf(i.ToArray(),c)==0) 
//        Console.WriteLine(i+" ");
//}

//1
//Random random = new Random();

//string a = "Tom";
//string b = "Jerry";
//string c = "Bob";
//string d = "Mike";
//string e = "Jone";
//string f = "Maria";
//string[] names = new string[6];
//for ( int i = 0;i<names.Length;i++ )
//{
//    switch(random.Next((6)))
//        {
//        case 0:
//            names[i] = a; break;
//        case 1:
//            names[i] = b; break;
//        case 2:
//            names[i]= c; break;
//        case 3:
//            names[i] = d; break;
//        case 4:
//            names[i] = e; break;
//        case 5:
//            names[i] = f; break;
//    }
//    Console.WriteLine(names[i]+" ");
//}
//Console.WriteLine();
//do
//{
//    Console.WriteLine("Введите имя: ");
//    string name = Console.ReadLine();
//    while (Array.IndexOf(names, name) != -1)
//    {
//        names[Array.IndexOf(names, name)] = "Удален";
//    }
//    Console.Write("Продолжить y/n: ");
//    char answer = char.Parse(Console.ReadLine());
//    if (answer == 'n') break;
//}
//while (true);
//foreach (string i in names)
//    if(i!="Удален") Console.WriteLine(i+" ");

//2

//Random random = new Random();
//Console.Write("Введите размер массива:");
//int n=int.Parse(Console.ReadLine());
//int[] mas1 = new int[n];
//int[] mas2 = new int[n];
//int[] mas3 = new int[n];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(10, 100);
//    mas1[i] = random.Next(10, 100);
//    mas3[i] = mas1[i] - mas2[i];
//}
//foreach (int i in mas1) Console.Write(i + " ");
//Console.WriteLine();
//foreach (int i in mas2) Console.Write(i + " ");
//Console.WriteLine();
//foreach (int i in mas3) Console.Write(i + " ");
//Console.WriteLine();

//3

//Console.Write("Введите размер массива:");
//int n = int.Parse(Console.ReadLine());
//Random random = new Random();
//double[] mas = new double[n];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i]=random.NextDouble()*100;
//    Console.Write($"{ mas[i]:F2} ");
//}
//Console.WriteLine();
//Array.Reverse(mas);
//string strMas = "";
//foreach (double i in mas)
//{
//    Console.Write($"{i:F2} ");
//    strMas += i.ToString("F2") + " ";
//}
//Console.WriteLine();
//Console.WriteLine(strMas);
//Console.WriteLine(strMas.Substring(0,strMas.Length/2-1));

//4
Random random = new Random();
Console.Write("Введите размер массива:");
int n = .Parse(Console.ReadLine());
double[] mas1 = new double[n];
double[] mas2 = new double[n];
double[] mas3 = new double[n];
