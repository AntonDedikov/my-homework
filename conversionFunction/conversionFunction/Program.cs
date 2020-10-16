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
            bool correctlyInput;
            int inputConvert;

            do
            {
                Console.Write("Впишите число для конвертации:");
                string userInput = Console.ReadLine();
                ConvertatorInt(userInput, out correctlyInput, out inputConvert);
                Console.Clear();
            } while (correctlyInput == false);

            Console.WriteLine("число " + inputConvert + " успешно сконвертировано");
            Console.ReadKey();
        }
        static void ConvertatorInt(string x, out bool y, out int z)
        {
            y = int.TryParse(x, out z);
        }
    }
}
