using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[10,10];
            Random rand = new Random();
            int maxElement = int.MinValue;

            for(int i = 0; i < A.GetLength(0); i++)
            {
                for(int j = 0; j < A.GetLength(1); j++)
                {                
                    Console.Write((A[i,j] = rand.Next(10,100)) + " ");
                    if (maxElement < A[i, j])
                    {
                        maxElement = A[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxElement);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (maxElement == A[i, j])
                    {
                      A[i, j] = 0;
                    }
                    Console.Write(A[i, j] +" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
