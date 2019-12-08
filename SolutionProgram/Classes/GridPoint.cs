namespace AdventOfCode
{
    public class GridPoint {
        
        public GridPoint() {}

        public int steps {get; set;}
        private int horizontalId;
        private int verticalId;
        private bool horizontalWire;
        private bool verticalWire;
        public bool isIntersection { 
            get {
                 return horizontalWire && verticalWire && (verticalId != horizontalId);
                 }
            }

        public void setVertical(bool value, int hash) {
            verticalId = hash;
            verticalWire = value;
        }
        public void setHorizontal(bool value, int hash) {
            horizontalId = hash;
            horizontalWire = value;
        }

    }



}