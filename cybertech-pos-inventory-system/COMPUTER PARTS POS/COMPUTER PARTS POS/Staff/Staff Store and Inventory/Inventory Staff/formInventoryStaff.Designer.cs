namespace COMPUTER_PARTS_POS.COMPUTER_PARTS_POS.Staff.Staff_Store_and_Inventory.Inventory_Staff
{
    partial class formInventoryStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInventoryStaff));
            this.panel13 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.ComputerPSTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnComputerPSContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComputerPartsInventoryContainer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddMembers = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.pnComputerPSContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(-9, -23);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
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
            this.btnAddSupplier.Location = new System.Drawing.Point(-9, -23);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnAddSupplier.Size = new System.Drawing.Size(278, 91);
            this.btnAddSupplier.TabIndex = 2;
            this.btnAddSupplier.Text = "             Add Supplier";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // ComputerPSTransition
            // 
            this.ComputerPSTransition.Interval = 5;
            this.ComputerPSTransition.Tick += new System.EventHandler(this.ComputerPSTransition_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.sidebar.Controls.Add(this.pnComputerPSContainer);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 39);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(250, 573);
            this.sidebar.TabIndex = 14;
            // 
            // pnLogout
            // 
            this.pnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(170)))));
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(0, 84);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(252, 53);
            this.pnLogout.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-15, -20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(278, 91);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "             Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnComputerPSContainer
            // 
            this.pnComputerPSContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(155)))));
            this.pnComputerPSContainer.Controls.Add(this.panel1);
            this.pnComputerPSContainer.Controls.Add(this.panel4);
            this.pnComputerPSContainer.Controls.Add(this.panel13);
            this.pnComputerPSContainer.Controls.Add(this.panel3);
            this.pnComputerPSContainer.Location = new System.Drawing.Point(0, 26);
            this.pnComputerPSContainer.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
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
            this.panel1.Size = new System.Drawing.Size(258, 53);
            this.panel1.TabIndex = 4;
            // 
            // ComputerPartsInventoryContainer
            // 
            this.ComputerPartsInventoryContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.ComputerPartsInventoryContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerPartsInventoryContainer.ForeColor = System.Drawing.Color.White;
            this.ComputerPartsInventoryContainer.Image = ((System.Drawing.Image)(resources.GetObject("ComputerPartsInventoryContainer.Image")));
            this.ComputerPartsInventoryContainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComputerPartsInventoryContainer.Location = new System.Drawing.Point(-12, -20);
            this.ComputerPartsInventoryContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ComputerPartsInventoryContainer.Name = "ComputerPartsInventoryContainer";
            this.ComputerPartsInventoryContainer.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
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
            this.btnAddMembers.Location = new System.Drawing.Point(-8, -22);
            this.btnAddMembers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMembers.Name = "btnAddMembers";
            this.btnAddMembers.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.btnAddMembers.Size = new System.Drawing.Size(278, 91);
            this.btnAddMembers.TabIndex = 2;
            this.btnAddMembers.Text = "            Add Product";
            this.btnAddMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMembers.UseVisualStyleBackColor = false;
            this.btnAddMembers.Click += new System.EventHandler(this.formAddProduct_Click);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Controls.Add(this.label10);
            this.formPanel.Controls.Add(this.btnHam);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1259, 39);
            this.formPanel.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(56, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 26);
            this.label10.TabIndex = 88;
            this.label10.Text = "CYBERTECH";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(8, 6);
            this.btnHam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(31, 25);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // formInventoryStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 612);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.formPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "formInventoryStaff";
            this.Text = "formInventoryStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formInventoryStaff_Load);
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.pnComputerPSContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer ComputerPSTransition;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.FlowLayoutPanel pnComputerPSContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ComputerPartsInventoryContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddMembers;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
    }
}