using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_array
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            int[] numbers = new int[0];

            while (isOpen)
            {
                Console.WriteLine("input - ввести число");
                Console.WriteLine("sum - суммирование введенных чисел");
                Console.WriteLine("sort - сортировка массива");
                Console.WriteLine("exit - выход");

                Console.SetCursorPosition(0,10);
                Console.Write("Введенные числа:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }

                Console.SetCursorPosition(0,5);
                Console.Write("Введите команду: ");
                switch (Console.ReadLine())
                {
                    case "input":
                        int userImput;
                        Console.Write("Введите число: ");
                        userImput = Convert.ToInt32(Console.ReadLine());
                        int[] tempNumbers = new int[numbers.Length + 1];
                        for(int i = 0; i < numbers.Length; i++)
                        {
                            tempNumbers[i] = numbers[i];
                        }
                        tempNumbers[tempNumbers.Length - 1] = userImput;
                        numbers = tempNumbers;
                        break;
                    case "sum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine("Cумма введенных чисел - " + sum);
                        Console.ReadKey();
                        break;
                    case "sort":
                        int temp;
                        for (int i = 0; i < numbers.Length - 1; i++)
                        {
                            for (int j = i + 1; j < numbers.Length; j++)
                            {
                                if (numbers[i] > numbers[j])
                                {
                                    temp = numbers[i];
                                    numbers[i] = numbers[j];
                                    numbers[j] = temp;
                                }
                            }
                        }
                        break;
                    case "exit":
                        isOpen = false;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
