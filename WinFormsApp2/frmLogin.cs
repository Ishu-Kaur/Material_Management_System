using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        string connStr = "Data Source=LAPTOP-JL31KL2H\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
            textBoxPass.PasswordChar = '•';

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text.Trim();
            string password = textBoxPass.Text.Trim();


            // Check if both fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Try connecting to the database and validating the login credentials
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // SQL query to check if the user exists in the database
                    string query = "SELECT COUNT(*) FROM Login WHERE User_Name = @User_Name AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@User_Name", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the query and get the result
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount == 1)
                        {
                            // If a match is found, show success message and open frmBrand
                            MessageBox.Show("Login successful!");
                            this.Hide();  // Hide the current login form

                            // Open the Menu form
                            frmMenu menuForm = new frmMenu();
                            menuForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            // If no match, show error message
                            MessageBox.Show("Wrong username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display any error encountered while connecting to the database
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Confirm exit action
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Show the password
                textBoxPass.PasswordChar = '\0';  // No masking
            }
            else
            {
                // Hide the password
                textBoxPass.PasswordChar = '•';  // Bullet points
            }
        }

        private void Button_reset_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = string.Empty;
            textBoxPass.Text = string.Empty;

            // Optionally uncheck the 'Show Password' checkbox and hide the password
            checkBox1.Checked = false;
            textBoxPass.PasswordChar = '•';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
