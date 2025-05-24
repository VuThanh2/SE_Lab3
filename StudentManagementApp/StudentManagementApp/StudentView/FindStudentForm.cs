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
    public partial class FindStudentForm : Form
    {
        public readonly StudentService _studentService;
        public FindStudentForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnFind.Click += btnFind_Click;
            this.btnCancel.Click += btnCancel_Click;
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
