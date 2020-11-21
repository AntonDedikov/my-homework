using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawMap
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
                        AddDossier(ref fullNames, ref post);
                        break;
                    case "display":
                        ShowDossier(fullNames, post);
                        break;
                    case "delete":
                        deleteDossier(ref fullNames, ref post);
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
        static void AddDossier(ref string[] newName, ref string[] newPost)
        {
            Console.WriteLine("Впишите ФИО сотрудника:");
            string[] tempArray = new string[newName.Length + 1];

            for (int i = 0; i < newName.Length; i++)
            {
                tempArray[i] = newName[i];
            }
            tempArray[tempArray.Length - 1] = Console.ReadLine();
            newName = tempArray;

            Console.WriteLine("Впишите должность нового сотрудника ");
            string[] tempArray2 = new string[newPost.Length + 1];

            for (int i = 0; i < newPost.Length; i++)
            {
                tempArray2[i] = newPost[i];
            }
            tempArray2[tempArray2.Length - 1] = Console.ReadLine();
            newPost = tempArray2;
        }
        static void ShowDossier(string[] name, string[] post)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i + 1} {name[i]} - {post[i]}");
            }
        }
        static void deleteDossier(ref string[] name, ref string[] post)
        {
            Console.Write("Введите номер досье которое хотите удалить:");
            int indexDelete = Convert.ToInt32(Console.ReadLine());
            string[] tempArrayName = new string[name.Length - 1];
            string[] tempArrayPost = new string[post.Length - 1];

            for (int i = 0, j = 0; i < tempArrayName.Length; i++, j++)
            {
                if (i == indexDelete - 1)
                {
                    j++;
                    tempArrayName[i] = name[j];
                    tempArrayPost[i] = post[j];
                }
                else
                {
                    tempArrayName[i] = name[j];
                    tempArrayPost[i] = name[j];
                }
            }
            name = tempArrayName;
            post = tempArrayPost;
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
