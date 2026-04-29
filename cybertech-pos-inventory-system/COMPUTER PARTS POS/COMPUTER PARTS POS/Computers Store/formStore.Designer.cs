using System.Drawing;
using System.Windows.Forms;

namespace ComputerPartsPOS
{
    partial class formStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStore));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.dataGridView_Product_Store = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.cmbFilterCategory = new ReaLTaiizor.Controls.PoisonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtOrderedAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCartTotalAmounnt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEmptyCartItems = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDecreaseQuantity = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnIncreaseQuantity = new System.Windows.Forms.Button();
            this.dataGridView_Cart = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDecreaseQuantityCart = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnIncreaseQuantityCart = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product_Store)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.btnIncreaseQuantityCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogout
            // 
            this.pnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLogout.Controls.Add(this.btnAddToCart);
            this.pnLogout.Location = new System.Drawing.Point(558, 656);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(191, 81);
            this.pnLogout.TabIndex = 52;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.Location = new System.Drawing.Point(-20, -14);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnAddToCart.Size = new System.Drawing.Size(223, 112);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "         ADD TO CART";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // dataGridView_Product_Store
            // 
            this.dataGridView_Product_Store.AllowUserToAddRows = false;
            this.dataGridView_Product_Store.AllowUserToDeleteRows = false;
            this.dataGridView_Product_Store.AllowUserToResizeColumns = false;
            this.dataGridView_Product_Store.AllowUserToResizeRows = false;
            this.dataGridView_Product_Store.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Product_Store.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Product_Store.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Product_Store.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Product_Store.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Product_Store.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Product_Store.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_Product_Store.ColumnHeadersHeight = 40;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Product_Store.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_Product_Store.EnableHeadersVisualStyles = false;
            this.dataGridView_Product_Store.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView_Product_Store.Location = new System.Drawing.Point(24, 96);
            this.dataGridView_Product_Store.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Product_Store.Name = "dataGridView_Product_Store";
            this.dataGridView_Product_Store.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Product_Store.RowHeadersVisible = false;
            this.dataGridView_Product_Store.RowHeadersWidth = 51;
            this.dataGridView_Product_Store.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Product_Store.Size = new System.Drawing.Size(753, 460);
            this.dataGridView_Product_Store.TabIndex = 105;
            this.dataGridView_Product_Store.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Product_Store_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnCheckout);
            this.panel2.Location = new System.Drawing.Point(1136, 650);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 81);
            this.panel2.TabIndex = 53;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(-11, -16);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnCheckout.Size = new System.Drawing.Size(223, 112);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "         CHECKOUT";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.DisplayFocus = true;
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.ItemHeight = 24;
            this.cmbFilterCategory.Location = new System.Drawing.Point(24, 42);
            this.cmbFilterCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(241, 30);
            this.cmbFilterCategory.TabIndex = 89;
            this.cmbFilterCategory.UseSelectable = true;
            this.cmbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 580);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 88;
            this.label4.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 87;
            this.label2.Text = "PRICE";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(467, 576);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(127, 36);
            this.txtQuantity.TabIndex = 86;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtSearchbar
            // 
            this.txtSearchbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbar.Location = new System.Drawing.Point(359, 42);
            this.txtSearchbar.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchbar.Multiline = true;
            this.txtSearchbar.Name = "txtSearchbar";
            this.txtSearchbar.Size = new System.Drawing.Size(389, 36);
            this.txtSearchbar.TabIndex = 90;
            this.txtSearchbar.TextChanged += new System.EventHandler(this.txtSearchbar_TextChanged);
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(1148, 480);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayment.Multiline = true;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(177, 36);
            this.txtPayment.TabIndex = 91;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 575);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 42);
            this.panel1.TabIndex = 93;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(264, 5);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(148, 32);
            this.txtPrice.TabIndex = 90;
            this.txtPrice.Text = "0";
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.txtOrderedAmount);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(21, 656);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 42);
            this.panel3.TabIndex = 94;
            // 
            // txtOrderedAmount
            // 
            this.txtOrderedAmount.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderedAmount.ForeColor = System.Drawing.Color.White;
            this.txtOrderedAmount.Location = new System.Drawing.Point(268, 6);
            this.txtOrderedAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtOrderedAmount.Name = "txtOrderedAmount";
            this.txtOrderedAmount.Size = new System.Drawing.Size(144, 32);
            this.txtOrderedAmount.TabIndex = 89;
            this.txtOrderedAmount.Text = "0";
            this.txtOrderedAmount.Click += new System.EventHandler(this.txtOrderedAmount_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 87;
            this.label1.Text = "ORDERED AMOUNT";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 32);
            this.label7.TabIndex = 96;
            this.label7.Text = "CASH AMOUNT";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(794, 565);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 32);
            this.label8.TabIndex = 97;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Alata", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(797, 524);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(548, 32);
            this.label9.TabIndex = 99;
            this.label9.Text = "___________________________________________";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtCartTotalAmounnt);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(797, 426);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 42);
            this.panel4.TabIndex = 100;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(225, 5);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 32);
            this.label16.TabIndex = 105;
            this.label16.Text = "₱";
            // 
            // txtCartTotalAmounnt
            // 
            this.txtCartTotalAmounnt.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartTotalAmounnt.ForeColor = System.Drawing.Color.White;
            this.txtCartTotalAmounnt.Location = new System.Drawing.Point(349, 5);
            this.txtCartTotalAmounnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCartTotalAmounnt.Name = "txtCartTotalAmounnt";
            this.txtCartTotalAmounnt.Size = new System.Drawing.Size(185, 32);
            this.txtCartTotalAmounnt.TabIndex = 88;
            this.txtCartTotalAmounnt.Text = "0000.00";
            this.txtCartTotalAmounnt.Click += new System.EventHandler(this.txtCartTotalAmounnt_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 32);
            this.label10.TabIndex = 87;
            this.label10.Text = "TOTAL";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(794, 570);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(296, 32);
            this.label11.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Alata", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(797, 609);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(548, 32);
            this.label12.TabIndex = 102;
            this.label12.Text = "___________________________________________";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(797, 570);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(296, 32);
            this.label13.TabIndex = 103;
            this.label13.Text = "CHANGE";
            // 
            // txtChange
            // 
            this.txtChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChange.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Black;
            this.txtChange.Location = new System.Drawing.Point(1153, 570);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(144, 32);
            this.txtChange.TabIndex = 89;
            this.txtChange.Text = "00.00";
            this.txtChange.Click += new System.EventHandler(this.txtChange_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1101, 570);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 32);
            this.label15.TabIndex = 104;
            this.label15.Text = "₱";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnEmptyCartItems);
            this.panel5.Location = new System.Drawing.Point(956, 336);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 76);
            this.panel5.TabIndex = 54;
            // 
            // btnEmptyCartItems
            // 
            this.btnEmptyCartItems.BackColor = System.Drawing.Color.Chocolate;
            this.btnEmptyCartItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyCartItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyCartItems.ForeColor = System.Drawing.Color.White;
            this.btnEmptyCartItems.Image = ((System.Drawing.Image)(resources.GetObject("btnEmptyCartItems.Image")));
            this.btnEmptyCartItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmptyCartItems.Location = new System.Drawing.Point(-28, -17);
            this.btnEmptyCartItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmptyCartItems.Name = "btnEmptyCartItems";
            this.btnEmptyCartItems.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnEmptyCartItems.Size = new System.Drawing.Size(223, 112);
            this.btnEmptyCartItems.TabIndex = 2;
            this.btnEmptyCartItems.Text = "          EMPTY CART";
            this.btnEmptyCartItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmptyCartItems.UseVisualStyleBackColor = false;
            this.btnEmptyCartItems.Click += new System.EventHandler(this.btnEmptyCartItems_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btnRemoveItem);
            this.panel6.Location = new System.Drawing.Point(1154, 336);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 76);
            this.panel6.TabIndex = 55;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Red;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Image")));
            this.btnRemoveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItem.Location = new System.Drawing.Point(-27, -20);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnRemoveItem.Size = new System.Drawing.Size(223, 112);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "          REMOVE ITEM";
            this.btnRemoveItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.btnDecreaseQuantity);
            this.panel7.Location = new System.Drawing.Point(687, 571);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(67, 49);
            this.panel7.TabIndex = 55;
            // 
            // btnDecreaseQuantity
            // 
            this.btnDecreaseQuantity.BackColor = System.Drawing.Color.Red;
            this.btnDecreaseQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseQuantity.ForeColor = System.Drawing.Color.White;
            this.btnDecreaseQuantity.Image = ((System.Drawing.Image)(resources.GetObject("btnDecreaseQuantity.Image")));
            this.btnDecreaseQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecreaseQuantity.Location = new System.Drawing.Point(-20, -32);
            this.btnDecreaseQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecreaseQuantity.Name = "btnDecreaseQuantity";
            this.btnDecreaseQuantity.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnDecreaseQuantity.Size = new System.Drawing.Size(93, 112);
            this.btnDecreaseQuantity.TabIndex = 2;
            this.btnDecreaseQuantity.Text = "          ";
            this.btnDecreaseQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecreaseQuantity.UseVisualStyleBackColor = false;
            this.btnDecreaseQuantity.Click += new System.EventHandler(this.btnDecreaseQuantity_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.btnIncreaseQuantity);
            this.panel8.Location = new System.Drawing.Point(608, 570);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(67, 50);
            this.panel8.TabIndex = 56;
            // 
            // btnIncreaseQuantity
            // 
            this.btnIncreaseQuantity.BackColor = System.Drawing.Color.SeaGreen;
            this.btnIncreaseQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseQuantity.ForeColor = System.Drawing.Color.White;
            this.btnIncreaseQuantity.Image = ((System.Drawing.Image)(resources.GetObject("btnIncreaseQuantity.Image")));
            this.btnIncreaseQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncreaseQuantity.Location = new System.Drawing.Point(-22, -22);
            this.btnIncreaseQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncreaseQuantity.Name = "btnIncreaseQuantity";
            this.btnIncreaseQuantity.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnIncreaseQuantity.Size = new System.Drawing.Size(89, 91);
            this.btnIncreaseQuantity.TabIndex = 3;
            this.btnIncreaseQuantity.Text = "         ";
            this.btnIncreaseQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncreaseQuantity.UseVisualStyleBackColor = false;
            this.btnIncreaseQuantity.Click += new System.EventHandler(this.btnIncreaseQuantity_Click);
            // 
            // dataGridView_Cart
            // 
            this.dataGridView_Cart.AllowUserToAddRows = false;
            this.dataGridView_Cart.AllowUserToDeleteRows = false;
            this.dataGridView_Cart.AllowUserToResizeColumns = false;
            this.dataGridView_Cart.AllowUserToResizeRows = false;
            this.dataGridView_Cart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Cart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Cart.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_Cart.ColumnHeadersHeight = 40;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Cart.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_Cart.EnableHeadersVisualStyles = false;
            this.dataGridView_Cart.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView_Cart.Location = new System.Drawing.Point(797, 96);
            this.dataGridView_Cart.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Cart.Name = "dataGridView_Cart";
            this.dataGridView_Cart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Cart.RowHeadersVisible = false;
            this.dataGridView_Cart.RowHeadersWidth = 51;
            this.dataGridView_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Cart.Size = new System.Drawing.Size(548, 233);
            this.dataGridView_Cart.TabIndex = 107;
            this.dataGridView_Cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Cart_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1101, 485);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 32);
            this.label3.TabIndex = 108;
            this.label3.Text = "₱";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.btnDecreaseQuantityCart);
            this.panel10.Location = new System.Drawing.Point(876, 352);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(68, 49);
            this.panel10.TabIndex = 57;
            // 
            // btnDecreaseQuantityCart
            // 
            this.btnDecreaseQuantityCart.BackColor = System.Drawing.Color.Red;
            this.btnDecreaseQuantityCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecreaseQuantityCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecreaseQuantityCart.ForeColor = System.Drawing.Color.White;
            this.btnDecreaseQuantityCart.Image = ((System.Drawing.Image)(resources.GetObject("btnDecreaseQuantityCart.Image")));
            this.btnDecreaseQuantityCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecreaseQuantityCart.Location = new System.Drawing.Point(-18, -33);
            this.btnDecreaseQuantityCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecreaseQuantityCart.Name = "btnDecreaseQuantityCart";
            this.btnDecreaseQuantityCart.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnDecreaseQuantityCart.Size = new System.Drawing.Size(93, 112);
            this.btnDecreaseQuantityCart.TabIndex = 2;
            this.btnDecreaseQuantityCart.Text = "          ";
            this.btnDecreaseQuantityCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecreaseQuantityCart.UseVisualStyleBackColor = false;
            this.btnDecreaseQuantityCart.Click += new System.EventHandler(this.btnDecreaseQuantityCart_Click);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel11.Controls.Add(this.label14);
            this.panel11.Location = new System.Drawing.Point(797, 52);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(548, 42);
            this.panel11.TabIndex = 106;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(507, 32);
            this.label14.TabIndex = 87;
            this.label14.Text = "CART";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIncreaseQuantityCart
            // 
            this.btnIncreaseQuantityCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncreaseQuantityCart.Controls.Add(this.button1);
            this.btnIncreaseQuantityCart.Location = new System.Drawing.Point(797, 352);
            this.btnIncreaseQuantityCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncreaseQuantityCart.Name = "btnIncreaseQuantityCart";
            this.btnIncreaseQuantityCart.Size = new System.Drawing.Size(67, 50);
            this.btnIncreaseQuantityCart.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-18, -22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(89, 91);
            this.button1.TabIndex = 3;
            this.button1.Text = "         ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnIncreaseQuantityCart_Click);
            // 
            // formStore
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1368, 763);
            this.Controls.Add(this.btnIncreaseQuantityCart);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Cart);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtSearchbar);
            this.Controls.Add(this.cmbFilterCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_Product_Store);
            this.Controls.Add(this.pnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formStore";
            this.ShowIcon = false;
            this.Text = "formComputerStore";
            this.Load += new System.EventHandler(this.formComputerStore_Load);
            this.pnLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product_Store)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.btnIncreaseQuantityCart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnAddToCart;
        public System.Windows.Forms.DataGridView dataGridView_Product_Store;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCheckout;
        private ReaLTaiizor.Controls.PoisonComboBox cmbFilterCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSearchbar;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtOrderedAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtCartTotalAmounnt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtChange;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEmptyCartItems;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label txtPrice;
        private Panel panel7;
        private Button btnDecreaseQuantity;
        private Panel panel8;
        private Button btnIncreaseQuantity;
        public DataGridView dataGridView_Cart;
        private Label label3;
        private Panel panel10;
        private Button btnDecreaseQuantityCart;
        private Panel panel11;
        private Label label14;
        private Panel btnIncreaseQuantityCart;
        private Button button1;
    }
}