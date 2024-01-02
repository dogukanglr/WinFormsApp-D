namespace WinFormsApp_D
{
    partial class GradesDeleteForm
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
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            comboBox5 = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            InsertButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(108, 207);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 76;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(108, 159);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 75;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(108, 118);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 74;
            label9.Text = "label9";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(278, 71);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 73;
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
            comboBox5.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 74);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 71;
            label8.Text = "StudentID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 288);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 61;
            label5.Text = "Grade";
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertButton.Location = new Point(128, 327);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(116, 40);
            InsertButton.TabIndex = 68;
            InsertButton.Text = "Delete";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 248);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 67;
            label7.Text = "Exam Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 207);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 66;
            label6.Text = "Section ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 159);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 65;
            label4.Text = "Course ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 64;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 63;
            label2.Text = "Exam Grade Delete";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 118);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 62;
            label1.Text = "Student ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(108, 248);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 77;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(108, 288);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 78;
            label13.Text = "label13";
            // 
            // GradesDeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(389, 397);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(comboBox5);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(InsertButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GradesDeleteForm";
            Text = "GradesDeleteForm";
            Load += GradesDeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label10;
        private Label label9;
        private Button button1;
        private ComboBox comboBox5;
        private Label label8;
        private Label label5;
        private Button InsertButton;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label12;
        private Label label13;
    }
}