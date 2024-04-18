//Память.Рекурсия
//static void Main(string[] args)
//{
//    PrintSome(1);
//    void PrintSome(int number)
//    {
//        Console.WriteLine("Текущая итерация: " + number);
//        number++;

//        if(number>5000)
//        {
//            return;
//        }
//        PrintSome(number);
//    }
//}


///1 Дано число 10.Введите на экран все числа от 0 до 10 используя рекурсию
//int number = 10;

//Decreaser(0, number);
//void Decreaser(int min,int max)
//{
//    Console.Write(min+" ");
//    min++;
//    if (min > max)
//    {
//        return;
//    }

//    Decreaser(min, max);
//}

////2 Создайте рекрусивную функцию,выводящую на консоль алфавит в строку
//string alphabet = "abcdifghijklmnopqrstyvwxuz";

//Printer(alphabet, 0);
//void Printer(string alphabet, int index)
//{
//    Console.Write(alphabet[index]+" ");
//    index++;
//    if ( index == alphabet.Length)
//    {
//        return;
//    }
//    Printer(alphabet, index);
//}

//3
//Console.Write("Введите число a: ");
//int a=int.Parse(Console.ReadLine());
//Console.Write("Введите число b: ");
//int b = int.Parse(Console.ReadLine());


////5 Дано натуральное число N. Вычислите сумму его цифр

//int number = 5;
//int sum =0;
//Summator (0,number);
//void Summator(int border,int start=1,int sum=0)
//{
//    sum += start;
//    start++;
//    {
//        if(start>border)
//        {
//            Console.WriteLine(sum);
//            return;
//        }
//        Summator (border,start,sum);
//    }
//}

//1
//Создайте рекурсивную функцию, которая возводит число в степень.
//Пример, где функция возвращает результат 4^5:
//Recursion(4, 5)

int number = 4;
int power = 5;

GetPower(4, 5);
void GetPower(int number,int power,int result=1)
{
    result *= number;
    power--;
    {
        if (power == 0)
        {
            Console.WriteLine(result);
            return;
        }
        GetPower(number, power, result);
    }
}
