namespace WinFormsApp_D
{
    partial class GradeUpdateForm
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
            comboBox4 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            InsertButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            comboBox5 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100" });
            comboBox4.Location = new Point(108, 280);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(250, 28);
            comboBox4.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 288);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 42;
            label5.Text = "Grade";
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertButton.Location = new Point(119, 324);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(116, 40);
            InsertButton.TabIndex = 49;
            InsertButton.Text = "Update";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 248);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 48;
            label7.Text = "Exam Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 207);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 47;
            label6.Text = "Section ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 159);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 46;
            label4.Text = "Course ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 45;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 44;
            label2.Text = "Exam Grade Update";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 118);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 43;
            label1.Text = "Student ID";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(278, 71);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 57;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(108, 71);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(164, 28);
            comboBox5.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 74);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 55;
            label8.Text = "StudentID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(108, 118);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 58;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(108, 159);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 59;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(108, 207);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 60;
            label11.Text = "label11";
            // 
            // GradeUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(392, 386);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(comboBox5);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(InsertButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GradeUpdateForm";
            Text = "GradeUpdateForm";
            Load += GradeUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button InsertButton;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}