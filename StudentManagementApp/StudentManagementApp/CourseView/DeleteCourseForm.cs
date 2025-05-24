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
    public partial class DeleteCourseForm : Form
    {
        private readonly CourseService _courseService;
        public DeleteCourseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _courseService = new CourseService();
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var courseID = int.Parse(txtDeleteCourseID.Text);
            var result = _courseService.DeleteCourse(courseID);
            if (result != null)
            {
                MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to delete course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
