using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_output
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            char userSimbol;
            string characterString = "";

            Console.Write("Введите имя:");
            userName = Console.ReadLine();

            Console.Write("Введите символ:");
            userSimbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < userName.Length + 2; i++)
            {
                characterString += userSimbol;
            }
            Console.WriteLine(characterString);
            Console.WriteLine(userSimbol + userName + userSimbol);
            Console.WriteLine(characterString);
            Console.ReadKey();
        }
    }
}
