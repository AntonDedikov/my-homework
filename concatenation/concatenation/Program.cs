using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userAge;
            string userZodiac;
            string userWork;

            Console.Write("Введите свое имя:");
            userName = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            userAge = Console.ReadLine();
            Console.WriteLine("Какой ваш знак зодиака?");
            userZodiac = Console.ReadLine();
            Console.WriteLine("Где вы работаете?");
            userWork = Console.ReadLine();

            Console.WriteLine("Вас зовут " + userName + ", вам " + userAge + " год, вы " 
                + userZodiac + " по знаку зодиака и работаете " + userWork + ".");
            Console.ReadKey();
        }
    }
}
