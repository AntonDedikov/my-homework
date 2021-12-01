using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trader trader = new Trader();
            Player player = new Player();

            while (true)
            {

                Console.SetCursorPosition(20, 10);
                Console.WriteLine($"твоё золото - {player.Coins}");
                Console.SetCursorPosition(1, 1);

                Console.WriteLine(" Торговец - 1");
                Console.WriteLine(" Инвентарь - 2");

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.NumPad1:
                        trader.ShowProduct();

                        Console.WriteLine(" Что желаете купить?");
                        int UserNumber = GetNumber();
                        if (UserNumber > 0)
                        {
                            UserNumber--;
                            if (trader.CheckItemsIdexInList(UserNumber))
                            {
                                if (player.CheckSolvency(trader.GetPrice(UserNumber)))
                                {
                                    trader.TakeCoins(player.Pay());
                                    player.AddInventory(trader.GiveItem(UserNumber));
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("У вас нехватает монет");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Такого предмета нет в лавке");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Торговец не знает такого языка");
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.NumPad2:
                        player.ShowInventory();
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
        static int GetNumber()
        {
            bool correctlyInput = true;
            int convertNumber;
            string userInput = Console.ReadLine();
            correctlyInput = int.TryParse(userInput, out convertNumber);
            return convertNumber;
        }
    }

    class Trader
    {
        private int _coins = 0;
        private List<Item> _items = new List<Item>();

        public Trader()
        {
            _items.Add(new Item("Деревянный лук", 20));
            _items.Add(new Item("Кожаный доспех", 50));
            _items.Add(new Item("Зелье исцеления", 15));
        }

        public void ShowProduct()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"  {i+1} {_items[i].Label} - {_items[i].Price}");
            }
        }

        public int GetPrice(int userNumber)
        {
            return _items[userNumber].Price;
        }

        public bool CheckItemsIdexInList(int userNumber)
        {
            if (userNumber >= 0 && userNumber < _items.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeCoins(int playerCoins)
        {
            _coins += playerCoins;
        }

        public Item GiveItem(int userNumber)
        {
            Item temp = _items[userNumber];
            _items.RemoveAt(userNumber);
            Console.WriteLine($"Торговец передал вам {temp.Label}");
            return temp;
        }
    }

    class Item
    {
        public string Label { get; private set; }
        public int Price { get; private set; }

        public Item(string label, int price)
        {
            Label = label;
            Price = price;
        }
    }

    class Player
    {
        public int Coins { get; private set; } = 20;
        private int _coinsToPay;

        private List<Item> _playerInventory = new List<Item>();

        public void ShowInventory()
        {
            foreach (Item item in _playerInventory)
            {
                Console.WriteLine(item.Label);
            }
        }

        public void AddInventory(Item temp)
        {
            _playerInventory.Add(temp);
        }

        public bool CheckSolvency(int price)
        {
            _coinsToPay = price;
            if (Coins >= _coinsToPay)
            {
                return true;
            }
            else
            {
                _coinsToPay = 0;
                return false;
            }
        }

        public int Pay()
        {
            Coins -= _coinsToPay;
            return _coinsToPay;
        }
    }
}
