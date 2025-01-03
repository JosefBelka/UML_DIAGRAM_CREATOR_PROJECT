namespace Project_UML_diagram
{
    partial class FormEditLine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxVztah1 = new ComboBox();
            buttonSave = new Button();
            comboBoxMulti1 = new ComboBox();
            comboBoxMulti2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxVztah1
            // 
            comboBoxVztah1.FormattingEnabled = true;
            comboBoxVztah1.Items.AddRange(new object[] { "Asociace", "Agregace", "Kompozice", "Generalizace" });
            comboBoxVztah1.Location = new Point(179, 150);
            comboBoxVztah1.Name = "comboBoxVztah1";
            comboBoxVztah1.Size = new Size(151, 28);
            comboBoxVztah1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(179, 223);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(151, 35);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxMulti1
            // 
            comboBoxMulti1.FormattingEnabled = true;
            comboBoxMulti1.Items.AddRange(new object[] { "*", "1" });
            comboBoxMulti1.Location = new Point(67, 82);
            comboBoxMulti1.Name = "comboBoxMulti1";
            comboBoxMulti1.Size = new Size(151, 28);
            comboBoxMulti1.TabIndex = 5;
            // 
            // comboBoxMulti2
            // 
            comboBoxMulti2.FormattingEnabled = true;
            comboBoxMulti2.Items.AddRange(new object[] { "*", "1" });
            comboBoxMulti2.Location = new Point(296, 82);
            comboBoxMulti2.Name = "comboBoxMulti2";
            comboBoxMulti2.Size = new Size(151, 28);
            comboBoxMulti2.TabIndex = 6;
            // 
            // FormEditLine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 270);
            Controls.Add(comboBoxMulti2);
            Controls.Add(comboBoxMulti1);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxVztah1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditLine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditLine";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxVztah1;
        private Button buttonSave;
        private ComboBox comboBoxMulti1;
        private ComboBox comboBoxMulti2;
    }
}