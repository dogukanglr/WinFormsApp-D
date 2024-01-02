namespace WinFormsApp_D
{
    partial class CourseUpdateForm
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
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            TextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertButton.Location = new Point(123, 241);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(116, 40);
            InsertButton.TabIndex = 46;
            InsertButton.Text = "Update";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 198);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 27);
            textBox2.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 201);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 44;
            label5.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 158);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 42;
            label4.Text = "Course Name";
            // 
            // TextBox
            // 
            TextBox.Location = new Point(123, 117);
            TextBox.MaxLength = 6;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(258, 27);
            TextBox.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 40;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 39;
            label2.Text = "Course Update";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 38;
            label1.Text = "Course Code";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(293, 74);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 49;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 80);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 47;
            label8.Text = "CourseID";
            // 
            // CourseUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(396, 310);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(InsertButton);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CourseUpdateForm";
            Text = "CourseUpdateForm";
            Load += CourseUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InsertButton;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private TextBox TextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label8;
    }
}