using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates {
    public delegate double Calc(int p1, int p2, double p3);

    
    class Program {
        public static double PlusMinus(int p1, int p2, double p3) {
            return p1 + p2 - p3;
        }
        public static double MinusMinus(int p1, int p2, double p3) {
            return p1 - p2 - p3;
        }

        public static double PlusDivide(int p1, int p2, double p3) {
            return (p1 + p2) / p3;
        }

        public static void CalcMethod(int p1, int p2, double p3, Calc c) {
            double result = c(p1, p2, p3);
            Console.WriteLine(result);
        }

        public static void CalcFuncMethod(int p1, int p2, double p3, Func<int, int, double, double> f) {
            double result = f(p1, p2, p3);
            Console.WriteLine(result);
        }

        static void Main(string[] args) {
            int i1 = 7, i2 = 3;
            double i3 = 4;
            Console.WriteLine("Вызовы методов, принимающих обыкновенный делегат.");
            CalcMethod(i1, i2, i3, PlusMinus);
            CalcMethod(i1, i2, i3, MinusMinus);
            CalcMethod(i1, i2, i3, PlusDivide);
            CalcMethod(i1, i2, i3, (int x, int y, double z) => {
                double res = (x * y) / z;
                return res;
            });
            Console.WriteLine("Вызовы методов, принимающих обобщенный делегат типа Func.");
            CalcFuncMethod(i1, i2, i3, PlusMinus);
            CalcFuncMethod(i1, i2, i3, MinusMinus);
            CalcFuncMethod(i1, i2, i3, PlusDivide);
            CalcFuncMethod(i1, i2, i3, (int x, int y, double z) => {
                double res = (x * y) / z;
                return res;
            });
            Console.ReadLine();
        }
    }
}
