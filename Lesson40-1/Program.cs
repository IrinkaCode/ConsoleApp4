////Деревья 

//Console.Write("Введите путь: ");
//PrintDirectory(new DirectoryInfo(Console.ReadLine()!), "", true);


//void PrintDirectory(DirectoryInfo directory, string indent, bool lastDirectory)
//{
//    Console.Write(indent);
//    if (lastDirectory)
//    {
//        Console.Write("|--");
//        indent += " ";
//    }
//    else
//    {
//        Console.Write("|--");
//        indent += "| ";
//    }
//    Console.WriteLine(directory.Name);
//    DirectoryInfo[] subDirectories = directory.GetDirectories();
//    for (int i = 0; i < subDirectories.Length; i++)
//    {
//        PrintDirectory(subDirectories[i], indent, i == subDirectories.Length - 1);
//    }
//}


////Поля класса - 30.05
//namespace Test_1_Bogdan
//{
//    class Program
//    {
//        static int number = 50; // поле класса (глобальная переменная)

//        public static void Main(string[] args)
//        {
//            PersonData newPerson = new PersonData();
//            newPerson.SetName("; DROP DATABASE;");
//            newPerson.petName = "Черчилль";
//            newPerson.SetAge(25);

//            Console.WriteLine("Данные успешно сохранены на сервере");
//        }
//    }

//    class PersonData
//    {
//        private string _name;
//        public string petName;
//        private int _age;

//        public void SetName(string newName)
//        {
//            if (!newName.Contains("DROP"))
//            {
//                _name = newName;
//            }
//            else
//            {
//                throw new ArgumentException("ПРАВИЛЬНО ОБРАБАТЫВАЙ ДАННЫЕ!");
//            }
//        }

//        public int GetAge()
//        {
//            return _age;
//        }

//        public void SetAge(int newAge)
//        {
//            if (newAge < 120 && newAge > 0)
//            {
//                _age = newAge;
//            }
//            else
//            {
//                throw new ArgumentException("ПРАВИЛЬНО ОБРАБАТЫВАЙ ДАННЫЕ!");
//            }
//        }
//    }
//}

//Сортировка пузырьком

//int[] array = new int[] { 2, 8, 3, 15, 46, 1 };
//int arrLenght = array.Length - 1;
//for (int i = 0; i < arrLenght; i++) //количество обходов массива
//{
//	for (int j = 0; j < arrLenght; j++)
//	{
//		if (array[j] > array[j+1])
//		{
//			int temp=array[j];   //сохраняем в промежуточную переменную
//			array[j]=array[j+1]; //меняем местами
//			array[j+1]=temp;      //устанавливаем число обратно в  массив
//		}
//	}
//}
//Console.WriteLine();



////Сортировка выбором
using System.Diagnostics;

namespace Test_1_Bogdan
{
    class Program
    {

        public static int[] bubble;
        public static int[] selection;

        public static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            CreateRandomArr(50000);

            sw.Start();
            BubbleSort(bubble);
            sw.Stop();

            long timeBubbleSort = sw.ElapsedMilliseconds;

            sw.Start();
            SelectionSort(selection);
            sw.Stop();

            long timeSelectionSort = sw.ElapsedMilliseconds;

            Console.WriteLine("Время сортировки пузырьком: " + timeBubbleSort);
            Console.WriteLine("Время сортировки выбором: " + timeSelectionSort);
        }

        public static void BubbleSort(int[] array)
        {
            int arrLength = array.Length - 1;

            for (int i = 0; i < arrLength; i++) // Количество обходов массива
            {
                for (int j = 0; j < arrLength; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j]; // Сохраняем в промеж. переменную
                        array[j] = array[j + 1]; // Меняем местами
                        array[j + 1] = temp; // Устанавливаем число обратно в массив
                    }
                }
            }
            Console.WriteLine("Пузырек все");
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minNumberIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minNumberIndex])
                    {
                        minNumberIndex = j;
                    }
                }
                int temp = array[minNumberIndex];
                array[minNumberIndex] = array[i];
                array[i] = temp;
            }
        }
        public static void CreateRandomArr(int lenght)
        {
            Random rnd = new Random();

            bubble = new int[lenght];
            selection = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                int temp = rnd.Next(int.MinValue, int.MaxValue);
                bubble[i] = temp;
                bubble[i] = temp;
            }
        }
    }
}
