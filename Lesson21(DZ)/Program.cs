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

