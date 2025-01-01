using System.Security.Cryptography.X509Certificates;

namespace Belka_project_uml_diagram
{
    public class Box
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public string className { get; set; }

        public int MinWidth => className.Length*8+160;
        public int MinHeight => classes.Count * 15 + Methods.Count * 15 + 75 + (LineCount*15);
        public int MaxWidth => 1000;
        public int MaxHeight => 1000;

        public int LineCount;

        public List<ClassIUML> classes;
        public List<MethodUML> Methods;
        public List<Line> Lines;

        private Brush _color;

        private Pen _pen;

        public Box(int x, int y, string Classname, List<ClassIUML> Classes, List<MethodUML> methods)
        {
            PositionX = x;
            PositionY = y;
            Width = 80;
            Height = 80;
            _color = Brushes.Beige;
            className = Classname;
            classes = Classes;
            Methods = methods;
            _pen = Pens.Black;
            Lines = new List<Line>();
            LineCount = 0;
        }

        public void Select()
        {
            _pen = Pens.Red;
        }

        public void Unselect()
        {
            _pen = Pens.Black;
        }

        public void Move(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public void Resize(int w, int h)
        {
            if (w < MinWidth)
                w = MinWidth;

            if (h < MinHeight)
                h = MinHeight;

            if (w > MaxWidth)
                w = MaxWidth;

            if (h > MaxHeight)
                h = MaxHeight;

            Width = w;
            Height = h;
        }

        public void Draw(Graphics g)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            g.TranslateTransform(PositionX, PositionY);
            g.FillRectangle(_color, 0, 0, Width, Height);
            g.FillRectangle(Brushes.Red, 0, 0, 15, 15);
            g.DrawLine(Pens.White, 3, 3, 12, 12);
            g.DrawLine(Pens.White, 3, 12, 12, 3);
            g.FillRectangle(Brushes.Lime, Width - 40, 0, 40, 15);
            g.DrawString("EDIT", new Font("Arial", 9), Brushes.Black, Width - 20, 7, stringFormat);
            g.FillRectangle(Brushes.Black, Width - 5, Height - 5, 5, 5);
            g.FillRectangle(Brushes.Blue, Width - 6, Height / 2 - 3, 6, 6);
            g.DrawString(className, new Font("Arial", 10), Brushes.Black, Width / 2, 10, stringFormat);
            g.DrawLine(_pen, 0, 0, Width, 0);
            g.DrawLine(_pen, 0, 0, 0, Height);
            g.DrawLine(_pen, 0, Height, Width, Height);
            g.DrawLine(_pen, Width, 0, Width, Height);
            g.DrawLine(_pen, 0, 20, Width, 20);
            int a = 30;
            foreach (ClassIUML item in classes)
            {
                g.DrawString(item.ToString(), new Font("Arial", 8), Brushes.Black, 10, a);
                a = a + 15;
            }
            a = 15;
            g.DrawLine(_pen, 0, classes.Count * a + 40, Width, classes.Count * a + 40);
            int b = classes.Count * a + 50;
            foreach (MethodUML item in Methods)
            {
                g.DrawString(item.ToString(), new Font("Arial", 8), Brushes.Black, 10, b);
                b = b + 15;
            }
            g.ResetTransform();

            int c = 0;

            foreach (Line l in Lines)
            {
                if (l.box2 == null)
                    g.DrawLine(Pens.Red, PositionX + l.box1.Width, PositionY + l.box1.Height / 2, l.X, l.Y);
                else
                {
                    
                    g.DrawLine(Pens.Red, PositionX + l.box1.Width + 10, PositionY + l.box1.Height / 2 + (c * 20), l.box2.PositionX - 10, l.box2.PositionY + l.box2.Height / 2);

                    g.DrawString(l.Multi1, new Font("Arial", 12), Brushes.Red, PositionX + l.box1.Width, PositionY + l.box1.Height / 2 - 15 + (c*20));
                    g.DrawString(l.Multi2, new Font("Arial", 9), Brushes.Red, l.box2.PositionX - 10, l.box2.PositionY + l.box2.Height / 2 - 15);


                    g.DrawLine(Pens.Red, PositionX + l.box1.Width, PositionY + l.box1.Height / 2 + (c * 20), PositionX + l.box1.Width + 10, PositionY + l.box1.Height / 2 + 5 + (c * 20));
                    g.DrawLine(Pens.Red, PositionX + l.box1.Width, PositionY + l.box1.Height / 2 + (c * 20), PositionX + l.box1.Width + 10, PositionY + l.box1.Height / 2 - 5 + (c * 20));
                    g.DrawLine(Pens.Red, PositionX + l.box1.Width + 10, PositionY + l.box1.Height / 2 + 5 + (c * 20), PositionX + l.box1.Width + 10, PositionY + l.box1.Height / 2 - 5 + (c * 20));

                    g.DrawLine(Pens.Red, l.box2.PositionX, l.box2.PositionY + l.box2.Height / 2, l.box2.PositionX - 10, l.box2.PositionY + l.box2.Height / 2 + 5);
                    g.DrawLine(Pens.Red, l.box2.PositionX, l.box2.PositionY + l.box2.Height / 2, l.box2.PositionX - 10, l.box2.PositionY + l.box2.Height / 2 - 5);
                    g.DrawLine(Pens.Red, l.box2.PositionX - 10, l.box2.PositionY + l.box2.Height / 2 + 5, l.box2.PositionX - 10, l.box2.PositionY + l.box2.Height / 2 - 5);

                    c++;
                }
            }

            if (Width < MinWidth)
                Resize(MinWidth, MinHeight);
        }

        public bool IsInCollision(int x, int y)
        {
            return x > PositionX && x <= PositionX + Width
                && y > PositionY && y <= PositionY + Height;
        }

        public bool IsInCollisionWithCorner(int x, int y)
        {
            return x > (PositionX + Width - 10) && x <= PositionX + Width
                && y > (PositionY + Height - 10) && y <= PositionY + Height;
        }

        public bool IsInCollisonWithMid(int x, int y)
        {
            return x > (PositionX + Width - 6) && x <= PositionX + Width
                 && y > (PositionY + Height / 2 - 6) && y <= PositionY + Height;
        }

        public bool IsInCollisonWithRedBox(int x, int y)
        {
            return x >= PositionX && x <= PositionX + 10
                && y >= PositionY && y <= PositionY + 10;
        }

        public bool IsInCollisonWithGreenBox(int x, int y)
        {
            return x <= PositionX + Width && x >= PositionX + Width - 40
                && y >= PositionY && y <= PositionY + 15;
        }
    }
}
