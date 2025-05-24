namespace StudentManagementApp.DepartmentView
{
    partial class UpdateDepartmentForm
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
            btnUpdate = new Button();
            label1 = new Label();
            txtDepartmentID = new TextBox();
            btnCancel = new Button();
            btnFind = new Button();
            txtDepartmentName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(379, 49);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 28);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 61;
            label1.Text = "DepartmentID";
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.Location = new Point(33, 49);
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Size = new Size(211, 26);
            txtDepartmentID.TabIndex = 60;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(379, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(271, 49);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 28);
            btnFind.TabIndex = 58;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(34, 118);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(304, 26);
            txtDepartmentName.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 95);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 56;
            label2.Text = "Department Name";
            // 
            // UpdateDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 177);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txtDepartmentID);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Controls.Add(txtDepartmentName);
            Controls.Add(label2);
            Name = "UpdateDepartmentForm";
            Text = "UpdateDepartmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label1;
        private TextBox txtDepartmentID;
        private Button btnCancel;
        private Button btnFind;
        private TextBox txtDepartmentName;
        private Label label2;
    }
}