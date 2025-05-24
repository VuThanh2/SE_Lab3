namespace StudentManagementApp
{
    partial class StudentCourseForm
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
            btnFind = new Button();
            btnBack = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            studentCourseGridView = new DataGridView();
            txtStudentID = new DataGridViewTextBoxColumn();
            txtStudentName = new DataGridViewTextBoxColumn();
            txtCourseID = new DataGridViewTextBoxColumn();
            txtCourseName = new DataGridViewTextBoxColumn();
            txtCredits = new DataGridViewTextBoxColumn();
            txtDepartmentName = new DataGridViewTextBoxColumn();
            txtInstructorName = new DataGridViewTextBoxColumn();
            cmbMajorFilter = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentCourseGridView).BeginInit();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1328, 342);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 49);
            btnFind.TabIndex = 32;
            btnFind.Text = "Find Student";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(21, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 28);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1328, 280);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 28);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1328, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1328, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 28);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1328, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 28);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // studentCourseGridView
            // 
            studentCourseGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentCourseGridView.Columns.AddRange(new DataGridViewColumn[] { txtStudentID, txtStudentName, txtCourseID, txtCourseName, txtCredits, txtDepartmentName, txtInstructorName });
            studentCourseGridView.Location = new Point(60, 69);
            studentCourseGridView.Name = "studentCourseGridView";
            studentCourseGridView.RowHeadersWidth = 49;
            studentCourseGridView.ScrollBars = ScrollBars.Vertical;
            studentCourseGridView.Size = new Size(1230, 369);
            studentCourseGridView.TabIndex = 26;
            // 
            // txtStudentID
            // 
            txtStudentID.FillWeight = 107.382553F;
            txtStudentID.HeaderText = "StudentID";
            txtStudentID.MinimumWidth = 6;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Resizable = DataGridViewTriState.False;
            txtStudentID.Width = 120;
            // 
            // txtStudentName
            // 
            txtStudentName.FillWeight = 181.043655F;
            txtStudentName.HeaderText = "StudentName";
            txtStudentName.MinimumWidth = 6;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Resizable = DataGridViewTriState.False;
            txtStudentName.Width = 220;
            // 
            // txtCourseID
            // 
            txtCourseID.FillWeight = 102.482018F;
            txtCourseID.HeaderText = "CourseID";
            txtCourseID.MinimumWidth = 6;
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Resizable = DataGridViewTriState.False;
            txtCourseID.Width = 120;
            // 
            // txtCourseName
            // 
            txtCourseName.FillWeight = 103.581955F;
            txtCourseName.HeaderText = "CouseName";
            txtCourseName.MinimumWidth = 6;
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Resizable = DataGridViewTriState.False;
            txtCourseName.Width = 220;
            // 
            // txtCredits
            // 
            txtCredits.FillWeight = 43.18237F;
            txtCredits.HeaderText = "Credits";
            txtCredits.MinimumWidth = 6;
            txtCredits.Name = "txtCredits";
            txtCredits.Resizable = DataGridViewTriState.False;
            txtCredits.Width = 60;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.FillWeight = 94.58236F;
            txtDepartmentName.HeaderText = "DepartmentName";
            txtDepartmentName.MinimumWidth = 6;
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Resizable = DataGridViewTriState.False;
            txtDepartmentName.Width = 220;
            // 
            // txtInstructorName
            // 
            txtInstructorName.FillWeight = 119.372139F;
            txtInstructorName.HeaderText = "InstructorName";
            txtInstructorName.MinimumWidth = 6;
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Resizable = DataGridViewTriState.False;
            txtInstructorName.Width = 220;
            // 
            // cmbMajorFilter
            // 
            cmbMajorFilter.FormattingEnabled = true;
            cmbMajorFilter.Location = new Point(1036, 18);
            cmbMajorFilter.Name = "cmbMajorFilter";
            cmbMajorFilter.Size = new Size(254, 27);
            cmbMajorFilter.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(982, 22);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 34;
            label1.Text = "Major";
            // 
            // StudentCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 450);
            Controls.Add(label1);
            Controls.Add(cmbMajorFilter);
            Controls.Add(btnFind);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(studentCourseGridView);
            Name = "StudentCourseForm";
            Text = "StudentEnrollmentsForm";
            ((System.ComponentModel.ISupportInitialize)studentCourseGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFind;
        private Button btnBack;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView studentCourseGridView;
        private DataGridViewTextBoxColumn txtStudentID;
        private DataGridViewTextBoxColumn txtStudentName;
        private DataGridViewTextBoxColumn txtCourseID;
        private DataGridViewTextBoxColumn txtCourseName;
        private DataGridViewTextBoxColumn txtCredits;
        private DataGridViewTextBoxColumn txtDepartmentName;
        private DataGridViewTextBoxColumn txtInstructorName;
        private ComboBox cmbMajorFilter;
        private Label label1;
    }
}