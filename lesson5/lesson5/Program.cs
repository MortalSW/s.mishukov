using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient1 = new Client();
            Console.WriteLine(myClient1.identifier);
            
            Console.ReadKey();
        }
    }
}
