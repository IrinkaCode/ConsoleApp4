//Урок 2
//1
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
Console.Write("Укажите количество квадратов: ");//программа предлагает пользователю ввести количество квадратов
int quantity =Convert.ToInt32(Console.ReadLine());//сохраняем в переменной

Console.Write("Укажите сторону квадрата: ");//программа предлагает пользователю ввести длину стороны квадрата
int weigth = Convert.ToInt32(Console.ReadLine());//сохраняем в переменной

for (int i = 0; i < quantity; i++) //Внешний цикл для перебора указанного количества квадратов
{
    for(int j = 0; j < weigth; j++) //Внутренний цикл.Первый цикл создает верхний и нижний ряды квадрата.
    {
        Console.Write("*");//печать звездочек
        Console.Write(" ");//печать пробелов
    }
    Console.WriteLine();
    for (int k=0; k < weigth-2;k++) //Второй цикл внутренний цикл создает средние ряды квадрата с пустыми местами между ними.
    {
        Console.Write("*");//печать звездочек
        for (int l = 0; l < weigth + weigth - 2; l++) 
        {
            Console.Write(" ");
        }
        Console.Write("*");// печать звездочек
        Console.WriteLine();//печать пробелов
    }
    for(int m=0; m < weigth; m++)//Третий цикл создает нижний ряд квадрата.
    {
        Console.Write("*");//печать звездочек
        Console.Write(" ");//печать пробелов
    }
    Console.WriteLine();
}
