using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    public partial class formAdmin : Form
    {
        private formAddAdmin addAdminForm;
        private formEditAdmin editAdminForm;

        public Dictionary<string, string> adminCredentials = new Dictionary<string, string>();

        SqlConnection connection = new SqlConnection("Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;");

        public formAdmin()
        {
            InitializeComponent();

            dataGridView_Admin.CellClick += dataGridView_Admin_CellClick;
            dataGridView_Admin_Staff.CellClick += dataGridView_Admin_Staff_CellClick;

            dataGridView_Admin_Staff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadAdminData();
            LoadAdminStaffData();

            dataGridView_Admin.Columns["ID_Admin"].HeaderText = "ID Admin";
            dataGridView_Admin.Columns["admin_name"].HeaderText = "Admin Name";
            dataGridView_Admin.Columns["admin_username"].HeaderText = "Username";
            dataGridView_Admin.Columns["admin_email"].HeaderText = "Admin Email";
            dataGridView_Admin.Columns["admin_phone_number"].HeaderText = "Phone Number";
            dataGridView_Admin.Columns["admin_role"].HeaderText = "Role";

            dataGridView_Admin.Columns["admin_password"].Visible = false;

            dataGridView_Admin.CellFormatting += dataGridView_Admin_CellFormatting;

            dataGridView_Admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_Admin.ColumnHeadersHeightSizeModeChanged += DataGridView_Admin_ColumnHeadersHeightSizeModeChanged;

                        dataGridView_Admin_Staff.Columns["ID_Admin"].HeaderText = "ID";
            dataGridView_Admin_Staff.Columns["admin_name"].HeaderText = "Name";
            dataGridView_Admin_Staff.Columns["admin_username"].HeaderText = "Username";
            dataGridView_Admin_Staff.Columns["admin_email"].HeaderText = "Email";
            dataGridView_Admin_Staff.Columns["admin_phone_number"].HeaderText = "Phone";
            dataGridView_Admin_Staff.Columns["admin_role"].HeaderText = "Role";

            dataGridView_Admin_Staff.Columns["admin_password"].Visible = false;

            dataGridView_Admin_Staff.CellFormatting += dataGridView_Admin_Staff_CellFormatting;

            dataGridView_Admin_Staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_Admin_Staff.ColumnHeadersHeightSizeModeChanged += DataGridView_Admin_Staff_ColumnHeadersHeightSizeModeChanged;
        }

        private void DataGridView_Admin_ColumnHeadersHeightSizeModeChanged(object sender, EventArgs e)
        {
            dataGridView_Admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void DataGridView_Admin_Staff_ColumnHeadersHeightSizeModeChanged(object sender, EventArgs e)
        {
            dataGridView_Admin_Staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        public void LoadAdminData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM tbl_admin WHERE admin_role = 'Main Admin' OR admin_role = 'Admin'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        if (row[col] != null && row[col] != DBNull.Value)
                        {
                            row[col] = row[col].ToString().TrimEnd();
                        }
                    }
                }

                dataGridView_Admin.DataSource = dataTable;
                dataGridView_Admin.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void LoadAdminStaffData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM tbl_admin WHERE admin_role = 'Cashier' OR admin_role = 'Inventory Staff'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        if (row[col] != null && row[col] != DBNull.Value)
                        {
                            row[col] = row[col].ToString().TrimEnd();
                        }
                    }
                }

                dataGridView_Admin_Staff.DataSource = dataTable;
                dataGridView_Admin_Staff.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (addAdminForm == null || addAdminForm.IsDisposed)
            {
                addAdminForm = new formAddAdmin(this);
                addAdminForm.FormClosed += AddAdminForm_FormClosed;
                addAdminForm.MdiParent = this.MdiParent;
                addAdminForm.Dock = DockStyle.Fill;
                addAdminForm.Show();
            }
            else
            {
                addAdminForm.Activate();
                LoadAdminData();
                LoadAdminStaffData();
            }
        }

        private void AddAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            addAdminForm = null;
            LoadAdminData();
            LoadAdminStaffData();
        }

        private void dataGridView_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                                dataGridView_Admin_Staff.ClearSelection();

                                dataGridView_Admin.ClearSelection();

                                dataGridView_Admin.RowsDefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Admin.RowsDefaultCellStyle.SelectionForeColor = Color.White;

                                dataGridView_Admin.Rows[e.RowIndex].Selected = true;

                                DataGridViewRow selectedRow = dataGridView_Admin.Rows[e.RowIndex];
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dataGridView_Admin_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                                dataGridView_Admin.ClearSelection();

                                dataGridView_Admin_Staff.ClearSelection();

                                dataGridView_Admin_Staff.RowsDefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Admin_Staff.RowsDefaultCellStyle.SelectionForeColor = Color.White;

                                dataGridView_Admin_Staff.Rows[e.RowIndex].Selected = true;

                                DataGridViewRow selectedRow = dataGridView_Admin_Staff.Rows[e.RowIndex];
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dataGridView_Admin_Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                                dataGridView_Admin_Staff.ClearSelection();

                                dataGridView_Admin_Staff.RowsDefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Admin_Staff.RowsDefaultCellStyle.SelectionForeColor = Color.White;

                                dataGridView_Admin_Staff.Rows[e.RowIndex].Selected = true;

                                DataGridViewRow selectedRow = dataGridView_Admin_Staff.Rows[e.RowIndex];
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dataGridView_Admin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_Admin.Columns[e.ColumnIndex].Name == "admin_password" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void dataGridView_Admin_Staff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_Admin_Staff.Columns[e.ColumnIndex].Name == "admin_password" && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;

            if (dataGridView_Admin_Staff.CurrentCell != null && dataGridView_Admin_Staff.SelectedRows.Count > 0)
            {
                row = dataGridView_Admin_Staff.SelectedRows[0];
            }
            else if (dataGridView_Admin.CurrentCell != null && dataGridView_Admin.SelectedRows.Count > 0)
            {
                row = dataGridView_Admin.SelectedRows[0];
            }

            if (row != null)
            {
                string adminID = row.Cells["ID_Admin"].Value?.ToString();
                string adminName = row.Cells["admin_name"].Value?.ToString();
                string adminUsername = row.Cells["admin_username"].Value?.ToString();
                string adminPhoneNumber = row.Cells["admin_phone_number"].Value?.ToString();
                string adminEmail = row.Cells["admin_email"].Value?.ToString();
                string adminPassword = row.Cells["admin_password"].Value?.ToString();
                string adminRole = row.Cells["admin_role"].Value?.ToString(); 
                editAdminForm = new formEditAdmin(this, adminID, adminName, adminUsername, adminPassword, adminEmail, adminPhoneNumber, adminRole);
                editAdminForm.FormClosed += EditAdminForm_FormClosed;
                editAdminForm.MdiParent = this.MdiParent;
                editAdminForm.Dock = DockStyle.Fill;
                editAdminForm.UpdateAdminInfoRequested += EditAdminForm_UpdateAdminInfoRequested;
                editAdminForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an admin to edit.");
            }
        }

        private void EditAdminForm_UpdateAdminInfoRequested(string adminID, string newAdminName, string newAdminUsername, string newPassword, string newEmail, string newPhoneNumber, string newRole)
        {
            UpdateAdminInfo(adminID, newAdminName, newAdminUsername, newPassword, newEmail, newPhoneNumber);
            LoadAdminData();
            LoadAdminStaffData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;

            if (dataGridView_Admin_Staff.CurrentCell != null && dataGridView_Admin_Staff.SelectedRows.Count > 0)
            {
                row = dataGridView_Admin_Staff.SelectedRows[0];
            }
            else if (dataGridView_Admin.CurrentCell != null && dataGridView_Admin.SelectedRows.Count > 0)
            {
                row = dataGridView_Admin.SelectedRows[0];
            }

            if (row != null)
            {
                string adminID = row.Cells["ID_Admin"].Value?.ToString();

                if (adminID == "1")
                {
                    MessageBox.Show("The Main Admin cannot be deleted.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this admin?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection("Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;"))
                        {
                            connection.Open();
                            string query = "DELETE FROM tbl_admin WHERE ID_Admin = @AdminID";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@AdminID", adminID);
                            command.ExecuteNonQuery();
                        }

                        if (row.DataGridView == dataGridView_Admin)
                        {
                            dataGridView_Admin.Rows.RemoveAt(row.Index);
                        }
                        else if (row.DataGridView == dataGridView_Admin_Staff)
                        {
                            dataGridView_Admin_Staff.Rows.RemoveAt(row.Index);
                        }

                        LoadAdminData();
                        LoadAdminStaffData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting admin: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an admin to delete.");
            }
        }


        private void EditAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            editAdminForm = null;
        }

        public void UpdateAdminInfo(string adminID, string newAdminName, string newAdminUsername, string newPassword, string newEmail, string newPhoneNumber)
        {
            string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE tbl_admin SET admin_name = @NewAdminName, admin_username = @NewAdminUsername, admin_password = @NewPassword, admin_email = @NewEmail, admin_phone_number = @NewPhoneNumber WHERE ID_Admin = @AdminID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewAdminName", newAdminName);
                cmd.Parameters.AddWithValue("@NewAdminUsername", newAdminUsername);
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@NewEmail", newEmail);
                cmd.Parameters.AddWithValue("@NewPhoneNumber", newPhoneNumber);
                cmd.Parameters.AddWithValue("@AdminID", adminID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

