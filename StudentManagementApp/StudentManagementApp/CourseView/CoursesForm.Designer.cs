namespace StudentManagementApp
{
    partial class CoursesForm
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
            courseGridView = new DataGridView();
            txtCourseID = new DataGridViewTextBoxColumn();
            txtCourseName = new DataGridViewTextBoxColumn();
            txtCredits = new DataGridViewTextBoxColumn();
            txtDepartmentID = new DataGridViewTextBoxColumn();
            txtDepartmentName = new DataGridViewTextBoxColumn();
            txtInstructorID = new DataGridViewTextBoxColumn();
            txtInstructorName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)courseGridView).BeginInit();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1299, 342);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 49);
            btnFind.TabIndex = 32;
            btnFind.Text = "Find Course";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(19, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 28);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1299, 280);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 28);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1299, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1299, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 28);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1299, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 28);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // courseGridView
            // 
            courseGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseGridView.Columns.AddRange(new DataGridViewColumn[] { txtCourseID, txtCourseName, txtCredits, txtDepartmentID, txtDepartmentName, txtInstructorID, txtInstructorName });
            courseGridView.Location = new Point(58, 69);
            courseGridView.Name = "courseGridView";
            courseGridView.RowHeadersWidth = 49;
            courseGridView.ScrollBars = ScrollBars.Vertical;
            courseGridView.Size = new Size(1206, 369);
            courseGridView.TabIndex = 26;
            // 
            // txtCourseID
            // 
            txtCourseID.FillWeight = 107.382553F;
            txtCourseID.HeaderText = "CourseID";
            txtCourseID.MinimumWidth = 6;
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Resizable = DataGridViewTriState.False;
            txtCourseID.Width = 120;
            // 
            // txtCourseName
            // 
            txtCourseName.FillWeight = 181.043655F;
            txtCourseName.HeaderText = "CourseName";
            txtCourseName.MinimumWidth = 6;
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Resizable = DataGridViewTriState.False;
            txtCourseName.Width = 240;
            // 
            // txtCredits
            // 
            txtCredits.FillWeight = 102.482018F;
            txtCredits.HeaderText = "Credits";
            txtCredits.MinimumWidth = 6;
            txtCredits.Name = "txtCredits";
            txtCredits.Resizable = DataGridViewTriState.False;
            txtCredits.Width = 115;
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.FillWeight = 103.581955F;
            txtDepartmentID.HeaderText = "DepartmentID";
            txtDepartmentID.MinimumWidth = 6;
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Resizable = DataGridViewTriState.False;
            txtDepartmentID.Width = 120;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.HeaderText = "DepartmentName";
            txtDepartmentName.MinimumWidth = 6;
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Resizable = DataGridViewTriState.False;
            txtDepartmentName.Width = 220;
            // 
            // txtInstructorID
            // 
            txtInstructorID.FillWeight = 43.18237F;
            txtInstructorID.HeaderText = "InstructorID";
            txtInstructorID.MinimumWidth = 6;
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Resizable = DataGridViewTriState.False;
            txtInstructorID.Width = 120;
            // 
            // txtInstructorName
            // 
            txtInstructorName.HeaderText = "InstructorName";
            txtInstructorName.MinimumWidth = 6;
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Resizable = DataGridViewTriState.False;
            txtInstructorName.Width = 220;
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 450);
            Controls.Add(btnFind);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(courseGridView);
            Name = "CoursesForm";
            Text = "CoursesForm";
            ((System.ComponentModel.ISupportInitialize)courseGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFind;
        private Button btnBack;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView courseGridView;
        private DataGridViewTextBoxColumn txtCourseID;
        private DataGridViewTextBoxColumn txtCourseName;
        private DataGridViewTextBoxColumn txtCredits;
        private DataGridViewTextBoxColumn txtDepartmentID;
        private DataGridViewTextBoxColumn txtDepartmentName;
        private DataGridViewTextBoxColumn txtInstructorID;
        private DataGridViewTextBoxColumn txtInstructorName;
    }
}