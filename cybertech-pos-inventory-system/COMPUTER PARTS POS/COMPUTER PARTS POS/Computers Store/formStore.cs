using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;

namespace ComputerPartsPOS
{
    public partial class formStore : Form
    {
        private string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_admin_1;Password=12345678admin;";
        private SqlDataAdapter adapter;
        private DataTable productTable;

        public formStore()
        {
            InitializeComponent();

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            printDocument1.DocumentName = "CYBERTECH Receipt";
        }

        private void formComputerStore_Load(object sender, EventArgs e)
        {
            txtSearchbar.KeyPress += txtSearchbar_KeyPress; 
            this.ControlBox = false;

            dataGridView_Product_Store.ReadOnly = true;

                        LoadCategories();

                        LoadProducts();

            DisplayCart();

            UpdateTotalAmount();

                        cmbFilterCategory.SelectedItem = "All";

                        txtQuantity.Text = "1";

            dataGridView_Product_Store.CellClick += dataGridView_Product_Store_CellClick;

                        txtQuantity.TextChanged += txtQuantity_TextChanged;
                        txtQuantity.Validating += txtQuantity_Validating;
                        txtQuantity.KeyPress += txtQuantity_KeyPress;

                        dataGridView_Product_Store.ClearSelection();
            dataGridView_Product_Store.CurrentCell = null;

                        dataGridView_Product_Store.RowPostPaint += dataGridView_Product_Store_RowPostPaint;

            dataGridView_Cart.RowPostPaint += dataGridView_Cart_RowPostPaint;

            dataGridView_Cart.CellClick += dataGridView_Cart_CellClick;

            btnDecreaseQuantity.Click += btnDecreaseQuantity_Click;

            dataGridView_Cart.ReadOnly = true;


            dataGridView_Product_Store.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_Cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                        dataGridView_Product_Store.ColumnHeadersHeightSizeModeChanged += DataGridView_Product_Store_ColumnHeadersHeightSizeModeChanged;
            dataGridView_Cart.ColumnHeadersHeightSizeModeChanged += DataGridView_Cart_ColumnHeadersHeightSizeModeChanged;

            txtPayment.KeyPress += txtPayment_KeyPress;

                        dataGridView_Product_Store.DataBindingComplete += dataGridView_Product_Store_DataBindingComplete;

                        SetWrapMode();
        }

        private void SetWrapMode()
        {
            foreach (DataGridViewColumn column in dataGridView_Product_Store.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dataGridView_Product_Store.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }



        private void dataGridView_Product_Store_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView_Product_Store.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dataGridView_Product_Store.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Product_Store.AutoResizeColumnHeadersHeight();
        }

        private void DataGridView_Product_Store_ColumnHeadersHeightSizeModeChanged(object sender, EventArgs e)
        {
                        dataGridView_Product_Store.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void DataGridView_Cart_ColumnHeadersHeightSizeModeChanged(object sender, EventArgs e)
        {
                        dataGridView_Cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }




        private void LoadCategories()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Category_Name FROM tbl_category";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                                cmbFilterCategory.Items.Add("All");

                while (reader.Read())
                {
                    cmbFilterCategory.Items.Add(reader["Category_Name"].ToString());
                }
            }
        }

        private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Product_ID, Product_Name, Brand_Name, Product_Location, Category, Sell_Price, Quantity FROM tbl_product";
                adapter = new SqlDataAdapter(query, connection);
                productTable = new DataTable();
                adapter.Fill(productTable);

                dataGridView_Product_Store.DataSource = productTable;
                dataGridView_Product_Store.Columns["Product_ID"].Visible = false;

                dataGridView_Product_Store.Columns["Product_Name"].HeaderText = "Product Name";
                dataGridView_Product_Store.Columns["Brand_Name"].HeaderText = "Brand Name";
                dataGridView_Product_Store.Columns["Product_Location"].HeaderText = "Product Location";
                dataGridView_Product_Store.Columns["Category"].HeaderText = "Category";
                dataGridView_Product_Store.Columns["Sell_Price"].HeaderText = "Sell Price";
                dataGridView_Product_Store.Columns["Quantity"].HeaderText = "Quantity";

                dataGridView_Product_Store.Columns["Product_Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            }
        }

        private void DisplayCart()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Product_Name, Quantity, Total_Price FROM tbl_cart";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable cartTable = new DataTable();

