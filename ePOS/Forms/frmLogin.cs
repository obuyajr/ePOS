using ePOS.Forms;
using ePOS.modules;
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

namespace ePOS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            try
            {
                // Call the static method from sysPublic class

                SqlConnection connection = sysPublic.getDatabaseConnection();




                // Create SQL command to check if user exists

                string query = "SELECT COUNT(1) FROM users WHERE username=@username AND password=@password";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", username);

                command.Parameters.AddWithValue("@password", password);


                // Execute the command
                int count = (int)command.ExecuteScalar();

                // Check if user exists
                if (count == 1)
                {

                    sysPublic.loggedInUserName = username;

                    MessageBox.Show("Login successful!");
                    new frmMainMenu().Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                    txtPassword.Clear();

                    Console.Beep();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

            }
        }
    }
}
