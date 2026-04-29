using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComputerPartsPOS
{
    public partial class formDashboard : Form
    {
                private string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;";

        public formDashboard()
        {
            InitializeComponent();
        }


        private void formDashboard_Load(object sender, EventArgs e)
        {
                        this.ControlBox = false;

                        try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadData()
        {
                        using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); 
                                string queryProducts = "SELECT COUNT(*) FROM tbl_product";
                SqlCommand cmdProducts = new SqlCommand(queryProducts, connection);
                int totalProducts = (int)cmdProducts.ExecuteScalar();
                lblTotalProducts.Text = $"{totalProducts}";

                                string queryAdmins = "SELECT COUNT(*) FROM tbl_admin WHERE TRIM(admin_role) IN ('Main Admin', 'Admin')";
                SqlCommand cmdAdmins = new SqlCommand(queryAdmins, connection);
                int totalAdmins = (int)cmdAdmins.ExecuteScalar();
                lblTotalAdmins.Text = $"{totalAdmins}";

                                string queryCashiers = "SELECT COUNT(*) FROM tbl_admin WHERE TRIM(admin_role) = 'Cashier'";
                SqlCommand cmdCashiers = new SqlCommand(queryCashiers, connection);
                int totalCashiers = (int)cmdCashiers.ExecuteScalar();
                lblCashierStaff.Text = $"{totalCashiers}";

                                string queryInventoryStaff = "SELECT COUNT(*) FROM tbl_admin WHERE TRIM(admin_role) = 'Inventory Staff'";
                SqlCommand cmdInventoryStaff = new SqlCommand(queryInventoryStaff, connection);
                int totalInventoryStaff = (int)cmdInventoryStaff.ExecuteScalar();
                lblInventoryStaff.Text = $"{totalInventoryStaff}";

                                string querySuppliers = "SELECT COUNT(*) FROM tbl_supplier";
                SqlCommand cmdSuppliers = new SqlCommand(querySuppliers, connection);
                int totalSuppliers = (int)cmdSuppliers.ExecuteScalar();
                lblTotalSuppliers.Text = $"{totalSuppliers}";

                                string queryTotalProfits = "SELECT SUM(Total_Price) FROM tbl_sales_history";
                SqlCommand cmdTotalProfits = new SqlCommand(queryTotalProfits, connection);
                object totalProfitsObj = cmdTotalProfits.ExecuteScalar();
                decimal totalProfits = totalProfitsObj == DBNull.Value ? 0 : Convert.ToDecimal(totalProfitsObj);
                lblTotalProfits.Text = $"{totalProfits}";
            }
        }

        private void lblTotalProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalProfits_Click(object sender, EventArgs e)
        {

        }
    }
}
