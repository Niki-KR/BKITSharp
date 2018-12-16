using System;
using System.Collections.Generic;
using System.Collections;


namespace GeometryCollections {
    class Program {
        static void Main(string[] args) {
            Shape c1 = new Circle(10), c2 = new Circle(7);
            Shape r1 = new Rectangle(4, 15), r2 = new Rectangle(20, 5);
            Shape s1 = new Square(8), s2 = new Square(6);
            Console.WriteLine("ArrayList\n");
            ArrayList arr = new ArrayList {
                c1, r1, s1, c2, r2, s2
            };
            arr.Sort();
            foreach (Shape s in arr) {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("\nList\n");
            List<Shape> list = new List<Shape> {
                c1, r1, s1, c2, r2, s2
            };
            list.Sort();
            foreach (Shape s in list) {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("\nMatrix\n");
            Matrix<Shape> matr = new Matrix<Shape>(3, 3, 2, new ShapeMatrixCheckEmpty());
            matr[0, 0, 0] = c1;
            matr[1, 1, 0] = s1;
            matr[2, 2, 0] = r1;
            matr[0, 0, 1] = c2;
            matr[1, 1, 1] = s2;
            matr[2, 2, 1] = r2;
            Console.WriteLine(matr.ToString());
            Console.WriteLine("\nSimpleList\n");
            SimpleList<Shape> slist = new SimpleList<Shape> {
                c1, s1, r1, c2, s2, r2
            };
            slist.Sort();
            foreach (var s in slist) {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine("\nSimpleStack\n");
            SimpleStack<Shape> stack = new SimpleStack<Shape>();
            stack.Push(s1);
            stack.Push(c1);
            stack.Push(c2);
            stack.Push(r2);
            stack.Push(r1);
            foreach (var s in stack) {
                Console.WriteLine(s.ToString());
            }
            Shape popped = stack.Pop();
            Console.WriteLine("\nИз стека удалён " + popped.ToString() + "\n");
            foreach (var s in stack) {
                Console.WriteLine(s.ToString());
            }
            Console.ReadLine();
        }
    }
}
