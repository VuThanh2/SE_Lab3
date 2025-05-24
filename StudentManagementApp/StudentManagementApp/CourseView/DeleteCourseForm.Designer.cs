namespace StudentManagementApp 
{
    partial class DeleteCourseForm
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
            txtDeleteCourseID = new TextBox();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(34, 25);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(132, 20);
            lblStudentID.TabIndex = 7;
            lblStudentID.Text = "Enter the CourseID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(34, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(34, 91);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 28);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Course";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtDeleteCourseID
            // 
            txtDeleteCourseID.Location = new Point(34, 48);
            txtDeleteCourseID.Name = "txtDeleteCourseID";
            txtDeleteCourseID.Size = new Size(175, 26);
            txtDeleteCourseID.TabIndex = 4;
            // 
            // DeleteCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 189);
            Controls.Add(lblStudentID);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(txtDeleteCourseID);
            Name = "DeleteCourseForm";
            Text = "DeleteCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Button btnCancel;
        private Button btnDelete;
        private TextBox txtDeleteCourseID;
    }
}