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

            do
            {
                int i;
                if ((i = GetInt()) != -1)
                    integers.Add(i);
                else
                    break;
            } while (true);

            foreach (int i in integers.Distinct())
            {
                if (integers.Where(x => x == i).Count() > 1) {
                    Print(i);
                }
            } // СПЛЮ уже, никак не пойму как сделать по другому... уже и с хэшсетом с отбрасыванием пробовал
              // но никак не пойму как сделать.... и с findindex и findindexlast мутил... ошибка
              // или это лучший вариант? всетаки System.Linq по дефолту в проекте )
              // можно конечно заводить несколько листов и во второй пихать если есть такой при вводе, 
              // но это неправильно, хочется научиться работать с листами не при вводе а при наличии такового

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
