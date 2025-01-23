using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Dictionary
    {
        public void TaskLoop()
        {
            Dictionary<string, double> students = new Dictionary<string, double>();

            while (true)
            {
                Console.WriteLine("Введите имя студента:");
                string studentName = Console.ReadLine();

                double grade;
                while (true)
                {
                    Console.WriteLine("Введите среднюю оценку студента от 2 до 5:");
                    if(double.TryParse(Console.ReadLine(), out grade) && grade >= 2 && grade <=5 )
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Оценка должна быть от 2 до 5.");
                    }
                }

                students[studentName] = grade;
                Console.WriteLine("\nВсе студенты и их оценки:");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.Key}: {student.Value}");
                }

                Console.WriteLine("\nВведите имя студента для поиска оценки:");
                string searchName = Console.ReadLine();
                if (students.ContainsKey(searchName))
                {
                    Console.WriteLine($"{searchName} имеет оценку {students[searchName]}");
                }
                else
                {
                    Console.WriteLine($"Студент с именем {searchName} не найден.");
                }

                Console.WriteLine("\nВведите \"–exit\" для выхода.");
                if (Console.ReadLine() == "–exit")
                {
                    break;
                }
            }
        }
    }
}
