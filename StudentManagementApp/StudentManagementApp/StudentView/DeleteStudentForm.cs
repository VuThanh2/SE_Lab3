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

namespace StudentManagementApp.StudentView
{
    public partial class DeleteStudentForm : Form
    {
        private readonly StudentService _studentService;
        public DeleteStudentForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnDelete.Click += new System.EventHandler(btnUpdate_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var studentID = int.Parse(txtStudentID.Text);
            var result = _studentService.DeleteStudent(studentID);
            if (result != null)
            {
                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Failed to delete student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
