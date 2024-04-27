//Урок 1
//Рядом с основным классом Program создайте класс RubleConverter и в нем опишите статические методы:
//ToDollars
//ToEuros
//ToZlotys
//ToYuan
//ToRupes
//Которые должны будут конвертировать рубли в указанную валюту

Console.Write("Введите количество рублей: ");
double rubles;
double.TryParse(Console.ReadLine(), out rubles);
Console.Write("");
public class RubleConverter
{
    private double Dollar = 0.011;
    private double Euro = 0.010;
    private double Zloty = 0.044;
    private double Yuan = 0.073;
    private double Rupee = 0.9;
    public double ToDollars(double rubles)
    {
        return rubles * Dollar;
    }
    public double ToEuros(double rubles)
    {
        return rubles * Euro;
    }

    public double ToZlotys(double rubles)
    {
        return rubles * Zloty;
    }

    public double ToYuan(double rubles)
    {
        return rubles * Yuan;
    }

    public double ToRupes(double rubles)
    {
        return rubles * Rupee;
    }
}