using BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DAL;
using BLL;

namespace StudentManagementApp
{
    public partial class InstructorsForm : Form
    {
        private readonly InstructorService _instructorService;

        public InstructorsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _instructorService = new InstructorService();
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            InstructorsForm_Load();
        }

        private void InstructorsForm_Load()
        {
            LoadData();
        }

        private void LoadData()
        {
            var instructors = _instructorService.GetAllInstructors();

            if (instructors == null || !instructors.Any())
            {
                MessageBox.Show("No instructor found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("txtInstructorID", typeof(int));
            table.Columns.Add("txtInstructorName", typeof(string));
            table.Columns.Add("txtDepartmentID", typeof(int));
            table.Columns.Add("txtDepartmentName", typeof(string));

            foreach (var instructor in instructors)
            {
                table.Rows.Add(
                    instructor.InstructorID,
                    instructor.InstructorName,
                    instructor.DepartmentID,
                    instructor.tblDepartment?.DepartmentName
                );
            }

            // Bind the DataTable to the existing DataGridView
            instructorGridView.DataSource = table;

            //Ensure the columns match the predefined ones
            instructorGridView.Columns["txtInstructorID"].DataPropertyName = "txtInstructorID";
            instructorGridView.Columns["txtInstructorName"].DataPropertyName = "txtInstructorName";
            instructorGridView.Columns["txtDepartmentID"].DataPropertyName = "txtDepartmentID";
            instructorGridView.Columns["txtDepartmentName"].DataPropertyName = "txtDepartmentName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}