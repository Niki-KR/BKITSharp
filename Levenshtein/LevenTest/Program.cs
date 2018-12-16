using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevenTest {
    class Program {
        static void Main(string[] args) {
            Levenshtein.Levenshtein.WriteDistance("Москва", "Плотва");
        }
    }
}
