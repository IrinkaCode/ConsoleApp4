//Урок 1
//Дано слово, состоящее только из строчных букв. Проверьте, является ли это слово палиндромом.
//Выведите Is a palindrom если слово таковым является и Not a palindrom в противном случае.

//Console.Write("Введите слово: ");
//string word = Console.ReadLine();

//if (IsPalindrome(word))
//{
//    Console.WriteLine("Is a palindrom");
//}
//else
//{
//    Console.WriteLine("Not a palindrom");
//}


//bool IsPalindrome(string word)
//{
//    int left = 0;
//    int right = word.Length - 1;

//    while (left < right)
//    {
//        if (word[left] != word[right])
//        {
//            return false;
//        }

//        left++;
//        right--;
//    }

//    return true;
//}



//Урок 2
//Напишите программу, где:
//На ввод берется число от пользователя и передается в функцию.
//Функция должна выводить все нечетные числа от 1 до этого числа не включительно и делать это рекурсивно.

//void Main()
//{
Console.Write("Введите число: ");
int max = int.Parse(Console.ReadLine());
Print(1, max-1);
//}

void Print(int min, int max)
{
    if (min > max)
    {
        return;
    }

    if (min % 2 != 0)
    {
        Console.Write(min + " ");
    }

    Print(min + 1, max);
}
