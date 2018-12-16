using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levenshtein {
    public static class Levenshtein {
        public static int Distance(string str1, string str2) {
            int strlen1 = str1.Length, strlen2 = str2.Length;

            //проверка на пустую строку
            if (strlen1 == 0 || strlen2 == 0) {
                if (strlen1 != 0) {
                    return strlen1;
                }
                else {
                    return strlen2;
                }
            }
            string s1 = str1.ToUpper(), s2 = str2.ToUpper();
            int[,] matrix = new int[strlen1 + 1, strlen2 + 1];

            //первая строка и столбец матрицы
            for (int i = 0; i <= strlen1; i++) {
                matrix[i, 0] = i;
            }
            for (int j = 0; j <= strlen2; j++) {
                matrix[0, j] = j;
            }

            //остальные ячейки матрицы
            for (int i = 1; i <= strlen1; i++) {
                for (int j = 1; j <= strlen2; j++) {
                    int equal;
                    if (s1.Substring(i - 1, 1) == s2.Substring(j - 1, 1)) {
                        equal = 0;
                    }
                    else {
                        equal = 1;
                    }
                    matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1), matrix[i - 1, j - 1] + equal);
                    if ((i > 1) && (j > 1) &&
                    (s1.Substring(i - 1, 1) == s2.Substring(j - 1, 1)) &&
                    (s1.Substring(i - 2, 1) == s2.Substring(j - 2, 1))) {
                        matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + equal);
                    }
                }
            }
            
            //возврат результата
            return matrix[strlen1, strlen2];
        }

        public static void WriteDistance(string str1, string str2) {
            Console.WriteLine(Distance(str1, str2));
            Console.ReadLine();
        }
    }
}

