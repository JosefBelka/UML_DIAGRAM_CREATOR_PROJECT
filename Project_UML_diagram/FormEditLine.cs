using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Belka_project_uml_diagram;

namespace Project_UML_diagram
{
    public partial class FormEditLine : Form
    {
        public Line Line { get; set; }
        public FormEditLine(Line line)
        {
            this.Line = line;
            InitializeComponent();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            Line.Multi1 = comboBoxMulti1.SelectedItem.ToString();
            Line.Multi2 = comboBoxMulti2.SelectedItem.ToString();
            Close();
        }
    }
}
