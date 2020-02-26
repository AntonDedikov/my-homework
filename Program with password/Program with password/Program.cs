using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_with_password
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = "1234";
            int inputAttempts = 3;
            string userInput;

            while (inputAttempts-- > 0)
            {
                Console.Write("Введите пароль:");
                userInput = Console.ReadLine();
                if (userInput == "1234")
                {
                    Console.WriteLine("Ответ: 42, Живи с этим.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("У вас осталось " + inputAttempts + " попыток.");
                }
            }
            Console.WriteLine("Доступ заблокирован!");
            Console.ReadKey();
        }
    }
}
