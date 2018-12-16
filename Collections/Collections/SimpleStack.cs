using System;

namespace GeometryCollections {
    class SimpleStack<T>: SimpleList<T> where T: IComparable {

        public void Push(T elem) {
            Add(elem);
        }

        public T Pop() {
            T Result = default(T);
            if (Count == 0) {
                return Result;
            }
            if (Count == 1) {
                Result = First.Data;
                First = null;
                Last = null;
            }
            else {
                SimpleListItem<T> NewLast = GetItem(Count - 2);
                Result = NewLast.Next.Data;
                Last = NewLast;
                NewLast.Next = null;
            }
            Count--;
            return Result;
        }

    }
}
