using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Введите exit для выключения программы:");
                string userInput = Console.ReadLine();
                if(userInput == "exit")
                {
                    exit = true;
                }
                Console.Clear();
            }
        }
    }
}
