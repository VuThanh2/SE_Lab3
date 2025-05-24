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
    public partial class FindDepartmentForm : Form
    {
        private readonly DepartmentService _departmentService;
        public FindDepartmentForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _departmentService = new DepartmentService();
            btnFind.Click += new System.EventHandler(btnFind_Click);
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
