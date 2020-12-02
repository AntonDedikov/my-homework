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

            Player player1 = new Player(name);

            player1.ShowInfo();
            Console.ReadKey();
        }
        class Player
        {
            string Name;
            int Health;
            int Spead;
            int Damage;
            public Player(string name)
            {
                Name = name;
                Health = 100;
                Spead = 5;
                Damage = 10;
            }

            public void ShowInfo()
            {
                Console.WriteLine($" Имя игрока = {Name}\n Жизни = {Health}\n Скорость = {Spead}\n Урон = {Damage}\n");
            }
        }
    }
}
