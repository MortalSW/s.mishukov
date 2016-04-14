using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HomeWorkTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            // можно долго и нудно описывать все кейсы арифметических операций, но это как то грустно, поэтому взъюзнем то что написано до нас.
            // мы же учим ООП язык и к тому-же прикладной :)
            // ввод данных как в задаче, дабы не отклонятся от условий, а можно всё убрать, оставить только ввод строки,
            // где ожидается любое математически выражение поддерживаемое данным методом.

            double L, R = 0;
            string S,SL,SR = "";

            try
            {
                Console.WriteLine("Enter left value:");
                SL = Console.ReadLine();
                Console.WriteLine("\nEnter operand:");
                S = Console.ReadLine();
                Console.WriteLine("\nEnter right value:");
                SR = Console.ReadLine();

                L = Convert.ToDouble(SL);
                R = Convert.ToDouble(SR);
                
                Console.WriteLine("\n"+new DataTable().Compute((L + S + R).Replace(",","."), "").ToString());
            }
            catch
            {
                Console.WriteLine("\nYou did mistake");

                //дабы не отклоняться от т.з. :) вот проверка на деление на 0
                
                /*if (S == "/" && R == 0)
                {
                    Console.WriteLine("Divizion by zero");
                }
                */
                // гы, не прокатило, ибо валидный вариант, проверь ))))

                // И странно! В какойто момент студия стала говорить что не определена S: Use of unassigned local variable 'S'


            }

            Console.WriteLine("\nPress a key");
            Console.ReadKey();
        }
    }
}
