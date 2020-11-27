using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueBuyers = new Queue<int>();
            Random rand = new Random();
            int cashRegister = 0;
            int humanCount = rand.Next(5, 15);

            for (int i = 0; i < humanCount; i++)
            {
                queueBuyers.Enqueue(rand.Next(10, 20));
            }
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("количество людей в очереди " + humanCount);
            for (int i = 0; i < humanCount; i++)
            {
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("Сумма покупки:" + queueBuyers.Peek());
                Console.SetCursorPosition(4, 7);
                Console.WriteLine($"Деньги в кассе: {cashRegister += queueBuyers.Dequeue()}");
                Console.ReadKey();
            }
            Console.Clear();
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("Рабочий день окончен.");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine($"Деньги в кассе: {cashRegister}");
            Console.ReadKey();
        }
    }
}
