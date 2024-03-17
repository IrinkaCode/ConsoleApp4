//Урок 1
//Напишите программу, составляющую из, циклично вводимых пользователем слов, предложение, записывающую его в переменную, и в случае нахождения значений, введенных пользователем в массив,заменяющую их на “(скрыто)”

//string[] forbiddenWords = { "слово1", "слово2", "слово3" };
//string sentence = "";
//while (true)
//{
//    Console.Write("Введите слово (для завершения введите 'конец'): ");
//    string word = Console.ReadLine();
//    for (int i = 0; i < forbiddenWords.Length; i++)
//    {
//        if (word == forbiddenWords[i])
//        {
//            word = "(скрыто)"; 
//            break;
//        }
//        if (word == "конец")
//        {
//            break;
//        }
//        sentence += word + " ";
//    }
//    Console.WriteLine("Сформированное предложение: " + sentence);
//}



//Урок 2
//Напишите программу, которая принимает от пользователя строку,содержащую числа, разделенные запятой. Используя метод Split(),разделите строку на отдельные числа и найдите их сумму. Выведите полученную сумму на экран.
//1 вариант
//Console.WriteLine("Введите числа, разделенные запятой:");
//string input = Console.ReadLine();

//string[] numbers = input.Split(',');
//int sum = 0;

//foreach (string number in numbers)
//{
//    if (int.TryParse(number, out int num))
//    {
//        sum += num;
//    }
//}
//Console.WriteLine($"Сумма чисел: {sum}");


//2 вариант
//Console.WriteLine("Введите строку чисел, разделенных запятой:");
//string input = Console.ReadLine();

//string[] numbers = input.Split(',');
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (int.TryParse(numbers[i], out int number))
//    {
//        sum += number;
//    }
//}

//Console.WriteLine($"Сумма чисел: {sum}");