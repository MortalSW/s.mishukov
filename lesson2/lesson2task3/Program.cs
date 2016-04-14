using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // опустим весь уже неинтересный бред по вводу N
            int N = 5;

            Random rnd = new Random();

            // заюзаем 2 разных по типу массива - только для изучения
            int[,] V = new int[N, N];
            int[][] V2 = new int[N][];

            // количество циклов только для красивой отрисовки, можно конечно для понятности кода сначала данные сформировать, а потом выводить
            // а какой best practice ?

            Console.WriteLine("Matrix 1:");
            for (int i = 0; i < N; i++)
            {
                V2[i] = new int[N];
                for (int j = 0; j < N; j++)
                {
                    // ограничимся диапазоном дабы не выходить за пределы инта и красиво отрисовывать
                    V[i, j] = rnd.Next(-1000,1000);
                    V2[i][j] = rnd.Next(-1000,1000);
                    Console.Write("{0,6}", V[i, j]);
                    if ((j + 1) % N == 0) { Console.WriteLine(); }
                }
            }

            Console.WriteLine("\nMatrix 2:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,6}", V2[i][j]);
                    if ((j + 1) % N == 0) { Console.WriteLine(); }
                }
            }

            Console.WriteLine("\nMatrix summ: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    V[i, j] += V2[i][j];
                    Console.Write("{0,6}", V[i,j]);
                    if ((j + 1) % N == 0) { Console.WriteLine(); }
                }
            }

            Console.WriteLine("\nPress a key");
            Console.ReadKey();

            
        }
    }
}
