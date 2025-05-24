namespace StudentManagementApp
{
    partial class LoginForm
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
            Username = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            label1 = new Label();
            btnTogglePassword = new CheckBox();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(73, 34);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 108);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(73, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(283, 26);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(73, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 26);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(144, 206);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 28);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(266, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 283);
            label1.Name = "label1";
            label1.Size = new Size(232, 20);
            label1.TabIndex = 6;
            label1.Text = "Developed by Duong Thanh Long";
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.AutoSize = true;
            btnTogglePassword.Location = new Point(73, 163);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(139, 24);
            btnTogglePassword.TabIndex = 7;
            btnTogglePassword.Text = "Toggle Password";
            btnTogglePassword.UseVisualStyleBackColor = true;
            btnTogglePassword.CheckedChanged += btnTogglePassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 312);
            Controls.Add(btnTogglePassword);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(Username);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
        private Label label1;
        private CheckBox btnTogglePassword;
    }
}
