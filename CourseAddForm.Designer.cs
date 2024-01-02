namespace WinFormsApp_D
{
    partial class CourseAddForm
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
            TextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            InsertButton = new Button();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Location = new Point(123, 75);
            TextBox.MaxLength = 6;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(250, 27);
            TextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 10;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 9;
            label2.Text = "Course ADD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 8;
            label1.Text = "Course Code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 116);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 12;
            label4.Text = "Course Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 156);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 159);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 14;
            label5.Text = "Description";
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertButton.Location = new Point(138, 205);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(116, 40);
            InsertButton.TabIndex = 37;
            InsertButton.Text = "Save";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // CourseAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(393, 259);
            Controls.Add(InsertButton);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CourseAddForm";
            Text = "CourseAddForm";
            Load += CourseAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button InsertButton;
    }
}