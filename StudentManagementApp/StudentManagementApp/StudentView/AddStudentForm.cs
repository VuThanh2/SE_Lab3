using System;
using System.Windows.Forms;
using BLL;
using DAL;

namespace StudentManagementApp
{
    public partial class AddStudentForm : Form
    {
        private readonly StudentService _studentService;

        public AddStudentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _studentService = new StudentService();
            btnAdd.Click += new System.EventHandler(BtnAdd_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                var student = new tblStudents
                {
                    StudentName = txtStudentName.Text,
                    DateOfBirth = DateTime.Parse(txtDateOfBirth.Text),
                    City = txtCity.Text,
                    Age = int.Parse(txtAge.Text),
                    YearOfEnroll = int.Parse(txtYearOfEnroll.Text),
                    Major = txtMajor.Text,
                    GPA = decimal.Parse(txtGPA.Text)
                };

                var result = _studentService.AddStudent(student);
                if (result != null)
                {
                    MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
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
    }
}
