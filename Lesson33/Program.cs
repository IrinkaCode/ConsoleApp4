//Person person1 = new Person();
//Console.Write("Введите ФИО: ");
//string fio=Console.ReadLine();
//person1.setFIO(fio);
//Console.WriteLine(person1.getFIO());
//class Person
//{
//    private string FIO;
//    private int age;
//    private double rost;
//    private double weight;

//    public string getFIO()
//    {
//        return FIO;
//    }
//    public void setFIO(string fio)
//    {
//        FIO = fio;
//    }
//    public int getAge() 
//    {
//        return age;
//    }

//    public void setAge(int a)
//    {
//        age = a;
//    }
//    public double getRost(double r) 
//    {
//        return rost; 
//    }
//    public void setRost(double r)
//    {
//        rost = r;
//    }
//    public double getWeight()
//    {
//        weight = Massa();
//        return Massa();
//    }
//    private double Massa()
//    {
//        return rost - 100;
//    }
//    //private int Massa()       ////перегрузка метода
//    //{
//    //    return (int)(rost - 100);
//    //}
//}


//1
//Console.Write("Введите x: ");
//double x, y;
//double.TryParse(Console.ReadLine(), out x);
//Console.Write("Введите y: ");
//double.TryParse(Console.ReadLine(), out y);
//Calculator calc=new Calculator(x,y);
//Console.WriteLine(calc.Add());
//Console.WriteLine(calc.Sub());
//Console.WriteLine(calc.Mult());
//Console.WriteLine(calc.Div());

//class Calculator
//{
//    private double X;
//    private double Y;

//    public Calculator(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }
//    public double Add()
//    {
//        return X + Y;
//    }
//    public double Mult() 
//    {
//        return X * Y;
//    }
//    public double Div() 
//    {
//        return X / Y;
//    }
//    public double Sub()=> X - Y;    

//}


//2
//Console.Write("Введите строку:");
//string str = Console.ReadLine();
//StringAnalizer analiz = new StringAnalizer(str);
//Console.WriteLine(analiz.getLength());
//Console.Write("Введите подстроку:");
//string sub = Console.ReadLine();
//Console.WriteLine(analiz.SubStr(sub));
//Console.WriteLine(analiz.OurToLower());
//Console.WriteLine(analiz.OurToUpper());
//class StringAnalizer
//{
//    private string Stroka;
//    public StringAnalizer(string stroka)
//    {
//        Stroka = stroka;
//    }
//    public int getLength()
//    {
//        return Stroka.Length;
//    }
//    public bool SubStr(string substr)
//    {
//        return Stroka.Contains(substr);
//    }
//    public string OurToUpper()
//    {
//        return Stroka.ToUpper();
//    }
//    public string OurToLower()
//    {
//        return Stroka.ToLower();
//    }
//}

//1 дописать из гита
//Random random = new Random();
//int[] mas = new int[random.Next(10,20)];
//mas = mas.Select(i => i + random.Next(10, 100)).ToArray();
//Arrays arrays = new Arrays(mas);
//arrays.Print();
//Console.WriteLine("min=" + arrays.Min());
//Console.WriteLine("max=" + arrays.Max());
//arrays.Sort();
//arrays.Print();
//Console.WriteLine("sum=" + arrays.Sum());
//class Arrays
//{
//    private int[] mas;

//    public Arrays(int[] mas)
//    {
//        this.mas = mas;
//    }
//    public int Sum()
//    {
//        return mas.Sum();
//    }
//    public int Max()
//    {
//        return mas.Max();
//    }
//    public int Min() 
//    {
//        return mas.Min();
//    }
//    public void Sort()
//    {
//        Array.Sort(mas);
//    }
//    public void Print()
//    {
//        foreach (int item in mas) Console.WriteLine(item + " ");        
//        Console.WriteLine();
//    }
//}

//2
//файловый менеджер   дописать
using System;
using System.IO;
using System.Text;
Console.Write("Введите название файла:");
string file = Console.ReadLine();
string path = Environment.CurrentDirectory + @"\" + file + ".txt";
FileManager fm = new FileManager(path);
fm.Write("Hello");
Console.WriteLine(fm.Read());

class FileManager
{
    private string fileName;

    public FileManager(string f)
    {
        fileName = f;
    }
    public bool Exists()
    {
        FileInfo fi = new FileInfo(fileName);
        return fi.Exists;
    }
    public async void Write(string text)
    {
        FileInfo fi = new FileInfo(fileName);
        if (fi.Exists)
        {
            using (FileStream fs = fi.OpenWrite())
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                await fs.WriteAsync(buffer, 0, buffer.Length);
            }
        }
        else
        {
            using (FileStream fs = fi.Create())
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                await fs.WriteAsync(buffer, 0, buffer.Length);
            }
        }
    }
    public string Read()
    {
        FileInfo fi = new FileInfo(fileName);
        byte[] buffer = null;
        if (fi.Exists)
        {
            using (FileStream fs = fi.OpenRead())
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
            }
        }
        return Encoding.Default.GetString(buffer);
    }
}