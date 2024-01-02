namespace WinFormsApp_D
{
    partial class TeacherUpdateForm
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
            comboBox1 = new ComboBox();
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
            button1 = new Button();
            comboBox2 = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Computer Science", "English", "Mathematics", "Chemistry", "History", "Psychology", "Art", "Physics", "Economics", "Biology" });
            comboBox1.Location = new Point(122, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 37;
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertButton.Location = new Point(122, 298);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(116, 40);
            InsertButton.TabIndex = 36;
            InsertButton.Text = "Update";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(122, 200);
            EmailTextBox.MaxLength = 100;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(250, 27);
            EmailTextBox.TabIndex = 35;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(120, 156);
            SurnameTextBox.MaxLength = 50;
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(250, 27);
            SurnameTextBox.TabIndex = 34;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(120, 115);
            NameTextBox.MaxLength = 50;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(250, 27);
            NameTextBox.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 253);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 32;
            label7.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 207);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 31;
            label6.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 159);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 30;
            label4.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 42);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 29;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 28;
            label2.Text = "Teacher Update";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 118);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 27;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(290, 69);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 40;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(120, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 75);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 38;
            label8.Text = "TeacherID";
            // 
            // TeacherUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(389, 368);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
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
            Name = "TeacherUpdateForm";
            Text = "TeacherUpdateForm";
            Load += TeacherUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
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
        private Button button1;
        private ComboBox comboBox2;
        private Label label8;
    }
}