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

namespace StudentManagementApp.DepartmentView
{
    public partial class DeleteDepartmentForm : Form
    {
        private readonly DepartmentService _departmentService;
        public DeleteDepartmentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _departmentService = new DepartmentService();
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeleteDepartmentID.Text))
            {
                MessageBox.Show("Please enter a department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var departmentId = int.Parse(txtDeleteDepartmentID.Text);
            var result = _departmentService.DeleteDepartmentById(departmentId);
            if (result != null)
            {
                MessageBox.Show("Department deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to delete department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
