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
            int valInt = GetInt();
            float valFloat = GetFloat();
            string valString = GetString();
            int[] valIntArr = GetIntArr();
            float[] valFloatArr = GetFloatArr();

            Print(valInt);
            Print(valFloat);
            Print(valString);
            Print(valIntArr);
            Print(valFloatArr);

            Console.ReadKey();
        }

        private static int GetInt()
        {
            int Val = 0;
            Console.Write("Enter INTEGER value (will zero if error): ");
            int.TryParse(Console.ReadLine(), out Val);
            return Val;
        }

        private static float GetFloat()
        {
            float Val = 0;
            Console.Write("Enter FLOAT value (will zero if error): ");
            float.TryParse(Console.ReadLine(), out Val);
            return Val;
        }

        private static string GetString()
        {
            string Val = "";
            Console.Write("Enter STRING value: ");
            Val = Console.ReadLine();
            return Val;
        }

        private static int[] GetIntArr()
        {
            
            Console.WriteLine("Enter arrayInt length: ");
            int arrLen = GetInt();

            int[] arr = new int[arrLen];

            for (int i = 0; i<arrLen;i++)
            {
                Console.WriteLine("Enter "+i+" element: ");
                arr[i] = GetInt();
            }
            return arr;
        }

        private static float[] GetFloatArr()
        {
            Console.WriteLine("Enter arrayFloat length: ");
            int arrLen = GetInt();

            float[] arr = new float[arrLen];

            for (int i = 0; i < arrLen; i++)
            {
                Console.WriteLine("Enter " + i + " element: ");
                arr[i] = GetFloat();
            }
            return arr;
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
            for (int i = 0; i < Val.Length; i++)
            {
                Console.WriteLine(Val[i]);
            }
        }

        private static void Print(float[] Val)
        {
            for (int i = 0; i < Val.Length; i++)
            {
                Console.WriteLine(Val[i]);
            }
        }
    }
}
