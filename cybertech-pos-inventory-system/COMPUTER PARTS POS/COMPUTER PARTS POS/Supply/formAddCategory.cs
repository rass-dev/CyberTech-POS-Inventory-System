using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Supply
{
    public partial class formAddCategory : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;");
        SqlDataAdapter adapter;
        DataTable table;

        public formAddCategory()
        {
            InitializeComponent();
            this.dataGridView_Category.ReadOnly = true;
            dataGridView_Category.CellClick += dataGridView_Category_CellClick;
        }

        private void formAddCategory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();

            dataGridView_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_Category.ColumnHeadersHeightSizeModeChanged += DataGridView_Category_ColumnHeadersHeightSizeModeChanged;

            foreach (DataGridViewColumn column in dataGridView_Category.Columns)
            {
                if (column is DataGridViewTextBoxColumn)
                {
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }

            dataGridView_Category.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void DataGridView_Category_ColumnHeadersHeightSizeModeChanged(object sender, EventArgs e)
        {
            dataGridView_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void LoadData()
        {
            adapter = new SqlDataAdapter("SELECT * FROM tbl_category", connection);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView_Category.DataSource = table;

            dataGridView_Category.Columns["Category_ID"].HeaderText = "ID";
            dataGridView_Category.Columns["Category_Name"].HeaderText = "Category Name";
            dataGridView_Category.Columns["Category_Details"].HeaderText = "Category Details";

            dataGridView_Category.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_category (Category_Name, Category_Details) VALUES (@name, @details)", connection))
                {
                    cmd.Parameters.AddWithValue("@name", txtCategoryName.Text);
                    cmd.Parameters.AddWithValue("@details", txtCategoryDetails.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please enter a category name.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Category.CurrentCell != null)
            {
                DataGridViewRow row = dataGridView_Category.Rows[dataGridView_Category.CurrentCell.RowIndex];
                txtCategoryName.Text = row.Cells["Category_Name"].Value.ToString();
                txtCategoryDetails.Text = row.Cells["Category_Details"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView_Category.CurrentCell != null)
            {
                if (!string.IsNullOrWhiteSpace(txtCategoryName.Text) && !string.IsNullOrWhiteSpace(txtCategoryDetails.Text))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dataGridView_Category.Rows[dataGridView_Category.CurrentCell.RowIndex];
                        int categoryID = Convert.ToInt32(row.Cells["Category_ID"].Value);

                        using (SqlCommand cmd = new SqlCommand("UPDATE tbl_category SET Category_Name=@name, Category_Details=@details WHERE Category_ID=@id", connection))
                        {
                            cmd.Parameters.AddWithValue("@id", categoryID);
                            cmd.Parameters.AddWithValue("@name", txtCategoryName.Text);
                            cmd.Parameters.AddWithValue("@details", txtCategoryDetails.Text);

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
                    MessageBox.Show("Please fill in all fields before updating.");
                }
            }
            else
            {
                MessageBox.Show("Please select a category to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Category.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView_Category.Rows[dataGridView_Category.CurrentCell.RowIndex];
                    int categoryID = Convert.ToInt32(row.Cells["Category_ID"].Value);

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM tbl_category WHERE Category_ID=@id", connection))
                    {
                        cmd.Parameters.AddWithValue("@id", categoryID);

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
                MessageBox.Show("Please select a category to delete.");
            }
        }

        private void ClearFields()
        {
            txtCategoryName.Clear();
            txtCategoryDetails.Clear();
        }

        private void dataGridView_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView_Category.ClearSelection();

                dataGridView_Category.RowsDefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                dataGridView_Category.RowsDefaultCellStyle.SelectionForeColor = Color.White;

                dataGridView_Category.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dataGridView_Category.Rows[e.RowIndex];
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.dataGridView_Category.Width, this.dataGridView_Category.Height);
            dataGridView_Category.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView_Category.Width, this.dataGridView_Category.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
