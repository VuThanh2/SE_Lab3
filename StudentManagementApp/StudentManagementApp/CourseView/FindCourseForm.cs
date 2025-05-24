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
using Microsoft.VisualBasic.Devices;

namespace StudentManagementApp
{
    public partial class FindCourseForm : Form
    {
        private readonly CourseService _courseService;
        public FindCourseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _courseService = new CourseService();
            btnFind.Click += new System.EventHandler(tbnFind_Click);
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
                courseFindGridView.DataSource = table;

                // Ensure the columns match the predefined ones
                courseFindGridView.Columns["txtCourseID"].DataPropertyName = "txtCourseID";
                courseFindGridView.Columns["txtCourseName"].DataPropertyName = "txtCourseName";
                courseFindGridView.Columns["txtCredits"].DataPropertyName = "txtCredits";
                courseFindGridView.Columns["txtDepartmentID"].DataPropertyName = "txtDepartmentID";
                courseFindGridView.Columns["txtDepartmentName"].DataPropertyName = "txtDepartmentName";
                courseFindGridView.Columns["txtInstructorID"].DataPropertyName = "txtInstructorID";
                courseFindGridView.Columns["txtInstructorName"].DataPropertyName = "txtInstructorName";
            }
            else
            {
                MessageBox.Show("Course not found!");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
