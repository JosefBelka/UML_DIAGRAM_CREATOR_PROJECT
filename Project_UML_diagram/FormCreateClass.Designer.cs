namespace Belka_project_uml_diagram
{
    partial class FormCreateClass
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
            label1 = new Label();
            label2 = new Label();
            textBoxClassName = new TextBox();
            buttonAddAttribute = new Button();
            label3 = new Label();
            label4 = new Label();
            buttonAddMethod = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(207, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 0;
            label1.Text = "Create Class";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 66);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 1;
            label2.Text = "Class name :";
            // 
            // textBoxClassName
            // 
            textBoxClassName.Location = new Point(182, 68);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(285, 23);
            textBoxClassName.TabIndex = 2;
            // 
            // buttonAddAttribute
            // 
            buttonAddAttribute.Location = new Point(182, 161);
            buttonAddAttribute.Name = "buttonAddAttribute";
            buttonAddAttribute.Size = new Size(285, 29);
            buttonAddAttribute.TabIndex = 3;
            buttonAddAttribute.Text = "Add Attribute";
            buttonAddAttribute.UseVisualStyleBackColor = true;
            buttonAddAttribute.Click += buttonAddAttribute_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 163);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 4;
            label3.Text = "Attributes :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(76, 241);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 5;
            label4.Text = "Methods :";
            // 
            // buttonAddMethod
            // 
            buttonAddMethod.Location = new Point(182, 239);
            buttonAddMethod.Name = "buttonAddMethod";
            buttonAddMethod.Size = new Size(285, 29);
            buttonAddMethod.TabIndex = 6;
            buttonAddMethod.Text = "Add Method";
            buttonAddMethod.UseVisualStyleBackColor = true;
            buttonAddMethod.Click += buttonAddMethod_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(207, 313);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(131, 36);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormCreateClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 361);
            Controls.Add(buttonAdd);
            Controls.Add(buttonAddMethod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonAddAttribute);
            Controls.Add(textBoxClassName);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCreateClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCreateClass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxClassName;
        private Button buttonAddAttribute;
        private Label label3;
        private Label label4;
        private Button buttonAddMethod;
        private Button buttonAdd;
    }
}