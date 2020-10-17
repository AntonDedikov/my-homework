using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversionFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertToInt(out int inputConvert);
            Console.WriteLine("число " + inputConvert + " успешно сконвертировано");
            Console.ReadKey();
        }
        static void ConvertToInt(out int inputConvert)
        {
            bool correctlyInput = true;
            do
            {
                Console.Write("Впишите число для конвертации:");
                string userInput = Console.ReadLine();
                correctlyInput = int.TryParse(userInput, out inputConvert);
                Console.Clear();
            } while (correctlyInput == false);
        }
    }
}
