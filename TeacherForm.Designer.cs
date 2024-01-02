namespace WinFormsApp_D
{
    partial class TeacherForm
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
            InsertButton = new Button();
            EmailTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertButton.Location = new Point(125, 258);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(116, 40);
            InsertButton.TabIndex = 25;
            InsertButton.Text = "Save";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(125, 160);
            EmailTextBox.MaxLength = 100;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(250, 27);
            EmailTextBox.TabIndex = 22;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(123, 116);
            SurnameTextBox.MaxLength = 50;
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(250, 27);
            SurnameTextBox.TabIndex = 21;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(123, 75);
            NameTextBox.MaxLength = 50;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(250, 27);
            NameTextBox.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 213);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 19;
            label7.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 167);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 18;
            label6.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 16;
            label4.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 15;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 14;
            label2.Text = "Teacher Creation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 13;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Computer Science", "English", "Mathematics", "Chemistry", "History", "Psychology", "Art", "Physics", "Economics", "Biology" });
            comboBox1.Location = new Point(125, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 26;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(403, 321);
            Controls.Add(comboBox1);
            Controls.Add(InsertButton);
            Controls.Add(EmailTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InsertButton;
        private TextBox EmailTextBox;
        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
    }
}