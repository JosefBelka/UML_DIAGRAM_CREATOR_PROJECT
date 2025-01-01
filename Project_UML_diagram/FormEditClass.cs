using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belka_project_uml_diagram
{
    public partial class FormEditClass : Form
    {
        public Box Box { get; set; }
        public BindingList<MethodUML> methods { get; set; }
        public BindingList<ClassIUML> attributes { get; set; }
        public FormEditClass(Box box)
        {
            Box = box;
            methods = new BindingList<MethodUML>();
            attributes = new BindingList<ClassIUML>();
            InitializeComponent();
            dataGridViewAtt.DataSource = attributes;
            dataGridViewMeth.DataSource = methods;
            textBoxName.Text = Box.className;
            refresh();
        }

        public void refresh()
        {
            methods.Clear();
            attributes.Clear();

            foreach (MethodUML m in Box.Methods)
            {
                methods.Add(m);
            }

            foreach (ClassIUML a in Box.classes)
            {
                attributes.Add(a);
            }

        }

        private void buttonDelAtt_Click(object sender, EventArgs e)
        {
            int i = dataGridViewAtt.CurrentCell.RowIndex;
            Box.classes.Remove(Box.classes[i]);
            refresh();
        }

        private void buttonDelMeth_Click(object sender, EventArgs e)
        {
            int i = dataGridViewMeth.CurrentCell.RowIndex;
            Box.Methods.Remove(Box.Methods[i]);
            refresh();
        }

        private void buttonAddAtt_Click(object sender, EventArgs e)
        {
            FormAddAttibute form = new FormAddAttibute(Box.classes);
            form.ShowDialog();
            refresh();
        }

        private void buttonAddMeth_Click(object sender, EventArgs e)
        {
            FormAddMethod form = new FormAddMethod(Box.Methods);
            form.ShowDialog();
            refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Box.className = textBoxName.Text;
            Close();
        }
    }
}
