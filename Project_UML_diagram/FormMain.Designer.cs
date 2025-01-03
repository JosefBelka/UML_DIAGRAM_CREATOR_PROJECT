namespace Belka_project_uml_diagram
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox = new PictureBox();
            buttonAddClass = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            saveFileDialog1 = new SaveFileDialog();
            buttonPrint = new Button();
            buttonSaveJSON = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(14, 64);
            pictureBox.Margin = new Padding(3, 4, 3, 4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1294, 792);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.MouseClick += pictureBox_MouseClick;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Location = new Point(14, 16);
            buttonAddClass.Margin = new Padding(3, 4, 3, 4);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(152, 40);
            buttonAddClass.TabIndex = 1;
            buttonAddClass.Text = "Add Class";
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += buttonAddClass_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 60;
            timer1.Tick += timer1_Tick;
            // 
            // buttonPrint
            // 
            buttonPrint.Location = new Point(195, 16);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(147, 40);
            buttonPrint.TabIndex = 2;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonSaveJSON
            // 
            buttonSaveJSON.Location = new Point(1143, 16);
            buttonSaveJSON.Name = "buttonSaveJSON";
            buttonSaveJSON.Size = new Size(165, 37);
            buttonSaveJSON.TabIndex = 3;
            buttonSaveJSON.Text = "Save classes as txt";
            buttonSaveJSON.UseVisualStyleBackColor = true;
            buttonSaveJSON.Click += buttonSaveJSON_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 872);
            Controls.Add(buttonSaveJSON);
            Controls.Add(buttonPrint);
            Controls.Add(buttonAddClass);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DragAndDrop";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonAddClass;
        private System.Windows.Forms.Timer timer1;
        private SaveFileDialog saveFileDialog1;
        private Button buttonPrint;
        private Button buttonSaveJSON;
    }
}
