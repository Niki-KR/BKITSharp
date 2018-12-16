using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files {
    public static class SubLists {
        public static List<MinMax> SplitList(int firstIndex, int lastIndex, int subListCount) {
            List<MinMax> result = new List<MinMax>();
            if (lastIndex - firstIndex <= subListCount) {
                result.Add(new MinMax(0, lastIndex - firstIndex));
                return result;
            }
            int subListSize = (lastIndex - firstIndex) / subListCount;
            int currentFirstIndex = firstIndex;
            while (lastIndex - currentFirstIndex >= 2*subListSize) {
                result.Add(new MinMax(currentFirstIndex, currentFirstIndex + subListSize));
                currentFirstIndex += subListSize;
            }
            result.Add(new MinMax (currentFirstIndex, lastIndex));
            return result;
        }

    }
}
