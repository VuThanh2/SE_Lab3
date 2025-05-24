namespace StudentManagementApp.DepartmentView
{
    partial class FindDepartmentForm
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
            txtDepartmentID = new TextBox();
            btnCancel = new Button();
            btnFind = new Button();
            txtDepartmentName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 54;
            label1.Text = "DepartmentID";
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(32, 47);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Size = new Size(211, 26);
            txtDepartmentID.TabIndex = 53;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(405, 45);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 52;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(280, 45);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 28);
            btnFind.TabIndex = 51;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(33, 116);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.ReadOnly = true;
            txtDepartmentName.Size = new Size(304, 26);
            txtDepartmentName.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 37;
            label2.Text = "Department Name";
            // 
            // FindDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 172);
            Controls.Add(label1);
            Controls.Add(txtDepartmentID);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Controls.Add(txtDepartmentName);
            Controls.Add(label2);
            Name = "FindDepartmentForm";
            Text = "FindDepartmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDepartmentID;
        private Button btnCancel;
        private Button btnFind;
        private TextBox txtDepartmentName;
        private Label label2;
    }
}