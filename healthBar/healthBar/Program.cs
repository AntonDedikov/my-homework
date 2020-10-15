using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 467, maxHealth = 1000;

            while (true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Red, 0, '#');

                Console.SetCursorPosition(0, 5);

                Console.Write("Введите число на которое изменится жизни:");
                health += Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = ' ')
        {
            int percentValue;
            maxValue = maxValue / 100;
            percentValue = value / maxValue;
            value = percentValue / 10;


            ConsoleColor defoultColor = Console.BackgroundColor;
            string bar = "";


            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }


            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defoultColor;


            bar = "";
            for (int i = value; i < maxValue; i++)
            {
                bar += '_';
            }
            Console.Write(bar + ']');
        }
    }
}
