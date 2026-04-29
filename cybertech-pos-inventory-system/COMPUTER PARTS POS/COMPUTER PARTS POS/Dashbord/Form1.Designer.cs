namespace ComputerPartsPOS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnmenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComputersContainer = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnComputers = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.submenu1 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ComputerContainer = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReturnItems = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pnComputerPSContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComputerPartsInventoryContainer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddMembers = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.pnAdminContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AdminContainer = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnManageAdmin = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ComputerTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.ComputerPSTransition = new System.Windows.Forms.Timer(this.components);
            this.AdminTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.pnDashboard.SuspendLayout();
            this.pnmenuContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnComputerPSContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnAdminContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Controls.Add(this.label10);
            this.formPanel.Controls.Add(this.btnHam);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1277, 39);
            this.formPanel.TabIndex = 0;
            this.formPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formPanel_Paint);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(70, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 32);
            this.label10.TabIndex = 88;
            this.label10.Text = "CYBERTECH";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(5, 4);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(41, 31);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // pnDashboard
            // 
            this.pnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(170)))));
            this.pnDashboard.Controls.Add(this.btnDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(0, 33);
            this.pnDashboard.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(252, 53);
            this.pnDashboard.TabIndex = 2;
            this.pnDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDashboard_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-19, -20);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(278, 91);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "              Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnmenuContainer
            // 
            this.pnmenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(155)))));
            this.pnmenuContainer.Controls.Add(this.panel2);
            this.pnmenuContainer.Controls.Add(this.panel10);
            this.pnmenuContainer.Controls.Add(this.panel8);
            this.pnmenuContainer.Controls.Add(this.panel5);
            this.pnmenuContainer.Location = new System.Drawing.Point(0, 92);
            this.pnmenuContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnmenuContainer.Name = "pnmenuContainer";
            this.pnmenuContainer.Size = new System.Drawing.Size(252, 53);
            this.pnmenuContainer.TabIndex = 8;
            this.pnmenuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ComputersContainer);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 53);
            this.panel2.TabIndex = 5;
            // 
            // ComputersContainer
            // 
            this.ComputersContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.ComputersContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputersContainer.ForeColor = System.Drawing.Color.White;
            this.ComputersContainer.Image = ((System.Drawing.Image)(resources.GetObject("ComputersContainer.Image")));
            this.ComputersContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComputersContainer.Location = new System.Drawing.Point(-19, -17);
            this.ComputersContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ComputersContainer.Name = "ComputersContainer";
            this.ComputersContainer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.ComputersContainer.Size = new System.Drawing.Size(278, 91);
            this.ComputersContainer.TabIndex = 2;
            this.ComputersContainer.Text = "              Computer Store";
            this.ComputersContainer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComputersContainer.UseVisualStyleBackColor = false;
            this.ComputersContainer.Click += new System.EventHandler(this.ComputersContainer_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnComputers);
            this.panel10.Location = new System.Drawing.Point(0, 53);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(258, 53);
            this.panel10.TabIndex = 4;
            // 
            // btnComputers
            // 
            this.btnComputers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnComputers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputers.ForeColor = System.Drawing.Color.White;
            this.btnComputers.Image = ((System.Drawing.Image)(resources.GetObject("btnComputers.Image")));
            this.btnComputers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputers.Location = new System.Drawing.Point(-16, -18);
            this.btnComputers.Margin = new System.Windows.Forms.Padding(0);
            this.btnComputers.Name = "btnComputers";
            this.btnComputers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnComputers.Size = new System.Drawing.Size(278, 91);
            this.btnComputers.TabIndex = 2;
            this.btnComputers.Text = "             Store";
            this.btnComputers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputers.UseVisualStyleBackColor = false;
            this.btnComputers.Click += new System.EventHandler(this.btnComputers_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.submenu1);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Location = new System.Drawing.Point(0, 106);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(258, 53);
            this.panel8.TabIndex = 4;
            // 
            // submenu1
            // 
            this.submenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.submenu1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submenu1.ForeColor = System.Drawing.Color.White;
            this.submenu1.Image = ((System.Drawing.Image)(resources.GetObject("submenu1.Image")));
            this.submenu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu1.Location = new System.Drawing.Point(-14, -22);
            this.submenu1.Margin = new System.Windows.Forms.Padding(0);
            this.submenu1.Name = "submenu1";
            this.submenu1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.submenu1.Size = new System.Drawing.Size(278, 91);
            this.submenu1.TabIndex = 2;
            this.submenu1.Text = "             Sales History";
            this.submenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu1.UseVisualStyleBackColor = false;
            this.submenu1.Click += new System.EventHandler(this.formSalesHistory_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.ComputerContainer);
            this.panel11.Location = new System.Drawing.Point(0, 53);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(248, 53);
            this.panel11.TabIndex = 4;
            // 
            // ComputerContainer
            // 
            this.ComputerContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.ComputerContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerContainer.ForeColor = System.Drawing.Color.White;
            this.ComputerContainer.Image = ((System.Drawing.Image)(resources.GetObject("ComputerContainer.Image")));
            this.ComputerContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComputerContainer.Location = new System.Drawing.Point(0, 145);
            this.ComputerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ComputerContainer.Name = "ComputerContainer";
            this.ComputerContainer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.ComputerContainer.Size = new System.Drawing.Size(278, 91);
            this.ComputerContainer.TabIndex = 2;
            this.ComputerContainer.Text = "              Computer";
            this.ComputerContainer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComputerContainer.UseVisualStyleBackColor = false;
            this.ComputerContainer.Click += new System.EventHandler(this.ComputersContainer_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnReturnItems);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Location = new System.Drawing.Point(0, 159);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 53);
            this.panel5.TabIndex = 5;
            // 
            // btnReturnItems
            // 
            this.btnReturnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnReturnItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnItems.ForeColor = System.Drawing.Color.White;
            this.btnReturnItems.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnItems.Image")));
            this.btnReturnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnItems.Location = new System.Drawing.Point(-14, -22);
            this.btnReturnItems.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnItems.Name = "btnReturnItems";
            this.btnReturnItems.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReturnItems.Size = new System.Drawing.Size(278, 91);
            this.btnReturnItems.TabIndex = 2;
            this.btnReturnItems.Text = "             Return Items";
            this.btnReturnItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnItems.UseVisualStyleBackColor = false;
            this.btnReturnItems.Click += new System.EventHandler(this.btnReturnItems_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button3);
            this.panel9.Location = new System.Drawing.Point(0, 53);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(248, 53);
            this.panel9.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(190)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 145);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(278, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "              Computer";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pnComputerPSContainer
            // 
            this.pnComputerPSContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(155)))));
            this.pnComputerPSContainer.Controls.Add(this.panel1);
            this.pnComputerPSContainer.Controls.Add(this.panel4);
            this.pnComputerPSContainer.Controls.Add(this.panel13);
            this.pnComputerPSContainer.Controls.Add(this.panel3);
            this.pnComputerPSContainer.Location = new System.Drawing.Point(0, 151);
            this.pnComputerPSContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnComputerPSContainer.Name = "pnComputerPSContainer";
            this.pnComputerPSContainer.Size = new System.Drawing.Size(252, 53);
            this.pnComputerPSContainer.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ComputerPartsInventoryContainer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 53);
            this.panel1.TabIndex = 4;
            // 
            // ComputerPartsInventoryContainer
            // 
            this.ComputerPartsInventoryContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.ComputerPartsInventoryContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerPartsInventoryContainer.ForeColor = System.Drawing.Color.White;
            this.ComputerPartsInventoryContainer.Image = ((System.Drawing.Image)(resources.GetObject("ComputerPartsInventoryContainer.Image")));
            this.ComputerPartsInventoryContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComputerPartsInventoryContainer.Location = new System.Drawing.Point(-20, -19);
            this.ComputerPartsInventoryContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ComputerPartsInventoryContainer.Name = "ComputerPartsInventoryContainer";
            this.ComputerPartsInventoryContainer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.ComputerPartsInventoryContainer.Size = new System.Drawing.Size(278, 91);
            this.ComputerPartsInventoryContainer.TabIndex = 2;
            this.ComputerPartsInventoryContainer.Text = "              Computer Parts Inventory";
            this.ComputerPartsInventoryContainer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComputerPartsInventoryContainer.UseVisualStyleBackColor = false;
            this.ComputerPartsInventoryContainer.Click += new System.EventHandler(this.ComputerPSContainer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddMembers);
            this.panel4.Location = new System.Drawing.Point(0, 53);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 53);
            this.panel4.TabIndex = 4;
            // 
            // btnAddMembers
            // 
            this.btnAddMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnAddMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMembers.ForeColor = System.Drawing.Color.White;
            this.btnAddMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMembers.Image")));
            this.btnAddMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMembers.Location = new System.Drawing.Point(-14, -21);
            this.btnAddMembers.Name = "btnAddMembers";
            this.btnAddMembers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddMembers.Size = new System.Drawing.Size(278, 91);
            this.btnAddMembers.TabIndex = 2;
            this.btnAddMembers.Text = "            Add Product";
            this.btnAddMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMembers.UseVisualStyleBackColor = false;
            this.btnAddMembers.Click += new System.EventHandler(this.formAddProduct_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button1);
            this.panel13.Location = new System.Drawing.Point(0, 106);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(258, 53);
            this.panel13.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-16, -21);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(278, 91);
            this.button1.TabIndex = 2;
            this.button1.Text = "            Add Category";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddSupplier);
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 53);
            this.panel3.TabIndex = 5;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.Image")));
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(-16, -18);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddSupplier.Size = new System.Drawing.Size(278, 91);
            this.btnAddSupplier.TabIndex = 2;
            this.btnAddSupplier.Text = "             Add Supplier";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // pnAdminContainer
            // 
            this.pnAdminContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(155)))));
            this.pnAdminContainer.Controls.Add(this.panel6);
            this.pnAdminContainer.Controls.Add(this.panel12);
            this.pnAdminContainer.Controls.Add(this.panel7);
            this.pnAdminContainer.Location = new System.Drawing.Point(0, 210);
            this.pnAdminContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnAdminContainer.Name = "pnAdminContainer";
            this.pnAdminContainer.Size = new System.Drawing.Size(252, 53);
            this.pnAdminContainer.TabIndex = 10;
            this.pnAdminContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnAdminContainer_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.AdminContainer);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 53);
            this.panel6.TabIndex = 4;
            // 
            // AdminContainer
            // 
            this.AdminContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.AdminContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminContainer.ForeColor = System.Drawing.Color.White;
            this.AdminContainer.Image = ((System.Drawing.Image)(resources.GetObject("AdminContainer.Image")));
            this.AdminContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminContainer.Location = new System.Drawing.Point(-19, -19);
            this.AdminContainer.Margin = new System.Windows.Forms.Padding(0);
            this.AdminContainer.Name = "AdminContainer";
            this.AdminContainer.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.AdminContainer.Size = new System.Drawing.Size(278, 91);
            this.AdminContainer.TabIndex = 2;
            this.AdminContainer.Text = "              Admin";
            this.AdminContainer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminContainer.UseVisualStyleBackColor = false;
            this.AdminContainer.Click += new System.EventHandler(this.AdminContainer_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnManageAdmin);
            this.panel12.Location = new System.Drawing.Point(0, 53);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(258, 53);
            this.panel12.TabIndex = 4;
            // 
            // btnManageAdmin
            // 
            this.btnManageAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnManageAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdmin.ForeColor = System.Drawing.Color.White;
            this.btnManageAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnManageAdmin.Image")));
            this.btnManageAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAdmin.Location = new System.Drawing.Point(-27, -20);
            this.btnManageAdmin.Name = "btnManageAdmin";
            this.btnManageAdmin.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnManageAdmin.Size = new System.Drawing.Size(301, 91);
            this.btnManageAdmin.TabIndex = 2;
            this.btnManageAdmin.Text = "                 Manage Admins";
            this.btnManageAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAdmin.UseVisualStyleBackColor = false;
            this.btnManageAdmin.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAddAdmin);
            this.panel7.Location = new System.Drawing.Point(0, 106);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 53);
            this.panel7.TabIndex = 5;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(225)))));
            this.btnAddAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAdmin.Image")));
            this.btnAddAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdmin.Location = new System.Drawing.Point(-17, -22);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddAdmin.Size = new System.Drawing.Size(278, 91);
            this.btnAddAdmin.TabIndex = 2;
            this.btnAddAdmin.Text = "             Add Admin";
            this.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // pnAbout
            // 
            this.pnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(170)))));
            this.pnAbout.Controls.Add(this.btnAbout);
            this.pnAbout.Location = new System.Drawing.Point(0, 269);
            this.pnAbout.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(252, 53);
            this.pnAbout.TabIndex = 6;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-21, -21);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(278, 91);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "              About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(170)))));
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(0, 328);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(252, 53);
            this.pnLogout.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-19, -19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(278, 91);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "             Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ComputerTransition
            // 
            this.ComputerTransition.Interval = 5;
            this.ComputerTransition.Tick += new System.EventHandler(this.ComputerTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            // 
            // ComputerPSTransition
            // 
            this.ComputerPSTransition.Interval = 5;
            this.ComputerPSTransition.Tick += new System.EventHandler(this.ComputerPSTransition_Tick);
            // 
            // AdminTransition
            // 
            this.AdminTransition.Interval = 5;
            this.AdminTransition.Tick += new System.EventHandler(this.AdminTransition_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.pnmenuContainer);
            this.sidebar.Controls.Add(this.pnComputerPSContainer);
            this.sidebar.Controls.Add(this.pnAdminContainer);
            this.sidebar.Controls.Add(this.pnAbout);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 39);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(250, 620);
            this.sidebar.TabIndex = 12;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1277, 659);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.pnDashboard.ResumeLayout(false);
            this.pnmenuContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnComputerPSContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnAdminContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button ComputerContainer;
        private System.Windows.Forms.Timer ComputerTransition;
        private System.Windows.Forms.FlowLayoutPanel pnmenuContainer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button submenu1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnComputers;
        private System.Windows.Forms.FlowLayoutPanel pnComputerPSContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ComputerPartsInventoryContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddMembers;
        private System.Windows.Forms.Timer ComputerPSTransition;
        private System.Windows.Forms.FlowLayoutPanel pnAdminContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button AdminContainer;
        private System.Windows.Forms.Button btnManageAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Timer AdminTransition;
        private System.Windows.Forms.Button ComputersContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReturnItems;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button3;
    }
}

