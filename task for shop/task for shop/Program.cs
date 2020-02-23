using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_for_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientCash;
            int crystalCost = 15;
            int countCristals;
            bool control;

            Console.Write("Ваши средства: ");
            clientCash = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов вы хотите приобрести?: ");
            countCristals = Convert.ToInt32(Console.ReadLine());


            control = clientCash >= crystalCost * countCristals;
            countCristals *= Convert.ToInt32(control);

            clientCash -= crystalCost * countCristals;

            Console.WriteLine("вы приобрели: " + countCristals + " кристаллов");
            Console.WriteLine("у вас осталось: " + clientCash + " золота");
            Console.ReadKey();

        }
    }
}
