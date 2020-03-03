using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_specific_rows_columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] number = new int[3, 5] { { 10, 2, 3, 4, 5 }, { 20, 7, 4, 4, 5 }, { 10, 2, 3, 4, 5 } };
            int sumTwoString = 0;
            int firstRowProduct = 1;

            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    if (i == 1)
                    {
                        sumTwoString += number[i, j];
                    }
                    if (j == 0)
                    {
                        firstRowProduct *= number[i, j];
                    }
                    Console.Write(number[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма второй строки " + sumTwoString);
            Console.WriteLine("Произведение первого столбца " + firstRowProduct);
            Console.ReadKey();
        }
    }
}
