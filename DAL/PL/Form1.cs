using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BLL;
using DAL;

namespace PL
{
    public partial class Form1 : Form
    {
        private readonly UserService _userService;
        private readonly CustomerService _customerService;
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            //_userService = new UserService();
            //_customerService = new CustomerService();
            connectionString =
            ConfigurationManager.ConnectionStrings["Lab02ConnectionString"].ConnectionString;
        }

        //private void UserForm_Load()
        //{
        //    var users = _userService.GetAllUser();
        //    DataTable table = new DataTable();
        //    table.Columns.Add("UserId", typeof(int));
        //    table.Columns.Add("Name", typeof(string));
        //    table.Columns.Add("Email", typeof(string));

        //    foreach (var user in users)
        //    {
        //        table.Rows.Add(user.UserId, user.Name, user.Email);
        //    }

        //    dataGridView1.DataSource = table;
        //}
        private void UserForm_Load()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            //var users = _userService.GetAllUsers();
            //DataTable table = new DataTable();
            //table.Columns.Add("Id", typeof(int));
            //table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Email", typeof(string));

            //foreach (var user in users)
            //{
            //    table.Rows.Add(user.UserId, user.Name, user.Email);
            //}

            //dataGridView1.DataSource = table;
        }

        private void CustomerForm_Load()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

            //var customers = _customerService.GetAllCustomers();
            //DataTable table = new DataTable();
            //table.Columns.Add("Id", typeof(int));
            //table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Email", typeof(string));

            //foreach (var customer in customers)
            //{
            //    table.Rows.Add(customer.Id, customer.Name, customer.Email);
            //}

            //dataGridView1.DataSource = table;
        }

        private void btnGetUser_Click(object sender, EventArgs e)
        {
            UserForm_Load();
        }

        private void btnGetAllCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm_Load();
        }
    }
}
