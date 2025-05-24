using StudentManagementApp.StudentView;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DAL;
using BLL;

namespace StudentManagementApp
{
    public partial class CoursesForm : Form
    {
        private readonly CourseService _courseService;

        public CoursesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _courseService = new CourseService();
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            CourseForm_Load();
        }

        private void CourseForm_Load()
        {
            LoadData();
        }

        private void LoadData()
        {
            var courses = _courseService.GetAllCourses();

            if (courses == null || !courses.Any())
            {
                MessageBox.Show("No courses found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("txtCourseID", typeof(int));
            table.Columns.Add("txtCourseName", typeof(string));
            table.Columns.Add("txtCredits", typeof(int));
            table.Columns.Add("txtDepartmentID", typeof(string));
            table.Columns.Add("txtDepartmentName", typeof(string));
            table.Columns.Add("txtInstructorID", typeof(string));
            table.Columns.Add("txtInstructorName", typeof(string));

            foreach (var course in courses)
            {
                table.Rows.Add(
                    course.CourseID,
                    course.CourseName,
                    course.Credits,
                    course.DepartmentID,
                    course.tblDepartment?.DepartmentName,
                    course.InstructorID,
                    course.tblInstructor?.InstructorName
                );
            }

            // Bind the DataTable to the existing DataGridView
            courseGridView.DataSource = table;

            //Ensure the columns match the predefined ones
            courseGridView.Columns["txtCourseID"].DataPropertyName = "txtCourseID";
            courseGridView.Columns["txtCourseName"].DataPropertyName = "txtCourseName";
            courseGridView.Columns["txtCredits"].DataPropertyName = "txtCredits";
            courseGridView.Columns["txtDepartmentID"].DataPropertyName = "txtDepartmentID";
            courseGridView.Columns["txtDepartmentName"].DataPropertyName = "txtDepartmentName";
            courseGridView.Columns["txtInstructorID"].DataPropertyName = "txtInstructorID";
            courseGridView.Columns["txtInstructorName"].DataPropertyName = "txtInstructorName";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show();
            CourseForm_Load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCourseForm updateCourseForm = new UpdateCourseForm();
            updateCourseForm.Show();
            CourseForm_Load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCourseForm deleteCourseForm = new DeleteCourseForm();
            deleteCourseForm.Show();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindCourseForm findCourseForm = new FindCourseForm();
            findCourseForm.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

    }
}