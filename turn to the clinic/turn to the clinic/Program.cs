using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_to_the_clinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int turnPeople;
            int serviceTime = 10;
            int waitMinutes;
            int waitHours;

            Console.Write("Введите кол-во человек в очереди: ");
            turnPeople = Convert.ToInt32(Console.ReadLine());

            waitMinutes = turnPeople * serviceTime;
            waitHours = waitMinutes / 60;
            waitMinutes = waitMinutes % 60;

            Console.WriteLine("Время ожидания равно " + waitHours + " часов " + waitMinutes + " минут");
            Console.ReadKey();
        }
    }
}
