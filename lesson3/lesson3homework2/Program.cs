using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();

            Print("Enter values, when -1, then exit");

            { //так вложим чтобы i была локальной для цикла этого только
                int i;
                do
                {
                    if ((i = GetInt()) != -1)
                        integers.Add(i);
                    else
                        break;
                } while (true);
            }

            Print("\nVersion 1:");
            foreach (int i in integers.Distinct())
            {
                if (integers.Where(item => item == i).Count() > 1)
                {
                    Print(i+" has duplicates");
                }
            } // СПЛЮ уже, никак не пойму как сделать по другому... уже и с хэшсетом с отбрасыванием пробовал
              // и с findindex и findindexlast мутил... ошибка
              // или это лучший вариант? всетаки System.Linq по дефолту в проекте )
              // можно конечно заводить несколько листов и во второй пихать если есть такой при вводе, 
              // но это неправильно, хочется научиться работать с листами не при вводе а при наличии такового

            // во придумаааал ))
            // утро вечера мудреней
            Print("\nVersion 2:");
            integers.Sort(); 
            int last = -1;

            for (int i = 0; i < integers.Count - 1; i++)
            {
                if (integers[i] == integers[i+1] && last != integers[i])
                {
                    Print("" + integers[i] + " has duplicates");
                    last = integers[i];
                }
            }

            Console.ReadKey();
        }
        private static int GetInt()
        {
            int Val = 0;
            Console.Write("Enter INTEGER value (will zero if error): ");
            int.TryParse(Console.ReadLine(), out Val);
            return Val;
        }
        private static void Print(int Val)
        {
            Console.WriteLine(Val);
        }
        private static void Print(string Val)
        {
            Console.WriteLine(Val);
        }


    }
}
