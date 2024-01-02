namespace WinFormsApp_D
{
    partial class SectionAddForm
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
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            NameTextBox = new TextBox();
            label1 = new Label();
            DateOfBirthPicker = new DateTimePicker();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            InsertStudentButton = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 4;
            label3.Text = "------------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 3;
            label2.Text = "Section ADD";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(130, 71);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 74);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 40;
            label4.Text = "Course ID";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(130, 109);
            NameTextBox.MaxLength = 50;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(250, 27);
            NameTextBox.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 42;
            label1.Text = "SectionNumber";
            // 
            // DateOfBirthPicker
            // 
            DateOfBirthPicker.Location = new Point(130, 147);
            DateOfBirthPicker.Name = "DateOfBirthPicker";
            DateOfBirthPicker.Size = new Size(250, 27);
            DateOfBirthPicker.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 152);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 44;
            label5.Text = "DateOfBirth";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 190);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 46;
            label6.Text = "Teacher";
            // 
            // InsertStudentButton
            // 
            InsertStudentButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertStudentButton.Location = new Point(130, 231);
            InsertStudentButton.Name = "InsertStudentButton";
            InsertStudentButton.Size = new Size(116, 40);
            InsertStudentButton.TabIndex = 48;
            InsertStudentButton.Text = "Save";
            InsertStudentButton.UseVisualStyleBackColor = true;
            InsertStudentButton.Click += InsertStudentButton_Click;
            // 
            // SectionAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(392, 300);
            Controls.Add(InsertStudentButton);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(DateOfBirthPicker);
            Controls.Add(label5);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SectionAddForm";
            Text = "SectionAddForm";
            Load += SectionAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox NameTextBox;
        private Label label1;
        private DateTimePicker DateOfBirthPicker;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Button InsertStudentButton;
    }
}