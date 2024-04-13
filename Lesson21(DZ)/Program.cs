//Урок 1
//Создайте вручную папку с домашним заданием.
//Напишите программу, которая просит пользователя ввести путь к файлу и текст, который необходимо записать в него.
//После записи вывести на экран информацию “Файл успешно записан”.
//Создать еще 2 файла с названиями “Файл2” и “Файл3” программно
//Вывести на экран содержимое 1го файла.

//Console.WriteLine("Введите путь к файлу: ");
//string filePath = Console.ReadLine();
//Console.WriteLine("Введите текст: ");
//string text = Console.ReadLine();
//File.WriteAllText(filePath, text);
//Console.WriteLine("Файл успешно записан");
//string filePath2 = "Файл2.txt";
//string filePath3 = "Файл3.txt";

//File.Create(filePath2).Dispose();
//File.Create(filePath3).Dispose();

//Console.WriteLine("Содержимое 1го файла:");
//Console.WriteLine(File.ReadAllText(filePath));


//Урок 2
//Напишите программу, которая просит пользователя ввести путь к файлу на компьютере. Затем программа должна проверить, существует ли указанный файл, и вывести соответствующее сообщение. Если файл существует, программа должна также вывести его размер в байтах, дату последнего изменения и расширение файла.

//Console.Write("Введите путь к файлу: ");
//string filePath = Console.ReadLine();

//if (File.Exists(filePath))
//{
//    Console.WriteLine("Файл существует.");
//}
//else
//{
//    Console.WriteLine("Файл не найден.");
//}

//FileInfo fileInfo = new FileInfo(filePath);
//Console.WriteLine("Размер: " + fileInfo.Length + "байт");
//Console.WriteLine("Последнее изменение: " + fileInfo.LastWriteTime);
//Console.WriteLine("Расширение: " + fileInfo.Extension);

//Урок 3
//Напишите программу, которая позволяет пользователю перемещаться по файловой системе компьютера.
//На экране должна быть видна текущая директория пользователя и под этим выводом ожидаться название папки, в которую необходимо перейти. После ввода, пользователь переходит в эту папку

//string currentDirectory = Directory.GetCurrentDirectory();

//while (true)
//{
//    Console.WriteLine("Текущая директория: " + currentDirectory);
//    Console.Write("Введите название папки, в которую необходимо перейти (или наберите 'выход' для выхода из программы): ");
//    string input = Console.ReadLine();

//    if (input.ToLower() == "выход")
//    {
//        break;
//    }

//    string newDirectory = Path.Combine(currentDirectory, input);

//    if (Directory.Exists(newDirectory))
//    {
//        currentDirectory = newDirectory;
//    }
//    else
//    {
//        Console.WriteLine("Папка не найдена.");
//    }
//}

//Урок 4
//Напишите программу, которая позволяет пользователю удалить файл или папку. Программа должна запрашивать путь к файлу или папке, которую нужно удалить, и выполнить удаление. Перед удалением, программа должна запрашивать подтверждение пользователя.
Console.Write("Введите путь к файлу или папке, которую вы хотите удалить: ");
string path = Console.ReadLine();
if (File.Exists(path) || Directory.Exists(path))
{
    Console.Write("Вы действительно хотите удалить этот файл или папку?(да/нет)");
    string confirm = Console.ReadLine();

    if (confirm.ToLower() == "да")
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("Файл успешно удален.");
        }
        else if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
            Console.WriteLine("Папка успешно удалена.");
        }
    }
    else
    {
        Console.WriteLine("Удаление отменено.");
    }
}
else
{
    Console.WriteLine("Файл или папка не существует.");
}
