using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class List
    {
        public void TaskLoop()
        {
            List<string> strings = new List<string> { "Осень", "Зима", "Весна" };

            Console.WriteLine("Первоначальный список:");
            foreach (var item in strings) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Введите месяц для добавляения в список:");
            string strings2 = Console.ReadLine();
            strings.Add(strings2);

            Console.WriteLine("Содержимое списка после добавления:");
            foreach(var item in strings2)
            { 
                Console.WriteLine(item); 
            }

            Console.WriteLine("Введите месяц для добавляения в середину списка:");
            string strings3 = Console.ReadLine();
            int midString = strings.Count / 2;
            strings.Insert(midString, strings3);

            Console.WriteLine("Содержимое списка после добавления в середину:");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nВведите \" - exit\" для выхода");
            if (Console.ReadLine()== "-exite")
            {
                return;
            }
        }

    }
}
