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
    public partial class AddDepartmentForm : Form
    {
        private readonly DepartmentService _departmentService;
        public AddDepartmentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _departmentService = new DepartmentService();
            btnAdd.Click += new System.EventHandler(btnAdd_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            try
                {
                var department = new tblDepartment
                {
                    DepartmentName = txtDepartmentName.Text
                };
                var result = _departmentService.AddDepartment(department);
                if (result != null)
                {
                    MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add department!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
