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

            Database database = new Database();

            while (isOpen)
            {
                Console.SetCursorPosition(20, 1);
                Console.WriteLine("База данных");
                database.ShowPlayers();

                Console.SetCursorPosition(3, 16);
                Console.WriteLine("Доступные команды:\n" +
                    "1 - Добавить игрока\n" +
                    "2 - Забанить\n" +
                    "3 - Разбанить\n" +
                    "4 - Удалить");
                int userInput;

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.NumPad1:
                        database.AddPlayer();
                        break;
                    case ConsoleKey.NumPad2:
                        userInput = GetNumber();
                        database.BanPlayer(userInput);
                        break;
                    case ConsoleKey.NumPad3:
                        userInput = GetNumber();
                        database.UnBanPlayer(userInput);
                        break;
                    case ConsoleKey.NumPad4:
                        userInput = GetNumber();
                        database.DeletePlayer(userInput);
                        break;
                }
                Console.Clear();
            }
        }

        static int GetNumber()
        {
            bool correctlyInput = true;

            do
            {
                int convertNumber;
                Console.Write("Введите номер игрока:");
                string userInput = Console.ReadLine();
                correctlyInput = int.TryParse(userInput, out convertNumber);
                return convertNumber;
            }
            while (correctlyInput == false);
        }
    }

    class Database
    {
        private List<Player> _players = new List<Player>();

        public void AddPlayer()
        {
            Random random = new Random();

            Console.WriteLine("Введите ник игрока:");
            string nickName = Console.ReadLine();
            int level = random.Next(0, 81);
            bool isBanned = false;

            _players.Add(new Player(nickName, level, isBanned));
        }

        public void BanPlayer(int number)
        {
            if (CheckPlayerIdexInList(number) == true)
            {
                _players[number].Ban();
            }
        }

        public void UnBanPlayer(int number)
        {
            if (CheckPlayerIdexInList(number) == true)
            {
                _players[number].UnBan();
            }
        }

        public void DeletePlayer(int number)
        {
            if (CheckPlayerIdexInList(number) == true)
            {
                _players.RemoveAt(number);
            }
        }

        public void ShowPlayers()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                Console.Write(i);
                _players[i].ShowInfo();
            }
        }

        private bool CheckPlayerIdexInList(int number)
        {
            if (_players.Count > number && number >= 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Игрок не найден");
                Console.ReadKey();
                return false;
            }
        }
    }

    class Player
    {
        private string _nickname;
        private int _level;
        private bool _isBanned;

        public Player(string nickName, int level, bool isBanned)
        {
            _nickname = nickName;
            _level = level;
            _isBanned = isBanned;
        }

        public void Ban()
        {
            _isBanned = true;
        }

        public void UnBan()
        {
            _isBanned = false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($" Игрок - {_nickname} уровень - {_level} бан - {_isBanned}");
        }
    }
}
