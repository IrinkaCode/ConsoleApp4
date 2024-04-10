

//static void Main(string[] args)
//{
//    //string content = "hcgfdfukg";
//    File.WriteAllText(@"MyFile.txt", "Привет мир");
//    string[] lines =
//    {
//        "ПРивет",
//        "Пока",
//        "как дела?",
//        "Цифра",
//    };
//    File.WriteAllLines(@"MyFileLines.txt", lines);
//    File.WriteAllText(@"MyFile.txt", "");
//    File.Create(@"MyFile.txt");
//{
//    string content = File.ReadAllText("MyFile.txt");
//    Console.WriteLine(content);
//}
//{
//    string[] content = File.ReadAllLines("MyFileLines.txt");
//    for (int i = 0; i < content.Length; i++)
//    {
//        Console.WriteLine(content[i]);
//    }
//}


//Напишите программу,используя функции,которые в зависимости от выбора пользователя будут:создавать файл,читать содержимое файла,удалять файл,создавать и удалять директорию.

//using static System.Net.Mime.MediaTypeNames;

//Console.WriteLine("Выберите операцию: ");
//Console.WriteLine("1- Создать файл");
//Console.WriteLine("2- Читать содержимое файла");
//Console.WriteLine("3- Удалить файл");
//Console.WriteLine("4- Создать директорию");
//Console.WriteLine("5- Удалить директорию");

//int userChoice = int.Parse(Console.ReadLine());
//switch(userChoice)
//{
//    case 1:
//        Console.WriteLine("Введите путь к файлу: ");
//        string filePath = Console.ReadLine();
//        Console.WriteLine("Введите текст: ");
//        string text = Console.ReadLine();
//        File.WriteAllText(filePath, text);
//        break;
//    case 2:
//        Console.WriteLine("Введите путь к файлу: ");
//        filePath = Console.ReadLine();
//        File.ReadAllText(filePath);
//        break;
//    case 3:
//        Console.WriteLine("Введите путь до удаляемого файла: ");
//        filePath = Console.ReadLine();
//        File.Delete(filePath);
//        break;
//    case 4:
//        Console.WriteLine("Введите путь до папки: ");
//        filePath = Console.ReadLine();
//        Directory.CreateDirectory(filePath);
//        break;

//    case 5:
//        Console.WriteLine("Введите путь до удаляемой папки: ");
//        filePath = Console.ReadLine();
//        Directory.Delete(filePath);
//        break;

//    default:
//        Console.WriteLine("Введена не существующая команда");
//        break;
//}




//void Main()
//{
//    while (true)
//    {
//        Console.WriteLine("Выберите действие:");
//        Console.WriteLine("1. Создать файл");
//        Console.WriteLine("2. Прочитать содержимое файла");
//        Console.WriteLine("3. Удалить файл");
//        Console.WriteLine("4. Создать директорию");
//        Console.WriteLine("5. Удалить директорию");
//        Console.WriteLine("6. Выйти");

//        int choice = int.Parse(Console.ReadLine());

//        switch (choice)
//        {
//            case 1:
//                CreateFile();
//                break;
//            case 2:
//                ReadFile();
//                break;
//            case 3:
//                DeleteFile();
//                break;
//            case 4:
//                CreateFolder();
//                break;
//            case 5:
//                RemoveFolder();
//                break;
//            case 6:
//                return;
//            default:
//                Console.WriteLine("Неверный выбор. Попробуйте снова.");
//                break;
//        }
//    }
//}

//void CreateFile()
//{
//    Console.WriteLine("Введите имя файла для создания:");
//    string fileName = Console.ReadLine();
//    File.Create(fileName);
//    Console.WriteLine($"Файл {fileName} успешно создан.");
//}

//void ReadFile()
//{
//    Console.WriteLine("Введите имя файла для чтения:");
//    string fileName = Console.ReadLine();
//    string content = File.ReadAllText(fileName);
//    Console.WriteLine($"Содержимое файла {fileName}:");
//    Console.WriteLine(content);
//}

//void DeleteFile()
//{
//    Console.WriteLine("Введите имя файла для удаления:");
//    string fileName = Console.ReadLine();
//    File.Delete(fileName);
//    Console.WriteLine($"Файл {fileName} успешно удален.");
//}

//void CreateFolder()
//{
//    Console.WriteLine("Введите имя директории для создания:");
//    string directoryName = Console.ReadLine();
//    Directory.CreateDirectory(directoryName);
//    Console.WriteLine($"Директория {directoryName} успешно создана.");
//}

//void RemoveFolder()
//{
//    Console.WriteLine("Введите имя директории для удаления:");
//    string directoryName = Console.ReadLine();
//    Directory.Delete(directoryName, true);
//    Console.WriteLine($"Директория {directoryName} успешно удалена.");
//}

//
using System.IO;

static void Main(string[] args)
{
    Random random = new Random();
    string alphabet = "abcdefjhigklmnopqrstuvwxyz";
    int lenght = 10;
    string result = "";
    for (int i = 0; i < lenght; i++)
    {
        result += alphabet[random.Next(0, alphabet.Length)];
    }

    if (Directory.Exists(result))
    {
        result = "";
        for(int i = 0;i < lenght; i++) 
        {
            result += alphabet[random.Next(0, alphabet.Length)];
        }
    }
    return result;
}
