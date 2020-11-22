using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnelRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            string[] fullNames = new string[0];
            string[] post = new string[0];

            while (isOpen)
            {
                Console.WriteLine("add - Добавить досье");
                Console.WriteLine("display - вывести все досье");
                Console.WriteLine("delete - удалить досье");
                Console.WriteLine("search - поиск по фамилии");
                Console.WriteLine("exit - выход");
                Console.Write("Введите команду:");

                switch (Console.ReadLine())
                {
                    case "add":
                        Console.WriteLine("Впишите ФИО сотрудника:");
                        AddDossier(ref fullNames);
                        Console.WriteLine("Впишите должность нового сотрудника ");
                        AddDossier(ref post);
                        break;
                    case "display":
                        ShowDossier(fullNames, post);
                        break;
                    case "delete":
                        Console.Write("Введите номер досье которое хотите удалить:");
                        int indexDelete = Convert.ToInt32(Console.ReadLine());
                        DeleteDossier(ref fullNames, indexDelete);
                        DeleteDossier(ref post, indexDelete);
                        break;
                    case "search":
                        FindByName(fullNames, post);
                        break;
                    case "exit":
                        isOpen = false;
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void AddDossier(ref string[] dataWorker)
        {
            string[] tempArray = new string[dataWorker.Length + 1];

            for (int i = 0; i < dataWorker.Length; i++)
            {
                tempArray[i] = dataWorker[i];
            }
            tempArray[tempArray.Length - 1] = Console.ReadLine();
            dataWorker = tempArray;
        }
        static void ShowDossier(string[] name, string[] post)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i + 1} {name[i]} - {post[i]}");
            }
        }
        static void DeleteDossier(ref string[] dataWorker, int indexDelete)
        {
            string[] tempArrayName = new string[dataWorker.Length - 1];
            for (int i = 0, j = 0; i < tempArrayName.Length; i++, j++)
            {
                if (i == indexDelete - 1)
                {
                    j++;
                    tempArrayName[i] = dataWorker[j];
                }
                else
                {
                    tempArrayName[i] = dataWorker[j];
                }
            }
            dataWorker = tempArrayName;   
        }
        static void FindByName(string[] name, string[] post)
        {
            Console.WriteLine("Введите фамилию:");
            string requestName = Console.ReadLine();

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < requestName.Length; j++)
                {
                    if (requestName[j] != name[i][j])
                    {
                        ++i;
                        j = 0;
                    }
                    if (j == requestName.Length - 1)
                    {
                        Console.WriteLine($"Должность сотрудника - {post[i]}");
                    }
                }
                break;
            }
        }
    }
}
