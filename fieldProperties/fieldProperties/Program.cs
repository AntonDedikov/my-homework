using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fieldProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(2, 2);
            Renderer renderer = new Renderer();

            renderer.DrawPlayer(player.X, player.Y, '@');
            Console.ReadKey();
        }
    }
    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Renderer
    {
        public void DrawPlayer(int x, int y, char playerSymbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(playerSymbol);
        }
    }
}