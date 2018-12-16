using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic {

    class Program {
        static int Get(char coef) {
            Console.Write("Введите коэффициент {0}: ", coef);
            string str = Console.ReadLine();
            bool res = int.TryParse(str, out int n);
            while (res == false) {
                Console.Write("Введённые данные нельзя преобразовать в целое число. Повторите ввод.\nВведите коэффициент {0}: ", coef);
                str = Console.ReadLine();
                res = int.TryParse(str, out n);
            }
            return n;
        }
        static void Main(string[] args) {
            int a = Get('A');
            int b = Get('B');
            int c = Get('C');
            double d = b * b - (4 * a * c);
            if (d > 0) {
                double x1 = (-Math.Sqrt(d) - b) / (2 * a);
                double x2 = (Math.Sqrt(d) - b) / (2 * a);
                Console.WriteLine("Дискриминант уравнения равен {0}.\nКорни уравнения: {1} и {2}.", d, x1, x2);
            }
            else if (d == 0) {
                double x = -b/(2*a);
                Console.WriteLine("Дискриминант уравнения равен 0.\nУравнение имеет единственный действительный корень: {0}.", x);
            }
            else {
                Console.WriteLine("Дискриминант уравнения {0}.\nУравнение не имеет действительных корней.", d);
            }
            Console.ReadLine();
        }
    }
}