                adapter.Fill(cartTable);

                dataGridView_Cart.DataSource = cartTable;

                dataGridView_Cart.Columns["Product_Name"].HeaderText = "Product Name";
                dataGridView_Cart.Columns["Quantity"].HeaderText = "Quantity";
                dataGridView_Cart.Columns["Total_Price"].HeaderText = "Total Price";

                dataGridView_Cart.Columns["Product_Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbFilterCategory.SelectedItem.ToString();
            DataView dv = new DataView(productTable);

            if (category == "All")
            {
                dataGridView_Product_Store.DataSource = productTable;
            }
            else
            {
                dv.RowFilter = $"Category = '{category}'";
                dataGridView_Product_Store.DataSource = dv;
            }
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchbar.Text.ToLower();             
            DataView dv = new DataView(productTable);

            dv.RowFilter = $"Product_Name LIKE '%{searchText}%' OR Brand_Name LIKE '%{searchText}%' OR Category LIKE '%{searchText}%' OR Convert(Sell_Price, 'System.String') LIKE '%{searchText}%'";
            dataGridView_Product_Store.DataSource = dv;
        }

        private void txtSearchbar_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;             }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                if (quantity > 1000)
                {
                    txtQuantity.Text = "1000";
                    MessageBox.Show("Quantity cannot exceed 1000.");
                }
            }

                        CalculateTotalPrice();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
                        if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                txtQuantity.Text = "1";
            }
        }

        private void CalculateTotalPrice()
        {
            if (decimal.TryParse(txtPrice.Text, out decimal sellPrice) && decimal.TryParse(txtQuantity.Text, out decimal quantity))
            {
                decimal totalPrice = sellPrice * quantity;
                txtOrderedAmount.Text = totalPrice.ToString();             }
            else
            {
                txtOrderedAmount.Text = "0";             }
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderedAmount_Click(object sender, EventArgs e)
        {
                    }

        private void dataGridView_Product_Store_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Product_Store_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)             {
                                dataGridView_Product_Store.ClearSelection();

                                dataGridView_Product_Store.RowsDefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Product_Store.RowsDefaultCellStyle.SelectionForeColor = Color.White;

                                dataGridView_Product_Store.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dataGridView_Product_Store.Rows[e.RowIndex];
                                string sellPrice = selectedRow.Cells["Sell_Price"].Value.ToString();
                txtPrice.Text = sellPrice; 
                                CalculateTotalPrice();
            }
        }

        private void dataGridView_Product_Store_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
                        DataGridViewRow row = dataGridView_Product_Store.Rows[e.RowIndex];

                        string productName = row.Cells["Product_Name"].Value?.ToString() ?? string.Empty;

                        SizeF textSize = e.Graphics.MeasureString(productName, dataGridView_Product_Store.Font, dataGridView_Product_Store.Columns["Product_Name"].Width);

                        row.Height = (int)Math.Ceiling(textSize.Height) + 15;         }

        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                                quantity++;
                txtQuantity.Text = quantity.ToString();
            }
            else
            {
                                txtQuantity.Text = "1";
            }
        }

        private void btnIncreaseQuantity_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                                quantity++;
                txtQuantity.Text = quantity.ToString();
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.");
            }
        }

        private void btnDecreaseQuantity_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity > 1)
            {
                quantity--;
                txtQuantity.Text = quantity.ToString();
            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
                        string productName = dataGridView_Product_Store.CurrentRow.Cells["Product_Name"].Value.ToString();
            int quantity = int.Parse(txtQuantity.Text);
            decimal totalPrice = decimal.Parse(txtOrderedAmount.Text);

            if (totalPrice <= 0)
            {
                MessageBox.Show("Please select Product");
                return;
            }

                        if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                txtQuantity.Text = "1";                 return;
            }

                        int availableQuantity = Convert.ToInt32(dataGridView_Product_Store.CurrentRow.Cells["Quantity"].Value);
            if (quantity > availableQuantity)
            {
                MessageBox.Show("Quantity exceeds available stock.");
                txtQuantity.Text = "1";                 return;
            }

            bool productExists = false;
            int existingQuantity = 0;
            int updatedQuantity = 0;

                        foreach (DataGridViewRow row in dataGridView_Cart.Rows)
            {
                if (row.Cells["Product_Name"].Value.ToString() == productName)
                {
                    productExists = true;
                    existingQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    updatedQuantity = existingQuantity + quantity;
                    break;
                }
            }

                        if (productExists)
            {
                if (updatedQuantity > availableQuantity)
                {
                    MessageBox.Show("Quantity exceeds available stock.");
                    txtQuantity.Text = "1";                     return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE tbl_cart SET Quantity = @UpdatedQuantity, Total_Price = @TotalPrice WHERE Product_Name = @ProductName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);
                    command.Parameters.AddWithValue("@TotalPrice", totalPrice * updatedQuantity);
                    command.Parameters.AddWithValue("@ProductName", productName);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            DisplayCart();
                            UpdateTotalAmount();
                            MessageBox.Show("Quantity updated in cart successfully.");
                            txtQuantity.Text = "1";                         }
                        else
                        {
                            MessageBox.Show("Failed to update quantity in cart.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO tbl_cart (Product_Name, Quantity, Total_Price) VALUES (@ProductName, @Quantity, @TotalPrice)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            DisplayCart();
                            UpdateTotalAmount();
                            MessageBox.Show("Product added to cart successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add product to cart.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

                        txtSearchbar.Text = string.Empty;
            cmbFilterCategory.SelectedItem = "All";
            dataGridView_Product_Store.DataSource = productTable;
        }




        private void dataGridView_Cart_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
                        DataGridViewRow row = dataGridView_Cart.Rows[e.RowIndex];

                        string productName = row.Cells["Product_Name"].Value?.ToString() ?? string.Empty;

                        SizeF textSize = e.Graphics.MeasureString(productName, dataGridView_Cart.Font, dataGridView_Cart.Columns["Product_Name"].Width);

                        row.Height = (int)Math.Ceiling(textSize.Height) + 10;         }


        private void dataGridView_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView_Cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                        if (e.RowIndex >= 0)
            {
                                dataGridView_Cart.ClearSelection();

                                dataGridView_Cart.RowsDefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Cart.RowsDefaultCellStyle.SelectionForeColor = Color.White;

                                dataGridView_Cart.Rows[e.RowIndex].Selected = true;
            }
        }


        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
                        if (dataGridView_Cart.SelectedRows.Count > 0)
            {
                                DataGridViewRow selectedRow = dataGridView_Cart.SelectedRows[0];

                                string productName = selectedRow.Cells["Product_Name"].Value.ToString();

                                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM tbl_cart WHERE Product_Name = @ProductName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            DisplayCart();
                            MessageBox.Show("Product removed from cart successfully.");
                            UpdateTotalAmount();
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove product from cart.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to remove.");
            }
        }

        private void btnEmptyCartItems_Click(object sender, EventArgs e)
        {
                        using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "TRUNCATE TABLE tbl_cart";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        DisplayCart();                     
                    }
                    else
                    {
                        MessageBox.Show("Cart emptied successfully.");
                        DisplayCart();
                        UpdateTotalAmount();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error: " + ex.Message); 
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtCartTotalAmounnt_Click(object sender, EventArgs e)
        {
         

        }

        private void UpdateTotalAmount()
        {
                        decimal totalAmount = CalculateTotalAmount();

                        txtCartTotalAmounnt.Text = totalAmount.ToString();
        }

        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

                        using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Total_Price FROM tbl_cart";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                                                if (decimal.TryParse(reader["Total_Price"].ToString(), out decimal price))
                        {
                            totalAmount += price;
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating total amount: " + ex.Message);
                }
            }

            return totalAmount;
        }

        private void btnIncreaseQuantityCart_Click(object sender, EventArgs e)
        {
                        if (dataGridView_Cart.SelectedRows.Count > 0)
            {
                                DataGridViewRow selectedRow = dataGridView_Cart.SelectedRows[0];

                                string productName = selectedRow.Cells["Product_Name"].Value.ToString();
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                int availableQuantity = Convert.ToInt32(dataGridView_Product_Store.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => row.Cells["Product_Name"].Value.ToString() == productName)
                    .Select(row => row.Cells["Quantity"].Value)
                    .FirstOrDefault());

                                if (currentQuantity < availableQuantity)
                {
                    currentQuantity++;
                    UpdateQuantityInCart(productName, currentQuantity);
                }
                else
                {
                    MessageBox.Show("Quantity exceeds available stock.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update quantity.");
            }
        }

        private void btnDecreaseQuantityCart_Click(object sender, EventArgs e)
        {
                        if (dataGridView_Cart.SelectedRows.Count > 0)
            {
                                DataGridViewRow selectedRow = dataGridView_Cart.SelectedRows[0];

                                string productName = selectedRow.Cells["Product_Name"].Value.ToString();
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                                if (currentQuantity > 1)
                {
                    currentQuantity--;
                    UpdateQuantityInCart(productName, currentQuantity);
                }
                else
                {
                    MessageBox.Show("Quantity cannot be less than 1.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to update quantity.");
            }
        }

        private void UpdateQuantityInCart(string productName, int newQuantity)
        {
                        using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Sell_Price FROM tbl_product WHERE Product_Name = @ProductName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        decimal sellPrice = Convert.ToDecimal(reader["Sell_Price"]);
                        decimal totalPrice = sellPrice * newQuantity;

                        reader.Close();

                        string updateQuery = "UPDATE tbl_cart SET Quantity = @NewQuantity, Total_Price = @TotalPrice WHERE Product_Name = @ProductName";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        updateCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        updateCommand.Parameters.AddWithValue("@ProductName", productName);

                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            DisplayCart();
                            UpdateTotalAmount();
                            MessageBox.Show("Quantity updated in cart successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update quantity in cart.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
                        if (txtPayment.Text == "0" && txtPayment.Text.Length > 1)
            {
                txtPayment.Text = txtPayment.Text.TrimStart('0');
                txtPayment.SelectionStart = txtPayment.Text.Length;             }

                        txtPayment.Text = txtPayment.Text.Replace(",", ".");
            txtPayment.SelectionStart = txtPayment.Text.Length; 
                        CalculateChange();
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CalculateChange();
            }

                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

                        if ((e.KeyChar == '.' || e.KeyChar == ',') && (txtPayment.Text.Contains('.') || txtPayment.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void CalculateChange()
        {
            string paymentText = txtPayment.Text.Replace(",", ".");             if (decimal.TryParse(txtCartTotalAmounnt.Text, out decimal totalAmount) &&
                decimal.TryParse(paymentText, out decimal payment))
            {
                if (payment >= totalAmount)
                {
                    decimal change = payment - totalAmount;
                    txtChange.Text = change.ToString();
                }
                else
                {
                    txtChange.Text = "0";                 }
            }
            else
            {
                txtChange.Text = "0";             }
        }

        private void txtChange_Click(object sender, EventArgs e)
        {
                    }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cart.Rows.Count == 0)
            {
                MessageBox.Show("No items in the cart.");
                return;
            }

            if (!decimal.TryParse(txtCartTotalAmounnt.Text, out decimal totalAmount))
            {
                MessageBox.Show("Invalid total amount.");
                return;
            }

            string paymentText = txtPayment.Text.Replace(",", ".");
            if (!decimal.TryParse(paymentText, out decimal paymentAmount))
            {
                MessageBox.Show("Invalid payment amount. Please enter a valid number.");
                return;
            }

            if (paymentAmount < totalAmount)
            {
                MessageBox.Show("Insufficient payment amount.");
                return;
            }

            CalculateChange();

            if (string.IsNullOrWhiteSpace(txtChange.Text) || txtChange.Text == "0")
            {
                MessageBox.Show("Please calculate the change before proceeding to checkout.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (DataGridViewRow row in dataGridView_Cart.Rows)
                    {
                        string productName = row.Cells["Product_Name"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal totalPrice = Convert.ToDecimal(row.Cells["Total_Price"].Value);

                        string salesHistoryQuery = "INSERT INTO tbl_sales_history (Product_Name, Quantity, Total_Price, Sale_Date) VALUES (@ProductName, @Quantity, @TotalPrice, @SaleDate)";
                        SqlCommand salesHistoryCommand = new SqlCommand(salesHistoryQuery, connection, transaction);
                        salesHistoryCommand.Parameters.AddWithValue("@ProductName", productName);
                        salesHistoryCommand.Parameters.AddWithValue("@Quantity", quantity);
                        salesHistoryCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        salesHistoryCommand.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                        salesHistoryCommand.ExecuteNonQuery();

                        string updateProductQuery = "UPDATE tbl_product SET Quantity = Quantity - @Quantity WHERE Product_Name = @ProductName";
                        SqlCommand updateProductCommand = new SqlCommand(updateProductQuery, connection, transaction);
                        updateProductCommand.Parameters.AddWithValue("@Quantity", quantity);
                        updateProductCommand.Parameters.AddWithValue("@ProductName", productName);
                        updateProductCommand.ExecuteNonQuery();
                    }

                    string clearCartQuery = "TRUNCATE TABLE tbl_cart";
                    SqlCommand clearCartCommand = new SqlCommand(clearCartQuery, connection, transaction);
                    clearCartCommand.ExecuteNonQuery();

                    transaction.Commit();

                                        if (PrinterSettings.InstalledPrinters.Count > 0)
                    {
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No printers detected. Please install a printer to proceed.");
                    }

                    DisplayCart();
                    UpdateTotalAmount();

                    MessageBox.Show("Checkout completed successfully.");

                    txtPayment.Text = "";

                    LoadProducts();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error during checkout: " + ex.Message);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);
            int yPos = 20;
            int lineHeight = bodyFont.Height + 5;

            e.Graphics.DrawString("CYBERTECH", titleFont, Brushes.Black, new PointF(100, yPos));
            yPos += 30;
            e.Graphics.DrawLine(Pens.Black, 20, yPos, 400, yPos);
            yPos += 10;

            e.Graphics.DrawString($"Date Issued: {DateTime.Now}", headerFont, Brushes.Black, new PointF(20, yPos));
            yPos += 30;

            int col1Width = 200;
            int col2Width = 50;
            int col3Width = 100;
            e.Graphics.DrawString("Product Name", headerFont, Brushes.Black, new PointF(20, yPos));
            e.Graphics.DrawString("Qty", headerFont, Brushes.Black, new PointF(20 + col1Width, yPos));
            e.Graphics.DrawString("Total Price", headerFont, Brushes.Black, new PointF(20 + col1Width + col2Width, yPos));
            yPos += lineHeight;

            foreach (DataGridViewRow row in dataGridView_Cart.Rows)
            {
                string productName = row.Cells["Product_Name"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal totalPrice = Convert.ToDecimal(row.Cells["Total_Price"].Value);

                SizeF size = e.Graphics.MeasureString(productName, bodyFont, col1Width);
                RectangleF rect = new RectangleF(new PointF(20, yPos), new SizeF(col1Width, size.Height));
                e.Graphics.DrawString(productName, bodyFont, Brushes.Black, rect);

                int rowHeight = (int)Math.Ceiling(size.Height);

                e.Graphics.DrawString(quantity.ToString(), bodyFont, Brushes.Black, new PointF(20 + col1Width, yPos));
                e.Graphics.DrawString($"₱ {totalPrice:N2}", bodyFont, Brushes.Black, new PointF(20 + col1Width + col2Width, yPos));
                yPos += rowHeight + 5;
            }

            yPos += 10;
            e.Graphics.DrawLine(Pens.Black, 20, yPos, 400, yPos);
            yPos += 10;

            decimal totalAmount = decimal.Parse(txtCartTotalAmounnt.Text);
            decimal paymentAmount = decimal.Parse(txtPayment.Text.Replace(",", "."));
            decimal changeAmount = decimal.Parse(txtChange.Text.Replace(",", "."));

            yPos += lineHeight;
            e.Graphics.DrawString($"Total Amount Due: ₱ {totalAmount:N2}", headerFont, Brushes.Black, new PointF(20, yPos));
            yPos += lineHeight;
            e.Graphics.DrawString($"Paid Amount: ₱ {paymentAmount:N2}", headerFont, Brushes.Black, new PointF(20, yPos));
            yPos += lineHeight;
            e.Graphics.DrawString($"Cash Change: ₱ {changeAmount:N2}", headerFont, Brushes.Black, new PointF(20, yPos));
            yPos += 40;

            e.Graphics.DrawString("Valid until 7 days to return items.", bodyFont, Brushes.Black, new PointF(20, yPos));

            e.PageSettings.PaperSize = new PaperSize("Custom", 400, yPos + 100);
        }



        private PrintDocument printDocument1 = new PrintDocument();

        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

    }
}
