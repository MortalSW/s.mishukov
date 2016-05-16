﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7homework
{
    struct Fraction : IComparable
    {
        public decimal upPart;
        public decimal downPart;

        public Fraction(decimal upPart, decimal downPart)
        {
            this.upPart = upPart;
            if (downPart == 0)
            {
                throw new DivideByZeroException();
            }
            this.downPart = downPart;
            if (upPart == 0)
            {
                this.downPart = 1;
            }
            Simplify();
        }
        
        public int CompareTo(object obj)
        {
            Fraction comparedFraction = (Fraction)obj;
            decimal f1UpPart = upPart * comparedFraction.downPart;
            decimal f2UpPart = comparedFraction.upPart * downPart;
            if (f1UpPart > f2UpPart)
            {
                return -1;
            }
            else
            if (f1UpPart < f2UpPart)
            {
                return 1;
            }
            return 0;
        }
       
        public void Print()
        {
            Console.WriteLine("{0} / {1}", upPart, downPart);
        }
        public override string ToString()
        {
            return $"{{{upPart}}} / {{{downPart}}}";
        }
        public Fraction Add(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.downPart = f1.downPart * f2.downPart;
            f3.upPart = f1.upPart * f2.downPart + f2.upPart * f1.downPart;
            f3.Simplify();
            return f3;
        }
        public void Add(Fraction f)
        {
            Fraction thisFraction = new Fraction { upPart = this.upPart, downPart = this.downPart };
            Fraction newFraction = new Fraction().Add(thisFraction,f);
            this.downPart = newFraction.downPart;
            this.upPart = newFraction.upPart;
        }

        public Fraction Sub(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.downPart = f1.downPart * f2.downPart;
            f3.upPart = f1.upPart * f2.downPart - f2.upPart * f1.downPart;
            f3.Simplify();
            return f3;
        }
        public void Sub(Fraction f)
        {
            Fraction thisFraction = new Fraction { upPart = this.upPart, downPart = this.downPart };
            Fraction newFraction = new Fraction().Sub(thisFraction, f);
            this.downPart = newFraction.downPart;
            this.upPart = newFraction.upPart;
        }
        public Fraction Multiply(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.downPart = f1.downPart * f2.downPart;
            f3.upPart = f1.upPart * f2.upPart;
            //if (f3.upPart == 0) f3.downPart = 1;
            f3.Simplify();
            return f3;
        }
        public void Multiply(Fraction f)
        {
            Fraction thisFraction = new Fraction { upPart = this.upPart, downPart = this.downPart };
            Fraction newFraction = new Fraction().Multiply(thisFraction, f);
            this.downPart = newFraction.downPart;
            this.upPart = newFraction.upPart;
        }
        public Fraction Divide(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction();
            f3.downPart = f1.downPart * f2.upPart;
            f3.upPart = f1.upPart * f2.downPart;
            if (f2.upPart < 0)
            {
                f3.downPart *= -1;
                f3.upPart *= -1;
            }
            if (f3.downPart == 0) throw new DivideByZeroException();
            f3.Simplify();
            return f3;
        }
        public void Divide(Fraction f)
        {
            Fraction thisFraction = new Fraction { upPart = this.upPart, downPart = this.downPart };
            Fraction newFraction = new Fraction().Divide(thisFraction, f);
            this.downPart = newFraction.downPart;
            this.upPart = newFraction.upPart;
        }
        private bool isSimpleDigit(decimal digit)
        {
            bool isSimple = true;
            for (int i = 2; i < digit; i++)
                if ((digit % i) == 0) isSimple = false;
            return isSimple;
        }
        public void Simplify()
        {
            bool isNeedToSimple = false;
            decimal max = Math.Max(Math.Abs(upPart), Math.Abs(downPart));
            HashSet<decimal> simpleDecimals = new HashSet<decimal>();

            for (decimal i = 2; i < max; i++)
            {
                if (isSimpleDigit(i)) simpleDecimals.Add(i);
            }

            foreach (decimal simpleDigit in simpleDecimals)
            {
                if (upPart % simpleDigit == 0 && downPart % simpleDigit == 0)
                {
                    downPart = downPart / simpleDigit;
                    upPart = upPart / simpleDigit;
                    isNeedToSimple = true;
                }
            }

            if (isNeedToSimple) Simplify();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(2, 3);
            fraction1.Print();
            Fraction fraction2 = new Fraction(2, 3);
            fraction2.Print();
            Fraction fraction3 = new Fraction().Add(fraction1, fraction2);
            fraction3.Print();
            Fraction fraction4 = new Fraction().Sub(fraction1, fraction2);
            fraction4.Print();
            Fraction fraction5 = new Fraction().Divide(fraction1, fraction2);
            fraction5.Print();
            Fraction fraction6 = new Fraction().Multiply(fraction1, fraction2);
            fraction6.Print();

            Console.WriteLine("Add in");
            fraction1.Add(fraction2);
            fraction1.Print();

            Console.WriteLine("Сравнение");
            Console.WriteLine(fraction1.CompareTo(fraction2)+"\n");
            //if (fraction1 > fraction2) Console.WriteLine("{0} > {1}",fraction1.Print,fraction2.Print); 
            // не работает :(

            const int n = 5;

            Fraction[] arrFraction = new Fraction[n];
            Random rnd = new Random();
            
            for (int i = 0; i<5; i++)
            {
                arrFraction[i] = new Fraction { upPart = rnd.Next(-10, 10), downPart = rnd.Next(1, 10) };
                arrFraction[i].Print();
            }

            Fraction sum = new Fraction(0,1);

            Console.WriteLine("просуммируем");
            foreach (Fraction i in arrFraction)
            {
                Console.WriteLine("sum: {0} i {1}",sum.ToString(),i.ToString());
                sum.Add(i);
            }

            sum.Print();

            //arrFraction.Sort();
            // Не понимаю почему не заработало. вроде всё описал...

            Console.ReadKey();
        }
    }
}
