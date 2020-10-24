using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace healthBar2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxHealth = 50000, userInputProcent = 0;

            while (true)
            {
                DrawBar(maxHealth, userInputProcent, ConsoleColor.Red, 0, '#');

                Console.SetCursorPosition(0, 5);

                Console.Write("Введите процент на который изменится жизни:");
                userInputProcent = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(int maxValue, int inputProcentValue, ConsoleColor color, int position, char symbol = ' ')
        {
            int drawnProcent, oneProcent, barLength = 10, valueHealth;

            oneProcent = maxValue / 100;
            valueHealth = inputProcentValue * oneProcent;
            drawnProcent = inputProcentValue / barLength;

            Console.SetCursorPosition(12, position);
            Console.Write($" {valueHealth}hp");

            ConsoleColor defoultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < drawnProcent; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defoultColor;

            bar = "";
            for (int i = drawnProcent; i < barLength; i++)
            {
                bar += '_';
            }
            Console.Write(bar + ']');
        }
    }
}

