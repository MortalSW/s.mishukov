using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,Z;
            Console.WriteLine("Enter N:");
            N =  Convert.ToInt32(Console.ReadLine());

            int sum,min,max,qua,Y;
            sum = max = qua = min = 0;
            Y = 1;

            for (int i = 0; i<N; i++)
            {
                Console.WriteLine("Enter " + i + " variable: ");
                Z = Convert.ToInt32(Console.ReadLine());
                sum += Z;
                if (Z>max) { max = Z; }
                if (Z < min) { min = Z; }

                if (Z % 2 == 0) { qua++; }
                else Y *= Z;
            }

            Console.WriteLine("Sum: "+sum);
            Console.WriteLine("Max: "+max);
            Console.WriteLine("Quantity: "+qua);
            Console.WriteLine("*: "+Y);

            Console.ReadKey();
        }
    }
}
