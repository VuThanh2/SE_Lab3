namespace StudentManagementApp.StudentView
{
    partial class DeleteStudentForm
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
            txtStudentID = new TextBox();
            btnDelete = new Button();
            btnCancel = new Button();
            lblStudentID = new Label();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(47, 51);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(175, 26);
            txtStudentID.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(47, 94);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 28);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(47, 128);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(47, 28);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(138, 20);
            lblStudentID.TabIndex = 3;
            lblStudentID.Text = "Enter the StudentID";
            // 
            // DeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 188);
            Controls.Add(lblStudentID);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(txtStudentID);
            Name = "DeleteStudentForm";
            Text = "DeleteStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private Button btnDelete;
        private Button btnCancel;
        private Label lblStudentID;
    }
}