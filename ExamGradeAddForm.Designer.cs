namespace WinFormsApp_D
{
    partial class ExamGradeAddForm
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
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            SuspendLayout();
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertButton.Location = new Point(121, 284);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(116, 40);
            InsertButton.TabIndex = 36;
            InsertButton.Text = "Save";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 208);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 32;
            label7.Text = "Exam Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 167);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 31;
            label6.Text = "Section ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 30;
            label4.Text = "Course ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 29;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 28;
            label2.Text = "Exam Grade ADD";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 27;
            label1.Text = "Student ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 248);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 3;
            label5.Text = "Grade";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 38;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(110, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 39;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(110, 159);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 28);
            comboBox3.TabIndex = 40;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            comboBox4.Location = new Point(110, 240);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(250, 28);
            comboBox4.TabIndex = 41;
            // 
            // ExamGradeAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(385, 346);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(InsertButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExamGradeAddForm";
            Text = "ExamGradeAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button InsertButton;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}