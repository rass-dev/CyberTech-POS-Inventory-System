using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ComputerPartsPOS
{
    public partial class formEditAdmin : Form
    {
        private string adminID;
        private string adminName;
        private string adminUsername;
        private string adminPassword;
        private string adminEmail;
        private string adminPhoneNumber;
        private string adminRole;

        private formAdmin adminForm;

        public formEditAdmin(formAdmin parentForm, string adminID, string adminName, string adminUsername, string adminPassword, string adminEmail, string adminPhoneNumber, string adminRole)
        {
            InitializeComponent();
            this.adminForm = parentForm;
            this.adminID = adminID;
            this.adminName = adminName;
            this.adminUsername = adminUsername;
            this.adminPassword = adminPassword;
            this.adminEmail = adminEmail;
            this.adminPhoneNumber = adminPhoneNumber;
            this.adminRole = adminRole;
            SetAdminInfo(adminID, adminName, adminUsername, adminPassword, adminEmail, adminPhoneNumber, adminRole);
        }

        private void SetAdminInfo(string adminID, string adminName, string adminUsername, string adminPassword, string adminEmail, string adminPhoneNumber, string adminRole)
        {
            txtAdminName.Text = adminName;
            txtAdminUsername.Text = adminUsername;
            txtAdminEmail.Text = adminEmail;
            txtAdminPhoneNumber.Text = adminPhoneNumber;
            txtAdminPassword.Text = adminPassword;
            cmbAdminRole.SelectedItem = adminRole;

            this.adminID = adminID;
            this.adminName = adminName;
            this.adminUsername = adminUsername;
            this.adminPassword = adminPassword;
            this.adminEmail = adminEmail;
            this.adminPhoneNumber = adminPhoneNumber;
            this.adminRole = adminRole;
        }

        private void formEditAdmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            txtAdminName.KeyPress += txtAdminName_KeyPress;
            txtAdminPhoneNumber.KeyPress += txtAdminPhoneNumber_KeyPress;

            if (adminRole == "Main Admin")
            {
                cmbAdminRole.Enabled = false;
            }

                        if (adminID == "1")
            {
                cmbAdminRole.Items.Clear();
                cmbAdminRole.Items.Add("Main Admin");
                cmbAdminRole.SelectedIndex = 0;
            }
        }

        public event EventHandler AdminInfoUpdated;

        private void OnAdminInfoUpdated()
        {
            AdminInfoUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            string newAdminName = txtAdminName.Text.Trim();
            string newAdminUsername = txtAdminUsername.Text.Trim();
            string newEmail = txtAdminEmail.Text.Trim();
            string newPhoneNumber = txtAdminPhoneNumber.Text.Trim();
            string newPassword = txtAdminPassword.Text;
            string newAdminRole = cmbAdminRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newAdminName) || string.IsNullOrEmpty(newAdminUsername) ||
                string.IsNullOrEmpty(newEmail) || string.IsNullOrEmpty(newPhoneNumber) ||
                string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(newAdminRole))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(newAdminName, @"^[a-zA-Z0-9]{1,20}$"))
            {
                MessageBox.Show("Please enter a valid admin name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextAndFocus(txtAdminName);
                return;
            }

            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(newEmail, pattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextAndFocus(txtAdminEmail);
                return;
            }

            if (!Regex.IsMatch(newPhoneNumber, @"^0\d{10}$"))
            {
                MessageBox.Show("Please enter a valid phone number (starting with 0 and exactly 11 numbers).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextAndFocus(txtAdminPhoneNumber);
                return;
            }

            if (newPassword.Length < 8 || newPassword.Length > 20)
            {
                MessageBox.Show("Please enter a password between 8 and 20 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextAndFocus(txtAdminPassword);
                return;
            }

            string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE tbl_admin SET admin_name = @NewAdminName, admin_username = @NewAdminUsername, " +
                                   "admin_email = @NewEmail, admin_phone_number = @NewPhoneNumber, admin_password = @NewPassword, admin_role = @NewAdminRole " +
                                   "WHERE ID_Admin = @AdminID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewAdminName", newAdminName);
                        command.Parameters.AddWithValue("@NewAdminUsername", newAdminUsername);
                        command.Parameters.AddWithValue("@NewEmail", newEmail);
                        command.Parameters.AddWithValue("@NewPhoneNumber", newPhoneNumber);
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@NewAdminRole", newAdminRole);
                        command.Parameters.AddWithValue("@AdminID", adminID);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Admin information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UpdateAdminInfoRequested?.Invoke(adminID, newAdminName, newAdminUsername, newPassword, newEmail, newPhoneNumber, newAdminRole);

                            OnAdminInfoUpdated();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update admin information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearTextAndFocus(TextBox textBox)
        {
            textBox.Text = "";
            textBox.Focus();
        }

        private void btnClear_Admin_Click(object sender, EventArgs e)
        {
            txtAdminName.Text = "";
            txtAdminUsername.Text = "";
            txtAdminEmail.Text = "";
            txtAdminPhoneNumber.Text = "";
            txtAdminPassword.Text = "";
            cmbAdminRole.SelectedIndex = -1;
        }

        public delegate void UpdateAdminInfoHandler(string adminID, string newAdminName, string newAdminUsername, string newPassword, string newEmail, string newPhoneNumber, string newAdminRole);

        public event UpdateAdminInfoHandler UpdateAdminInfoRequested;

        private void txtAdminName_TextChanged(object sender, EventArgs e) { }

        private void txtAdminName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAdminEmail_TextChanged(object sender, EventArgs e) { }

        private void txtUserPassword_TextChanged(object sender, EventArgs e) { }

        private void txtAdminPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string adminPhoneNumber = txtAdminPhoneNumber.Text;
            adminPhoneNumber = new string(adminPhoneNumber.Where(char.IsDigit).ToArray());

            if (adminPhoneNumber.Length > 11)
            {
                MessageBox.Show("Please use a valid phone number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdminPhoneNumber.Text = "";
                return;
            }

            txtAdminPhoneNumber.Text = adminPhoneNumber;
        }

        private void txtAdminPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
