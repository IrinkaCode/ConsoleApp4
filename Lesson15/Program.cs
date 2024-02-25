//одномерные массивы

//int[] mas1 = new int[] { 4, 7, 3, 8, 2 };//инициализация
//int[] mas2 = new int[5];//ввод с клавиатуры
//Console.WriteLine("Введите элементы массива: ");
//for  (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i]=int.Parse(Console.ReadLine());
//}
//
//    Console.Write(mas2[i]+" ");
//Console.WriteLine();

//генерация по формуле
//int[] mas3 = new int[10];
//for (int i = 0; i < mas3.Length; i++)
//{
//    mas3[i] = 2 * i + 1;
//    Console.Write(mas3[i]+" ");
//}
//Console.WriteLine();

////генератор случайных чисел
//int[] mas4 = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i]=random.Next(10,100);
//    Console.Write(mas4[i]+" ");
//}
//Console.WriteLine();

//double[] mas5 = new double[20];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i]=random.NextDouble()*100;
//    Console.WriteLine($"{mas5[i]:F2} ");
//}
//Console.WriteLine();


//Console.Write("Введите размер массива: ");
//int n=int.Parse(Console.ReadLine());
//int[] mas=new int[n];
//Random random=new Random();
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i]= random.Next(10,100);
//    Console.Write(mas[i]+" ");
//    sum += mas[i];
//}
//Console.WriteLine();
//Console.WriteLine("sum="+sum);


//Console.Write("Введите размер массива: ");
//int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random random = new Random();
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    sum += mas[i];
//}
//foreach(int i in mas)
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();
//Console.WriteLine("sum=" + sum);

//int[] mas=new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i]=random.Next(-7,8);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Console.Write("Введите число в диапазоне от -7 до 7: ");
//int n=int.Parse(Console.ReadLine());
//int last = -1;
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i]==n) last = i;
//    if (mas[i] < n) count++;
//}
//if(last!=-1) Console.WriteLine("Последнее вхождение "+last);
//else Console.WriteLine("Такого числа нет");
//Console.WriteLine("Количество элементов меньше "+n+":"+count);

//1
//Создайте одномерный массив с числами от 1 до 10. 
//int[] mas1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] mas2 = new int[10];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas2[i] = i + 1;
//    Console.Write(mas2[i]+" ");
//}
//Console.WriteLine();

//2 
//Создайте одномерный массив, состоящий из имен пользователей: 
//Дмитрий, Максим, Сергей, Андрей, Владислав. 
//Выведите на экран имя Максим. 
//Выведите все имена построчно используя цикл for. 

//string[] mas = { "Дмитрий", "Максим", "Сергей", "Андрей", "Владислав" };
//Console.WriteLine(mas[1]);
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.WriteLine(mas[i]);
//}
//Console.WriteLine("Введите номер от 0 до 4: ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(mas[n]);

//4
//Создайте пустой строковый массив, с помощью цикла for заполните 
//его именами, принимаемыми от пользователя. 
//Выведите содержимое массива на экран. 
//Console.WriteLine("Введите размер массива: ");
//int n = int.Parse(Console.ReadLine());
//string[] mas=new string[n];
//Console.WriteLine("Введите имена: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = Console.ReadLine();
//}
//foreach(string i in mas)
//{
//    Console.Write(i+" ");
//}
//Console.WriteLine();

//5
//Создайте массив разных цифр. 
//От пользователя берется число, и производится поиск числа в массиве. 
//Если число найдено, выведите его на экран, если нет, выведите “число 
//не найдено”
//int[] mas = { 4, 7, 3, 9, 2, 5, 8 };
//Console.WriteLine("Введите число: ");
//int n=int.Parse(Console.ReadLine());
//bool have = false;
//for(int i=0; i<mas.Length;i++)
//{
//    if (mas[i]==n)
//    {
//        have = true;
//        break;
//    }
//}
//if (have == true) Console.WriteLine(n);
//else Console.WriteLine("Число не  найдено");

//8
//Создайте массив из 15 случайных целых чисел и выведите на экран 
//только те элементы, которые делятся на 2 и не делятся на 3. 

//int[] mas = new int[15];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i]=random.Next(1,100);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//foreach (int i in mas)
//{
//    if(i%2==0&&i%3!=0) Console.Write(i+" ");
//}

//6
//Создайте массив из 10 случайных целых чисел и найдите в нем сумму всех элементов, кратных 3. 
//int[] mas = new int[10];
//Random random = new Random();
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//    if (mas[i] % 3 == 0) sum += mas[i];
//}
//Console.WriteLine();
//Console.WriteLine("sum=" + sum);

//7
//Создайте массив из 20 случайных действительных чисел и
//найдите в нем индекс первого отрицательного элемента.

//double[] mas = new double[20];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100 - 50;
//    Console.Write($"{mas[i]:F} ");
//}
//Console.WriteLine();
//int index = -1;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i]<0)
//    {
//        index = i; break;
//    }
//}
//Console.WriteLine("Индекс первого отрицательного: "+index);