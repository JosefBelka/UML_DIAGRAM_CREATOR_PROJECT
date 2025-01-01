namespace Belka_project_uml_diagram
{
    public partial class FormAddMethod : Form
    {
        public List<MethodUML> Methods { get; set; }
        public FormAddMethod(List<MethodUML> methods)
        {
            Methods = methods;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MethodUML methodUML = new MethodUML(textBoxPrivateOrPublic.Text, textBoxMethodName.Text, textBoxDataType.Text);
            Methods.Add(methodUML);

            Close();
        }
    }
}
