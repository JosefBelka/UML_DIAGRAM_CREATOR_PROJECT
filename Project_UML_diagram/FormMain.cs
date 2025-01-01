
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Belka_project_uml_diagram
{
    public partial class FormMain : Form
    {
        private Canvas _canvas;
        public List<Box> _boxList;

        public FormMain(List<Box> boxList)
        {
            _boxList = boxList;
            _canvas = new Canvas(_boxList);
            InitializeComponent();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _canvas.Unselect();
            pictureBox.Refresh();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _canvas.Select(e.X, e.Y);
            pictureBox.Refresh();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            _canvas.Move(e.X, e.Y);
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            _canvas.Draw(e.Graphics);
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            FormCreateClass form = new FormCreateClass(_boxList, _canvas);
            form.ShowDialog();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(bmp);
                _canvas.Draw(g);

                bmp.Save(saveFileDialog1.FileName + ".png", ImageFormat.Png);
            }
        }
    }
}
