namespace WinFormsApp_D
{
    partial class StudentUpdateForm
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
            InsertStudentButton = new Button();
            PhoneNumberTextBox = new TextBox();
            DateOfBirthPicker = new DateTimePicker();
            EmailTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // InsertStudentButton
            // 
            InsertStudentButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertStudentButton.Location = new Point(123, 334);
            InsertStudentButton.Name = "InsertStudentButton";
            InsertStudentButton.Size = new Size(116, 40);
            InsertStudentButton.TabIndex = 25;
            InsertStudentButton.Text = "Update";
            InsertStudentButton.UseVisualStyleBackColor = true;
            InsertStudentButton.Click += InsertStudentButton_Click;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(123, 290);
            PhoneNumberTextBox.MaxLength = 20;
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(250, 27);
            PhoneNumberTextBox.TabIndex = 24;
            // 
            // DateOfBirthPicker
            // 
            DateOfBirthPicker.Location = new Point(123, 201);
            DateOfBirthPicker.Name = "DateOfBirthPicker";
            DateOfBirthPicker.Size = new Size(250, 27);
            DateOfBirthPicker.TabIndex = 23;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(123, 244);
            EmailTextBox.MaxLength = 100;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(250, 27);
            EmailTextBox.TabIndex = 22;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(123, 159);
            SurnameTextBox.MaxLength = 50;
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(250, 27);
            SurnameTextBox.TabIndex = 21;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(123, 118);
            NameTextBox.MaxLength = 50;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(250, 27);
            NameTextBox.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 297);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 19;
            label7.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 251);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 18;
            label6.Text = "E-Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 17;
            label5.Text = "DateOfBirth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 162);
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
            label2.Size = new Size(146, 25);
            label2.TabIndex = 14;
            label2.Text = "Student Update";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 74);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 26;
            label8.Text = "StudentID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 27;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(293, 68);
            button1.Name = "button1";
            button1.Size = new Size(88, 31);
            button1.TabIndex = 28;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // StudentUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(397, 398);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(InsertStudentButton);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(DateOfBirthPicker);
            Controls.Add(EmailTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentUpdateForm";
            Text = "StudentUpdateForm";
            Load += StudentUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InsertStudentButton;
        private TextBox PhoneNumberTextBox;
        private DateTimePicker DateOfBirthPicker;
        private TextBox EmailTextBox;
        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private ComboBox comboBox1;
        private Button button1;
    }
}