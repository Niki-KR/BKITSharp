using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryCollections {
    class Matrix<T> {

        Dictionary<string, T> _matrix = new Dictionary<string, T>();
        int maxX, maxY, maxZ;

        IMatrixCheckEmpty<T> CheckEmpty;

        public Matrix(int xx, int yy, int zz, IMatrixCheckEmpty<T> CheckEmptyParam) {
            maxX = xx;
            maxY = yy;
            maxZ = zz;
            CheckEmpty = CheckEmptyParam;
        }

        string DictKey(int x, int y, int z) {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }

        void CheckBounds(int x, int y, int z) {
            if (x < 0 || x >= maxX) {
                throw new ArgumentOutOfRangeException("x", "x=" + x.ToString() + " выходит за границы.");
            }
            if (y < 0 || y >= maxY) {
                throw new ArgumentOutOfRangeException("y", "y=" + y.ToString() + " выходит за границы.");
            }
            if (z < 0 || z >= maxZ) {
                throw new ArgumentOutOfRangeException("z", "z=" + z.ToString() + " выходит за границы.");
            }
        }

        public T this[int x, int y, int z] {
            set {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                _matrix.Add(key, value);
            }

            get {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (_matrix.ContainsKey(key)) {
                    return _matrix[key];
                }
                else {
                    return CheckEmpty.GetEmptyElement();
                }
            }
        }

        public override string ToString() {
            StringBuilder tab = new StringBuilder();
            for (int k = 0; k < maxZ; k++) {
                tab.Append("Z = " + k.ToString() + "\n\n");
                for (int j = 0; j < maxY; j++) {
                    tab.Append("[");
                    for (int i = 0; i < maxX; i++) {
                        if (i > 0) {
                            tab.Append('\t');
                        }
                        if (!CheckEmpty.CheckEmptyElement(this[i, j, k])) {
                            tab.Append(this[i, j, k].ToString());
                        }
                        else {
                            tab.Append(" . ");
                        }
                    }
                    tab.Append("]\n");
                }
                if (k < maxZ - 1) {
                    tab.Append("\n==========================================================================\n\n");
                }
            }
            return tab.ToString();
        }

    }
}
