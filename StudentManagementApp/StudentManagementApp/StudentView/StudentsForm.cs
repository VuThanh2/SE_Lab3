using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DAL;
using BLL;
using System.Xml.Linq;
using StudentManagementApp.StudentView;

namespace StudentManagementApp
{
    public partial class StudentsForm : Form
    {
        private readonly StudentService _studentService;

        public StudentsForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            StudentForm_Load();
        }

        private void StudentForm_Load()
        {
            LoadData();
        }

        private void LoadData()
        {
            var students = _studentService.GetAllStudents();

            if (students == null || !students.Any())
            {
                MessageBox.Show("No students found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Convert the list to a DataTable manually
            DataTable table = new DataTable();
            table.Columns.Add("txtStudentID", typeof(int));
            table.Columns.Add("txtStudentName", typeof(string));
            table.Columns.Add("txtDateOfBirth", typeof(DateTime)); // Keep DateTime type
            table.Columns.Add("txtCity", typeof(string));
            table.Columns.Add("txtAge", typeof(int));
            table.Columns.Add("txtYearOfEnroll", typeof(int));
            table.Columns.Add("txtMajor", typeof(string));
            table.Columns.Add("txtGPA", typeof(decimal));

            foreach (var student in students)
            {
                table.Rows.Add(
                    student.StudentID,
                    student.StudentName,
                    student.DateOfBirth,
                    student.City,
                    student.Age,
                    student.YearOfEnroll,
                    student.Major,
                    student.GPA);
            }

            // Bind the DataTable to the existing DataGridView
            studentGridView.DataSource = table;

            // Ensure the columns match the predefined ones
            studentGridView.Columns["txtStudentID"].DataPropertyName = "txtStudentID";
            studentGridView.Columns["txtStudentName"].DataPropertyName = "txtStudentName";
            studentGridView.Columns["txtDateOfBirth"].DataPropertyName = "txtDateOfBirth";
            studentGridView.Columns["txtCity"].DataPropertyName = "txtCity";
            studentGridView.Columns["txtAge"].DataPropertyName = "txtAge";
            studentGridView.Columns["txtYearOfEnroll"].DataPropertyName = "txtYearOfEnroll";
            studentGridView.Columns["txtMajor"].DataPropertyName = "txtMajor";
            studentGridView.Columns["txtGPA"].DataPropertyName = "txtGPA";

            // Optional: Format Date and GPA columns
            studentGridView.Columns["txtDateOfBirth"].DefaultCellStyle.Format = "dd-MM-yyyy";
            studentGridView.Columns["txtGPA"].DefaultCellStyle.Format = "0.00";

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
            StudentForm_Load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudentForm updateStudentForm = new UpdateStudentForm();
            updateStudentForm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudentForm deleteStudentForm = new DeleteStudentForm();
            deleteStudentForm.Show();
            StudentForm_Load();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindStudentForm findForm = new FindStudentForm();
            findForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

    }
}