using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[rand.Next(15,30)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10,100);
            }
            WriteNamberArray(array);
            Shuffle(array);
            WriteNamberArray(array);
            Console.ReadKey();
        }
        static void Shuffle(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int randIndex = rand.Next(0,array.Length);
                int randIndex2 = rand.Next(0,array.Length);
                int tempNamber = array[randIndex];
                array[randIndex] = array[randIndex2];
                array[randIndex2] = tempNamber;
            }
        }
        static void WriteNamberArray(int[] array)
        {
            foreach (int namber in array)
            {
                Console.Write(namber + " ");
            }
            Console.WriteLine();
        }
    }
}
