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
            int repeatNumber;

            Console.WriteLine("Впишите сообщение:");
            userInput = Console.ReadLine();
            Console.WriteLine("Сколько раз повторить:");
            repeatNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repeatNumber; i++)
            {
                Console.WriteLine(userInput);
            }
            Console.ReadKey();
        }
    }
}
