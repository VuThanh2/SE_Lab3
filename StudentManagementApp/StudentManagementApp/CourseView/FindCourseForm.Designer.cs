namespace StudentManagementApp
{
    partial class FindCourseForm
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
            txtFindCourseID = new TextBox();
            btnCancel = new Button();
            btnFind = new Button();
            txtFindCourseName = new TextBox();
            courseFindGridView = new DataGridView();
            txtCourseID = new DataGridViewTextBoxColumn();
            txtCourseName = new DataGridViewTextBoxColumn();
            txtCredits = new DataGridViewTextBoxColumn();
            txtDepartmentID = new DataGridViewTextBoxColumn();
            txtDepartmentName = new DataGridViewTextBoxColumn();
            txtInstructorID = new DataGridViewTextBoxColumn();
            txtInstructorName = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)courseFindGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 54;
            label1.Text = "CourseID";
            // 
            // txtFindCourseID
            // 
            txtFindCourseID.Location = new Point(28, 44);
            txtFindCourseID.Name = "txtFindCourseID";
            txtFindCourseID.Size = new Size(211, 26);
            txtFindCourseID.TabIndex = 53;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(764, 42);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 52;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(652, 42);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 28);
            btnFind.TabIndex = 51;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFindCourseName
            // 
            txtFindCourseName.Location = new Point(314, 44);
            txtFindCourseName.Name = "txtFindCourseName";
            txtFindCourseName.ReadOnly = true;
            txtFindCourseName.Size = new Size(211, 26);
            txtFindCourseName.TabIndex = 55;
            // 
            // courseFindGridView
            // 
            courseFindGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseFindGridView.Columns.AddRange(new DataGridViewColumn[] { txtCourseID, txtCourseName, txtCredits, txtDepartmentID, txtDepartmentName, txtInstructorID, txtInstructorName });
            courseFindGridView.Location = new Point(28, 94);
            courseFindGridView.Name = "courseFindGridView";
            courseFindGridView.ReadOnly = true;
            courseFindGridView.RowHeadersWidth = 49;
            courseFindGridView.ScrollBars = ScrollBars.Vertical;
            courseFindGridView.Size = new Size(1206, 369);
            courseFindGridView.TabIndex = 56;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 21);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 57;
            label2.Text = "CourseName (Placeholder)";
            // 
            // FindCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 495);
            Controls.Add(label2);
            Controls.Add(courseFindGridView);
            Controls.Add(txtFindCourseName);
            Controls.Add(label1);
            Controls.Add(txtFindCourseID);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Name = "FindCourseForm";
            Text = "FindCourse";
            ((System.ComponentModel.ISupportInitialize)courseFindGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFindCourseID;
        private Button btnCancel;
        private Button btnFind;
        private TextBox txtGPA;
        private TextBox txtMajor;
        private Label label8;
        private TextBox txtFindCourseName;
        private DataGridView courseFindGridView;
        private DataGridViewTextBoxColumn txtCourseID;
        private DataGridViewTextBoxColumn txtCourseName;
        private DataGridViewTextBoxColumn txtCredits;
        private DataGridViewTextBoxColumn txtDepartmentID;
        private DataGridViewTextBoxColumn txtDepartmentName;
        private DataGridViewTextBoxColumn txtInstructorID;
        private DataGridViewTextBoxColumn txtInstructorName;
        private Label label2;
    }
}