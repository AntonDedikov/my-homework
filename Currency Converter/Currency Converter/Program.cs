using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            float uahToUsd = 24.5f, uahToRub = 2.6f,
                usdToUah = 24.5f, usdToRub = 64f,
                rubToUah = 2.6f, rubToUsd = 64f;
            float rub;
            float usd;
            float uah;
            string userInput;
            float currencyCount;
            string continueProgram = "0";

            Console.WriteLine("Добро пожаловать в обменник валют.");

            Console.WriteLine("Введите сумму рублей:");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите сумму долларов:");
            usd = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите сумму гривень:");
            uah = Convert.ToSingle(Console.ReadLine());

            do
            { 
                Console.WriteLine("1 - обменять гривны на доллары");
                Console.WriteLine("2 - обменять гривны на рубли");
                Console.WriteLine("3 - обменять доллары на рубли");
                Console.WriteLine("4 - обменять доллары на гривны");
                Console.WriteLine("5 - обменять рубли на доллары");
                Console.WriteLine("6 - обменять рубли на гривны");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Обмен гривень на доллары");
                        Console.Write("Cколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (uah >= currencyCount)
                        {
                            uah -= currencyCount;
                            usd += currencyCount / uahToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая операция");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Обмен гривень на рубли");
                        Console.Write("Cколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (uah >= currencyCount)
                        {
                            uah -= currencyCount;
                            rub += currencyCount * uahToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая операция");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Обмен доллоров на рубли");
                        Console.Write("Cколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая операция");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Обмен доллоров на гривны");
                        Console.Write("Cколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            uah += currencyCount * usdToUah;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая операция");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.Write("Cколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая операция");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Обмен рублей на гривны");
                        Console.Write("Cколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            uah += currencyCount / rubToUah;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимая операция");
                        }
                        break;
                }
                Console.WriteLine("Ваш баланс " + rub + " рублей, " + usd 
                    + " долларов и " + uah + " гривень.");
                Console.Write("Введите " + "0" + " для продолжения или любую клавишу для выхода:");
                userInput = Console.ReadLine();
                
            } while(userInput == continueProgram);


        }
    }
}
