using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter N:");
            N = Convert.ToInt32(Console.ReadLine());

            int[] values = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter " + i + " variable: ");
                values[i] = Convert.ToInt32(Console.ReadLine());

            }

            Array.Sort(values);
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(values[i]);
            }

            Console.ReadKey();
        }
    }
}
