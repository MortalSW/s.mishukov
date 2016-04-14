using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// fake
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp;
            int a;
            int b;
            Console.WriteLine("Enter a:");
            inp = Console.ReadLine();
            a = Convert.ToInt32(inp);
            Console.WriteLine("Enter b:");
            inp = Console.ReadLine();
            b = Convert.ToInt32(inp);
            a = a + b;
            Console.WriteLine(a);


            Console.WriteLine("\nEnter n:");
            inp = Console.ReadLine();
            int n = Convert.ToInt32(inp);
            Console.WriteLine("Enter i:");
            inp = Console.ReadLine();
            int i = Convert.ToInt32(inp);

            n = (n >> i) & 1;

            Console.WriteLine(n);

            Console.WriteLine("\nEnter n:");
            inp = Console.ReadLine();
            n = Convert.ToInt32(inp);

            n = n >> 1;
            n = n << 1;

            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
