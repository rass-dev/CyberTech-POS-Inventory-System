using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    public partial class formAddSupplier : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_admin_1;Password=12345678admin;");
        SqlDataAdapter adapter;
        DataTable table;

        public formAddSupplier()
        {
            InitializeComponent();
            this.dataGridView_Supplier.ReadOnly = true;
            dataGridView_Supplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Supplier.CellClick += dataGridView_Supplier_CellClick;

            txtSupplierContactNumber.KeyPress += TxtSupplierContactNumber_KeyPress;
        }

        private void formAddSupplier_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();

            dataGridView_Supplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridView_Supplier.ColumnHeadersHeightSizeModeChanged += DataGridView_Supplier_ColumnHeadersHeightSizeModeChanged;
        }

        private void DataGridView_Supplier_ColumnHeadersHeightSizeModeChanged(object sender, EventArgs e)
        {
            dataGridView_Supplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void TxtSupplierContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadData()
        {
            adapter = new SqlDataAdapter("SELECT Supplier_ID, Supplier_Name, Contact_Number, Supplier_Address, Brand_Name, Note FROM tbl_supplier", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_Supplier.DataSource = table;

                        dataGridView_Supplier.Columns["Supplier_ID"].HeaderText = "ID";
            dataGridView_Supplier.Columns["Supplier_Name"].HeaderText = "Supplier Name";
            dataGridView_Supplier.Columns["Contact_Number"].HeaderText = "Contact Number";
            dataGridView_Supplier.Columns["Supplier_Address"].HeaderText = "Address";
            dataGridView_Supplier.Columns["Brand_Name"].HeaderText = "Brand Name";
            dataGridView_Supplier.Columns["Note"].HeaderText = "Note";

                        for (int i = 0; i < dataGridView_Supplier.Columns.Count; i++)
            {
                dataGridView_Supplier.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

                        dataGridView_Supplier.Columns["Supplier_Address"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView_Supplier.Columns["Note"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                        dataGridView_Supplier.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AreFieldsFilled())
            {
                                string phoneNumber = txtSupplierContactNumber.Text;
                if (!Regex.IsMatch(phoneNumber, @"^0\d{10}$"))
                {
                    MessageBox.Show("Please enter a valid phone number starting with 0 and having 11 digits.");
                    txtSupplierContactNumber.Clear();
                    return;
                }

                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_supplier (Supplier_Name, Contact_Number, Supplier_Address, Brand_Name, Note) VALUES (@name, @contact, @address, @brand, @note)", connection))
                {
                    cmd.Parameters.AddWithValue("@name", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@contact", txtSupplierContactNumber.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@brand", txtBrandName.Text);
                    cmd.Parameters.AddWithValue("@note", txtNote.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Supplier.CurrentCell != null)
            {
                int rowIndex = dataGridView_Supplier.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridView_Supplier.Rows.Count)
                {
                    DataGridViewRow row = dataGridView_Supplier.Rows[rowIndex];
                    txtSupplierName.Text = row.Cells["Supplier_Name"].Value.ToString();
                    txtSupplierContactNumber.Text = row.Cells["Contact_Number"].Value.ToString();
                    txtAddress.Text = row.Cells["Supplier_Address"].Value.ToString();
                    txtBrandName.Text = row.Cells["Brand_Name"].Value.ToString();
                    txtNote.Text = row.Cells["Note"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Supplier.CurrentCell != null)
            {
                int rowIndex = dataGridView_Supplier.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridView_Supplier.Rows.Count)
                {
                    DataGridViewRow row = dataGridView_Supplier.Rows[rowIndex];
                    int supplierID = Convert.ToInt32(row.Cells["Supplier_ID"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM tbl_supplier WHERE Supplier_ID=@id", connection))
                        {
                            cmd.Parameters.AddWithValue("@id", supplierID);

                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        LoadData();
                        ClearFields();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView_Supplier.CurrentCell != null)
            {
                int rowIndex = dataGridView_Supplier.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridView_Supplier.Rows.Count)
                {
                    DataGridViewRow row = dataGridView_Supplier.Rows[rowIndex];
                    int supplierID = Convert.ToInt32(row.Cells["Supplier_ID"].Value);

                    if (AreFieldsFilled())
                    {
                                                string phoneNumber = txtSupplierContactNumber.Text;
                        if (!Regex.IsMatch(phoneNumber, @"^0\d{10}$"))
                        {
                            MessageBox.Show("Please enter a valid phone number starting with 0 and having 11 digits.");
                            txtSupplierContactNumber.Clear();
                            return;
                        }

                        DialogResult result = MessageBox.Show("Are you sure you want to update this supplier?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE tbl_supplier SET Supplier_Name=@name, Contact_Number=@contact, Supplier_Address=@address, Brand_Name=@brand, Note=@note WHERE Supplier_ID=@id", connection))
                            {
                                cmd.Parameters.AddWithValue("@id", supplierID);
                                cmd.Parameters.AddWithValue("@name", txtSupplierName.Text);
                                cmd.Parameters.AddWithValue("@contact", txtSupplierContactNumber.Text);
                                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                                cmd.Parameters.AddWithValue("@brand", txtBrandName.Text);
                                cmd.Parameters.AddWithValue("@note", txtNote.Text);

                                connection.Open();
                                cmd.ExecuteNonQuery();
                                connection.Close();
                            }

                            LoadData();
                            ClearFields();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill all fields.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private bool AreFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(txtSupplierName.Text)
                && !string.IsNullOrWhiteSpace(txtSupplierContactNumber.Text)
                && !string.IsNullOrWhiteSpace(txtAddress.Text)
                && !string.IsNullOrWhiteSpace(txtBrandName.Text)
                && !string.IsNullOrWhiteSpace(txtNote.Text);
        }

        private void ClearFields()
        {
            txtSupplierName.Clear();
            txtSupplierContactNumber.Clear();
            txtAddress.Clear();
            txtBrandName.Clear();
            txtNote.Clear();
        }



        private void dataGridView_Supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)             {
                                dataGridView_Supplier.ClearSelection();

                                dataGridView_Supplier.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Supplier.DefaultCellStyle.SelectionForeColor = Color.White;

                                dataGridView_Supplier.Rows[e.RowIndex].Selected = true;

                                DataGridViewRow selectedRow = dataGridView_Supplier.Rows[e.RowIndex];
                string supplierName = selectedRow.Cells["Supplier_Name"].Value.ToString();

                            }
        }

        private void dataGridView_Supplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplierContactNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
