namespace Belka_project_uml_diagram
{
    partial class FormEditClass
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
            textBoxName = new TextBox();
            Attributes = new Label();
            label2 = new Label();
            dataGridViewMeth = new DataGridView();
            buttonAddAtt = new Button();
            buttonDelAtt = new Button();
            buttonAddMeth = new Button();
            buttonDelMeth = new Button();
            buttonSave = new Button();
            dataGridViewAtt = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMeth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 22);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(406, 19);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // Attributes
            // 
            Attributes.AutoSize = true;
            Attributes.Location = new Point(367, 91);
            Attributes.Name = "Attributes";
            Attributes.Size = new Size(74, 20);
            Attributes.TabIndex = 2;
            Attributes.Text = "Attributes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 403);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Methods";
            // 
            // dataGridViewMeth
            // 
            dataGridViewMeth.AllowUserToAddRows = false;
            dataGridViewMeth.AllowUserToDeleteRows = false;
            dataGridViewMeth.AllowUserToResizeColumns = false;
            dataGridViewMeth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMeth.Location = new Point(9, 440);
            dataGridViewMeth.MultiSelect = false;
            dataGridViewMeth.Name = "dataGridViewMeth";
            dataGridViewMeth.RowHeadersWidth = 51;
            dataGridViewMeth.Size = new Size(606, 248);
            dataGridViewMeth.TabIndex = 5;
            // 
            // buttonAddAtt
            // 
            buttonAddAtt.Location = new Point(644, 131);
            buttonAddAtt.Name = "buttonAddAtt";
            buttonAddAtt.Size = new Size(94, 29);
            buttonAddAtt.TabIndex = 6;
            buttonAddAtt.Text = "Add";
            buttonAddAtt.UseVisualStyleBackColor = true;
            buttonAddAtt.Click += buttonAddAtt_Click;
            // 
            // buttonDelAtt
            // 
            buttonDelAtt.Location = new Point(644, 193);
            buttonDelAtt.Name = "buttonDelAtt";
            buttonDelAtt.Size = new Size(94, 29);
            buttonDelAtt.TabIndex = 7;
            buttonDelAtt.Text = "Delete";
            buttonDelAtt.UseVisualStyleBackColor = true;
            buttonDelAtt.Click += buttonDelAtt_Click;
            // 
            // buttonAddMeth
            // 
            buttonAddMeth.Location = new Point(644, 440);
            buttonAddMeth.Name = "buttonAddMeth";
            buttonAddMeth.Size = new Size(94, 29);
            buttonAddMeth.TabIndex = 8;
            buttonAddMeth.Text = "Add";
            buttonAddMeth.UseVisualStyleBackColor = true;
            buttonAddMeth.Click += buttonAddMeth_Click;
            // 
            // buttonDelMeth
            // 
            buttonDelMeth.Location = new Point(644, 501);
            buttonDelMeth.Name = "buttonDelMeth";
            buttonDelMeth.Size = new Size(94, 29);
            buttonDelMeth.TabIndex = 9;
            buttonDelMeth.Text = "Delete";
            buttonDelMeth.UseVisualStyleBackColor = true;
            buttonDelMeth.Click += buttonDelMeth_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(347, 712);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewAtt
            // 
            dataGridViewAtt.AllowUserToAddRows = false;
            dataGridViewAtt.AllowUserToDeleteRows = false;
            dataGridViewAtt.AllowUserToResizeColumns = false;
            dataGridViewAtt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtt.Location = new Point(9, 131);
            dataGridViewAtt.MultiSelect = false;
            dataGridViewAtt.Name = "dataGridViewAtt";
            dataGridViewAtt.ReadOnly = true;
            dataGridViewAtt.RowHeadersVisible = false;
            dataGridViewAtt.RowHeadersWidth = 51;
            dataGridViewAtt.Size = new Size(606, 248);
            dataGridViewAtt.TabIndex = 0;
            // 
            // FormEditClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 753);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelMeth);
            Controls.Add(buttonAddMeth);
            Controls.Add(buttonDelAtt);
            Controls.Add(buttonAddAtt);
            Controls.Add(dataGridViewMeth);
            Controls.Add(label2);
            Controls.Add(dataGridViewAtt);
            Controls.Add(Attributes);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditClass";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMeth).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Label Attributes;
        private Label label2;
        private DataGridView dataGridViewMeth;
        private Button buttonAddAtt;
        private Button buttonDelAtt;
        private Button buttonAddMeth;
        private Button buttonDelMeth;
        private Button buttonSave;
        private DataGridView dataGridViewAtt;
    }
}