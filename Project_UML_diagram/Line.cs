namespace Belka_project_uml_diagram
{
    public class Line
    {
        public Box box1;
        public int X;
        public int Y;
        public Box box2;
        public string Multi1;
        public string Multi2;

        public Line(Box box1, int x, int y)
        {
            this.box1 = box1;
            X = x;
            Y = y;
            Multi1 = "*";
            Multi2 = "1";
        }

        public Line(Box box1, int x, int y, Box box)
        {
            this.box1 = box1;
            X = x;
            Y = y;
            box2 = box;
            Multi1 = "*";
            Multi2 = "1";
        }

        

        
    }
}
