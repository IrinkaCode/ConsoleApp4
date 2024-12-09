using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33_1_DZ_
{
    internal class Operations
    {
        private List<string> values = new List<string>();

        public void AddValue(string value)
        {
            values.Add(value);
        }

        public void RemoveValue(int index)
        {
            if (index >= 0 && index < values.Count)
            {
                values.RemoveAt(index);
                Console.WriteLine($"Элемент с индексом {index} удален.");
            }
            else
            {
                Console.WriteLine("Недействительный индекс.");
            }
        }

        public void SearchValue(string value)
        {
            int index = values.IndexOf(value);
            if (index != -1)
            {
                Console.WriteLine($"Значение '{value}' найдено на индексе {index}.");
            }
            else
            {
                Console.WriteLine($"Значение '{value}' не найдено в списке.");
            }
        }

        public void ClearValues()
        {
            values.Clear();
            Console.WriteLine("Список очищен.");
        }

        public void DisplayValues()
        {
            if (values.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                Console.WriteLine("Список значений:");
                for (int i = 0; i < values.Count; i++)
                {
                    Console.WriteLine($"{i}: {values[i]}");
                }
            }
        }
    }
}
