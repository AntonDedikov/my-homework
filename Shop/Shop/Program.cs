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
            bool isOpen = true;
            Trader trader = new Trader();
            Player player = new Player();

            while (isOpen)
            {

                Console.SetCursorPosition(20, 15);
                Console.WriteLine($"твоё золото - {player.Coins}");
                Console.SetCursorPosition(1, 1);

                Console.WriteLine(" Торговец - 1");
                Console.WriteLine(" Инвентарь - 2");

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.NumPad1:
                        trader.ShowProduct();
                        Console.WriteLine($"\n Желаете что-то купить?" +
                            $"\n (Нажмите <<Enter>> для того чтобы начать торговлю)");
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Trade(trader, player);
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

        static void Trade(Trader trader, Player player)
        {
            Console.WriteLine("Какая вещь вам приглянулась?");
            int userNumber = GetNumber();
            if (userNumber > 0)
            {
                userNumber -= 1;
                if (trader.IsPresent(userNumber))
                {
                    if (player.Coins >= trader.GetPrice(userNumber))
                    {
                        int price = trader.GetPrice(userNumber);
                        player.BuyItem(price, trader.SellItem(userNumber));
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
            _items.Add(new Item("Зелье бодрости", 10));
        }

        public void ShowProduct()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"  {i + 1} {_items[i].Label} - {_items[i].Price}");
            }
        }

        public int GetPrice(int userNumber)
        {
            return _items[userNumber].Price;
        }

        public bool IsPresent(int userNumber)
        {
            return userNumber >= 0 && userNumber < _items.Count;
        }

        public Item SellItem(int userNumber)
        {
            _coins += _items[userNumber].Price;
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
        private List<Item> _inventory = new List<Item>();
        public int Coins { get; private set; } = 20;

        public void ShowInventory()
        {
            foreach (Item item in _inventory)
            {
                Console.WriteLine(item.Label);
                Console.ReadKey();
            }
        }

        public void BuyItem(int price, Item temp)
        {
            _inventory.Add(temp);
            Coins -= price;
        }
    }
}
