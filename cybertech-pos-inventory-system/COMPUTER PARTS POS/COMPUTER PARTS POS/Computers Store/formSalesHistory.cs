using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    public partial class formSalesHistory : Form
    {
        private string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_admin_1;Password=12345678admin;";
        private PrintDocument printDocument = new PrintDocument();
        private int currentPrintRow;
        private bool isPrinting;

        public formSalesHistory()
        {
            InitializeComponent();

            this.dataGridView_Sales_History.ReadOnly = true;
            this.dataGridView_Sales_History.DataBindingComplete += DataGridView_Sales_History_DataBindingComplete;

            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCompleteSalesHistory();
            dataGridView_Sales_History.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_Sales_History.ColumnHeadersHeightSizeModeChanged += DataGridView_Sales_History_ColumnHeadersHeightSizeModeChanged;
        }

        private void DataGridView_Sales_History_ColumnHeadersHeightSizeModeChanged(object sender, EventArgs e)
        {
            dataGridView_Sales_History.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void LoadCompleteSalesHistory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MIN(Sale_Date) AS EarliestSaleDate FROM tbl_sales_history";
                    SqlCommand command = new SqlCommand(query, connection);
                    DateTime earliestSaleDate = (DateTime)command.ExecuteScalar();
                    DateTimeStartFrom.Value = earliestSaleDate;

                    query = "SELECT * FROM tbl_sales_history";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView_Sales_History.DataSource = dataTable;

                    dataGridView_Sales_History.Columns["Sale_ID"].HeaderText = "No.";
                    dataGridView_Sales_History.Columns["Product_Name"].HeaderText = "Product Name";
                    dataGridView_Sales_History.Columns["Quantity"].HeaderText = "Quantity";
                    dataGridView_Sales_History.Columns["Total_Price"].HeaderText = "Total Price";
                    dataGridView_Sales_History.Columns["Sale_Date"].HeaderText = "Sale Date";

                    dataGridView_Sales_History.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading complete sales history: " + ex.Message);
                }
            }
        }

        private void LoadFilteredSalesHistory(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM tbl_sales_history WHERE Sale_Date >= @StartDate AND Sale_Date <= @EndDate";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@EndDate", endDate.AddDays(1).AddTicks(-1));
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView_Sales_History.DataSource = dataTable;

                    dataGridView_Sales_History.Columns["Sale_ID"].HeaderText = "No.";
                    dataGridView_Sales_History.Columns["Product_Name"].HeaderText = "Product Name";
                    dataGridView_Sales_History.Columns["Quantity"].HeaderText = "Quantity";
                    dataGridView_Sales_History.Columns["Total_Price"].HeaderText = "Total Price";
                    dataGridView_Sales_History.Columns["Sale_Date"].HeaderText = "Sale Date";

                    dataGridView_Sales_History.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filtering sales history: " + ex.Message);
                }
            }
        }

        private void DataGridView_Sales_History_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView_Sales_History.Columns.Contains("Product_Name"))
            {
                dataGridView_Sales_History.Columns["Product_Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            dataGridView_Sales_History.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            currentPrintRow = 0;
            isPrinting = true;
            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
                        Rectangle area = e.MarginBounds;

                        int totalWidth = dataGridView_Sales_History.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int totalHeight = dataGridView_Sales_History.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

                        float scaleFactorWidth = (float)area.Width / totalWidth;
            float scaleFactorHeight = (float)area.Height / totalHeight;
            float scaleFactor = Math.Min(scaleFactorWidth, scaleFactorHeight);

                        int x = area.Left;
            int y = area.Top;

                        foreach (DataGridViewRow row in dataGridView_Sales_History.Rows)
            {
                if (!row.Visible)
                    continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!cell.Visible)
                        continue;

                                        int cellWidth = (int)(cell.Size.Width * scaleFactor);
                    int cellHeight = (int)(cell.Size.Height * scaleFactor);
                    Rectangle cellBounds = new Rectangle(x, y, cellWidth, cellHeight);

                                        e.Graphics.DrawString(cell.FormattedValue.ToString(), dataGridView_Sales_History.Font, Brushes.Black, cellBounds);

                                        x += cellBounds.Width;
                }

                                x = area.Left;
                y += (int)(row.Height * scaleFactor);
            }
        }


        private void dataGridView_Sales_History_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DateTimeStartFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadFilteredSalesHistory(DateTimeStartFrom.Value.Date, DateTimeToEnd.Value.Date);
        }

        private void DateTimeToEnd_ValueChanged(object sender, EventArgs e)
        {
            LoadFilteredSalesHistory(DateTimeStartFrom.Value.Date, DateTimeToEnd.Value.Date);
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            LoadCompleteSalesHistory();
        }

        private void btnPrintSales_Click(object sender, EventArgs e)
        {
            btnPrint_Click(sender, e);
        }

    }
}
