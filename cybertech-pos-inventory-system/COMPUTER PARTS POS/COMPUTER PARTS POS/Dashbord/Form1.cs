using COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Computers_Store;
using COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Supply;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    public partial class Form1 : Form
    {

         public static Timer globalTimer = new Timer();

        formDashboard dashboard;
        formStore ManagePC;

        formAbout about;
      
        private formStore managePC;


        private formAdminLogin loginForm;

        public Form1()
        {
            InitializeComponent();

                        this.WindowState = FormWindowState.Maximized;

                        mdiProp();

            managePC = new formStore();

                        adminForm = new formAdmin();

                        this.loginForm = new formAdminLogin();

                        this.loginForm.LoginSuccess += LoginForm_LoginSuccess;

                        this.loginForm.ShowDialog();

                        this.Visible = false;

                        formPanel.MouseDown += FormPanel_MouseDown;
            formPanel.MouseMove += FormPanel_MouseMove;
            formPanel.MouseUp += FormPanel_MouseUp;

                        this.Resize += Form1_Resize;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                CenterToScreen();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            OpenDashboard();
        }


        private formDashboard dashboardForm;

        private void OpenDashboard()
        {
            if (dashboardForm == null)
            {
                dashboardForm = new formDashboard();
                dashboardForm.FormClosed += DashboardForm_FormClosed;
                dashboardForm.MdiParent = this;
                dashboardForm.Dock = DockStyle.Fill;
                dashboardForm.Show();
            }
            else
            {
                dashboardForm.Activate();
            }
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
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


                private void LoginForm_LoginSuccess(object sender, EventArgs e)
        {
                        loginForm.Close();

                        this.Visible = true;

                        Form1_Load(null, EventArgs.Empty);

                        OpenDashboardForm();
        }


                private void OpenDashboardForm()
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }


        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        bool sidebarExpand = true;

        private void btnHam_Click(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                                sidebar.Width = 53;
                sidebarExpand = false;

                                pnDashboard.Width = sidebar.Width;
                pnmenuContainer.Width = sidebar.Width;
                pnComputerPSContainer.Width = sidebar.Width;
                pnAdminContainer.Width = sidebar.Width;
                pnAbout.Width = sidebar.Width;
                pnLogout.Width = sidebar.Width;
            }
            else
            {
                                sidebar.Width = 250;
                sidebarExpand = true;


                                pnDashboard.Width = sidebar.Width;
                pnmenuContainer.Width = sidebar.Width;
                pnComputerPSContainer.Width = sidebar.Width;
                pnAdminContainer.Width = sidebar.Width;
                pnAbout.Width = sidebar.Width;
                pnLogout.Width = sidebar.Width;
            }
        }


        
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void pnDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        bool ComputerExpand = false;


        private void ComputerTransition_Tick(object sender, EventArgs e)
        {
                        if (!ComputerExpand)
            {
                                pnmenuContainer.Height += 10;
                if (pnmenuContainer.Height >= 210)
                {
                    ComputerTransition.Stop();
                    ComputerExpand = true;
                                        if (AdminExpand)
                    {
                        AdminTransition.Start();
                    }
                    if (ComputerPSExpand)
                    {
                        ComputerPSTransition.Start();
                    }
                }
            }
            else
            {
                                pnmenuContainer.Height -= 10;
                if (pnmenuContainer.Height <= 53)
                {
                    ComputerTransition.Stop();
                    ComputerExpand = false;
                }
            }
        }


        private void ComputersContainer_Click(object sender, EventArgs e)
        {
            ComputerTransition.Start();

        }

      

        

        formStore formComputerStore;

        private void btnComputers_Click(object sender, EventArgs e)
        {
            formComputerStore = new formStore();

                        formComputerStore.FormClosed += formComputerStore_FormClosed;

                        formComputerStore.MdiParent = this;
            formComputerStore.Dock = DockStyle.Fill;
            formComputerStore.Show();
        }

        private void formComputerStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            formComputerStore = null;
        }
        

        formSalesHistory SalesHistory;

        private void formSalesHistory_Click(object sender, EventArgs e)
        {
            SalesHistory = new formSalesHistory();
            SalesHistory.FormClosed += SalesHistory_FormClosed;
            SalesHistory.MdiParent = this;
            SalesHistory.Dock = DockStyle.Fill;
            SalesHistory.Show();

        }

        private void SalesHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            SalesHistory = null;
        }


        formReturnItems ReturnItems;

        private void btnReturnItems_Click (object sender, EventArgs e)
        {
            ReturnItems = new formReturnItems();
            ReturnItems.FormClosed += ReturnItems_FormClosed;
            ReturnItems.MdiParent = this;
            ReturnItems.Dock = DockStyle.Fill;
            ReturnItems.Show();
        }

        private void ReturnItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReturnItems = null;
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
                                        if (AdminExpand)
                    {
                        AdminTransition.Start();
                    }
                    if (ComputerExpand)
                    {
                        ComputerTransition.Start();
                    }
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








        
        bool AdminExpand = false;

        private void AdminTransition_Tick(object sender, EventArgs e)
        {
                        if (!AdminExpand)
            {
                                pnAdminContainer.Height += 10;
                if (pnAdminContainer.Height >= 153)
                {
                    AdminTransition.Stop();
                    AdminExpand = true;

                                        if (ComputerExpand)
                    {
                        ComputerTransition.Start();
                    }
                    if (ComputerPSExpand)
                    {
                        ComputerPSTransition.Start();
                    }
                }
            }
            else
            {
                                pnAdminContainer.Height -= 10;
                if (pnAdminContainer.Height <= 53)
                {
                    AdminTransition.Stop();
                    AdminExpand = false;
                }
            }
        }



        private void AdminContainer_Click(object sender, EventArgs e)
        {
            AdminTransition.Start();
        }


        private void pnAdminContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private formAdmin adminsForm; 
        private void btnAdmins_Click(object sender, EventArgs e)
        {
            if (adminsForm == null)
            {
                adminsForm = new formAdmin();
                adminsForm.FormClosed += AdminsForm_FormClosed;
                adminsForm.MdiParent = this;
                adminsForm.Dock = DockStyle.Fill;
                adminsForm.Show();
            }
            else
            {
                adminsForm = new formAdmin();
                adminsForm.FormClosed += AdminsForm_FormClosed;
                adminsForm.MdiParent = this;
                adminsForm.Dock = DockStyle.Fill;
                adminsForm.Show();
            }
        }

        private void AdminsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminsForm = null;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (adminsForm == null)
            {
                adminsForm = new formAdmin();
                adminsForm.FormClosed += AdminsForm_FormClosed;
                adminsForm.MdiParent = this;
                adminsForm.Dock = DockStyle.Fill;
                adminsForm.Show();
            }
            else
            {
                adminsForm.Activate();
            }

                        if (adminsForm != null)
            {
                                adminsForm.btnAddAdmin_Click(sender, e);
            }
        }

        
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new formAbout();
                about.FormClosed += about_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }

        private void about_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;

        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {

                        this.Hide();

                        formAdminLogin loginForm = new formAdminLogin();

                        loginForm.LoginSuccess += LoginForm_LoginSuccess;

            loginForm.ShowDialog();

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
