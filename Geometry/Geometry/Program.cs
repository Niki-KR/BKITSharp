using System;

namespace Geometry {
    class Program {

        static void Main(string[] args) {
            Circle c1 = new Circle(4);
            Square s1 = new Square(10);
            Rectangle r1 = new Rectangle(20, 4);
            c1.Print();
            s1.Print();
            r1.Print();
            Console.ReadLine();
        }
    }
}
