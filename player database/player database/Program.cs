using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_database
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            DataBase dataBase = new DataBase();

            while (isOpen)
            {
                Console.SetCursorPosition(20, 1);
                Console.WriteLine("База данных");
                dataBase.ShowPlayers();

                Console.SetCursorPosition(3, 16);
                Console.WriteLine("Доступные команды:\n" +
                    "1 - Добавить игрока\n" +
                    "2 - Забанить\n" +
                    "3 - Разбанить\n" +
                    "4 - Удалить");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.NumPad1)
                {
                    dataBase.AddPlayer();
                }
                else
                {
                    dataBase.GetPlayer(key);
                }
                Console.Clear();
            }
        }
    }

    class DataBase
    {
        private List<Player> players = new List<Player>();

        public void AddPlayer()
        {
            Random random = new Random();

            Console.WriteLine("Введите ник игрока:");
            string nickName = Console.ReadLine();
            int level = random.Next(0, 81);
            bool ban = false;

            players.Add(new Player(nickName, level, ban));
        }

        public void GetPlayer(ConsoleKeyInfo key)
        {
            Console.WriteLine("Введите порядковый номер игрока:");
            int PlayerNumber = Convert.ToInt32(Console.ReadLine());

            switch (key.Key)
            {
                case ConsoleKey.NumPad2:
                    players[PlayerNumber].BanPlayer();
                    break;
                case ConsoleKey.NumPad3:
                    players[PlayerNumber].UnBanPlayer();
                    break;
                case ConsoleKey.NumPad4:
                    players.RemoveAt(PlayerNumber);
                    break;
            }
        }

        public void ShowPlayers()
        {
            for (int i = 0; i < players.Count; i++)
            {
                Console.Write(i);
                players[i].ShowInfo();
            }
        }
    }

    class Player
    {
        private string _nickname;
        private int _level;
        private bool _ban;

        public Player(string nickName, int level, bool ban)
        {
            _nickname = nickName;
            _level = level;
            _ban = ban;
        }

        public void BanPlayer()
        {
            _ban = true;
        }

        public void UnBanPlayer()
        {
            _ban = false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($" Игрок - {_nickname} уровень - {_level} бан - {_ban}");
        }
    }
}
