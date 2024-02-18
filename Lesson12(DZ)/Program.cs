//тема 12 Урок 1

//Console.Write("Введите первое число: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите операцию +,-,* или /: ");
//char oper = char.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//double b = double.Parse(Console.ReadLine());

//switch(oper)
//{
//    case '+':
//        Console.WriteLine($"{a}+{b}={a + b}");break;
//    case '-':
//        Console.WriteLine($"{a}-{b}={a - b}"); break;
//    case '*':
//        Console.WriteLine($"{a}*{b}={a * b}"); break;
//    case '/':
//        Console.WriteLine($"{a}/{b}={a / b}"); break;
//    default: 
//        Console.WriteLine("Неправильный оператор!");break;
//}


//Тема 12 Урок 2

Console.WriteLine("Введите номер аромата:\n1-Chanel\n2-Dior\n3-Tom Ford\n4-Gucci\n5-Yves Saint Laurent");
byte num=byte.Parse(Console.ReadLine());

switch(num)
{
    case 1: Console.WriteLine("Chanel - Классика на века!");break;
    case 2: Console.WriteLine("Dior - Потрясающие ароматы,получившие признание");break;
    case 3: Console.WriteLine("Tom Ford - Элитный,популярный и дорогой парфюм");break;
    case 4: Console.WriteLine("Gucci - Невероятной красотой парфюмерная композиция");break;
    case 5: Console.WriteLine("Yves Saint Laurent - Удивительно глубокий завораживающий аромат");break;
    default: Console.WriteLine("В списке только пять видов ароматов духов!");break;
}