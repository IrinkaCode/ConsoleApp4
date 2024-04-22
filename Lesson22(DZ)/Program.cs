//Урок 1
//Исследование встроенных типов исключений:
//Ваша задача состоит в том, чтобы исследовать различные встроенные типы исключений в С#. Создайте список из 5 различных типов исключений, и для каждого типа проведите следующую работу:
//Опишите предназначение типа исключения.
//Приведите примеры ситуаций, в которых такое исключение может возникнуть.
//Объясните, как правильно обработать каждый тип исключения.

//int n, m;
//do
//{
//    FileStream fs = null;
//    try
//    {
//        Console.Write("Введите 1 число: ");
//        n = int.Parse(Console.ReadLine());
//        Console.Write("Введите 2 число: ");
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
//    catch (ArithmeticException)          //неправильная арифметическая операция
//    {
//        Console.WriteLine("Числитель должен быть больше знаменателя");
//    }
//    catch (IndexOutOfRangeException e) // выход за границы массива
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (InvalidCastException e)     //неправильное преобразования типов
//    {
//        Console.WriteLine(e.Message);
//    }
//    catch (IOException ex)             // ошибка операции ввода-вывода
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch (Exception)                  //ошибка
//    {
//        Console.WriteLine("Длина должна быть 7 символов");
//    }
//    finally
//    {
//        if (fs != null)
//            fs.Close();
//    }
//}
//while (true);


//Урок 2
//Напишите программу, которая запрашивает у пользователя список чисел,разделенных пробелами, и вычисляет их сумму. Обработайте исключение,которое может возникнуть при некорректном вводе (например, если введены символы, отличные от цифр и пробелов).


Console.Write("Введите список чисел,разделенных пробелом: ");
string n = Console.ReadLine();

try
{
    string[] numbers = n.Split(' ');
    int sum = 0;

    foreach (string number in numbers)
    {
        sum += int.Parse(number);
    }

    Console.WriteLine($"Сумма введенных чисел: {sum}");
}
catch (FormatException)
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите только цифры, разделенные пробелами.");
}

