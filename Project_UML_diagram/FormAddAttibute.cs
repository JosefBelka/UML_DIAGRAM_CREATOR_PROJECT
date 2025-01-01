namespace Belka_project_uml_diagram
{
    public partial class FormAddAttibute : Form
    {
        public List<ClassIUML> Atrributes { get; set; }
        public FormAddAttibute(List<ClassIUML> atrributes)
        {
            Atrributes = atrributes;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClassIUML attribute = new ClassIUML(textBoxPrivateOrPublic.Text, textBoxName.Text, textBoxDataType.Text);
            Atrributes.Add(attribute);

            Close();
        }
    }
}
