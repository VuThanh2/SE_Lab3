namespace PL
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
            dataGridView1 = new DataGridView();
            btnGetUser = new Button();
            btnGetAllCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(572, 381);
            dataGridView1.TabIndex = 0;
            // 
            // btnGetUser
            // 
            btnGetUser.Location = new Point(648, 32);
            btnGetUser.Name = "btnGetUser";
            btnGetUser.Size = new Size(140, 28);
            btnGetUser.TabIndex = 1;
            btnGetUser.Text = "Get All User";
            btnGetUser.UseVisualStyleBackColor = true;
            btnGetUser.Click += btnGetUser_Click;
            // 
            // btnGetAllCustomer
            // 
            btnGetAllCustomer.Location = new Point(648, 92);
            btnGetAllCustomer.Name = "btnGetAllCustomer";
            btnGetAllCustomer.Size = new Size(140, 28);
            btnGetAllCustomer.TabIndex = 2;
            btnGetAllCustomer.Text = "Get All Customer";
            btnGetAllCustomer.UseVisualStyleBackColor = true;
            btnGetAllCustomer.Click += btnGetAllCustomer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetAllCustomer);
            Controls.Add(btnGetUser);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGetUser;
        private Button btnGetAllCustomer;
    }
}
