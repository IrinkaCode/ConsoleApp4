//Тема 27. Методы. Практика
//Задание 1.
//Создайте класс "Генератор случайных чисел", содержащий методы для генерации случайных чисел разных типов, таких как целые числа,вещественные числа, булевы значения и т.д. Напишите код, которыйиспользует эти методы для генерации случайных чисел.

//RandomClass rc = new RandomClass();
//Console.WriteLine(rc.RandomInt(100));
//Console.WriteLine($"{rc.RandomDouble(200):F2}");
//Console.WriteLine(rc.RandomBool());
//class RandomClass
//{
//    private Random random;

//    public RandomClass()
//    {
//        random = new Random();
//    }
//    public int RandomInt(int n) => random.Next(n);
//    public double RandomDouble(int n) => random.NextDouble() * n;
//    public bool RandomBool() => (random.Next(0, 2) == 0) ? false : true;
//}

//Тема 27. Методы. Практика
//Задание 1.
//Создайте класс "Генератор случайных чисел", содержащий методы для
//генерации случайных чисел разных типов, таких как целые числа,
//вещественные числа, булевы значения и т.д. Напишите код, который
//использует эти методы для генерации случайных чисел.

//int? d = null;
//int x = d ?? 0;
////string? str = Console.ReadLine();
//string str = Console.ReadLine()!;
//string res = str ?? "";
//Console.WriteLine(x);
//Console.WriteLine(res);

//RandomClass rc = new RandomClass();
//Console.WriteLine(rc.RandomInt(int.Parse(Console.ReadLine()!)));
//Console.WriteLine($"{rc.RandomDouble(200):F2}");
//Console.WriteLine(rc.RandomBool());
//class RandomClass
//{
//    private Random random;

//    public RandomClass()
//    {
//        random = new Random();
//    }
//    public int RandomInt(int n) => random.Next(n);
//    public double RandomDouble(int n) => random.NextDouble() * n;
//    public bool RandomBool() => (random.Next(0, 2) == 0) ? false : true;
//}


//Задание 2.
//Создайте класс, для работы со строкой, содержащий методы переворота строки, проверки на палиндром, разбиения строки на части, переводящий всю строку в верхний регистр или нижний, режущий строку по индексу элемента, производящий поиск по слову.
                             // дописать из гитхаба 2 вариант который короче и переписать полностью верх до класса
using System.Text;
Console.Write("Введите строку: ");
MyString myString=new MyString(Console.ReadLine()!);
Console.WriteLine(myString.Reverse());
Console.WriteLine(myString.IsPolindrom()?"Полиндром":"Не полиндром");
Console.Write("Введите символ: ");
char c = char.Parse(Console.ReadLine()!);
foreach (var item in myString.Split(c))
{
    Console.WriteLine(item);
}
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
foreach (var item in myString.Split(str))
{
    Console.WriteLine(item);
}
Console.Write("Введите индекс: ");
int index=int.Parse(Console.ReadLine()!);


class MyString
{
    private string str;
    public MyString(string str)
    {
        this.str = str;
    }
    public string Reverse()
    {
        string res = "";
        for (int i = str.Length - 1; i >= 0; i--) res += str[i];
        return res;
    }
    public bool IsPolindrom()
    {
        if (Reverse() == str) return true;
        else return false;
    }
    public string[] Split(char c)
    {
        return str.Split(c);
    }
    public string[] Split(string c)
    {
        return str.Split(c);
    }
    public string ToUpper()
    {
        return str.ToUpper();   
    }
    public string ToLower()
    {
        return str.ToLower();
    }
    public string[] Split(int index)
    {
        if (index >= 0 && index <= str.Length - 1)
        {
            char c = str[index];
            return str.Split(c);
        }
        else throw new Exception("Выход за границы строки");     
    }
    public bool Find(string word) => str.Contains(word);
}


