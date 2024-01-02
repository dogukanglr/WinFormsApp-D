namespace WinFormsApp_D
{
    partial class UserForm
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
            tabControl1 = new TabControl();
            view1Button = new Button();
            label3 = new Label();
            view2Button = new Button();
            view3Button = new Button();
            view4Button = new Button();
            label4 = new Label();
            view5Button = new Button();
            label5 = new Label();
            label6 = new Label();
            btnOpenStudentForm = new Button();
            btnOpenTeacherForm = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "User Form Screen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 40);
            label2.Name = "label2";
            label2.Size = new Size(801, 20);
            label2.TabIndex = 1;
            label2.Text = "------------------------------------------------------------------------------------------------------------------------------------";
            label2.Click += label2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Location = new Point(19, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 513);
            tabControl1.TabIndex = 2;
            // 
            // view1Button
            // 
            view1Button.Location = new Point(9, 660);
            view1Button.Name = "view1Button";
            view1Button.Size = new Size(139, 29);
            view1Button.TabIndex = 3;
            view1Button.Text = "Course Statistics";
            view1Button.UseVisualStyleBackColor = true;
            view1Button.Click += view1Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 602);
            label3.Name = "label3";
            label3.Size = new Size(801, 20);
            label3.TabIndex = 4;
            label3.Text = "------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // view2Button
            // 
            view2Button.Location = new Point(154, 660);
            view2Button.Name = "view2Button";
            view2Button.Size = new Size(172, 29);
            view2Button.TabIndex = 5;
            view2Button.Text = "Student Course Stats";
            view2Button.UseVisualStyleBackColor = true;
            view2Button.Click += view2Button_Click;
            // 
            // view3Button
            // 
            view3Button.Location = new Point(332, 660);
            view3Button.Name = "view3Button";
            view3Button.Size = new Size(172, 29);
            view3Button.TabIndex = 6;
            view3Button.Text = "Student Grades";
            view3Button.UseVisualStyleBackColor = true;
            view3Button.Click += view3Button_Click;
            // 
            // view4Button
            // 
            view4Button.Location = new Point(510, 660);
            view4Button.Name = "view4Button";
            view4Button.Size = new Size(172, 29);
            view4Button.TabIndex = 7;
            view4Button.Text = "Teacher Course";
            view4Button.UseVisualStyleBackColor = true;
            view4Button.Click += view4Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 622);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 8;
            label4.Text = "Views";
            // 
            // view5Button
            // 
            view5Button.Location = new Point(688, 660);
            view5Button.Name = "view5Button";
            view5Button.Size = new Size(128, 29);
            view5Button.TabIndex = 9;
            view5Button.Text = "Top Students";
            view5Button.UseVisualStyleBackColor = true;
            view5Button.Click += view5Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 693);
            label5.Name = "label5";
            label5.Size = new Size(795, 20);
            label5.TabIndex = 10;
            label5.Text = "-----------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label6.Location = new Point(12, 711);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 11;
            label6.Text = "Creation";
            // 
            // btnOpenStudentForm
            // 
            btnOpenStudentForm.Location = new Point(9, 745);
            btnOpenStudentForm.Name = "btnOpenStudentForm";
            btnOpenStudentForm.Size = new Size(139, 29);
            btnOpenStudentForm.TabIndex = 12;
            btnOpenStudentForm.Text = "Student Adding";
            btnOpenStudentForm.UseVisualStyleBackColor = true;
            btnOpenStudentForm.Click += btnOpenStudentForm_Click;
            // 
            // btnOpenTeacherForm
            // 
            btnOpenTeacherForm.Location = new Point(154, 745);
            btnOpenTeacherForm.Name = "btnOpenTeacherForm";
            btnOpenTeacherForm.Size = new Size(139, 29);
            btnOpenTeacherForm.TabIndex = 13;
            btnOpenTeacherForm.Text = "Teacher Adding";
            btnOpenTeacherForm.UseVisualStyleBackColor = true;
            btnOpenTeacherForm.Click += btnOpenTeacherForm_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 745);
            button2.Name = "button2";
            button2.Size = new Size(167, 29);
            button2.TabIndex = 14;
            button2.Text = "Exam Grade Adding";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(472, 745);
            button3.Name = "button3";
            button3.Size = new Size(167, 29);
            button3.TabIndex = 15;
            button3.Text = "Course Adding";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(649, 745);
            button4.Name = "button4";
            button4.Size = new Size(167, 29);
            button4.TabIndex = 16;
            button4.Text = "Section Adding";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 777);
            label7.Name = "label7";
            label7.Size = new Size(795, 20);
            label7.TabIndex = 17;
            label7.Text = "-----------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label8.Location = new Point(12, 795);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 18;
            label8.Text = "Update";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 862);
            label9.Name = "label9";
            label9.Size = new Size(795, 20);
            label9.TabIndex = 19;
            label9.Text = "-----------------------------------------------------------------------------------------------------------------------------------";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label10.Location = new Point(19, 882);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 20;
            label10.Text = "Delete";
            label10.Click += label10_Click;
            // 
            // button1
            // 
            button1.Location = new Point(9, 829);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 21;
            button1.Text = "Student Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(154, 830);
            button5.Name = "button5";
            button5.Size = new Size(139, 29);
            button5.TabIndex = 22;
            button5.Text = "Teacher Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(299, 829);
            button6.Name = "button6";
            button6.Size = new Size(167, 29);
            button6.TabIndex = 23;
            button6.Text = "Exam Grade Update";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(472, 829);
            button7.Name = "button7";
            button7.Size = new Size(167, 29);
            button7.TabIndex = 24;
            button7.Text = "Course Update";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(649, 829);
            button8.Name = "button8";
            button8.Size = new Size(167, 29);
            button8.TabIndex = 25;
            button8.Text = "Section Update";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 916);
            button9.Name = "button9";
            button9.Size = new Size(167, 29);
            button9.TabIndex = 26;
            button9.Text = "Exam Grade Delete";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(185, 916);
            button10.Name = "button10";
            button10.Size = new Size(167, 29);
            button10.TabIndex = 27;
            button10.Text = "Course Delete";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(358, 916);
            button11.Name = "button11";
            button11.Size = new Size(167, 29);
            button11.TabIndex = 28;
            button11.Text = "Section Delete";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(720, 12);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 29;
            button12.Text = "Sign Out";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(833, 966);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnOpenTeacherForm);
            Controls.Add(btnOpenStudentForm);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(view5Button);
            Controls.Add(label4);
            Controls.Add(view4Button);
            Controls.Add(view3Button);
            Controls.Add(view2Button);
            Controls.Add(label3);
            Controls.Add(view1Button);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private Button view1Button;
        private Label label3;
        private Button view2Button;
        private Button view3Button;
        private Button view4Button;
        private Label label4;
        private Button view5Button;
        private Label label5;
        private Label label6;
        private Button btnOpenStudentForm;
        private Button btnOpenTeacherForm;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}