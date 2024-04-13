﻿//Исключения Try catch

//int n, m;

//do
//{
//    FileStream fs = null;

//    try
//    {
//        Console.Write("Введите 1 число:");
//        n = int.Parse(Console.ReadLine());
//        Console.Write("Введите 2 число:");
//        m = int.Parse(Console.ReadLine());
//        if (n < m) throw new ArithmeticException();
//        int div = n / m;
//        Console.WriteLine(div);
//        int[] mas = new int[10];
//        mas[8] = 10;
//        Console.Write("Введите строку длиной 7 символов:");
//        string str = Console.ReadLine();
//        if (str.Length != 7) throw new Exception();
//        fs = File.OpenRead("file.txt");
//        break;
//    }
//    catch (FormatException e)//правильность формата введенной строки
//    {
//        Console.WriteLine(e.Message);
//        Console.WriteLine(e.StackTrace);
//        Console.WriteLine(e.HelpLink);
//        Console.WriteLine(e.InnerException);
//        Console.WriteLine(e.Data);
//        Console.WriteLine(e.Source);
//        Console.WriteLine(e.StackTrace);
//        Console.WriteLine(e.HResult);
//    }
//    catch (DivideByZeroException e)// деление на 0
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (IndexOutOfRangeException e)// выход за границы массива
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (InvalidCastException e)//неправильное преобразования типов
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (ArithmeticException)//неправильная арифметическая операция
//    {
//        Console.WriteLine("Числитель должен быть больше знаменателя");
//    }
//    catch (IOException ex)// ошибка операции ввода-вывода
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch (Exception) //ошибка
//    {
//        Console.WriteLine("Длина должна быть 7 символов");
//    }
//    finally
//    {
//        if (fs != null)
//        fs.Close();
//    }
//}
//while (true);

//3
//Напишите программу, которая запрашивает у пользователя число и выводит его квадратный корень. Обработайте исключение, которое может возникнуть, если введено отрицательное число.
//do
//{
//    try
//    {
//        double n;
//        Console.WriteLine("Введите число");
//        double.TryParse(Console.ReadLine(), out n);
//        if (n < 0) throw new ArithmeticException();
//        Console.WriteLine($"{Math.Sqrt(n)}");
//        break;

//    }
//    catch (ArithmeticException)
//    {
//        Console.WriteLine("Корень из отрицательного числа не существует");
//    }
//}
//while (true);


using System.IO;

string path = Directory.GetCurrentDirectory();
do
{
    Console.Write(path + ">");
    string command = Console.ReadLine();
    string[] commands = command.Split(' ');
    switch (commands[0])
    {
        case "cd"://переход между папками
            {
                switch (commands[1])
                {
                    case "..":
                        path = Directory.GetParent(path).FullName;
                        break;
                    case "/":
                        path = Directory.GetParent(path).Root.FullName;
                        break;
                    default:
                        if (Directory.Exists(path + @"\" + commands[1]))
                        {
                            path = new DirectoryInfo(path + @"\" + commands[1]).FullName;
                        }
                        break;
                }
            }
            break;
        case "ls"://показать содержимое папки
            GetAll(path);
            break;
        case "touch":
            {
                FileInfo file = new FileInfo(path + @"\" + commands[1]);
                if (!file.Exists)
                {
                    file.Create();
                }
                else Console.WriteLine($"Файл {file.Name} существует");
            }
            break;
        case "rm":
            {
                FileInfo file = new FileInfo(path + @"\" + commands[1]);
                if (file.Exists)
                {
                    file.Delete();
                }
                else Console.WriteLine($"Файл {file.Name} не существует");
            }
            break;
        case "cp":
            {
                string currentPath = path + @"\" + commands[1];
                string newPath = commands[2];
                FileInfo fileSrc = new FileInfo(currentPath);
                FileInfo fileSource = new FileInfo(newPath + @"\" + fileSrc.Name);
                if (fileSrc.Exists)
                {
                    if (!fileSource.Exists) fileSource.Create();
                    fileSrc.CopyTo(fileSource.FullName, true);
                }
                else Console.WriteLine($"Файл {fileSrc.Name} не существует");
            }
            break;
    }
}
while (true);

void GetAll(string path)
{
    var dir = new DirectoryInfo(path);
    DirectoryInfo[] dirs = dir.GetDirectories();
    foreach (DirectoryInfo item in dirs)
    {
        Console.WriteLine(item.Name);
    }
    FileInfo[] files = dir.GetFiles();
    foreach (FileInfo item in files)
    {
        Console.WriteLine(item.Name);
    }
}