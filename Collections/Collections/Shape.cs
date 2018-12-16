using System;

namespace GeometryCollections {
    public abstract class Shape: IComparable {

        public abstract double Area();

        public int CompareTo(object obj) {

            Shape s = (Shape)obj;

            if (Area() > s.Area()) {
                return 1;
            }
            else if (Area() == s.Area()) {
                return 0;
            }
            else {
                return -1;
            }

        }
               
    }
}
