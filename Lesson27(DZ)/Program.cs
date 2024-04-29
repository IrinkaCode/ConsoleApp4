//Урок 1
//public

//private

//protected



//Рядом с основным классом Program создайте класс RubleConverter и в нем опишите статические методы:
//ToDollars
//ToEuros
//ToZlotys
//ToYuan
//ToRupes
//Которые должны будут конвертировать рубли в указанную валюту

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Укажите количество рублей: ");
//        decimal rubles = decimal.Parse(Console.ReadLine()!);

//        Console.WriteLine($"В долларах: {RubleConverter.ToDollars(rubles)}");
//        Console.WriteLine($"В евро: {RubleConverter.ToEuros(rubles)}");
//        Console.WriteLine($"В злотых: {RubleConverter.ToZlotys(rubles)}");
//        Console.WriteLine($"В юанях: {RubleConverter.ToYuan(rubles)}");
//        Console.WriteLine($"В рупиях: {RubleConverter.ToRupes(rubles)}");
//    }
//}

//class RubleConverter
//{
//    public static decimal ToDollars(decimal rubles)
//    {
//        return rubles * 0.011m;
//    }

//    public static decimal ToEuros(decimal rubles)
//    {
//        return rubles * 0.01m;
//    }

//    public static decimal ToZlotys(decimal rubles)
//    {
//        return rubles * 0.044m;
//    }

//    public static decimal ToYuan(decimal rubles)
//    {
//        return rubles * 0.073m;
//    }

//    public static decimal ToRupes(decimal rubles)
//    {
//        return rubles * 0.9m;
//    }
//}


//Урок 2
//Создайте класс "Банковский счет", содержащий методы для выполнения операций со счетом, такие как пополнение, снятие денег, проверка баланса и т.д. Напишите код, который использует эти методы для управления банковским счетом.Текущий баланс клиента задать как переменную.Манипулировать балансом, вызывая методы
using System;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal Balance)
    {
        if (balance < 0)
        {
            throw new ArgumentException("Баланс не может быть отрицательным!");
        }

        balance = Balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Баланс не может быть отрицательным!");
        }

        balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Баланс не может быть отрицательным!");
        }

        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }

        return false;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine($"Банковский счет: {balance} рублей");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000);
        account.PrintAccountInfo();

        account.Deposit(500);
        account.PrintAccountInfo();

        account.Withdraw(200);
        account.PrintAccountInfo();

        bool success = account.Withdraw(2000);
        Console.WriteLine($"Снятие денежных средств: {success}");
        account.PrintAccountInfo();
    }
}

//Урок 3

//Напишите класс "Numbers", содержащий методы для работы с числами.
//Класс должен иметь следующие методы:
//● CalculateAverage - метод, который принимает массив чисел и возвращает их среднее арифметическое.
//● IsPrime - метод, который принимает число и проверяет, является ли оно простым числом. Метод возвращает булево значение true, если число простое, и false в противном случае.
//● IsEven - метод, который принимает число и проверяет, является ли оно четным. Метод возвращает булево значение true, если число четное, и false в противном случае.
//● IsOdd - метод, который принимает число и проверяет, является ли оно нечетным. Метод возвращает булево значение true, если число нечетное, и false в противном случае.

//Урок 4

//Дополните класс "Numbers", из предыдущего ДЗ, содержащий методы для
//работы с числами следующими методами:
//● CalculateFactorial - метод, который принимает число и вычисляет его факториал. Метод возвращает результат вычисления факториала.
//● ConvertToBinary - метод, который принимает число и преобразует его в двоичное представление. Метод возвращает строку, содержащую двоичное представление числа.
//● ConvertToHex - метод, который принимает число и преобразует его в шестнадцатеричное представление. Метод возвращает строку,содержащую шестнадцатеричное представление числа.
//● CalculatePower - метод, который принимает основание и показатель степени, и вычисляет значение основания, возведенного в указанную степень. Метод возвращает результат возведения в степень.