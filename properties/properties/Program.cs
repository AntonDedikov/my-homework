using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(2,2);
            Renderer renderer = new Renderer();

            Console.Write("Введите координату X для отрисовки персонажа:");
            player.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y для отрисовки персонажа:");
            player.X = Convert.ToInt32(Console.ReadLine());

            renderer.DrowPlayer(player.X, player.Y, '@');
            Console.ReadKey();
        }
    }
    
    class Player
    {
        public int X 
        {
            get
            {
                return X;
            }
            set 
            {
                if(value > 0 && value < 100)
                {
                    return;
                }
            }
        }
        public int Y 
        {
            get
            {
                return X;
            } 
            set
            {
                if(value > 0 && value < 100)
                {
                    return;
                }
            } 
        }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Renderer
    {
        public void DrowPlayer(int x, int y, char playerSimbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(playerSimbol);
        }
    }
}
