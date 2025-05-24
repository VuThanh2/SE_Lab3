namespace StudentManagementApp
{
    partial class FindStudentForm
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
            btnFind = new Button();
            txtGPA = new TextBox();
            txtMajor = new TextBox();
            txtYearOfEnroll = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            txtAge = new TextBox();
            txtCity = new TextBox();
            txtDateOfBirth = new TextBox();
            txtStudentName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtStudentID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(397, 52);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(285, 52);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 28);
            btnFind.TabIndex = 33;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(379, 265);
            txtGPA.Name = "txtGPA";
            txtGPA.ReadOnly = true;
            txtGPA.Size = new Size(304, 26);
            txtGPA.TabIndex = 32;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(379, 193);
            txtMajor.Name = "txtMajor";
            txtMajor.ReadOnly = true;
            txtMajor.Size = new Size(304, 26);
            txtMajor.TabIndex = 31;
            // 
            // txtYearOfEnroll
            // 
            txtYearOfEnroll.Location = new Point(379, 123);
            txtYearOfEnroll.Name = "txtYearOfEnroll";
            txtYearOfEnroll.ReadOnly = true;
            txtYearOfEnroll.Size = new Size(304, 26);
            txtYearOfEnroll.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(379, 242);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 29;
            label8.Text = "GPA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(379, 170);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 28;
            label9.Text = "Major";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(379, 100);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 27;
            label10.Text = "YearOfEnroll";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 319);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 26;
            label5.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(38, 342);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(304, 26);
            txtAge.TabIndex = 25;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(38, 269);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(304, 26);
            txtCity.TabIndex = 24;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(38, 195);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.ReadOnly = true;
            txtDateOfBirth.Size = new Size(304, 26);
            txtDateOfBirth.TabIndex = 23;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(38, 123);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.ReadOnly = true;
            txtStudentName.Size = new Size(304, 26);
            txtStudentName.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 246);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 21;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 172);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 20;
            label3.Text = "DateOfBirth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 19;
            label2.Text = "StudentName";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(37, 54);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(211, 26);
            txtStudentID.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 31);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 36;
            label1.Text = "StudentID";
            // 
            // FindStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 394);
            Controls.Add(label1);
            Controls.Add(txtStudentID);
            Controls.Add(btnCancel);
            Controls.Add(btnFind);
            Controls.Add(txtGPA);
            Controls.Add(txtMajor);
            Controls.Add(txtYearOfEnroll);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(txtCity);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtStudentName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FindStudentForm";
            Text = "FindForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnFind;
        private TextBox txtGPA;
        private TextBox txtMajor;
        private TextBox txtYearOfEnroll;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private TextBox txtAge;
        private TextBox txtCity;
        private TextBox txtDateOfBirth;
        private TextBox txtStudentName;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtStudentID;
        private Label label1;
    }
}