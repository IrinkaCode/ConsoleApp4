//Урок 2
//1
//Напишите программу, случайным образом генерирующую температуры от 1 до 100. В случае превышения, устройство останавливает работу с выводом значения критической температуры на экран.

//Random random = new Random();
//int temperature= 0 ;
//for (int i = 1; i >= temperature; i++)
//{
//    temperature = random.Next(1, 101);
//    Console.WriteLine($"Текущая температура: {temperature}");
//    {
//        if (temperature >90) Console.WriteLine($"Устройство становлено.Критическая температура: {temperature}"); break;
//    }
//}

//2

//Console.Write("Укажите количество квадратов: ");//программа предлагает пользователю ввести количество квадратов
//int quantity =Convert.ToInt32(Console.ReadLine());//сохраняем в переменной

//Console.Write("Укажите сторону квадрата: ");//программа предлагает пользователю ввести длину стороны квадрата
//int weigth = Convert.ToInt32(Console.ReadLine());//сохраняем в переменной

//for (int i = 0; i < quantity; i++) //Внешний цикл для перебора указанного количества квадратов
//{
//    for(int j = 0; j < weigth; j++) //Внутренний цикл.Первый цикл создает верхний ряд квадрата.
//    {
//        Console.Write("*");//печать звездочек
//        Console.Write(" ");//печать пробелов
//    }
//    Console.WriteLine();//переход на новую строку
//    for (int k=0; k < weigth-2;k++) //Второй цикл внутренний цикл создает средние ряды квадрата с пустыми местами между ними.
//    {
//        Console.Write("*");//печать звездочек
//        for (int l = 0; l < weigth + weigth - 2; l++) 
//        {
//            Console.Write(" ");//печать пробелов
//        }
//       Console.Write("*");// печать звездочек
//        Console.WriteLine();//переход на новую строку
//    }
//    for(int m=0; m < weigth; m++)//Третий цикл внутренний цикл создает нижний ряд квадрата.
//    {
//        Console.Write("*");//печать звездочек
//        Console.Write(" ");//печать пробелов
//    }
//    Console.WriteLine();//переход на новую строку
//}

// Урок 1
//Нужно разработать программу, которая будет генерировать пароли заданной длины для пользователей.



Console.Write("Введите длину пароля: ");
int passwordLength = int.Parse(Console.ReadLine());
string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
Random random = new Random();
string password = "";
for (int i = 0; i < passwordLength; i++)
{
    int index = random.Next(passwordLength);
    password += characters[i];
}
Console.WriteLine($"Ваш пароль: {password}");



