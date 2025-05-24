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
    public partial class UpdateDepartmentForm : Form
    {
        private readonly DepartmentService _departmentService;
        public UpdateDepartmentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _departmentService = new DepartmentService();
            btnFind.Click += new System.EventHandler(btnFind_Click);
            btnUpdate.Click += new System.EventHandler(btnUpdate_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentID.Text))
            {
                MessageBox.Show("Please enter a department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var departmentID = int.Parse(txtDepartmentID.Text);
            var department = _departmentService.GetDepartmentById(departmentID);
            if (department != null)
            {
                txtDepartmentName.Text = department.DepartmentName;
            }
            else
            {
                MessageBox.Show("Department not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            try
            {
                var department = new tblDepartment
                {
                    DepartmentID = int.Parse(txtDepartmentID.Text),
                    DepartmentName = txtDepartmentName.Text
                };
                var result = _departmentService.UpdateDepartment(department);
                if (result != null)
                {
                    MessageBox.Show("Department updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
