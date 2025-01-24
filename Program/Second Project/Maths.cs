using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Part_01.Second_Project
{
    internal static class Maths
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }


        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }


        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }


        public static int Divide(int x, int y)
        {
            if (0 == y) throw new DivideByZeroException();

            return x / y;
        }
        public static double Divide(double x, double y)
        {
            if (0 == y) throw new DivideByZeroException();

            return x / y;
        }
    }
}
