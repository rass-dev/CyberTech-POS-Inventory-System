using COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Supply;
using ComputerPartsPOS;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Staff.Staff_Store_and_Inventory.Inventory_Staff
{
    public partial class formInventoryStaff : Form
    {
        private formAdminLogin loginForm;

        public formInventoryStaff()
        {

            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            formPanel.MouseDown += FormPanel_MouseDown;
            formPanel.MouseMove += FormPanel_MouseMove;
            formPanel.MouseUp += FormPanel_MouseUp;

            this.Resize += formInventoryStaff_Resize;
        }

        private void formInventoryStaff_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                CenterToScreen();
            }
        }


        private void formInventoryStaff_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            mdiProp();

            OpenComputerParts();
        }

        private void OpenComputerParts()
        {
            if (AddProduct == null)
            {
                AddProduct = new formAddProduct();
                AddProduct.FormClosed += AddProduct_FormClosed;
                AddProduct.MdiParent = this;
                AddProduct.Dock = DockStyle.Fill;
                AddProduct.Show();
            }
            else
            {
                AddProduct.Activate();
            }
        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddProduct = null;
        }


        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastFormLocation;

        private void FormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastFormLocation = this.Location;
        }

        private void FormPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastFormLocation.X + deltaX, lastFormLocation.Y + deltaY);
            }
        }

        private void FormPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }



        private formAdmin adminForm;


        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;

        private void btnHam_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width = 53;
                sidebarExpand = false;             
                pnLogout.Width = sidebar.Width;
            }
            else
            {
                sidebar.Width = 250;
                sidebarExpand = true;
                pnLogout.Width = sidebar.Width;
            }
        }

        bool ComputerPSExpand = false;

        private void ComputerPSTransition_Tick(object sender, EventArgs e)
        {
            if (!ComputerPSExpand)
            {
                pnComputerPSContainer.Height += 10;
                if (pnComputerPSContainer.Height >= 210)
                {
                    ComputerPSTransition.Stop();
                    ComputerPSExpand = true;

                }
            }
            else
            {
                pnComputerPSContainer.Height -= 10;
                if (pnComputerPSContainer.Height <= 53)
                {
                    ComputerPSTransition.Stop();
                    ComputerPSExpand = false;
                }
            }
        }

        private void ComputerPSContainer_Click(object sender, EventArgs e)
        {
            ComputerPSTransition.Start();
        }

        formAddSupplier Addsuppler;

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {

            Addsuppler = new formAddSupplier();
            Addsuppler.FormClosed += Addsuppler_FormClosed;
            Addsuppler.MdiParent = this;
            Addsuppler.Dock = DockStyle.Fill;
            Addsuppler.Show();
        }

        private void Addsuppler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Addsuppler = null;
        }

        formAddProduct AddProduct;

        private void formAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct = new formAddProduct();
            AddProduct.FormClosed += formAddProduct_FormClosed;
            AddProduct.MdiParent = this;
            AddProduct.Dock = DockStyle.Fill;
            AddProduct.Show();
        }

        private void formAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddProduct = null;
        }

        formAddCategory AddCategory;

        private void AddCategory_Click(object sender, EventArgs e)
        {
            AddCategory = new formAddCategory();
            AddCategory.FormClosed += formAddCategory_FormClosed;
            AddCategory.MdiParent = this;
            AddCategory.Dock = DockStyle.Fill;
            AddCategory.Show();
        }

        private void formAddCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddCategory = null;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                formAdminLogin loginForm = new formAdminLogin();
                loginForm.ShowDialog();
            }
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }

    }
}
