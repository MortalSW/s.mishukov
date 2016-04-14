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
            // оптимизация по: данные присутствуют в переменных, меньшее количество итераций выполнения

            // опустим весь уже неинтересный бред по вводу N
            int N = 5;

            Random rnd = new Random();

            // создадим 3хмерный массив типа 1 т.к. данные будут всегда
            int[,,] V = new int[2, N, N];

            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        V[k, i, j] = rnd.Next(-1000,1000);
                    }
                }
            }


            Console.WriteLine("Matrix 1:");
            for (int i = 0; i < N; i++)
            {
                V2[i] = new int[N];
                for (int j = 0; j < N; j++)
                {
                    // ограничимся диапазоном дабы не выходить за пределы инта
                    V[i, j] = rnd.Next(-1000, 1000);
                    V2[i][j] = rnd.Next(-1000, 1000);
                    Console.Write("{0,11}", V[i, j]);
                    if ((j + 1) % N == 0) { Console.WriteLine(); }
                }
            }

            Console.WriteLine("Matrix 2:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    V[i, j] += V2[i][j];
                    Console.Write("{0,11}", V2[i][j]);
                    if ((j + 1) % N == 0) { Console.WriteLine(); }
                }
            }

            Console.WriteLine("Matrix summ: ");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,11}", V[i, j]);
                    if ((j + 1) % N == 0) { Console.WriteLine(); }
                }
            }

            // Пригласим в оптимизированный код
            Console.WriteLine("See optimized code in lesson2task3optimized");

            Console.ReadKey();


        }
    }
}
