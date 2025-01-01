namespace Belka_project_uml_diagram
{
    public partial class FormCreateClass : Form
    {
        public List<Box> boxes;
        public Canvas _canvas { get; set; }

        public List<MethodUML> Methods { get; set; }
        public List<ClassIUML> Classes { get; set; }

        public FormCreateClass(List<Box> boxes, Canvas canvas)
        {
            InitializeComponent();
            _canvas = canvas;
            this.boxes = boxes;
            Classes = new List<ClassIUML>();
            Methods = new List<MethodUML>();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Box box12 = new Box(30, 150, textBoxClassName.Text, Classes, Methods);
            boxes.Add(box12);
            Close();
        }

        private void buttonAddMethod_Click(object sender, EventArgs e)
        {
            FormAddMethod formAddMethod = new FormAddMethod(Methods);
            formAddMethod.ShowDialog();
        }

        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {
            FormAddAttibute formAddAtt = new FormAddAttibute(Classes);
            formAddAtt.ShowDialog();
        }
    }
}
