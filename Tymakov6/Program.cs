using System;
using System.Collections.Generic;
using System.IO;

namespace Tymakov6
{
    internal class Program
    {
        static int CountVowel(char[] text)
        {
            List<char> vowel = new List<char>() {'а', 'е', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я'};
            int count = 0;
            foreach (char c in text) 
            { 
                if (vowel.Contains(char.ToLower(c)))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountConsonant(char[] text)
        {
            List<char> consonant = new List<char>() {'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л','м', 'н', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'};
            int count = 0;
            foreach (char c in text)
            {
                if (consonant.Contains(char.ToLower(c)))
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args) 
        {
            Console.WriteLine("Задача 1. Программа считает количество гласных и согласных в файле.");
            Console.WriteLine("Введите название файла:");
            string file = Console.ReadLine();
            if (string.IsNullOrEmpty(file))
            {
                Console.WriteLine("Файл не найден");
            }

            string file1 = File.ReadAllText(file);
            char[] text = file1.ToCharArray();
            int vowelcount = CountVowel(text);
            int consonantcount = CountConsonant(text);
            
            Console.WriteLine("Количество гласных букв {0}", vowelcount);
            Console.WriteLine("Количество согласных букв {0}", consonantcount);

            Console.ReadKey();


        }
    }
}