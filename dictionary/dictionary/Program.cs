using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dictionary<string, string> words = new Dictionary<string, string>();
                words.Add("ахэгао", "ахэгао - это favicon на главной странице ЯЮниор");
                words.Add("сиеста", "сиеста - послеобеденный отдых");
                words.Add("катарсис", "катарсис - это нравственное очищение в результате \n душевного потрясения или перенесённого страдания");
                words.Add("рефлексия", "рефлексия - это размышление о своём психологическом \n состоянии, склонность анализировать свои переживания");
                Console.WriteLine("Великий словарь содержит такие слова: ахэгао, сиеста, катарсис, рефлексия");
                Console.Write("Введите слово:");
                string userInput = Console.ReadLine();

                if (words.ContainsKey(userInput))
                {
                    foreach (var word in words)
                    {
                        if (word.Key == userInput)
                        {
                            Console.WriteLine(word.Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вы вероятно ошиблись");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
