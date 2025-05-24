namespace StudentManagementApp
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsToolStripMenuItem = new ToolStripMenuItem();
            studentEnrollmentToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            viewCoursesToolStripMenuItem = new ToolStripMenuItem();
            instructorsToolStripMenuItem = new ToolStripMenuItem();
            viewInstructorsToolStripMenuItem = new ToolStripMenuItem();
            departmentsToolStripMenuItem = new ToolStripMenuItem();
            viewDepartmentsToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(19, 19);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, studentsToolStripMenuItem, coursesToolStripMenuItem, instructorsToolStripMenuItem, departmentsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(115, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStudentsToolStripMenuItem, studentEnrollmentToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // viewStudentsToolStripMenuItem
            // 
            viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            viewStudentsToolStripMenuItem.Size = new Size(218, 26);
            viewStudentsToolStripMenuItem.Text = "View Students";
            // 
            // studentEnrollmentToolStripMenuItem
            // 
            studentEnrollmentToolStripMenuItem.Name = "studentEnrollmentToolStripMenuItem";
            studentEnrollmentToolStripMenuItem.Size = new Size(218, 26);
            studentEnrollmentToolStripMenuItem.Text = "Student Enrollment";
            studentEnrollmentToolStripMenuItem.Click += studentEnrollmentToolStripMenuItem_Click;
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewCoursesToolStripMenuItem });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(74, 24);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // viewCoursesToolStripMenuItem
            // 
            viewCoursesToolStripMenuItem.Name = "viewCoursesToolStripMenuItem";
            viewCoursesToolStripMenuItem.Size = new Size(178, 26);
            viewCoursesToolStripMenuItem.Text = "View Courses";
            // 
            // instructorsToolStripMenuItem
            // 
            instructorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewInstructorsToolStripMenuItem });
            instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            instructorsToolStripMenuItem.Size = new Size(91, 24);
            instructorsToolStripMenuItem.Text = "Instructors";
            // 
            // viewInstructorsToolStripMenuItem
            // 
            viewInstructorsToolStripMenuItem.Name = "viewInstructorsToolStripMenuItem";
            viewInstructorsToolStripMenuItem.Size = new Size(195, 26);
            viewInstructorsToolStripMenuItem.Text = "View Instructors";
            // 
            // departmentsToolStripMenuItem
            // 
            departmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewDepartmentsToolStripMenuItem });
            departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            departmentsToolStripMenuItem.Size = new Size(109, 24);
            departmentsToolStripMenuItem.Text = "Departments";
            // 
            // viewDepartmentsToolStripMenuItem
            // 
            viewDepartmentsToolStripMenuItem.Name = "viewDepartmentsToolStripMenuItem";
            viewDepartmentsToolStripMenuItem.Size = new Size(213, 26);
            viewDepartmentsToolStripMenuItem.Text = "View Departments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 230);
            label1.Name = "label1";
            label1.Size = new Size(492, 20);
            label1.TabIndex = 1;
            label1.Text = "Student Management System Delevoped by Duong Thanh Long (Dranov)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem viewCoursesToolStripMenuItem;
        private ToolStripMenuItem instructorsToolStripMenuItem;
        private ToolStripMenuItem viewInstructorsToolStripMenuItem;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem viewDepartmentsToolStripMenuItem;
        private ToolStripMenuItem studentEnrollmentToolStripMenuItem;
        private Label label1;
    }
}