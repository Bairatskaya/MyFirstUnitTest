using System;
using System.Collections.Generic;
using System.Text;

namespace calculator._21._12.unit
{
 
    
        public class Metod_calculat
        {
            public static double Plus(double a, double b)
            {
                return a + b;
            }
            public static double Minus(double a, double b)
            {
                return a - b;
            }
            public static double Multiply(double a, double b)
            {
                return a * b;
            }
            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("na nol` ne deli");
                }
                return a / b;
            }
            public static double Square(double a)
            {
                if (a < 0)
                {
                    throw new ArgumentException("ne nizhe nulya");
                }
                return Math.Sqrt(a);
            }
        }
}
