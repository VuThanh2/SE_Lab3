using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DAL;
using BLL;
using StudentManagementApp.DepartmentView;

namespace StudentManagementApp
{
    public partial class DepartmentsForm : Form
    {
        private readonly DepartmentService _departmentService;

        public DepartmentsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _departmentService = new DepartmentService();
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            DepartmentForm_Load();
        }

        private void DepartmentForm_Load()
        {
            LoadData();
        }

        private void LoadData()
        {
            var departments = _departmentService.GetAllDepartments();

            if (departments == null || !departments.Any())
            {
                MessageBox.Show("No departments found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("txtDepartmentID", typeof(int));
            table.Columns.Add("txtDepartmentName", typeof(string));

            foreach (var department in departments)
            {
                table.Rows.Add(
                    department.DepartmentID,
                    department.DepartmentName
                );
            }

            // Bind the DataTable to the existing DataGridView
            departmentGridView.DataSource = table;

            //Ensure the columns match the predefined ones
            departmentGridView.Columns["txtDepartmentID"].DataPropertyName = "txtDepartmentID";
            departmentGridView.Columns["txtDepartmentName"].DataPropertyName = "txtDepartmentName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
            addDepartmentForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDepartmentForm updateDepartmentForm = new UpdateDepartmentForm();
            updateDepartmentForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDepartmentForm deleteDepartmentForm = new DeleteDepartmentForm();
            deleteDepartmentForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindDepartmentForm findDepartmentForm = new FindDepartmentForm();
            findDepartmentForm.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}