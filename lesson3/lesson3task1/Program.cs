using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[1] = 1;
            arr[2] = 2;
            Print(arr);

            Console.ReadKey();
        }

        private static int GetInt()
        {
            int Val = 0;
            int.TryParse(Console.ReadLine(), out Val);
            return Val;
        }

        private static float GetFloat()
        {
            float Val = 0;
            float.TryParse(Console.ReadLine(), out Val);
            return Val;
        }

        private static void Print(int Val)
        {
            Console.WriteLine(Val);
        }

        private static void Print(float Val)
        {
            Console.WriteLine(Val);
        }

        private static void Print(string Val)
        {
            Console.WriteLine(Val);
        }

        private static void Print(int[] Val)
        {
            Console.WriteLine(Val);
        }
    }
}
