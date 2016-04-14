using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dimension of the matrix: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] V = new int[N];

            for (int i=0;i<N;i++)
            {
                V[i] = rnd.Next(-1000, 1000);
                Console.Write("{0,5}", V[i]);
            }

            Console.Write("\n\nEnter A value: ");
            int A = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(V, A) >= 0) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }

            Console.Write("\nPress a key");
            Console.ReadKey();
        }
    }
}
