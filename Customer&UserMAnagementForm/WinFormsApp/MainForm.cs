using BLL;
using DAL;
using System.Data;
using System.Runtime.CompilerServices;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;
        private readonly CustomerService _customerService;
        public MainForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _customerService = new CustomerService();
            UserForm_Load();
            CustomerForm_Load();
        }
        private void UserForm_Load()
        {
            var users = _userService.GetAllUsers();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Email", typeof(string));

            foreach (var user in users)
            {
                table.Rows.Add(user.UserId, user.Name, user.Email);
            }

            userGridView.DataSource = table;
        }
        private void btnGetAllUser_Click(object sender, EventArgs e)
        {
            UserForm_Load();
        }

        private void btnGetAllCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm_Load();
        }
        private void CustomerForm_Load()
        {
            var customers = _customerService.GetAllCustomers();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Email", typeof(string));
            foreach (var customer in customers)
            {
                table.Rows.Add(customer.Id, customer.Name, customer.Email);
            }
            customerGridView.DataSource = table;
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm();
            addNewCustomerForm.Show();
        }
    }
}
