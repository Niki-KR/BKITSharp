using System;

namespace GeometryCollections {
    class Circle: Shape, IPrint {

        public int Radius { get; set; }

        public Circle(int a) {
            Radius = a;
        }

        public override double Area() {
            return Math.PI * Radius * Radius;
        }

        public override string ToString() {
            return "Круг радиуса " + Radius.ToString() + " и площадью " + Area().ToString();
        }

        public void Print() {
            Console.WriteLine(ToString());
        }
    }
}
