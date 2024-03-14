//Строки
//1
//Напишите программу, которая запрашивает у пользователя ввод строки и слова. Затем программа должна использовать метод Contains() для проверки, содержит ли введенная строка указанное слово. Выведите сообщение о результате проверки наличия слова в строке.
//Console.Write("Введите строку: ");
//string text =Console.ReadLine();
//Console.Write("Введите слово: ");
//string word = Console.ReadLine();
//string result = "Результат:";
//if (text.Contains(word)) result += "Строка содержит указанное слово.";
//else result += "Строка не содержит указанное слово";
//Console.WriteLine(result);

//2
//Напишите программу, которая запрашивает у пользователя ввод строки
//и символа, который нужно заменить, а также символа, на который
//нужно заменить.
//Затем программа должна использовать метод Replace() для замены указанного символа на другой символ во введенной строке. Выведите обновленную строку на экран.
//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//Console.Write("Введите символ для замены: ");
//char s = char.Parse(Console.ReadLine());
//Console.Write("Введите символ на который нужно заменить: ");
//char c = char.Parse(Console.ReadLine());
//text = text.Replace(s, c);
//Console.WriteLine(text);

//3
//Напишите программу, которая запрашивает у пользователя ввод строки и слова. Затем программа должна использовать метод Contains() и цикл для подсчета количества вхождений указанного слова во введенной строке. Выведите количество вхождений на экран.

//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//Console.Write("Введите слово для подсчета: ");
//string word = Console.ReadLine();
//string[] mas = text.Split(" ");
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Contains(word)) count++;
//}
//Console.WriteLine("Количество вхождений: "+count);
////2 вариант
//count = 0;
//int index = 0;
//while (text.IndexOf(word,index) !=-1)
//{
//        count++;
//        index = text.IndexOf(word, index) + word.Length;
//}
//Console.WriteLine("Количество вхождений: " + count);

//4
//Напишите программу, которая запрашивает у пользователя слово и заменяет все его вхождения на * посимвольно.
//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//Console.Write("Введите слово для замены: ");
//string word = Console.ReadLine();
//int index = 0;
//string replace = "";
//foreach (var item in word) replace += "*";
//text = text.Replace(word, replace);
//Console.WriteLine(text);

//урок 2
//4
//Console.Write("Введите строку: ");
//string text = Console.ReadLine();
//string[] mas = text.Split(' ');
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Contains(',')) Console.WriteLine(double.Parse(mas[i]).GetType);
//    else Console.WriteLine(int.Parse(mas[i]).GetType);
//}

