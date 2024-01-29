//DZ Урок 1
//задача 1

//int Petia = 10;
//int Alesha = Petia - 4;
//int Vania = Alesha + 2;
//int total = Petia + Alesha + Vania;
//Console.WriteLine($"Петя взял {Petia} книг, Алеша взял {Alesha} книг, Ваня взял {Vania} книг.");
//Console.WriteLine($"Всего они взяли {total} книги");

//задача 2

//int firstBasket = 23;
//int secondBasket = firstBasket - 11;
//int total = firstBasket + secondBasket;
//Console.WriteLine($"В обеих корзинках {total} яблок");


//Урок 2
//задача 1

//int total = 13;
//int residue = 9;
//int eat = total - residue;
//Console.WriteLine($"Съели {eat} яиц");

//задача 2

//int widthMagazine = 25;
//int widthNewspaper = widthMagazine - 16;
//Console.WriteLine($"Ширина газеты {widthNewspaper} см");

//задача 3

//int potatoes = 44;
//int beet = potatoes / 4;
//int onion = beet / 2;
//Console.WriteLine($"{onion} килограмм лука потратил повар");


//Урок3
//задача 1

//Console.Write($"Введите целое число: ");
//int number = int.Parse(Console.ReadLine());
//int result = number % 8;
//Console.WriteLine(result);

//задача 2


//Console.WriteLine("Введите три числа:");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int summa = a + b + c;
//int multiplication = a * b * c;
//Console.WriteLine($"Сумма чисел равна:{summa}");
//Console.WriteLine($"Произведение чисел равно:{multiplication}");


//Урок 4
//задание 1

using System.ComponentModel.Design;

decimal butter = 150;
decimal bread = 50;
decimal tea = 40;

Console.Write("Введите количество монет: ");
decimal money = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Хлеб:{bread}\nМасло:{butter}\nЧай:{tea}");
Console.Write("Введите количество хлеба:");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество масла:");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество чая:");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine($"{"Хлеб",-10} {bread,-8} {n1,-8} {n1 * bread}");
Console.WriteLine($"{"Масло",-10} {butter,-8} {n2,-8} {n2 * butter}");
Console.WriteLine($"{"Чай",-10} {tea,-8} {n3,-8} {n3 * bread}");
Console.WriteLine($"{"Итого",-10}{n1 * bread + n2 * butter + n3 * tea}");
Console.WriteLine($"{"Сдача",-10}{money - (n1 * bread + n2 * butter + n3 * tea)}");

if (money < n1 * bread + n2 * butter + n3 * tea) 
{
    Console.WriteLine($"На вашем счету недостаточно средств");
}

