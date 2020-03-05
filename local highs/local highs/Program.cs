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
           
            for(int j = 0; j < elements.Length; j++)
            {
                elements[j] = rand.Next(0, 100);
                Console.Write(elements[j] + " ");
            }
            Console.WriteLine("\n ");

            if (elements[0] > elements[1])
                {
                    Console.Write(elements[0] + " ");
                }

            for (int i = 1; i < elements.Length - 1; i++)
            {
                if (elements[i] > elements[i - 1] && elements[i] > elements[i + 1])
                {
                    Console.Write(elements[i] + " ");
                }
            }

            if (elements[elements.Length - 2] < elements[elements.Length - 1])
            {
                Console.Write(elements[elements.Length - 1] + " ");
            }
            Console.ReadKey();
        }
    }
}

        
    

