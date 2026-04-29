using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    public partial class formAddProduct : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;");
        SqlDataAdapter adapter;
        DataTable table;

        public formAddProduct()
        {
            InitializeComponent();
            dataGridView_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Product.ReadOnly = true;
            dataGridView_Product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Product.CellClick += dataGridView_Product_CellClick;

            dataGridView_Product.DataBindingComplete += dataGridView_Product_DataBindingComplete;
        }

        private void dataGridView_Product_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetWrapMode();
        }

        private void SetWrapMode()
        {
                        foreach (DataGridViewColumn column in dataGridView_Product.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                                if (column.Name == "Product_Name")
                {
                    column.Width += 8;
                }
            }

                        dataGridView_Product.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }


        private void SalesHistoryuterParts_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
            LoadCategories();
            LoadSuppliers();


            this.txtSupplyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplyPrice_KeyPress);
            this.txtSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellPrice_KeyPress);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);

            dataGridView_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridView_Product.ColumnHeadersHeightSizeModeChanged += DataGridView_Product_ColumnHeadersHeightSizeModeChanged;
        }

        private void DataGridView_Product_ColumnHeadersHeightSizeModeChanged(object sender, EventArgs e)
        {
            dataGridView_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

    private void txtSupplyPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

                        if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

                        if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadData()
        {
                        LoadCategories();
            LoadSuppliers();

                        adapter = new SqlDataAdapter("SELECT Product_ID, Product_Name, Product_Location, Category, Supplier_Price, Sell_Price, Quantity, Brand_Name FROM tbl_product", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_Product.DataSource = table;

                        dataGridView_Product.Columns["Product_ID"].HeaderText = "ID";
            dataGridView_Product.Columns["Product_Name"].HeaderText = "Name";
            dataGridView_Product.Columns["Quantity"].HeaderText = "Quantity";
            dataGridView_Product.Columns["Brand_Name"].HeaderText = "Brand Name";
            dataGridView_Product.Columns["Category"].HeaderText = "Category";
            dataGridView_Product.Columns["Supplier_Price"].HeaderText = "Supplier Price";
            dataGridView_Product.Columns["Sell_Price"].HeaderText = "Sell Price";
            dataGridView_Product.Columns["Product_Location"].HeaderText = "Location";

                        dataGridView_Product.Columns["Product_Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView_Product.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                        dataGridView_Product.ClearSelection();
        }

        private void LoadCategories()
        {
                        cmbCategory.Items.Clear();

                        string query = "SELECT Category_Name FROM tbl_category";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                                while (reader.Read())
                {
                    cmbCategory.Items.Add(reader["Category_Name"].ToString());
                }

                                reader.Close();
                connection.Close();
            }
        }

        private void LoadSuppliers()
        {
                        cmbBrandName.Items.Clear();

                        string query = "SELECT Brand_Name FROM tbl_supplier";

                        using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                                while (reader.Read())
                {
                    cmbBrandName.Items.Add(reader["Brand_Name"].ToString());
                }

                                reader.Close();
                connection.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                        if (IsAddFieldsFilled())
            {
                                string formattedSellPrice = string.Format("{0:0.00}", Convert.ToDouble(txtSellPrice.Text));
                string formattedSupplierPrice = string.Format("{0:0.00}", Convert.ToDouble(txtSupplyPrice.Text));

                                if (int.TryParse(txtQuantity.Text, out int quantity))
                {
                                        using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_product (Product_Name, Product_Location, Category, Supplier_Price, Sell_Price, Quantity, Brand_Name) VALUES (@name, @location, @category, @supplierPrice, @sellPrice, @quantity, @brandName)", connection))
                    {
                        cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@location", txtProductLocation.Text);
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@supplierPrice", formattedSupplierPrice);
                        cmd.Parameters.AddWithValue("@sellPrice", formattedSellPrice);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@brandName", cmbBrandName.SelectedItem.ToString()); 
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    LoadData();
                    LoadCategories();
                    LoadSuppliers();
                    ClearFields();

                }
                else
                {
                    MessageBox.Show("Please enter a valid whole number for Quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields and select a category before adding a product.");
            }
        }



        private bool IsAddFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(txtProductName.Text) &&
                   !string.IsNullOrWhiteSpace(txtProductLocation.Text) &&
                   cmbCategory.SelectedIndex != -1 &&
                   !string.IsNullOrWhiteSpace(txtSupplyPrice.Text) &&
                   !string.IsNullOrWhiteSpace(txtSellPrice.Text) &&
                   !string.IsNullOrWhiteSpace(txtQuantity.Text) &&
                   cmbBrandName.SelectedIndex != -1;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView_Product.CurrentCell != null)
            {
                if (IsUpdateFieldsFilled())
                {
                                        if (int.TryParse(txtQuantity.Text, out int quantity))
                    {
                                                DialogResult result = MessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int rowIndex = dataGridView_Product.CurrentCell.RowIndex;
                            if (rowIndex >= 0 && rowIndex < dataGridView_Product.Rows.Count)
                            {
                                DataGridViewRow row = dataGridView_Product.Rows[rowIndex];
                                int productID = Convert.ToInt32(row.Cells["Product_ID"].Value);

                                                                string formattedSellPrice = string.Format("{0:0.00}", Convert.ToDouble(txtSellPrice.Text));
                                string formattedSupplierPrice = string.Format("{0:0.00}", Convert.ToDouble(txtSupplyPrice.Text));

                                using (SqlCommand cmd = new SqlCommand("UPDATE tbl_product SET Product_Name=@name, Product_Location=@location, Category=@category, Supplier_Price=@supplierPrice, Sell_Price=@sellPrice, Quantity=@quantity, Brand_Name=@brandName WHERE Product_ID=@id", connection))
                                {
                                    cmd.Parameters.AddWithValue("@id", productID);
                                    cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                                    cmd.Parameters.AddWithValue("@location", txtProductLocation.Text);
                                    cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@supplierPrice", formattedSupplierPrice);
                                    cmd.Parameters.AddWithValue("@sellPrice", formattedSellPrice);
                                    cmd.Parameters.AddWithValue("@quantity", quantity);
                                    cmd.Parameters.AddWithValue("@brandName", cmbBrandName.SelectedItem.ToString());

                                    connection.Open();
                                    cmd.ExecuteNonQuery();
                                    connection.Close();
                                }
                                LoadData();
                                LoadCategories();
                                LoadSuppliers();
                                ClearFields();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid whole number for Quantity.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields before updating.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Product.CurrentCell != null)
            {
                int rowIndex = dataGridView_Product.CurrentCell.RowIndex;
                if (rowIndex >= 0 && rowIndex < dataGridView_Product.Rows.Count)
                {
                    DataGridViewRow row = dataGridView_Product.Rows[rowIndex];
                    txtProductName.Text = row.Cells["Product_Name"].Value.ToString();
                    txtProductLocation.Text = row.Cells["Product_Location"].Value.ToString();
                    cmbCategory.SelectedItem = row.Cells["Category"].Value.ToString();
                    txtSupplyPrice.Text = row.Cells["Supplier_Price"].Value.ToString();
                    txtSellPrice.Text = row.Cells["Sell_Price"].Value.ToString();
                    txtQuantity.Text = row.Cells["Quantity"].Value.ToString();

                                        string productSupplier = row.Cells["Brand_Name"].Value.ToString();
                    if (cmbBrandName.Items.Contains(productSupplier))
                    {
                        cmbBrandName.SelectedItem = productSupplier;
                    }
                    else
                    {
                        cmbBrandName.SelectedIndex = -1;                     }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Product.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView_Product.CurrentCell.RowIndex;
                    if (rowIndex >= 0 && rowIndex < dataGridView_Product.Rows.Count)
                    {
                        DataGridViewRow row = dataGridView_Product.Rows[rowIndex];
                        int productID = Convert.ToInt32(row.Cells["Product_ID"].Value);

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM tbl_product WHERE Product_ID=@id", connection))
                        {
                            cmd.Parameters.AddWithValue("@id", productID);

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

        private void ClearFields()
        {
            txtProductName.Clear();
            txtProductLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            txtSupplyPrice.Clear();
            txtSellPrice.Clear();
            txtQuantity.Clear();
            cmbCategory.Text = "";
            cmbBrandName.Text = "";
        }

        private bool IsUpdateFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(txtProductName.Text) &&
                   !string.IsNullOrWhiteSpace(txtProductLocation.Text) &&
                   cmbCategory.SelectedIndex != -1 &&
                   !string.IsNullOrWhiteSpace(txtSupplyPrice.Text) &&
                   !string.IsNullOrWhiteSpace(txtSellPrice.Text) &&
                   !string.IsNullOrWhiteSpace(txtQuantity.Text) &&
                   cmbBrandName.SelectedIndex != -1;
        }

        private void dataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)             {
                                dataGridView_Product.ClearSelection();

                                dataGridView_Product.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Product.DefaultCellStyle.SelectionForeColor = Color.White;

                                dataGridView_Product.Rows[e.RowIndex].Selected = true;

                                DataGridViewRow selectedRow = dataGridView_Product.Rows[e.RowIndex];
                string productName = selectedRow.Cells["Product_Name"].Value.ToString();

                            }
        }
    }
}