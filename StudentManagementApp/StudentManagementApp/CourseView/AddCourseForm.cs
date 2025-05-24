using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace StudentManagementApp
{
    public partial class AddCourseForm : Form
    {
        private readonly CourseService _courseService;
        public AddCourseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _courseService = new CourseService();
            btnAdd.Click += new System.EventHandler(btnAdd_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            LoadDepartments();
            LoadInstructors();
        }

        private void LoadDepartments()
        {
            var departments = _courseService.GetAllDepartments();
            if (departments != null && departments.Any())
            {
                txtDepartmentName.DataSource = departments;
                txtDepartmentName.DisplayMember = "DepartmentName";
                txtDepartmentName.ValueMember = "DepartmentID";
                txtDepartmentName.SelectedIndex = -1;
            }
        }

        private void LoadInstructors()
        {
            var instructors = _courseService.GetAllInstructors();
            if (instructors != null && instructors.Any())
            {
                txtInstructorName.DataSource = instructors;
                txtInstructorName.DisplayMember = "InstructorName";
                txtInstructorName.ValueMember = "InstructorID";
                txtInstructorName.SelectedIndex = -1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                var course = new tblCourses
                {
                    CourseName = txtCourseName.Text,
                    Credits = int.Parse(txtCredits.Text),
                    DepartmentID = (int)txtDepartmentName.SelectedValue,
                    InstructorID = (int)txtInstructorName.SelectedValue
                };

                var result = _courseService.AddCourse(course);
                if (result != null)
                {
                    MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();

                }
                else
                {
                    MessageBox.Show("Failed to add course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtCourseName.Clear();
            txtCredits.Clear();
            txtDepartmentName.SelectedIndex = -1;
            txtInstructorName.SelectedIndex = -1;
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text) ||
                string.IsNullOrWhiteSpace(txtCredits.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtCredits.Text, out _))
            {
                MessageBox.Show("Credits must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInstructorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
