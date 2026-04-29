using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Computers_Store
{
    public partial class formReturnItems : Form
    {
        private string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_admin_1;Password=12345678admin;";
        private DataTable productTable;
        private DataTable categoryTable;
        private SqlDataAdapter adapter;

        public formReturnItems()
        {
            InitializeComponent();
            dataGridView_Products.CellClick += dataGridView_Products_CellClick;
            cbkGoodCondition.CheckedChanged += cbkGoodCondition_CheckedChanged;
            cbkDefectiveItem.CheckedChanged += cbkDefectiveItem_CheckedChanged;
            txtSearchbar.KeyPress += txtSearchbar_KeyPress;         }

        private void formReturnItems_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

            dataGridView_Products.ReadOnly = true;
            dataGridView_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView_Products.DataBindingComplete += DataGridView_Products_DataBindingComplete;
            dataGridView_Products.CellFormatting += DataGridView_Products_CellFormatting;
        }

        private void DataGridView_Products_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_Products.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.BackColor = Color.RoyalBlue;
                e.CellStyle.ForeColor = Color.White;
            }
            else
            {
                e.CellStyle.BackColor = dataGridView_Products.DefaultCellStyle.BackColor;
                e.CellStyle.ForeColor = dataGridView_Products.DefaultCellStyle.ForeColor;
            }
        }

        private void DataGridView_Products_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView_Products.Columns.Contains("Product_Name"))
            {
                dataGridView_Products.Columns["Product_Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            dataGridView_Products.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Product_ID, Product_Name, Brand_Name, Product_Location, Category, Sell_Price, Quantity FROM tbl_product";
                adapter = new SqlDataAdapter(query, connection);
                productTable = new DataTable();
                adapter.Fill(productTable);

                dataGridView_Products.DataSource = productTable;
                dataGridView_Products.Columns["Product_ID"].Visible = false;

                dataGridView_Products.Columns["Product_Name"].HeaderText = "Product Name";
                dataGridView_Products.Columns["Brand_Name"].HeaderText = "Brand Name";
                dataGridView_Products.Columns["Product_Location"].HeaderText = "Product Location";
                dataGridView_Products.Columns["Category"].HeaderText = "Category";
                dataGridView_Products.Columns["Sell_Price"].HeaderText = "Sell Price";
                dataGridView_Products.Columns["Quantity"].HeaderText = "Quantity";

                dataGridView_Products.Columns["Product_Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
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

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            if (!cbkGoodCondition.Checked && !cbkDefectiveItem.Checked)
            {
                MessageBox.Show("Please select a condition for the returned product.", "Condition Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView_Products.SelectedRows.Count > 0)
            {
                string condition = cbkGoodCondition.Checked ? "Good Condition" : "Defective Item";

                DataGridViewRow selectedRow = dataGridView_Products.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["Product_ID"].Value);
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                if (cbkGoodCondition.Checked)
                {
                    int returnedQuantity = 1;
                    quantity += returnedQuantity;
                }
                else if (cbkDefectiveItem.Checked)
                {
                    int returnedQuantity = 1;
                    if (quantity >= returnedQuantity)
                    {
                        quantity -= returnedQuantity;
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock to return.");
                        return;
                    }
                }

                UpdateStock(productId, quantity);
                LoadProducts();
                MessageBox.Show($"Product returned in {condition}.", "Return Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a product to return.");
            }
        }

        private void UpdateStock(int productId, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE tbl_product SET Quantity = @Quantity WHERE Product_ID = @ProductID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@ProductID", productId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void dataGridView_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView_Products.ClearSelection();

                dataGridView_Products.RowsDefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Products.RowsDefaultCellStyle.SelectionForeColor = Color.White;

                dataGridView_Products.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dataGridView_Products.Rows[e.RowIndex];
            }
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbFilterCategory.SelectedItem.ToString();
            DataView dv = new DataView(productTable);

            if (category == "All")
            {
                dataGridView_Products.DataSource = productTable;
            }
            else
            {
                dv.RowFilter = $"Category = '{category}'";
                dataGridView_Products.DataSource = dv;
            }
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchbar.Text.ToLower();
            searchText = EscapeSpecialCharsForLike(searchText);
            DataView dv = new DataView(productTable);

            dv.RowFilter = $"Product_Name LIKE '%{searchText}%' OR Brand_Name LIKE '%{searchText}%' OR Category LIKE '%{searchText}%' OR Convert(Sell_Price, 'System.String') LIKE '%{searchText}%'";
            dataGridView_Products.DataSource = dv;
        }

        private void txtSearchbar_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;             }
        }

        private string EscapeSpecialCharsForLike(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

                        char[] specialChars = { '%', '_', '[', ']' };
            StringBuilder sb = new StringBuilder();
            foreach (char c in text)
            {
                if (specialChars.Contains(c))
                {
                    sb.Append("[").Append(c).Append("]");
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void cbkGoodCondition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkGoodCondition.Checked)
            {
                cbkDefectiveItem.Checked = false;
            }
        }

        private void cbkDefectiveItem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkDefectiveItem.Checked)
            {
                cbkGoodCondition.Checked = false;
            }
        }
    }
}
