using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = GetString();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!charCount.ContainsKey(str[i]))
                {
                    for (int j = i; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                        {
                            if (charCount.ContainsKey(str[i]))
                            {
                                charCount[str[i]]++;
                            }
                            else
                              charCount.Add(str[i], 1);
                        }
                    }
                }
            } //какой-то сложный цикл, как проще?

            foreach (KeyValuePair<char,int> kv in charCount)
            {
                Print(kv.Key.ToString()+" "+kv.Value.ToString());
            }

            Console.ReadKey();
        }
        private static string GetString()
        {
            string Val = "";
            Console.Write("Enter STRING value: ");
            Val = Console.ReadLine();
            return Val;
        }
        private static void Print(string Val)
        {
            Console.WriteLine(Val);
        }

    }
}
