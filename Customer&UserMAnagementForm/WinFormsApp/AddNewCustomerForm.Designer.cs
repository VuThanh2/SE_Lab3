namespace WinFormsApp
{
    partial class AddNewCustomerForm
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
            btnAdd = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(136, 185);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(251, 185);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(67, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 26);
            txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(67, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 26);
            txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 38);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(67, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // AddNewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 261);
            Controls.Add(lblEmail);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Name = "AddNewCustomerForm";
            Text = "AddNewCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnCancel;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label1;
        private Label lblEmail;
    }
}