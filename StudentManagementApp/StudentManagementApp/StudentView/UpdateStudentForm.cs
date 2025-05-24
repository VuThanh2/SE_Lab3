using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace StudentManagementApp
{
    public partial class UpdateStudentForm : Form
    {
        public readonly StudentService _studentService;
        public UpdateStudentForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnFind.Click += btnFind_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.btnUpdate.Click += btnUpdate_Click;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            var student = _studentService.GetStudentById(int.Parse(txtStudentID.Text));
            if (student != null)
            {
                txtStudentID.Text = student.StudentID.ToString();
                txtStudentName.Text = student.StudentName;
                txtDateOfBirth.Text = student.DateOfBirth.ToString();
                txtCity.Text = student.City;
                txtAge.Text = student.Age.ToString();
                txtYearOfEnroll.Text = student.YearOfEnroll.ToString();
                txtMajor.Text = student.Major;
                txtGPA.Text = student.GPA.ToString();

                //MessageBox.Show($"Student Found:" +
                //    $"\nName: {student.StudentName}\n" +
                //    $"DOB: {student.DateOfBirth}\n" +
                //    $"City: {student.City}\n" +
                //    $"Age: {student.Age}\n" +
                //    $"Year of Enroll: {student.YearOfEnroll}\n" +
                //    $"Major: {student.Major}\n" +
                //    $"GPA: {student.GPA}", "Student Info", 
                //    MessageBoxButtons.OK, 
                //    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Student not found!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                var student = new tblStudents
                {
                    StudentID = int.Parse(txtStudentID.Text),
                    StudentName = txtStudentName.Text,
                    DateOfBirth = DateTime.Parse(txtDateOfBirth.Text),
                    City = txtCity.Text,
                    Age = int.Parse(txtAge.Text),
                    YearOfEnroll = int.Parse(txtYearOfEnroll.Text),
                    Major = txtMajor.Text,
                    GPA = decimal.Parse(txtGPA.Text)
                };

                var result = _studentService.UpdateStudent(student);
                if (result != null)
                {
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    this.Close();
                    StudentsForm studentsForm = new StudentsForm();
                    studentsForm.Show();
                }
                else
                {
                    MessageBox.Show("Failed to update student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        private void ClearFields()
        {
            txtStudentName.Clear();
            txtDateOfBirth.Clear();
            txtCity.Clear();
            txtAge.Clear();
            txtYearOfEnroll.Clear();
            txtMajor.Clear();
            txtGPA.Clear();
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtDateOfBirth.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtYearOfEnroll.Text) ||
                string.IsNullOrWhiteSpace(txtMajor.Text) ||
                string.IsNullOrWhiteSpace(txtGPA.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtAge.Text, out _) || !int.TryParse(txtYearOfEnroll.Text, out _))
            {
                MessageBox.Show("Age and Year of Enrollment must be valid integers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtGPA.Text, out _))
            {
                MessageBox.Show("GPA must be a valid decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentsForm studentForm = new StudentsForm();
            studentForm.Show();
            this.Close();
        }
    }
}
