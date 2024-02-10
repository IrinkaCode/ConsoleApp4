//Console.Write("Введите номер дня недели:");
//byte n=byte.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1: Console.WriteLine("Понедельник"); break;
//    case 2: Console.WriteLine("Вторник"); break;
//    case 3: Console.WriteLine("Среда"); break;
//    case 4: Console.WriteLine("Четверг"); break;
//    case 5: Console.WriteLine("Пятница"); break;
//    case 6: Console.WriteLine("Суббота"); break;
//    case 7: Console.WriteLine("Воскресенье"); break;
//    default: Console.WriteLine("Такого дня недели нет");break;
//}

//Console.Write("Введите месяц года:");
//byte n = byte.Parse(Console.ReadLine());
//Console.WriteLine("Введите температуру");
//double t=double.Parse(ConsoleReadLine());

//switch (n)
//{
//    case 1: case 2:case 12:  Console.WriteLine("Зима"); break;
//    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
//    case 9: case 10: case 11: Console.WriteLine("Осень"); break;

//    default: Console.WriteLine("Такого месяца нет"); break;
//}


//1
//Random random = new Random();
//Console.WriteLine("Выберите какие числа сгенерировать\n" + "1-целые\n" + "2- с плавающей точкой\n" + "3-числа в диапазоне\n");
//Console.Write("Введите число:");
//byte n=byte.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        {
//            Console.Write("Введите максимальное значение:");
//            int max= int.Parse(Console.ReadLine());
//            Console.WriteLine(random.Next(max) + 1);
//        }
//        break;
//    case 2:
//        {
//            Console.Write("Введите максимальное значение:");
//            int max = int.Parse(Console.ReadLine());
//            Console.WriteLine($"{random.NextDouble() * max:F2}");
//        }
//        break;
//    case 3:
//        {
//            Console.Write("Введите минимальное значение:");
//            int min = int.Parse(Console.ReadLine());
//            Console.Write("Введите максимальное значение:");
//            int max = int.Parse(Console.ReadLine());
//            if(max<min)
//            {
//                int temp = max;
//                max = min;
//                min = temp;
//            }
//            Console.WriteLine($"{random.Next(min,max)}");
//        }
//        break;
//    default:
//        Console.WriteLine("Такого варианта нет");break;

//}

//3
//Random random = new Random();
//int x = random.Next(11);
//Console.Write("Введите число: ");
//int a = int.Parse(Console.ReadLine());
//int n;
//if (a == x) n = 0;
// else if(a>x) n = 1;
//else n = -1;
//switch (n)
//{
//    case 1: Console.WriteLine("Больше"); break;
//    case -1: Console.WriteLine("Меньше"); break;
//    case 0: Console.WriteLine("Равно"); break;
//}

//2
//Console.WriteLine("Выберете валюту\n 1 - доллары\n2 - с евро\n3 - рубли\n4 - юани\n5 - стерлинги");
//Console.Write("Введите номер:");
//byte num = byte.Parse(Console.ReadLine());
//Console.Write("Введите курс обмена:\n");
//double curs = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество");
//int quantity = int.Parse(Console.ReadLine());
//switch (num)
//{
//    case 1:
//        Console.WriteLine($"{quantity} долларов = {curs * quantity}");
//        break;
//    case 2:
//        Console.WriteLine($"{quantity} евро = {curs * quantity}");
//        break;
//    case 3:
//        Console.WriteLine($"{quantity} рублей = {curs * quantity}");
//        break;
//    case 4:
//        Console.WriteLine($"{quantity} юаней = {curs * quantity}");
//        break;
//    case 5:
//        Console.WriteLine($"{quantity} стерлингов = {curs * quantity}");
//        break;
//    default:
//        Console.WriteLine("Нет такого варианта");
//        break;
//}


//1
//Console.Write("Введите камень,ножноцы или бумага: ");
//string user = Console.ReadLine();
//Random random = new Random();
//string pc=" ";
//switch(random.Next(1,4))
//{
//    case 1:pc = "Камень";break;
//    case 2: pc = "Камень"; break;
//    case 3: pc = "Камень"; break;
//}
////if(user==pc) Console.WriteLine("Ничья");
////else if (user=="ножницы"&&pc=="бумага") Console.WriteLine("Вы выиграли");
//Console.WriteLine(user + " " + pc);

//2
//Random random = new Random();
//int sum = 0;
//////int n = random.Next(100);
//////int m = random.Next(100);
//////int var = 0;
//////switch (random.Next(1,5))
//////{
//////    case 1: { var = n + m; Console.WriteLine($"{n}+{m}="); }break;
//////    case 2: { var = n - m; Console.WriteLine($"{n}-{m}="); } break;
//////    case 3: { var = n * m; Console.WriteLine($"{n}*{m}="); } break;
//////    case 4: { var = n / m; Console.WriteLine($"{n}/{m}="); } break;
//////}
//    Console.Write("Введите ответ: ");
//    int res = int.Parse(Console.ReadLine);
//    if (res == var) sum++;

//Console.WriteLine($"Ваш результат:{sum}");
//switch(sum)
//{
//    case 0: case 1:
//        Console.WriteLine("Единица");
//    case 2:
//        Console.WriteLine("Два");
//    case 3:
//        Console.WriteLine("Три");
//    case 4:
//        Console.WriteLine("Четыре");
//    case 5:
//        Console.WriteLine("Пять");
//}

//Console.Write("Введите количество месяцев прошедших с начала 1900 года: ");
//int n= int.Parse(Console.ReadLine());
//switch (n % 12 + 1)
//{
//    case 1: Console.WriteLine("Январь"); break;
//    case 2: Console.WriteLine("Январь"); break;
//    case 13: Console.WriteLine("Январь"); break;
//}

//Console.Write("Введите сумму: ");
//int rub=int.Parse(Console.ReadLine()); 
//if(rub%100>=11&&rub%100<=14) Console.WriteLine($"{rub} рублей");
//else
//switch (rub%10)
//{
//    case 1:
//        Console.WriteLine($"{rub} рубль");break;
//    case 2: case 3: case 4:
//        Console.WriteLine($"{rub} рубля");break;
//    default:
//        Console.WriteLine($"{rub} рублей");break;

//}

//4.110
Console.WriteLine("Введите номер масти: ");
int m=int.Parse(Console.ReadLine());
int k=int.Parse(Console.ReadLine());
switch (m)
{
    case 6:
        Console.Write("шесть ");break;
    case 7:
        Console.Write("семь");break;
    case 8:
        Console.Write("восемь");break;
    case 9:
        Console.Write("девять");break;
    case 10:
        Console.WriteLine("десять");break;
    case 11:
        Console.WriteLine("Валет");break;
    case 12:
        Console.WriteLine("Дама"); break;
    case 13:
        Console.WriteLine("Король"); break;
    case 14:
        Console.WriteLine("Туз"); break;

}
switch(k)
{
    case 1:
        Console.WriteLine("Пики");break;
    case 2:
        Console.WriteLine("");
}