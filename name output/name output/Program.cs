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
            char userSymbol;
            string characterString = "";

            Console.Write("Введите имя:");
            userName = Console.ReadLine();

            Console.Write("Введите символ:");
            userSymbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < userName.Length + 2; i++)
            {
                characterString += userSymbol;
            }
            Console.WriteLine(characterString);
            Console.WriteLine(userSymbol + userName + userSymbol);
            Console.WriteLine(characterString);
            Console.ReadKey();
        }
    }
}
