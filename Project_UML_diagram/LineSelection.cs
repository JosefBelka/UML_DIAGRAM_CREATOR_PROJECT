namespace Belka_project_uml_diagram
{
    public class LineSelection : Selection
    {
        
        public LineSelection(Box box, int x, int y) 
            : base(box, x, y)
        {
            
        }

        public override void Move(int x, int y)
        {
            List<Line> lines = _selectedBox.Lines.TakeLast(1).ToList();
            foreach (Line line in lines)
            {
                line.X = x; line.Y = y;
            }
        }
    }
}
