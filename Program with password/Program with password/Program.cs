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
            string passwordForMessage = "1234";
            string userInput;
            int attempts = 3;

            Console.WriteLine("Введите пароль:");
            userInput = Console.ReadLine();
            for(attempts > 0; attemps--)
            {
                if (userInput == passwordForMessage)
                {
                    Console.WriteLine("42");
                }
                else
                {
                    Console.WriteLine("Пароль не верный. Попробуйте еще раз."
                        + "У вас осталось " + attempts + " попыток.");
                }
            }
        }
    }
}
