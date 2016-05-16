using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // classwork
            Phone phone1 = new Phone(999999);
            Phone phone2 = new Phone(3854, 369664);

            Console.WriteLine(phone1.ToString());
            Console.WriteLine(phone2.ToString());

            Console.ReadKey();

            //classwork 2
            // к сожалению не понял что нужно сделать, 
            // ибо как бы и так всё прикрыто извне от прямого вмешательства
            // было бы неплохо услышать или увидеть пояснения
            // ну или на доп. занятии.
        }
    }
}
