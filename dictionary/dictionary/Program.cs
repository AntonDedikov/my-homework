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
                words.Add("нэко", "нэко - это кошка или девушка, похожая на неё");
                words.Add("катарсис", "катарсис - это нравственное очищение в результате \n душевного потрясения или перенесённого страдания");
                words.Add("рефлексия", "рефлексия - это размышление о своём психологическом \n состоянии, склонность анализировать свои переживания");
                Console.WriteLine("Великий словарь содержит такие слова: ахэгао, нэко, катарсис, рефлексия");
                Console.Write("Введите слово:");
                string userInput = Console.ReadLine();

                int i = 0;
                foreach (var word in words)
                {
                    i++;
                    if (word.Key.ToLower() == userInput.ToLower())
                    {
                        Console.WriteLine(word.Value);
                        i = 5;
                    }
                    if (words.Count == i)
                    {
                        Console.WriteLine("Вы вероятно ошиблись");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
