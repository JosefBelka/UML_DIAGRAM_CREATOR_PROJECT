namespace Belka_project_uml_diagram
{
    partial class FormAddAttibute
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
            buttonAdd = new Button();
            textBoxPrivateOrPublic = new TextBox();
            textBoxDataType = new TextBox();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(100, 146);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(171, 38);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add Attribute";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxPrivateOrPublic
            // 
            textBoxPrivateOrPublic.Location = new Point(100, 90);
            textBoxPrivateOrPublic.Name = "textBoxPrivateOrPublic";
            textBoxPrivateOrPublic.PlaceholderText = "+/-";
            textBoxPrivateOrPublic.Size = new Size(171, 23);
            textBoxPrivateOrPublic.TabIndex = 6;
            // 
            // textBoxDataType
            // 
            textBoxDataType.Location = new Point(100, 61);
            textBoxDataType.Name = "textBoxDataType";
            textBoxDataType.PlaceholderText = "Data Type";
            textBoxDataType.Size = new Size(171, 23);
            textBoxDataType.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Attribute Name";
            textBoxName.Size = new Size(171, 23);
            textBoxName.TabIndex = 4;
            // 
            // FormAddAttibute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 261);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrivateOrPublic);
            Controls.Add(textBoxDataType);
            Controls.Add(textBoxName);
            Name = "FormAddAttibute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddAttibute";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxPrivateOrPublic;
        private TextBox textBoxDataType;
        private TextBox textBoxName;
    }
}