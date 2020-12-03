using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите имя:");
            string name = Console.ReadLine(); 

            Player player = new Player(name);

            player.ShowInfo();
            Console.ReadKey();
        }
        class Player
        {
            private string _name;
            private int _health;
            private int _speed;
            private int _damage;

            public Player(string name)
            {
                _name = name;
                _health = 100;
                _speed = 5;
                _damage = 10;
            }

            public void ShowInfo()
            {
                Console.WriteLine($" Имя игрока = {_name}\n Жизни = {_health}\n Скорость = {_speed}\n Урон = {_damage}\n");
            }
        }
    }
}
