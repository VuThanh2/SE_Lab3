namespace WinFormsApp
{
    partial class MainForm
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
            userGridView = new DataGridView();
            btnGetAllUsers = new Button();
            btnGetAllCustomers = new Button();
            label1 = new Label();
            customerGridView = new DataGridView();
            label2 = new Label();
            btnAddNewCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)userGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            SuspendLayout();
            // 
            // userGridView
            // 
            userGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGridView.Location = new Point(12, 32);
            userGridView.Name = "userGridView";
            userGridView.RowHeadersWidth = 49;
            userGridView.Size = new Size(463, 411);
            userGridView.TabIndex = 0;
            // 
            // btnGetAllUsers
            // 
            btnGetAllUsers.Location = new Point(481, 53);
            btnGetAllUsers.Name = "btnGetAllUsers";
            btnGetAllUsers.Size = new Size(155, 28);
            btnGetAllUsers.TabIndex = 1;
            btnGetAllUsers.Text = "Get All Users";
            btnGetAllUsers.UseVisualStyleBackColor = true;
            btnGetAllUsers.Click += btnGetAllUser_Click;
            // 
            // btnGetAllCustomers
            // 
            btnGetAllCustomers.Location = new Point(481, 99);
            btnGetAllCustomers.Name = "btnGetAllCustomers";
            btnGetAllCustomers.Size = new Size(155, 28);
            btnGetAllCustomers.TabIndex = 2;
            btnGetAllCustomers.Text = "Get All Customers";
            btnGetAllCustomers.UseVisualStyleBackColor = true;
            btnGetAllCustomers.Click += btnGetAllCustomers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 3;
            label1.Text = "Users";
            // 
            // customerGridView
            // 
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerGridView.Location = new Point(642, 32);
            customerGridView.Name = "customerGridView";
            customerGridView.RowHeadersWidth = 49;
            customerGridView.Size = new Size(463, 411);
            customerGridView.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 5;
            label2.Text = "Customers";
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.Location = new Point(481, 150);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(155, 28);
            btnAddNewCustomer.TabIndex = 6;
            btnAddNewCustomer.Text = "Add New Customer";
            btnAddNewCustomer.UseVisualStyleBackColor = true;
            btnAddNewCustomer.Click += btnAddNewCustomer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 455);
            Controls.Add(btnAddNewCustomer);
            Controls.Add(label2);
            Controls.Add(customerGridView);
            Controls.Add(label1);
            Controls.Add(btnGetAllCustomers);
            Controls.Add(btnGetAllUsers);
            Controls.Add(userGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)userGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView userGridView;
        private Button btnGetAllUsers;
        private Button btnGetAllCustomers;
        private Label label1;
        private DataGridView customerGridView;
        private Label label2;
        private Button btnAddNewCustomer;
    }
}
