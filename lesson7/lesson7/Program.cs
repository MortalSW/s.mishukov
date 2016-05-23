// fake change

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7homework
{
    struct Fraction : IComparable
    {
        public int upPart { get; }
        public int downPart { get; }
        private static int GreatestCommonDivisor(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        public Fraction(int inUpPart, int inDownPart) : this() // ох уж и намучился я с этим this вернее с его отсутствием, зато кровью понял
                                                               // что объект должен быть перед использованием быть инициализированным гад
        {
            if (inDownPart == 0)
            {
                throw new DivideByZeroException();
            }
            downPart = inDownPart;
            if (inUpPart == 0)
            {
                downPart = 1;
            }
            int gdc = GreatestCommonDivisor(inUpPart, inDownPart);
            upPart = inUpPart / gdc;
            downPart = inDownPart / gdc;
        }
        public int CompareTo(object obj)
        {
            Fraction comparedFraction = (Fraction)obj;
            int f1UpPart = upPart * comparedFraction.downPart;
            int f2UpPart = comparedFraction.upPart * downPart;
            if (f1UpPart > f2UpPart)
            {
                return 1;
            }
            else
            if (f1UpPart < f2UpPart)
            {
                return -1;
            }
            return 0;
        }
        public void Print()
        {
            Console.WriteLine("{0} / {1}", upPart, downPart);
        }
        public override string ToString()
        {
            return $"{upPart} / {downPart}"; // тут ты в лекции что-то напутал. вот так работает гуд, а если куча скобок, лишние выдает
        }
        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            return new Fraction(f1.upPart * f2.downPart + f2.upPart * f1.downPart, f1.downPart * f2.downPart);
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.upPart * f2.downPart - f2.upPart * f1.downPart, f1.downPart * f2.downPart);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.upPart * f2.upPart, f1.downPart * f2.downPart);
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int downPart = f1.downPart * f2.upPart;
            int upPart = f1.upPart * f2.downPart;
            if (f2.upPart < 0)
            {
                downPart *= -1;
                upPart *= -1;
            }
            if (downPart == 0) throw new DivideByZeroException();
            return new Fraction(upPart, downPart);
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            return (f1.upPart * f2.downPart > f2.upPart * f1.downPart);
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            return (f1.upPart * f2.downPart < f2.upPart * f1.downPart);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 2);
            fraction1.Print();
            Fraction fraction2 = new Fraction(1, 2);
            fraction2.Print();
            Fraction fraction3 = fraction1 + fraction2;
            fraction3.Print();
            Fraction fraction4 = fraction1 - fraction2;
            fraction4.Print();
            Fraction fraction5 = fraction1 * fraction2;
            fraction5.Print();
            Fraction fraction6 = fraction1 / fraction2;
            fraction6.Print();

            Console.WriteLine("\nСравнение");
            if (fraction1 > fraction2)
            {
                Console.WriteLine("{0} > {1}", fraction1.ToString(), fraction2.ToString());
            }
            else
            {
                if (fraction1 < fraction2)
                {
                    Console.WriteLine("{0} < {1}", fraction1.ToString(), fraction2.ToString());
                }
                else
                {
                    Console.WriteLine("{0} = {1}", fraction1.ToString(), fraction2.ToString());
                }
            }

            Console.WriteLine("\nList of random fractions");
            const int N = 5;
            List<Fraction> listFraction = new List<Fraction>();

            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                listFraction.Add(new Fraction(rnd.Next(-10, 10), rnd.Next(1, 10)));
                listFraction[i].Print();
            }

            Fraction sum = new Fraction(0, 1);

            Console.WriteLine("\nПросуммируем");
            foreach (Fraction i in listFraction)
            {
                sum += i;
                Console.WriteLine("i: {0} sum: {1}", i.ToString(), sum.ToString());
            }
            sum.Print();

            listFraction.Sort();
            Console.WriteLine();
            foreach (Fraction i in listFraction)
            {
                i.Print();
            }

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();

        }
    }
}
