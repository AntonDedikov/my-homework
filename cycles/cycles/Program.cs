using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int repeatMessage;

            Console.WriteLine("Впишите сообщение:");
            userInput = Console.ReadLine();
            Console.WriteLine("Сколько раз повторить:");
            repeatMessage = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repeatMessage; i++)
            {
                Console.WriteLine(userInput);
            }
            Console.ReadKey();
        }
    }
}
