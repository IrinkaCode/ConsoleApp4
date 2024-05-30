//Задание
//Создайте перечисление месяцев Month и к каждому присвойте числовое значение порядкового номера месяца, например:January = 1;
//Затем:
//1.Выведите на экран список месяцев и их порядковые номера, используя цикл for и метод Enum.GetValues(). Для каждого месяца выведите его имя и соответствующее числовое значение.
//Сделать это с помощью следующей конструкции:Console.WriteLine($"Выбран месяц: {selectedMonth}");
//2.Запросите у пользователя ввод порядкового номера месяца с помощью метода Console.ReadLine() и преобразуйте его в тип int.
//Проверьте, является ли введенное значение допустимым номером месяца, используя метод Enum.IsDefined(). Если введенное значение является допустимым, преобразуйте его в тип Month и выведите выбранный месяц на экран. Если введенное значение недопустимо,выведите сообщение о недопустимом номере месяца.


using System;
public enum Month
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12
}

public class Program
{
    public static void Main()
    {
        Array months = Enum.GetValues(typeof(Month));

        for (int i = 0; i < months.Length; i++)
        {
            Month selectedMonth = (Month)months.GetValue(i)!;
            Console.WriteLine($"Выбран месяц: {selectedMonth}, Номер: {(int)selectedMonth}");
        }
       
        Console.Write("Введите порядковый номер месяца: ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out int monthNumber))
        {
            if (Enum.IsDefined(typeof(Month), monthNumber))
            {
                Month selectedMonth = (Month)monthNumber;
                Console.WriteLine($"Выбран месяц: {selectedMonth}");
            }
            else
            {
                Console.WriteLine("Недопустимый номер месяца.");
            }
        }
        else
        {
            Console.WriteLine("Введенное значение не является числом.");
        }
    }
}

