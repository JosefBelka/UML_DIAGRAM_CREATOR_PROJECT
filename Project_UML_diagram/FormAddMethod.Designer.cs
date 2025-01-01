namespace Belka_project_uml_diagram
{
    partial class FormAddMethod
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
            textBoxMethodName = new TextBox();
            textBoxDataType = new TextBox();
            textBoxPrivateOrPublic = new TextBox();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // textBoxMethodName
            // 
            textBoxMethodName.Location = new Point(96, 36);
            textBoxMethodName.Name = "textBoxMethodName";
            textBoxMethodName.PlaceholderText = "Method Name";
            textBoxMethodName.Size = new Size(171, 23);
            textBoxMethodName.TabIndex = 0;
            // 
            // textBoxDataType
            // 
            textBoxDataType.Location = new Point(96, 65);
            textBoxDataType.Name = "textBoxDataType";
            textBoxDataType.PlaceholderText = "Data Type";
            textBoxDataType.Size = new Size(171, 23);
            textBoxDataType.TabIndex = 1;
            // 
            // textBoxPrivateOrPublic
            // 
            textBoxPrivateOrPublic.Location = new Point(96, 94);
            textBoxPrivateOrPublic.Name = "textBoxPrivateOrPublic";
            textBoxPrivateOrPublic.PlaceholderText = "+/-";
            textBoxPrivateOrPublic.Size = new Size(171, 23);
            textBoxPrivateOrPublic.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(96, 150);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(171, 38);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add Method";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormAddMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 261);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPrivateOrPublic);
            Controls.Add(textBoxDataType);
            Controls.Add(textBoxMethodName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddMethod";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddMethod";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMethodName;
        private TextBox textBoxDataType;
        private TextBox textBoxPrivateOrPublic;
        private Button buttonAdd;
    }
}