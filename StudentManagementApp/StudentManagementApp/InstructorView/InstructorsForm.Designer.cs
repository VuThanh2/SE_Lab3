namespace StudentManagementApp
{
    partial class InstructorsForm
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
            instructorGridView = new DataGridView();
            txtInstructorID = new DataGridViewTextBoxColumn();
            txtInstructorName = new DataGridViewTextBoxColumn();
            txtDepartmentID = new DataGridViewTextBoxColumn();
            txtDepartmentName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)instructorGridView).BeginInit();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.Location = new Point(833, 342);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 49);
            btnFind.TabIndex = 32;
            btnFind.Text = "Find Instructor";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(22, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 28);
            btnBack.TabIndex = 31;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(833, 280);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 28);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(833, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(833, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 28);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(833, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 28);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // instructorGridView
            // 
            instructorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            instructorGridView.Columns.AddRange(new DataGridViewColumn[] { txtInstructorID, txtInstructorName, txtDepartmentID, txtDepartmentName });
            instructorGridView.Location = new Point(61, 69);
            instructorGridView.Name = "instructorGridView";
            instructorGridView.RowHeadersWidth = 49;
            instructorGridView.ScrollBars = ScrollBars.Vertical;
            instructorGridView.Size = new Size(731, 369);
            instructorGridView.TabIndex = 26;
            // 
            // txtInstructorID
            // 
            txtInstructorID.FillWeight = 107.382553F;
            txtInstructorID.Frozen = true;
            txtInstructorID.HeaderText = "InstructorID";
            txtInstructorID.MinimumWidth = 6;
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Width = 120;
            // 
            // txtInstructorName
            // 
            txtInstructorName.FillWeight = 181.043655F;
            txtInstructorName.Frozen = true;
            txtInstructorName.HeaderText = "InstructorName";
            txtInstructorName.MinimumWidth = 6;
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Width = 220;
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.FillWeight = 102.482018F;
            txtDepartmentID.Frozen = true;
            txtDepartmentID.HeaderText = "DepartmentID";
            txtDepartmentID.MinimumWidth = 6;
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Width = 120;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.FillWeight = 103.581955F;
            txtDepartmentName.Frozen = true;
            txtDepartmentName.HeaderText = "DepartmentName";
            txtDepartmentName.MinimumWidth = 6;
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Width = 220;
            // 
            // InstructorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 450);
            Controls.Add(btnFind);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(instructorGridView);
            Name = "InstructorsForm";
            Text = "InstructorsForm";
            ((System.ComponentModel.ISupportInitialize)instructorGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFind;
        private Button btnBack;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView instructorGridView;
        private DataGridViewTextBoxColumn txtInstructorID;
        private DataGridViewTextBoxColumn txtInstructorName;
        private DataGridViewTextBoxColumn txtDepartmentID;
        private DataGridViewTextBoxColumn txtDepartmentName;
    }
}