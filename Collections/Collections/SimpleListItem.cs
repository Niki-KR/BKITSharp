namespace GeometryCollections {
    public class SimpleListItem<T> {
        
        public T Data { get; set; }

        public SimpleListItem<T> Next { get; set; }

        public SimpleListItem(T param) {
            Data = param;
        }

    }
}
