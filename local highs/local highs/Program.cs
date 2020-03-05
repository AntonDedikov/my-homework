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
            Console.WriteLine("\n ");

            if (elements[0] > elements[1])
                {
                    maxElement = elements[0];
                    Console.Write(maxElement + " ");
                }

            for (int i = 1; i < elements.Length - 1; i++)
            {
                if (elements[i] > elements[i - 1] && elements[i] > elements[i + 1])
                {
                    maxElement = elements[i];
                    Console.Write(maxElement + " ");
                }

                if (elements.Length - 2 == i && elements[i] < elements[i + 1])
                {
                    maxElement = elements[i + 1];
                    Console.Write(maxElement + " ");
                }
            }                 
            Console.ReadKey();
        }
    }
}

        
    

