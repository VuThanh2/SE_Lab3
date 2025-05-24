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
    public partial class UpdateCourseForm : Form
    {
        private readonly CourseService _courseService;
        public UpdateCourseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _courseService = new CourseService();
            btnFind.Click += new System.EventHandler(tbnFind_Click);
            btnUpdate.Click += new System.EventHandler(btnUpdate_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
        }
        private void tbnFind_Click(object sender, EventArgs e)
        {
            var course = _courseService.GetCourseById(int.Parse(txtFindCourseID.Text));
            if (course != null)
            {
                DataTable table = new DataTable();
                table.Columns.Add("txtCourseID", typeof(int));
                table.Columns.Add("txtCourseName", typeof(string));
                table.Columns.Add("txtCredits", typeof(int));
                table.Columns.Add("txtDepartmentID", typeof(string));
                table.Columns.Add("txtDepartmentName", typeof(string));
                table.Columns.Add("txtInstructorID", typeof(string));
                table.Columns.Add("txtInstructorName", typeof(string));

                table.Rows.Add(
                course.CourseID,
                course.CourseName,
                course.Credits,
                course.DepartmentID,
                course.tblDepartment?.DepartmentName ?? "N/A",
                course.InstructorID,
                course.tblInstructor?.InstructorName ?? "N/A"
            );
                // Bind the DataTable to the existing DataGridView
                courseUpdateGridView.DataSource = table;

                // Ensure the columns match the predefined ones
                courseUpdateGridView.Columns["txtCourseID"].DataPropertyName = "txtCourseID";
                courseUpdateGridView.Columns["txtCourseName"].DataPropertyName = "txtCourseName";
                courseUpdateGridView.Columns["txtCredits"].DataPropertyName = "txtCredits";
                courseUpdateGridView.Columns["txtDepartmentID"].DataPropertyName = "txtDepartmentID";
                courseUpdateGridView.Columns["txtDepartmentName"].DataPropertyName = "txtDepartmentName";
                courseUpdateGridView.Columns["txtInstructorID"].DataPropertyName = "txtInstructorID";
                courseUpdateGridView.Columns["txtInstructorName"].DataPropertyName = "txtInstructorName";
            }
            else
            {
                MessageBox.Show("Course not found!");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (courseUpdateGridView.SelectedRows.Count > 0)
            {
                // Retrieve the selected row
                DataGridViewRow selectedRow = courseUpdateGridView.SelectedRows[0];

                // Extract data from the selected row
                int courseId = Convert.ToInt32(selectedRow.Cells["txtCourseID"].Value);
                string courseName = selectedRow.Cells["txtCourseName"].Value.ToString();
                int credits = Convert.ToInt32(selectedRow.Cells["txtCredits"].Value);
                string departmentName = selectedRow.Cells["txtDepartmentName"].Value.ToString();
                string instructorName = selectedRow.Cells["txtInstructorName"].Value.ToString();

                // Create a new course object with the updated data
                tblCourses updatedCourse = new tblCourses
                {
                    CourseID = courseId,
                    CourseName = courseName,
                    Credits = credits
                };

                // Update the course in the database
                try
                {
                    _courseService.UpdateCourse(updatedCourse, instructorName, departmentName);
                    MessageBox.Show("Course updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating course: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a course to update.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
