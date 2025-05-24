using System;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            this.viewCoursesToolStripMenuItem.Click += new System.EventHandler(this.viewCoursesToolStripMenuItem_Click);
            this.viewInstructorsToolStripMenuItem.Click += new System.EventHandler(this.viewInstructorsToolStripMenuItem_Click);
            this.viewDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.viewDepartmentsToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        }
        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            this.Hide();
            studentsForm.Show();
        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new CoursesForm();
            this.Hide();
            coursesForm.Show();
        }

        private void viewInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructorsForm instructorsForm = new InstructorsForm();
            this.Hide();
            instructorsForm.Show();
        }

        private void viewDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentsForm departmentsForm = new DepartmentsForm();
            this.Hide();
            departmentsForm.Show();
        }
        private void studentEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentCourseForm studentEnrollmentsForm = new StudentCourseForm();
            this.Hide();
            studentEnrollmentsForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}