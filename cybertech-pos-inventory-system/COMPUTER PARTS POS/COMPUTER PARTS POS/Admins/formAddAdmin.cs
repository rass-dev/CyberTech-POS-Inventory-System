using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    public partial class formAddAdmin : Form
    {
        private formAdmin adminForm;

        public formAddAdmin(formAdmin adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void formAddAdmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            txtAdminName.KeyPress += txtAdminName_KeyPress;

            txtAdminPhoneNumber.KeyPress += txtAdminPhoneNumber_KeyPress;
        }

        private void txtAdminName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            string adminName = txtAdminName.Text.Trim();
            string adminUsername = txtAdminUserName.Text.Trim();
            string adminEmail = txtAdminEmail.Text.Trim();
            string adminPhoneNumber = txtAdminPhoneNumber.Text.Trim();
            string adminPassword = txtAdminPassword.Text;

            if (string.IsNullOrEmpty(adminName) || string.IsNullOrEmpty(adminUsername) ||
                string.IsNullOrEmpty(adminEmail) || string.IsNullOrEmpty(adminPhoneNumber) ||
                string.IsNullOrEmpty(adminPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(adminName, @"^[a-zA-Z0-9]{1,20}$"))
            {
                MessageBox.Show("Please enter a valid admin name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextAndFocus(txtAdminName);
                return;
            }

            if (!Regex.IsMatch(adminPhoneNumber, @"^0\d{10}$"))
            {
                MessageBox.Show("Please enter a valid phone number (starting with 0 and exactly 11 numbers).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextAndFocus(txtAdminPhoneNumber);
                return;
            }

            if (!IsValidEmail(adminEmail))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextAndFocus(txtAdminEmail);
                return;
            }

            if (adminPassword.Length < 8 || adminPassword.Length > 20)
            {
                MessageBox.Show("Please enter a password between 8 and 20 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextAndFocus(txtAdminPassword);
                return;
            }

            string selectedRole = cmbRole.SelectedItem.ToString();

            string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO tbl_admin (admin_username, admin_name, admin_email, admin_phone_number, admin_password, admin_role) " +
                               "VALUES (@AdminUsername, @AdminName, @AdminEmail, @AdminPhoneNumber, @AdminPassword, @AdminRole)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminUsername", adminUsername);
                    command.Parameters.AddWithValue("@AdminName", adminName);
                    command.Parameters.AddWithValue("@AdminEmail", adminEmail);
                    command.Parameters.AddWithValue("@AdminPhoneNumber", adminPhoneNumber);
                    command.Parameters.AddWithValue("@AdminPassword", adminPassword);
                    command.Parameters.AddWithValue("@AdminRole", selectedRole);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Admin added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearInputFields();

                            adminForm.LoadAdminData();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearTextAndFocus(TextBox textBox)
        {
            textBox.Text = "";
            textBox.Focus();
        }

        private void ClearInputFields()
        {
            txtAdminName.Text = "";
            txtAdminUserName.Text = "";
            txtAdminEmail.Text = "";
            txtAdminPhoneNumber.Text = "";
            txtAdminPassword.Text = "";
            txtAdminName.Focus();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnClear_Admin_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
