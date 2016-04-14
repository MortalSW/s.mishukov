using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 4;
            int M = 8;
            Random rnd = new Random();
            int[,] V = new int[N, M];
            int[] minV = new int[N];

            Console.WriteLine("Matrix:");
            for (int i = 0; i < N; i++)
            {
                minV[i] = V[i, 0];
                for (int j = 0; j < M; j++)
                {
                    V[i, j] = rnd.Next(-1000, 1000);
                    if (minV[i] > V[i, j]) { minV[i] = V[i, j]; }
                    Console.Write("{0,6}", V[i, j]);
                    if ((j + 1) % M == 0) { Console.WriteLine(); }
                }
            }

            Console.WriteLine("Min values: ");
            for (int i = 0; i<N; i++)
            {
                Console.Write("{0,6}",minV[i]);
            }

            Array.Sort(minV);
            Array.Reverse(minV);

            Console.WriteLine("\n\nSorted reversed values: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0,6}", minV[i]);
            }

            Console.Write("\n\nPress a key");
            Console.ReadKey();
        }
    }
}
