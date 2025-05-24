namespace WinFormsUI
{
    partial class MainForm
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
            customerGridView = new DataGridView();
            btnLoad = new Button();
            btnFind = new Button();
            btnAdd = new Button();
            txtCustomerID = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)customerGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // customerGridView
            // 
            customerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerGridView.Location = new Point(59, 62);
            customerGridView.Name = "customerGridView";
            customerGridView.RowHeadersWidth = 49;
            customerGridView.Size = new Size(594, 405);
            customerGridView.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(87, 144);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(150, 28);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Get All Customer";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(87, 94);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(150, 28);
            btnFind.TabIndex = 2;
            btnFind.Text = "Get Customer By Id";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(87, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 28);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New Customer";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(29, 62);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(208, 26);
            txtCustomerID.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(702, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 405);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Controller";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "CustomerID";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 494);
            Controls.Add(groupBox1);
            Controls.Add(customerGridView);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)customerGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView customerGridView;
        private Button btnLoad;
        private Button btnFind;
        private Button btnAdd;
        private TextBox txtCustomerID;
        private GroupBox groupBox1;
        private Label label1;
    }
}