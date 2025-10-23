using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ResidentManagementSystem
{
    public partial class frmDashboard : Form
    {
        private readonly string connectionString = "Server=localhost;Database=resident_database;User ID=root;Password=;";
        private int selectedResidentId = 0;

        public frmDashboard(string loggedInUsername)
        {
            InitializeComponent();
            this.Text = "Resident Management System - Welcome, " + loggedInUsername + "!";
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, full_name, nic, dob, gender, address, phone, email, occupation FROM residents";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvResidents.DataSource = dataTable;

                    if (dgvResidents.Columns.Contains("id"))
                    {
                        dgvResidents.Columns["id"].Visible = false;
                    }

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtNic.Clear();
            dtpDob.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtOccupation.Clear();
            txtSearch.Clear();
            selectedResidentId = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO residents (full_name, dob, nic, address, phone, email, occupation, gender) VALUES (@fullName, @dob, @nic, @address, @phone, @email, @occupation, @gender)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fullName", txtName.Text);
                    command.Parameters.AddWithValue("@dob", dtpDob.Value);
                    command.Parameters.AddWithValue("@nic", txtNic.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                    command.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Resident added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (MySqlException mx)
            {
                if (mx.Number == 1062)
                {
                    MessageBox.Show("A resident with this NIC already exists.", "Duplicate NIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + mx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvResidents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvResidents.Rows[e.RowIndex];
                selectedResidentId = Convert.ToInt32(row.Cells["id"].Value);
                txtName.Text = row.Cells["full_name"].Value.ToString();
                txtNic.Text = row.Cells["nic"].Value.ToString();
                dtpDob.Value = Convert.ToDateTime(row.Cells["dob"].Value);
                cmbGender.SelectedItem = row.Cells["gender"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtOccupation.Text = row.Cells["occupation"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedResidentId == 0)
            {
                MessageBox.Show("Please select a resident from the list to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE residents SET full_name = @fullName, dob = @dob, nic = @nic, address = @address, phone = @phone, email = @email, occupation = @occupation, gender = @gender WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fullName", txtName.Text);
                    command.Parameters.AddWithValue("@dob", dtpDob.Value);
                    command.Parameters.AddWithValue("@nic", txtNic.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@email", txtEmail.Text);
                    command.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                    command.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@id", selectedResidentId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Resident details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedResidentId == 0)
            {
                MessageBox.Show("Please select a resident from the list to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this resident?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM residents WHERE id = @id";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", selectedResidentId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Resident deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadData();
                return;
            }
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, full_name, nic, dob, gender, address, phone, email, occupation FROM residents WHERE full_name LIKE @term OR nic LIKE @term OR address LIKE @term";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@term", "%" + searchTerm + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvResidents.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ***** THIS IS THE CORRECT VALIDATION METHOD *****
        private bool ValidateInputs()
        {
            // 1. Required Fields Check (Phone number is now optional)
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtNic.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields: Full Name, NIC, Address, and Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. NIC Format Check
            string nic = txtNic.Text.ToUpper();
            bool isValidNic = false;
            if (nic.Length == 12 && nic.All(char.IsDigit))
            {
                isValidNic = true;
            }
            else if (nic.Length == 10)
            {
                string firstNine = nic.Substring(0, 9);
                char lastChar = nic[9];
                if (firstNine.All(char.IsDigit) && (lastChar == 'V' || lastChar == 'X'))
                {
                    isValidNic = true;
                }
            }
            if (!isValidNic)
            {
                MessageBox.Show("Invalid NIC format. Please enter a 12-digit number OR a 9-digit number followed by 'V' or 'X'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Phone Number Format Check (Only if a phone number is entered)
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Invalid Phone Number format. Please enter a 10-digit number or leave it empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // 4. Email Format Check (Only if an email is entered)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".")))
            {
                MessageBox.Show("Invalid Email format. Please enter a valid email address or leave it empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed.
        }


        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}