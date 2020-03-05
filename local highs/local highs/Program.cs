using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_highs
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] elements = new int[30];
            Random rand = new Random();
            int maxElement  = int.MinValue;
           
            for(int j = 0; j < elements.Length; j++)
            {
                elements[j] = rand.Next(0, 100);
                Console.Write(elements[j] + " ");
            }
            Console.WriteLine();

            if (elements[1] > elements[2])
                {
                    maxElement = elements[1];
                    Console.Write("Локальные максимумы: " + maxElement + " ");
                }

            for (int i = 1; i < elements.Length - 1; i++)
            {
                if (elements[i] > elements[i - 1] && elements[i] > elements[i + 1])
                {
                    maxElement = elements[i];
                    Console.Write(maxElement + " ");
                }
            }

            if (elements[29] > elements[28])
            {
                    maxElement = elements[29];
                    Console.Write(maxElement + " ");
            }
            Console.ReadKey();
        }
    }
}

        
    

