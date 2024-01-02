namespace WinFormsApp_D
{
    partial class CourseDeleteForm
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            InsertButton = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(293, 68);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 61;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 74);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 59;
            label8.Text = "CourseID";
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertButton.Location = new Point(140, 236);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(116, 40);
            InsertButton.TabIndex = 58;
            InsertButton.Text = "Delete";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 56;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 155);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 54;
            label4.Text = "Course Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 52;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 51;
            label2.Text = "Course Delete";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 50;
            label1.Text = "Course Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 114);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 62;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(123, 155);
            label7.Name = "label7";
            label7.Size = new Size(13, 20);
            label7.TabIndex = 63;
            label7.Text = " ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 195);
            label9.Name = "label9";
            label9.Size = new Size(13, 20);
            label9.TabIndex = 64;
            label9.Text = " ";
            // 
            // CourseDeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(399, 304);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(InsertButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CourseDeleteForm";
            Text = "CourseDeleteForm";
            Load += CourseDeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label8;
        private Button InsertButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label9;
    }
}