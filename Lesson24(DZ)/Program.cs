//Урок 1
//Дано слово, состоящее только из строчных букв. Проверьте, является ли это слово палиндромом.
//Выведите Is a palindrom если слово таковым является и Not a palindrom в противном случае.

Console.Write("Введите слово: ");
string UserWord = Console.ReadLine();

IsPalindrom(UserWord,0,UserWord.Length-1);
void IsPalindrom(string UserWord,int minIndex,int maxIndex)
{
    if (UserWord[minIndex] == UserWord[maxIndex])
    {
        minIndex++;
        maxIndex--;
        Console.WriteLine($"{UserWord} - Is a palindrom.");
    }
    else
    {
        Console.WriteLine($"{UserWord} - Not a palindrom.");
    }
    if (UserWord[minIndex] == UserWord[maxIndex] || UserWord[minIndex] != UserWord[maxIndex])
    {
        return;
    }
    IsPalindrom(UserWord, minIndex, maxIndex - 1);
}


//Урок 2
//Напишите программу, где:
//На ввод берется число от пользователя и передается в функцию.
//Функция должна выводить все нечетные числа от 1 до этого числа не включительно и делать это рекурсивно.

//Console.Write("Введите число: ");
//int max = int.Parse(Console.ReadLine());
//Print(1, max-1);

//void Print(int min, int max)
//{
//    if (min > max)
//    {
//        return;
//    }

//    if (min % 2 != 0)
//    {
//        Console.Write(min + " ");
//    }

//    Print(min + 1, max);
//}
