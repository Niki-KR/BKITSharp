using System;

namespace Geometry {
    class Square: Rectangle, IPrint {
        public Square(int side) : base(side, side) {

        }

        public override string ToString() {
            return "Квадрат со стороной " + Width.ToString() + " и площадью " + Area().ToString();
        }

        public new void Print() {
            Console.WriteLine(ToString());
        }
    }
}
