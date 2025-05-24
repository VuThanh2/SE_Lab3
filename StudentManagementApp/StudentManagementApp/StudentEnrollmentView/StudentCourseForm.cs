using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DAL;
using BLL;

namespace StudentManagementApp
{
    public partial class StudentCourseForm : Form
    {
        private readonly StudentCourseService _studentCourseService;
        public StudentCourseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _studentCourseService = new StudentCourseService();
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.cmbMajorFilter.SelectedIndexChanged += new System.EventHandler(this.cmbMajorFilter_SelectedIndexChanged);
            StudentCourseForm_Load();
            cmbMajorFilter_Load();
        }

        private void StudentCourseForm_Load()
        {
            LoadData();
        }
        private void LoadData()
        {
            var courses = _studentCourseService.GetAllStudentCourses();

            if (courses == null || !courses.Any())
            {
                MessageBox.Show("No courses found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("txtStudentID", typeof(int));
            table.Columns.Add("txtStudentName", typeof(string));
            table.Columns.Add("txtCourseID", typeof(string));
            table.Columns.Add("txtCourseName", typeof(string));
            table.Columns.Add("txtCredits", typeof(int));
            table.Columns.Add("txtDepartmentName", typeof(string));
            table.Columns.Add("txtInstructorName", typeof(string));

            foreach (var course in courses)
            {
                table.Rows.Add(
                    course.StudentID,
                    course.tblStudents?.StudentName,
                    course.CourseID,
                    course.tblCourses?.CourseName,
                    course.tblCourses?.Credits,
                    course.tblCourses?.tblDepartment.DepartmentName,
                    course.tblCourses?.tblInstructor.InstructorName
                );
            }

            // Bind the DataTable to the existing DataGridView
            studentCourseGridView.DataSource = table;

            //Ensure the columns match the predefined ones
            studentCourseGridView.Columns["txtStudentID"].DataPropertyName = "txtStudentID";
            studentCourseGridView.Columns["txtStudentName"].DataPropertyName = "txtStudentName";
            studentCourseGridView.Columns["txtCourseID"].DataPropertyName = "txtCourseID";
            studentCourseGridView.Columns["txtCourseName"].DataPropertyName = "txtCourseName";
            studentCourseGridView.Columns["txtCredits"].DataPropertyName = "txtCredits";
            studentCourseGridView.Columns["txtDepartmentName"].DataPropertyName = "txtDepartmentName";
            studentCourseGridView.Columns["txtInstructorName"].DataPropertyName = "txtInstructorName";
        }
        private void cmbMajorFilter_Load()
        {
            var majors = _studentCourseService.GetAllMajors();
            if (majors != null && majors.Any())
            {
                cmbMajorFilter.DataSource = majors;
                cmbMajorFilter.DisplayMember = "CourseName";
                cmbMajorFilter.ValueMember = "CourseID";
                cmbMajorFilter.SelectedIndex = -1;
            }
        }

        private void cmbMajorFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMajorFilter.SelectedItem == null || cmbMajorFilter.SelectedValue == null)
            {
                return;
            }

            if (cmbMajorFilter.SelectedValue is int selectedMajor)
            {
                var courses = _studentCourseService.GetAllStudentCoursesByMajor(selectedMajor);
                if (courses == null || !courses.Any())
                {
                    MessageBox.Show("No courses found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable table = new DataTable();
                table.Columns.Add("txtStudentID", typeof(int));
                table.Columns.Add("txtStudentName", typeof(string));
                table.Columns.Add("txtCourseID", typeof(string));
                table.Columns.Add("txtCourseName", typeof(string));
                table.Columns.Add("txtCredits", typeof(int));
                table.Columns.Add("txtDepartmentName", typeof(string));
                table.Columns.Add("txtInstructorName", typeof(string));
                foreach (var course in courses)
                {
                    table.Rows.Add(
                        course.StudentID,
                        course.tblStudents?.StudentName,
                        course.CourseID,
                        course.tblCourses?.CourseName,
                        course.tblCourses?.Credits,
                        course.tblCourses?.tblDepartment.DepartmentName,
                        course.tblCourses?.tblInstructor.InstructorName
                    );
                }
                // Bind the DataTable to the existing DataGridView
                studentCourseGridView.DataSource = table;
                //Ensure the columns match the predefined ones
                studentCourseGridView.Columns["txtStudentID"].DataPropertyName = "txtStudentID";
                studentCourseGridView.Columns["txtStudentName"].DataPropertyName = "txtStudentName";
                studentCourseGridView.Columns["txtCourseID"].DataPropertyName = "txtCourseID";
                studentCourseGridView.Columns["txtCourseName"].DataPropertyName = "txtCourseName";
                studentCourseGridView.Columns["txtCredits"].DataPropertyName = "txtCredits";
                studentCourseGridView.Columns["txtDepartmentName"].DataPropertyName = "txtDepartmentName";
                studentCourseGridView.Columns["txtInstructorName"].DataPropertyName = "txtInstructorName";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    } 
}