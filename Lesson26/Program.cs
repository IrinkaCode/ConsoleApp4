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

//асинхронное чтение из файла
using System.Text;
using (FileStream fStream = new FileStream("First.txt", FileMode.Open))
{
    byte[] buffer = new byte[fStream.Length];
    await fStream.WriteAsync(buffer, 0, buffer.Length);
    string text = Encoding.Default.GetString(buffer);
    Console.WriteLine(text);
}

//асинхронное чтение части файла 
//using System.Text;
using (FileStream fStream = new FileStream("First.txt", FileMode.Open))
{
    fStream.Seek(-10, SeekOrigin.End);
    byte[] buffer = new byte[10];
    await fStream.WriteAsync(buffer, 0, buffer.Length);
    string text = Encoding.Default.GetString(buffer);
    Console.WriteLine(text);
}
