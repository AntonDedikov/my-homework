using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnelRecord_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dossier = new Dictionary<string, string>();
            bool isOpen = true;
            while (isOpen)
            {
                Console.WriteLine("add - Добавить досье");
                Console.WriteLine("display - вывести все досье");
                Console.WriteLine("delete - удалить досье");
                Console.WriteLine("exit - выход");
                Console.Write("Введите команду:");

                switch (Console.ReadLine())
                {
                    case "add":
                        AddDossier(dossier);
                        break;
                    case "display":
                        ShowDossier(dossier);
                        break;
                    case "delete":
                        DeleteDossier(ref dossier);
                        break;
                    case "exit":
                        isOpen = false;
                        break;
                }
                Console.Clear();
            }
        }
        static void AddDossier(Dictionary<string, string> dossier)
        {
            Console.WriteLine("Впишите ФИО сотрудника:");
            string name = Console.ReadLine();
            Console.WriteLine("Впишите должность нового сотрудника ");
            string post = Console.ReadLine();
            dossier.Add(name, post);
        }
        static void ShowDossier(Dictionary<string, string> dossier)
        {
            foreach (var file in dossier)
            {
                Console.Write($"{file.Key} - {file.Value},");
            }
            Console.ReadKey();
        }
        static void DeleteDossier(ref Dictionary<string, string> dossier)
        {
            Console.Write("Введите фамилию сотрудника, чтобы удалить его досье:");
            string inputSurname = Console.ReadLine();
            foreach(var file in dossier)
            {
                if (inputSurname == file.Key.Split(' ')[0])
                {
                    dossier.Remove(file.Key);
                    break;
                }
            }
        }
    }
}
