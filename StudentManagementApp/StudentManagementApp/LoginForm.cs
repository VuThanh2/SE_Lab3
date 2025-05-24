using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using DAL;
using BLL;

namespace StudentManagementApp
{
    public partial class LoginForm : Form
    {
        private readonly LogService _logService;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _logService = new LogService();
            btnLogin.Click += new EventHandler(btnLogin_Click);
            txtPassword.UseSystemPasswordChar = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var users = _logService.GetAllUsers(); // Assuming it returns a Dictionary<string, string> or List<User>

            bool isAuthenticated = users.Any(user => user.Username == username && user.Password == password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var mainForm = new MainForm(); // Assuming there's a main form
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTogglePassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Hide password
            }
        }
    }
}