using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;


namespace ClassLibrary1
{
    public class Class1
    {
        public static double Sum(double a, double b)
        {
            double c = a + b;
            return c;
        }
        public static double Difference(double a, double b)
        {
            double c = a - b;
            return c;
        }
        public static double Degree(double a, double b)
        {
            double c = a / b;
            return c;
        }

        public static double Square(double a)
        {
            a *= a;
            return a;
        }
        public static double Multiplication(double a, double b)
        {
            double c = a * b;
            return c;
        }
        public static double Stepen(double a, double b)
        {
            a = Pow(a, b);
            return a;
        }
        

        public static double Sqrt1(double a)
        {
            a = Sqrt(a);
            return a;
        }
        public static double Rounding(double a)
        {
            a = Round(a);
            return a;
        }
        public static double AreaCircle(double r)
        {
            double S = PI * Pow(r, 2);
            return S;
        }
        public static double SquareArea(double a)
        {
            a = Pow(a, 2);
            return a;
        }
        //10
    }
}
