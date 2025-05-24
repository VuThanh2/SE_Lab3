namespace StudentManagementApp
{
    partial class DepartmentsForm
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
            departmentGridView = new DataGridView();
            txtDepartmentID = new DataGridViewTextBoxColumn();
            txtDepartmentName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)departmentGridView).BeginInit();
            SuspendLayout();
            // 
            // btnFind
            // 
            btnFind.Location = new Point(498, 342);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(101, 53);
            btnFind.TabIndex = 32;
            btnFind.Text = "Find Department";
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
            btnRefresh.Location = new Point(498, 280);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(101, 28);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(498, 69);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 28);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(498, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 28);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(498, 140);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 28);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // departmentGridView
            // 
            departmentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmentGridView.Columns.AddRange(new DataGridViewColumn[] { txtDepartmentID, txtDepartmentName });
            departmentGridView.Location = new Point(60, 69);
            departmentGridView.Name = "departmentGridView";
            departmentGridView.RowHeadersWidth = 49;
            departmentGridView.ScrollBars = ScrollBars.Vertical;
            departmentGridView.Size = new Size(391, 369);
            departmentGridView.TabIndex = 26;
            // 
            // txtDepartmentID
            // 
            txtDepartmentID.FillWeight = 107.382553F;
            txtDepartmentID.HeaderText = "DepartmentID";
            txtDepartmentID.MinimumWidth = 6;
            txtDepartmentID.Name = "txtDepartmentID";
            txtDepartmentID.Width = 120;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.FillWeight = 181.043655F;
            txtDepartmentName.HeaderText = "DepartmentName";
            txtDepartmentName.MinimumWidth = 6;
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Width = 220;
            // 
            // DepartmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 450);
            Controls.Add(btnFind);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(departmentGridView);
            Name = "DepartmentsForm";
            Text = "DepartmentsForm";
            ((System.ComponentModel.ISupportInitialize)departmentGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFind;
        private Button btnBack;
        private Button btnRefresh;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView departmentGridView;
        private DataGridViewTextBoxColumn txtDepartmentID;
        private DataGridViewTextBoxColumn txtDepartmentName;
    }
}