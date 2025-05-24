namespace StudentManagementApp
{
    partial class UpdateCourseForm
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
            label2 = new Label();
            txtFindCourseName = new TextBox();
            label1 = new Label();
            txtFindCourseID = new TextBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnFind = new Button();
            courseUpdateGridView = new DataGridView();
            txtCourseID = new DataGridViewTextBoxColumn();
            txtCourseName = new DataGridViewTextBoxColumn();
            txtCredits = new DataGridViewTextBoxColumn();
            txtDepartmentName = new DataGridViewTextBoxColumn();
            txtInstructorName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)courseUpdateGridView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 27);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 64;
            label2.Text = "CourseName (Placeholder)";
            // 
            // txtFindCourseName
            // 
            txtFindCourseName.Location = new Point(277, 50);
            txtFindCourseName.Name = "txtFindCourseName";
            txtFindCourseName.ReadOnly = true;
            txtFindCourseName.Size = new Size(211, 26);
            txtFindCourseName.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 61;
            label1.Text = "CourseID";
            // 
            // txtFindCourseID
            // 
            txtFindCourseID.Location = new Point(32, 50);
            txtFindCourseID.Name = "txtFindCourseID";
            txtFindCourseID.Size = new Size(211, 26);
            txtFindCourseID.TabIndex = 60;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(768, 48);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 59;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(656, 48);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 28);
            btnUpdate.TabIndex = 58;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(544, 48);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 28);
            btnFind.TabIndex = 65;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // courseUpdateGridView
            // 
            courseUpdateGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseUpdateGridView.Columns.AddRange(new DataGridViewColumn[] { txtCourseID, txtCourseName, txtCredits, txtDepartmentName, txtInstructorName });
            courseUpdateGridView.Location = new Point(32, 107);
            courseUpdateGridView.Name = "courseUpdateGridView";
            courseUpdateGridView.RowHeadersWidth = 49;
            courseUpdateGridView.ScrollBars = ScrollBars.Vertical;
            courseUpdateGridView.Size = new Size(965, 369);
            courseUpdateGridView.TabIndex = 66;
            // 
            // txtCourseID
            // 
            txtCourseID.FillWeight = 107.382553F;
            txtCourseID.HeaderText = "CourseID";
            txtCourseID.MinimumWidth = 6;
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Resizable = DataGridViewTriState.False;
            txtCourseID.Width = 166;
            // 
            // txtCourseName
            // 
            txtCourseName.FillWeight = 181.043655F;
            txtCourseName.HeaderText = "CourseName";
            txtCourseName.MinimumWidth = 6;
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Resizable = DataGridViewTriState.False;
            txtCourseName.Width = 280;
            // 
            // txtCredits
            // 
            txtCredits.FillWeight = 102.482018F;
            txtCredits.HeaderText = "Credits";
            txtCredits.MinimumWidth = 6;
            txtCredits.Name = "txtCredits";
            txtCredits.Resizable = DataGridViewTriState.False;
            txtCredits.Width = 159;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.HeaderText = "DepartmentName";
            txtDepartmentName.MinimumWidth = 6;
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Resizable = DataGridViewTriState.False;
            txtDepartmentName.Width = 154;
            // 
            // txtInstructorName
            // 
            txtInstructorName.HeaderText = "InstructorName";
            txtInstructorName.MinimumWidth = 6;
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Resizable = DataGridViewTriState.False;
            txtInstructorName.Width = 155;
            // 
            // UpdateCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 504);
            Controls.Add(courseUpdateGridView);
            Controls.Add(btnFind);
            Controls.Add(label2);
            Controls.Add(txtFindCourseName);
            Controls.Add(label1);
            Controls.Add(txtFindCourseID);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Name = "UpdateCourseForm";
            Text = "UpdateCourse";
            ((System.ComponentModel.ISupportInitialize)courseUpdateGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtFindCourseName;
        private Label label1;
        private TextBox txtFindCourseID;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnFind;
        private DataGridView courseUpdateGridView;
        private DataGridViewTextBoxColumn txtCourseID;
        private DataGridViewTextBoxColumn txtCourseName;
        private DataGridViewTextBoxColumn txtCredits;
        private DataGridViewTextBoxColumn txtDepartmentName;
        private DataGridViewTextBoxColumn txtInstructorName;
    }
}