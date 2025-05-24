namespace StudentManagementApp
{
    partial class StudentsForm
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
            btnBack = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            studentGridView = new DataGridView();
            btnFind = new Button();
            txtStudentID = new DataGridViewTextBoxColumn();
            txtStudentName = new DataGridViewTextBoxColumn();
            txtDateOfBirth = new DataGridViewTextBoxColumn();
            txtCity = new DataGridViewTextBoxColumn();
            txtAge = new DataGridViewTextBoxColumn();
            txtYearOfEnroll = new DataGridViewTextBoxColumn();
            txtMajor = new DataGridViewTextBoxColumn();
            txtGPA = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(25, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 28);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1062, 278);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 28);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1062, 67);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1062, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 28);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1062, 138);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 28);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // studentGridView
            // 
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Columns.AddRange(new DataGridViewColumn[] { txtStudentID, txtStudentName, txtDateOfBirth, txtCity, txtAge, txtYearOfEnroll, txtMajor, txtGPA });
            studentGridView.Location = new Point(64, 67);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 49;
            studentGridView.ScrollBars = ScrollBars.Vertical;
            studentGridView.Size = new Size(945, 369);
            studentGridView.TabIndex = 19;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1062, 340);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 49);
            btnFind.TabIndex = 25;
            btnFind.Text = "Find Student";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtStudentID
            // 
            txtStudentID.FillWeight = 107.382553F;
            txtStudentID.Frozen = true;
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
            txtStudentName.Width = 202;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.FillWeight = 102.482018F;
            txtDateOfBirth.HeaderText = "DateOfBirth";
            txtDateOfBirth.MinimumWidth = 6;
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Resizable = DataGridViewTriState.False;
            txtDateOfBirth.Width = 115;
            // 
            // txtCity
            // 
            txtCity.FillWeight = 103.581955F;
            txtCity.HeaderText = "City";
            txtCity.MinimumWidth = 6;
            txtCity.Name = "txtCity";
            txtCity.Resizable = DataGridViewTriState.False;
            txtCity.Width = 116;
            // 
            // txtAge
            // 
            txtAge.FillWeight = 43.18237F;
            txtAge.HeaderText = "Age";
            txtAge.MinimumWidth = 6;
            txtAge.Name = "txtAge";
            txtAge.Resizable = DataGridViewTriState.False;
            txtAge.Width = 48;
            // 
            // txtYearOfEnroll
            // 
            txtYearOfEnroll.FillWeight = 94.58236F;
            txtYearOfEnroll.HeaderText = "YearOfEnroll";
            txtYearOfEnroll.MinimumWidth = 6;
            txtYearOfEnroll.Name = "txtYearOfEnroll";
            txtYearOfEnroll.Resizable = DataGridViewTriState.False;
            txtYearOfEnroll.Width = 106;
            // 
            // txtMajor
            // 
            txtMajor.FillWeight = 119.372139F;
            txtMajor.HeaderText = "Major";
            txtMajor.MinimumWidth = 6;
            txtMajor.Name = "txtMajor";
            txtMajor.Resizable = DataGridViewTriState.False;
            txtMajor.Width = 133;
            // 
            // txtGPA
            // 
            txtGPA.FillWeight = 48.37289F;
            txtGPA.HeaderText = "GPA";
            txtGPA.MinimumWidth = 6;
            txtGPA.Name = "txtGPA";
            txtGPA.Resizable = DataGridViewTriState.False;
            txtGPA.Width = 54;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 450);
            Controls.Add(btnFind);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(studentGridView);
            Name = "StudentsForm";
            Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView studentGridView;
        private Button btnFind;
        private DataGridViewTextBoxColumn txtStudentID;
        private DataGridViewTextBoxColumn txtStudentName;
        private DataGridViewTextBoxColumn txtDateOfBirth;
        private DataGridViewTextBoxColumn txtCity;
        private DataGridViewTextBoxColumn txtAge;
        private DataGridViewTextBoxColumn txtYearOfEnroll;
        private DataGridViewTextBoxColumn txtMajor;
        private DataGridViewTextBoxColumn txtGPA;
    }
}