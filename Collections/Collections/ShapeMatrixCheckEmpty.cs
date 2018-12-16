namespace GeometryCollections {
    class ShapeMatrixCheckEmpty: IMatrixCheckEmpty<Shape> {
        
        public Shape GetEmptyElement() {
            return null;
        }

        public bool CheckEmptyElement(Shape element) {
            if (element == null) {
                return true;
            } 
            else {
                return false;
            }
        }

    }
}
