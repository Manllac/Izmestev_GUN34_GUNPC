using System;
using System.Text;

namespace String
{
    internal class Program
    {
            // Задание 1: Конкатенация двух строк
            public static string ConcatenateStrings(string str1, string str2)
            {
                return str1 + str2;
            }

            // Задание 2: Приветствие пользователя
            public static string GreetUser(string name, int age)
            {
                return $"Hello, {name}! You are {age} years old.\n";
            }

            // Задание 3: Информация о строке
            public static string StringInfo(string input)
            {
                return $"Length: {input.Length}\nUpper case: {input.ToUpper()}\nLower case: {input.ToLower()}";
            }

            // Задание 4: Первые 5 символов строки
            public static string FirstFiveCharacters(string input)
            {
                return input.Length >= 5 ? input.Substring(0, 5) : input;
            }

            // Задание 5: Объединение массива строк в одно предложение
            public static StringBuilder CombineStrings(string[] inputArray)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in inputArray)
                {
                    sb.Append(item + " ");
                }
                return sb;
            }

            // Задание 6: Замена слова в строке
            public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
            {
                return inputString.Replace(wordToReplace, replacementWord);
            }

            static void Main(string[] args)
            {

                string concatenated = ConcatenateStrings("Hello", " World");
                Console.WriteLine(concatenated); 

                string greeting = GreetUser("John", 25);
                Console.WriteLine(greeting);
                
                string info = StringInfo("Hello");
                Console.WriteLine(info); 

                string firstFive = FirstFiveCharacters("HelloWorld");
                Console.WriteLine(firstFive); 

                string[] words = { "The", "quick", "brown", "fox" };
                StringBuilder combined = CombineStrings(words);
                Console.WriteLine(combined.ToString().Trim()); 

                string replacedString = ReplaceWords("Hello world", "world", "universe");
                Console.WriteLine(replacedString);

                Console.ReadKey();
            }
        }
    }

