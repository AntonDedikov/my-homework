using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicArrayUp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            List<int> numbers = new List<int>();
            while (isOpen)
            {
                Console.WriteLine("input - ввести число");
                Console.WriteLine("sum - суммирование введенных чисел");
                Console.WriteLine("exit - выход");

                Console.SetCursorPosition(0, 5);
                Console.Write("Введите команду: ");
                switch (Console.ReadLine())
                {
                    case "input":
                        int userInput;
                        TakeNumber(out userInput);
                        numbers.Add(userInput);
                        break;
                    case "sum":
                        DisplaySum(numbers);
                        break;
                    case "exit":
                        isOpen = false;
                        break;
                }
                Console.Clear();
            }
        }
        static void TakeNumber(out int inputConvert)
        {
            bool correctlyInput = true;
            do
            {
                Console.Write("Впишите число:");
                string userInput = Console.ReadLine();
                correctlyInput = int.TryParse(userInput, out inputConvert);
            } while (correctlyInput == false);
        }
        static void DisplaySum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Cумма введенных чисел - " + sum);
            Console.ReadKey();
        }
    }
}
