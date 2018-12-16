using System;

namespace Geometry {
    class Rectangle : Shape, IPrint {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int w, int h) {
            Width = w;
            Height = h;
        }
        public override double Area() {
            return Width * Height;
        }
        public override string ToString() {
            return "Прямоугольник с шириной " + Width.ToString() + ", высотой " + Height.ToString() + " и площадью " + Area().ToString();
        }
        public void Print() {
            Console.WriteLine(ToString());
        }
    }
}
