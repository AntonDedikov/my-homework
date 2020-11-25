using System;

namespace drawMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int characterX = 0, characterY = 0;
            int characterDX = 0, characterDY = 0;
            bool isPlaying = true;
            bool isDrawing = false;

            char[,] map = new char[,]
             {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ','@',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            };

            Console.SetCursorPosition(20,1);
            Console.WriteLine("Нажмите E чтобы сменить режим");

            Console.SetCursorPosition(20, 3);
            Console.WriteLine("Нажмите 1 чтобы стереть");

            Console.SetCursorPosition(20, 5);
            Console.WriteLine("Нажмите 3 чтобы поставить стену");

            Console.SetCursorPosition(0,0);
            DisplayMap(map, ref characterX, ref characterY);
            Console.CursorVisible = false;

            while (isPlaying == true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                ChangeDirection(key, ref characterDX, ref characterDY);
                if (map[characterX + characterDX, characterY + characterDY] != '#' || isDrawing == true)
                {
                    Move(ref characterX, ref characterY, characterDX, characterDY, isDrawing);
                }

                ChangeMode(key, ref isDrawing);

                if (isDrawing == true)
                {
                    EnableTools(key, ref map, ref characterX, ref characterY);
                }
            }
        }
        static void DisplayMap(char[,] map, ref int X, ref int Y)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == '@')
                    {
                        X = i;
                        Y = j;
                    }
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ChangeDirection(ConsoleKeyInfo key, ref int DX, ref int DY)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    DX = -1; DY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    DX = 1; DY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    DX = 0; DY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    DX = 0; DY = 1;
                    break;
            }
        }
        static void Move(ref int X, ref int Y, int DX, int DY, bool isDrawing)
        {
            Console.SetCursorPosition(Y, X);
            if (isDrawing != true)
            {
                Console.Write(' ');
            }
            X += DX;
            Y += DY;
            Console.SetCursorPosition(Y, X);
            if (isDrawing != true)
            {
                Console.Write('@');
            }
        }
        static void ChangeMode(ConsoleKeyInfo key, ref bool isDrawing)
        {
            if (key.Key == ConsoleKey.E)
            {
                if (isDrawing == false)
                {
                    Console.CursorVisible = true;
                    isDrawing = true;
                }
                else
                {
                    Console.CursorVisible = false;
                    isDrawing = false;
                }
            }
        }
        static void EnableTools(ConsoleKeyInfo key, ref char[,] map, ref int X, ref int Y)
        {
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.SetCursorPosition(Y, X);
                    map[X, Y] = ' ';
                    Console.Write(' ');
                    break;
                case ConsoleKey.D3:
                    Console.SetCursorPosition(Y, X);
                    map[X, Y] = '#';
                    Console.Write('#');
                    break;
            }
        }
    }

}
