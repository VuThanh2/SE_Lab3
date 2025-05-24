namespace StudentManagementApp
{
    partial class AddStudentForm
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
            label3 = new Label();
            label4 = new Label();
            txtStudentName = new TextBox();
            txtDateOfBirth = new TextBox();
            txtCity = new TextBox();
            txtAge = new TextBox();
            label5 = new Label();
            txtGPA = new TextBox();
            txtMajor = new TextBox();
            txtYearOfEnroll = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 27);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "StudentName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 99);
            label3.Name = "label3";
            label3.Size = new Size(210, 20);
            label3.TabIndex = 2;
            label3.Text = "DateOfBirth (Eg: dd-MM-yyyy)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 173);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 3;
            label4.Text = "City";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(42, 50);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(304, 26);
            txtStudentName.TabIndex = 5;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(42, 122);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(304, 26);
            txtDateOfBirth.TabIndex = 6;
            txtDateOfBirth.Tag = "";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(42, 196);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(304, 26);
            txtCity.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(42, 269);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(304, 26);
            txtAge.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 246);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 9;
            label5.Text = "Age";
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(383, 192);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(304, 26);
            txtGPA.TabIndex = 16;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(383, 120);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(304, 26);
            txtMajor.TabIndex = 15;
            // 
            // txtYearOfEnroll
            // 
            txtYearOfEnroll.Location = new Point(383, 50);
            txtYearOfEnroll.Name = "txtYearOfEnroll";
            txtYearOfEnroll.Size = new Size(304, 26);
            txtYearOfEnroll.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(383, 169);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 12;
            label8.Text = "GPA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 97);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 11;
            label9.Text = "Major";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(383, 27);
            label10.Name = "label10";
            label10.Size = new Size(157, 20);
            label10.TabIndex = 10;
            label10.Text = "YearOfEnroll (Eg: yyyy)";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(464, 271);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(597, 269);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 28);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 327);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
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
            Name = "AddStudentForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStudentName;
        private TextBox txtDateOfBirth;
        private TextBox txtCity;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtGPA;
        private TextBox txtMajor;
        private TextBox txtYearOfEnroll;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnAdd;
        private Button btnCancel;
    }
}