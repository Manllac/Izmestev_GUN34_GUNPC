using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задачу (1 - Список, 2 - Словарь, 0 - Выход):");
                int task;
                if (!int.TryParse(Console.ReadLine(), out task))
                {
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    continue;
                }

                switch (task)
                {
                    case 1:
                        var listTask = new List();
                        listTask.TaskLoop();
                        break;
                    case 2:
                        var dictionTask = new Diction();
                        dictionTask.TaskLoop();
                        break;
                    case 0:
                        Console.WriteLine("Выход из программы.");
                        return; 
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}
