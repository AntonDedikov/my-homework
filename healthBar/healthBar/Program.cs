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
            int health = 40, maxHealth = 100;
            int userInputProcent = 0;

            while (true)
            {
                DrawBar(ref health, maxHealth, userInputProcent, ConsoleColor.Red, 0, '#');

                Console.SetCursorPosition(0, 5);

                Console.Write("Введите процент на который изменится жизни:");
                userInputProcent = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawBar(ref int value, int maxValue, int inputProcentValue, ConsoleColor color, int position, char symbol = ' ')
        {
            int DrawnMaxProcent = 10, DrawnProcent, oneProcent;

            oneProcent = maxValue / 100;
            value += oneProcent * inputProcentValue;
            DrawnProcent = value / oneProcent;

            Console.SetCursorPosition(12, position);
            Console.Write($" {DrawnProcent}%");

            DrawnProcent /= 10;

            ConsoleColor defoultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < DrawnProcent; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defoultColor;

            bar = "";
            for (int i = DrawnProcent; i < DrawnMaxProcent; i++)
            {
                bar += '_';
            }
            Console.Write(bar + ']');
        }
    }
}

