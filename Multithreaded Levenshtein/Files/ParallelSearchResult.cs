using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files {
    public class ParallelSearchResult {
        public string Word { get; set; }
        public int Dist { get; set; }
        public int Thread { get; set; }
        public ParallelSearchResult(string w, int d, int t) {
            Word = w;
            Dist = d;
            Thread = t;
        }
    }
}
