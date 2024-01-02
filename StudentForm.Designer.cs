namespace WinFormsApp_D
{
    partial class StudentForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            NameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            DateOfBirthPicker = new DateTimePicker();
            PhoneNumberTextBox = new TextBox();
            InsertStudentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Creation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(369, 20);
            label3.TabIndex = 2;
            label3.Text = "------------------------------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 119);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Surname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "DateOfBirth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 208);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 5;
            label6.Text = "E-Mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 254);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 6;
            label7.Text = "Phone Number";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(123, 75);
            NameTextBox.MaxLength = 50;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(250, 27);
            NameTextBox.TabIndex = 7;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(123, 116);
            SurnameTextBox.MaxLength = 50;
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(250, 27);
            SurnameTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(123, 201);
            EmailTextBox.MaxLength = 100;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(250, 27);
            EmailTextBox.TabIndex = 9;
            // 
            // DateOfBirthPicker
            // 
            DateOfBirthPicker.Location = new Point(123, 158);
            DateOfBirthPicker.Name = "DateOfBirthPicker";
            DateOfBirthPicker.Size = new Size(250, 27);
            DateOfBirthPicker.TabIndex = 10;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(123, 247);
            PhoneNumberTextBox.MaxLength = 20;
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(250, 27);
            PhoneNumberTextBox.TabIndex = 11;
            // 
            // InsertStudentButton
            // 
            InsertStudentButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InsertStudentButton.Location = new Point(132, 298);
            InsertStudentButton.Name = "InsertStudentButton";
            InsertStudentButton.Size = new Size(116, 40);
            InsertStudentButton.TabIndex = 12;
            InsertStudentButton.Text = "Save";
            InsertStudentButton.UseVisualStyleBackColor = true;
            InsertStudentButton.Click += InsertStudentButton_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(400, 368);
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
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private TextBox EmailTextBox;
        private DateTimePicker DateOfBirthPicker;
        private TextBox PhoneNumberTextBox;
        private Button InsertStudentButton;
    }
}