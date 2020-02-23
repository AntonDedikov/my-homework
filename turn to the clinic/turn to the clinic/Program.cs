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
            int people;
            int serviceTime = 10;
            int Minutes;
            int Hours;

            Console.Write("Введите кол-во человек в очереди: ");
            people = Convert.ToInt32(Console.ReadLine());

            Minutes = people * serviceTime;
            Hours = Minutes / 60;
            Minutes = Minutes % 60;

            Console.WriteLine("Время ожидания равно " + Hours + " часов " + Minutes + " минут");
            Console.ReadKey();
        }
    }
}
