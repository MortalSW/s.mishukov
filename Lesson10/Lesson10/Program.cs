using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson2task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
//            Console.WriteLine("Enter N:");
            //N = Convert.ToInt32(Console.ReadLine());

            //int[] values = new int[N];

            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine("Enter " + i + " variable: ");
            //    values[i] = Convert.ToInt32(Console.ReadLine());
            //    File.AppendAllText(@"c:\s.mishukov\myfile.txt",values[i].ToString()+Environment.NewLine);
            //}

            
            using (StreamReader mySR = new StreamReader(@"c:\s.mishukov\myfile.txt"))
            {
                string myLine = mySR.ReadLine(); 
                while (myLine != null)
                {
                    Console.WriteLine(myLine);
                    myLine = mySR.ReadLine();
                    
                }
            }

            Console.ReadKey();
        }
    }
}
