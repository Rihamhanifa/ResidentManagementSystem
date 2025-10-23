using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Required package to communicate with MySQL

namespace ResidentManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Connection String for the database.
            // Password is empty because the default XAMPP MySQL user 'root' has no password.
            string connectionString = "Server=localhost;Database=resident_database;User ID=root;Password=;";

            // 2. Get the username and password from the textboxes.
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // 3. Check if the username or password fields are empty.
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop the code execution here.
            }

            // 4. Create a new connection to the MySQL database.
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // 5. Open the connection.
                connection.Open();

                // 6. SQL query to check if a user with the given username and password exists.
                string query = "SELECT COUNT(*) FROM users WHERE Username = @user AND Password = @pass";

                // 7. Prepare the SQL command to be executed.
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@pass", password);

                // 8. Execute the command and get the result.
                int userCount = Convert.ToInt32(command.ExecuteScalar());

                // 9. If one user is found (userCount == 1), login is successful.
                if (userCount == 1)
                {
                    // ***** THIS IS THE KEY CHANGE *****
                    // Create an instance of the dashboard form, passing the current user's name.
                    frmDashboard dashboard = new frmDashboard(username);

                    this.Hide();      // Hide the current login form.
                    dashboard.Show(); // Show the dashboard form.
                }
                else
                {
                    // If no user is found, login fails.
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // If any error occurs while connecting to the database, show an error message.
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 10. This block will always run, ensuring the connection is closed.
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}