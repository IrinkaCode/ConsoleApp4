//Урок 2
Random random=new Random();
int temperature = 0;
for (int i = 1; i <= temperature; i++)
{
    int temp = random.Next(1, 101);
    Console.Write(temp + " ");
    {

    }
    if (temperature <= 0) Console.WriteLine($"Сгенерированная температура: {temperature}");


    if (temperature >= 90) break;
    Console.WriteLine("Устройство остановлено");
    Console.WriteLine($"Критическая температура: {temperature}");
}


//Random random = new Random();
//int temperature = random.Next(1, 101);
//Console.WriteLine($"Сгенерированная температура: {temperature}");
//for (int i = 1; i <= temperature; i++)
//{
//    if (temperature > 90) break;
//    Console.WriteLine("Устройство остановлено");
//    Console.WriteLine($"Критическая температура: {temperature}");
//}

//Random random = new Random();
//int temperature = random.Next(1, 101);

//for (int i = 1; i <= temperature; i++)
//{
//    if (temperature > 90)
//        Console.WriteLine($"Критическая температура: {temperature}"); break;
//    else
//        Console.WriteLine($"Текущая температура: {temperature}");
//}     