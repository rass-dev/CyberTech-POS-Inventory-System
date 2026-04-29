using COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Staff.Staff_Store_and_Inventory.Inventory_Staff;
using COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Staff.Staff_Store_and_Inventory;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    public partial class formAdminLogin : Form
    {
        public event EventHandler LoginSuccess;

        public formAdminLogin()
        {
            InitializeComponent();
        }

        private void formAdminLogin_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            txtAdminPassword.PasswordChar = '*';

                        if (pictureBox2.Image != null)
            {
                pictureBox2.Image = AdjustBrightness(pictureBox2.Image, 0.7f);             }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (LoginIsSuccessful())
            {
                string role = GetAdminRole(txtAdminUsername.Text.Trim());                 OpenRoleSpecificForm(role);                 this.Close();
            }
        }

        private bool LoginIsSuccessful()
        {
            string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;";             string username = txtAdminUsername.Text.Trim();
            string password = txtAdminPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtAdminUsername.Clear();
                txtAdminPassword.Clear();
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM tbl_admin WHERE admin_username COLLATE Latin1_General_CS_AS = @Username AND admin_password COLLATE Latin1_General_CS_AS = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    txtAdminUsername.Clear();
                    txtAdminPassword.Clear();

                    MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private string GetAdminRole(string username)
        {
            string role = string.Empty;
            string connectionString = "Data Source=FX505DT-AL226T\\SQLPROJECTS; Initial Catalog=db_computer_parts_pos_management; User ID=svc_Admin_1;Password=12345678admin;"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT admin_role FROM tbl_admin WHERE admin_username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                                role = ((string)command.ExecuteScalar()).Trim();
            }

            return role;
        }


        private void OpenRoleSpecificForm(string role)
        {
            role = role.Trim(); 
            switch (role)
            {
                case "Cashier":
                    formCashierPOS cashierForm = new formCashierPOS();
                    cashierForm.ShowDialog();
                    break;
                case "Inventory Staff":
                    formInventoryStaff inventoryStaffForm = new formInventoryStaff();
                    inventoryStaffForm.ShowDialog();
                    break;
                default:
                   
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkShowPassword.Checked)
            {
                txtAdminPassword.PasswordChar = '\0';
            }
            else
            {
                txtAdminPassword.PasswordChar = '*';
            }
        }

        private void txtAdminUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private Image AdjustBrightness(Image image, float brightnessFactor)
        {
            Bitmap tempBitmap = new Bitmap(image);
            float[][] colorMatrixElements = {
                new float[] {brightnessFactor, 0, 0, 0, 0},
                new float[] {0, brightnessFactor, 0, 0, 0},
                new float[] {0, 0, brightnessFactor, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Graphics g = Graphics.FromImage(tempBitmap);
            g.DrawImage(image, new Rectangle(0, 0, tempBitmap.Width, tempBitmap.Height), 0, 0, tempBitmap.Width, tempBitmap.Height, GraphicsUnit.Pixel, imageAttributes);
            g.Dispose();

            return tempBitmap;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
