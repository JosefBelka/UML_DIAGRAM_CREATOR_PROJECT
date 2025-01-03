using Microsoft.VisualBasic.Devices;
using Project_UML_diagram;

namespace Belka_project_uml_diagram
{
    public class Canvas
    {
        public List<Box> _boxes;
        private Selection? _selection;
        public bool _drawingLine;

        public Canvas(List<Box> boxes)
        {
            _boxes = boxes;
            _selection = null;
            _drawingLine = false;
        }

        public void Draw(Graphics g)
        {
            foreach (Box box in _boxes)
                box.Draw(g);
        }

        public void Select(int x, int y)
        {
            for (int i = 0; i < _boxes.Count; i++)
            {
                Box box = _boxes[i];
                if (box.IsInCollisionWithCorner(x, y))
                {
                    //MessageBox.Show("Corner selected!");

                    _selection = new ResizeSelection(box, x, y);
                    _selection.Select();
                    return;
                }
                else if (box.IsInCollisonWithRedBox(x, y))
                {
                    foreach (Box b in _boxes)
                    {
                        for (int p = 0; p < b.Lines.Count; p++)
                        {
                            if (b.Lines[p].box2 == box)
                                b.Lines.Remove(b.Lines[p]);
                        }
                    }
                    _boxes.Remove(box);
                }
                else if (box.IsInCollisonWithGreenBox(x, y))
                {
                    FormEditClass formEditClass = new FormEditClass(box);
                    formEditClass.ShowDialog();
                }
                else if (box.IsInCollisonWithMid(x, y))
                {
                    Line line = new Line(box, x, y);
                    box.Lines.Add(line);
                    _selection = new LineSelection(box, x, y);
                    _selection.Select();
                    _drawingLine = true;
                    return;
                }
                else if (box.IsInCollision(x, y))
                {
                    _selection = new MoveSelection(box, x, y);
                    _selection.Select();
                    return;
                }
            }
        }
        public void Unselect()
        {

            if (_selection == null)
                return;

            List<Line> l = _selection._selectedBox.Lines.TakeLast(1).ToList();
            if (_drawingLine == true)
            {

                foreach (Box box in _boxes)
                {

                    foreach (Line line in l)
                    {
                        if (box.IsInCollision(line.X, line.Y))
                        {
                            line.box2 = box;

                            line.box1.LineCount++;

                            _selection.Unselect();
                            _drawingLine = false;
                            _selection = null;
                            FormEditLine form = new FormEditLine(line);
                            form.ShowDialog();
                            return;
                        }

                    }
                }
                foreach (Line line in l)
                {
                    _selection._selectedBox.Lines.Remove(line);
                }
                _selection.Unselect();

            }

            else
                _selection.Unselect();
            _drawingLine = false;
            _selection = null;
        }



        public void Move(int x, int y)
        {
            if (_selection == null)
                return;

            _selection.Move(x, y);
        }
    }
}
