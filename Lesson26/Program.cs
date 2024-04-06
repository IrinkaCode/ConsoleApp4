//Работа с файловой системой

//синхронное чтение
//using System.Text;
//using (FileStream fs=new FileStream("file.txt",FileMode.Open))
//{
//    byte[] b= new byte[fs.Length];
//    UTF8Encoding temp = new UTF8Encoding(true);
//    while(fs.Read(b, 0, b.Length) > 0)
//    {
//        Console.WriteLine(temp.GetString(b));
//    }
//}

//асинхронная запись в файл
//using System.Text;
//Console.Write("Введите текст: ");
//string text = Console.ReadLine();
//using(FileStream fStream= new FileStream("First.txt", FileMode.OpenOrCreate))
//{
//    byte[] buffer = Encoding.Default.GetBytes(text);
//    await fStream.WriteAsync(buffer, 0, buffer.Length);
//    Console.WriteLine("Файл сохранен");
//}

////асинхронное чтение из файла
//using System.Text;
//using (FileStream fStream = new FileStream("First.txt", FileMode.Open))
//{
//    byte[] buffer = new byte[fStream.Length];
//    await fStream.WriteAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.WriteLine(text);
//}

////асинхронное чтение части файла 
////using System.Text;
//using (FileStream fStream = new FileStream("First.txt", FileMode.Open))
//{
//    fStream.Seek(-10, SeekOrigin.End);
//    byte[] buffer = new byte[10];
//    await fStream.WriteAsync(buffer, 0, buffer.Length);
//    string text = Encoding.Default.GetString(buffer);
//    Console.WriteLine(text);
//}


//Работа с текстовыми файлами

//Console.Write("Введите текст: ");
//string text = Console.ReadLine();
////перезапись файла
//using (StreamWriter write = new StreamWriter("First.txt", false))
//{
//    await write.WriteAsync(text);
////добавление в файл
//using (StreamWriter write = new StreamWriter("First.txt", false))
//{
//    await write.WriteLineAsync(" на лапу Азора");
//}

//чтение из файла
//using(StreamReader reader=new StreamReader("First.txt"))
//{
//    string text = await reader.ReadToEndAsync();
//    Console.WriteLine(text);
//}
//using (StreamReader reader = new StreamReader("First.txt"))
//{
//    string text = "";
//    while ((text = await reader.ReadLineAsync()) != null)
//    {
//        Console.WriteLine(text);
//    }
//}

//работа с дисками
//DriveInfo[] drives = DriveInfo.GetDrives();
//foreach (DriveInfo drive in drives)
//{
//    Console.WriteLine(drive.Name);
//    Console.WriteLine(drive.DriveType);
//    if(drive.IsReady)
//    {
//        Console.WriteLine($"{drive.TotalSize/1024} кБайт");
//        Console.WriteLine(drive.TotalFreeSpace);
//        Console.WriteLine(drive.VolumeLabel);
//    }
//    Console.WriteLine();
//}

//string dirName = @"C:\";                              // проверить
//if (Directory.Exists(@"C:\"))
//{
//    Console.WriteLine("Папки: ");
//    string[] dirs = Directory.GetDirectories();
//    foreach (string dir in dirs)
//    {
//        Console.WriteLine(dir);
//    }
//    Console.WriteLine("Файлы: ");
//    string[] files = Directory.GetFiles(dirName);
//    foreach (string file in files)
//    {
//        Console.WriteLine(file);
//    }
//}

////DirectoryInfo                                     //проверить
//DirectoryInfo dirInfo =new DirectoryInfo(dirName);
//if (dirInfo.Exists)
//{
//    Console.WriteLine("Папки: ");
//    DirectoryInfo[] dirs = dirInfo.GetDirectories();
//    foreach (DirectoryInfo dir in dirs)
//    {
//        Console.WriteLine(dir.FullName);
//    }
//    Console.WriteLine("Файлы: ");
//    FileInfo[] files = dirInfo.GetFiles();
//    foreach (FileInfo file in files)
//    {
//        Console.WriteLine(file.Name);
//    }
//}

//3 копирование файла
//string file1 = "File.txt";
//string file2 = "First.txt";
//FileInfo fi=new FileInfo(file1);
//if (fi.Exists )
//{
//    fi.CopyTo(file2,true);
//}


//4 поиска файла по расширению
using System.Runtime;

Console.WriteLine("Введите путь к папке: ");
string path=Console.ReadLine();
DirectoryInfo dirInfo = new DirectoryInfo($@"{path}");
FileInfo[] files = dirInfo.GetFiles();
Console.Write("Введите расширение для поиска: ");
string extension = Console.ReadLine();
foreach(FileInfo file in files)
{
    if (file.Extension == extension) Console.WriteLine(file.FullName);
}
