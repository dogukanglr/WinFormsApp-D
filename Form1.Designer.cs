namespace WinFormsApp_D
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            btnLogin_Click = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(165, 209);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(177, 254);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.Window;
            textBoxUsername.Location = new Point(253, 206);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(125, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.Window;
            textBoxPassword.Location = new Point(253, 247);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // btnLogin_Click
            // 
            btnLogin_Click.BackColor = Color.Transparent;
            btnLogin_Click.FlatAppearance.BorderColor = Color.Blue;
            btnLogin_Click.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin_Click.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin_Click.Location = new Point(227, 280);
            btnLogin_Click.Name = "btnLogin_Click";
            btnLogin_Click.Size = new Size(94, 29);
            btnLogin_Click.TabIndex = 4;
            btnLogin_Click.Text = "Log In";
            btnLogin_Click.UseVisualStyleBackColor = false;
            btnLogin_Click.Click += btnLogin_Click_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(547, 565);
            Controls.Add(btnLogin_Click);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button btnLogin_Click;
    }
}
