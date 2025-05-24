namespace StudentManagementApp.DepartmentView
{
    partial class DeleteDepartmentForm
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
            lblStudentID = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            txtDeleteDepartmentID = new TextBox();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(36, 27);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(167, 20);
            lblStudentID.TabIndex = 11;
            lblStudentID.Text = "Enter the DepartmentID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(36, 127);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(36, 93);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 28);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Department";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtDeleteDepartmentID
            // 
            txtDeleteDepartmentID.Location = new Point(36, 50);
            txtDeleteDepartmentID.Name = "txtDeleteDepartmentID";
            txtDeleteDepartmentID.Size = new Size(175, 26);
            txtDeleteDepartmentID.TabIndex = 8;
            // 
            // DeleteDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 188);
            Controls.Add(lblStudentID);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(txtDeleteDepartmentID);
            Name = "DeleteDepartmentForm";
            Text = "DeleteDepartmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Button btnCancel;
        private Button btnDelete;
        private TextBox txtDeleteDepartmentID;
    }
}