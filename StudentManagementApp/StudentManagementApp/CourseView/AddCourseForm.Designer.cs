namespace StudentManagementApp
{
    partial class AddCourseForm
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
            btnCancel = new Button();
            btnAdd = new Button();
            label9 = new Label();
            label10 = new Label();
            txtCredits = new TextBox();
            txtCourseName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtDepartmentName = new ComboBox();
            txtInstructorName = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(595, 211);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(462, 213);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(381, 106);
            label9.Name = "label9";
            label9.Size = new Size(111, 20);
            label9.TabIndex = 28;
            label9.Text = "InstructorName";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(381, 36);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 27;
            label10.Text = "DepartmentName";
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(40, 131);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(304, 26);
            txtCredits.TabIndex = 23;
            txtCredits.Tag = "";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(40, 59);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(304, 26);
            txtCourseName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 108);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 20;
            label3.Text = "Number of credit(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 36);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 19;
            label2.Text = "CourseName";
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.FormattingEnabled = true;
            txtDepartmentName.Location = new Point(381, 59);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(304, 27);
            txtDepartmentName.TabIndex = 35;
            txtDepartmentName.SelectedIndexChanged += txtDepartmentName_SelectedIndexChanged;
            // 
            // txtInstructorName
            // 
            txtInstructorName.FormattingEnabled = true;
            txtInstructorName.Location = new Point(381, 131);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Size = new Size(304, 27);
            txtInstructorName.TabIndex = 36;
            txtInstructorName.SelectedIndexChanged += txtInstructorName_SelectedIndexChanged;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 266);
            Controls.Add(txtInstructorName);
            Controls.Add(txtDepartmentName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseName);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AddCourseForm";
            Text = "AddCourseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnAdd;
        private Label label9;
        private Label label10;
        private TextBox txtCredits;
        private TextBox txtCourseName;
        private Label label3;
        private Label label2;
        private ComboBox txtDepartmentName;
        private ComboBox txtInstructorName;
    }
}