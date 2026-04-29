namespace ComputerPartsPOS
{
    partial class formSalesHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSalesHistory));
            this.DateTimeStartFrom = new ReaLTaiizor.Controls.PoisonDateTime();
            this.DateTimeToEnd = new ReaLTaiizor.Controls.PoisonDateTime();
            this.dataGridView_Sales_History = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sales_History)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimeStartFrom
            // 
            this.DateTimeStartFrom.Location = new System.Drawing.Point(423, 116);
            this.DateTimeStartFrom.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimeStartFrom.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateTimeStartFrom.Name = "DateTimeStartFrom";
            this.DateTimeStartFrom.Size = new System.Drawing.Size(303, 30);
            this.DateTimeStartFrom.TabIndex = 30;
            this.DateTimeStartFrom.ValueChanged += new System.EventHandler(this.DateTimeStartFrom_ValueChanged);
            // 
            // DateTimeToEnd
            // 
            this.DateTimeToEnd.Location = new System.Drawing.Point(840, 116);
            this.DateTimeToEnd.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimeToEnd.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateTimeToEnd.Name = "DateTimeToEnd";
            this.DateTimeToEnd.Size = new System.Drawing.Size(303, 30);
            this.DateTimeToEnd.TabIndex = 31;
            this.DateTimeToEnd.ValueChanged += new System.EventHandler(this.DateTimeToEnd_ValueChanged);
            // 
            // dataGridView_Sales_History
            // 
            this.dataGridView_Sales_History.AllowUserToAddRows = false;
            this.dataGridView_Sales_History.AllowUserToDeleteRows = false;
            this.dataGridView_Sales_History.AllowUserToResizeColumns = false;
            this.dataGridView_Sales_History.AllowUserToResizeRows = false;
            this.dataGridView_Sales_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Sales_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sales_History.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Sales_History.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Sales_History.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Sales_History.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Sales_History.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Sales_History.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Sales_History.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Sales_History.EnableHeadersVisualStyles = false;
            this.dataGridView_Sales_History.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView_Sales_History.Location = new System.Drawing.Point(135, 224);
            this.dataGridView_Sales_History.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Sales_History.Name = "dataGridView_Sales_History";
            this.dataGridView_Sales_History.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Sales_History.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Sales_History.RowHeadersVisible = false;
            this.dataGridView_Sales_History.RowHeadersWidth = 51;
            this.dataGridView_Sales_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Sales_History.Size = new System.Drawing.Size(1087, 278);
            this.dataGridView_Sales_History.TabIndex = 106;
            this.dataGridView_Sales_History.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sales_History_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 109;
            this.label1.Text = "Date Range:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(788, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 32);
            this.label2.TabIndex = 110;
            this.label2.Text = "To:";
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel11.Controls.Add(this.label14);
            this.panel11.Location = new System.Drawing.Point(135, 180);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1087, 42);
            this.panel11.TabIndex = 111;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1028, 32);
            this.label14.TabIndex = 87;
            this.label14.Text = "SALES HISTORY";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 42);
            this.panel1.TabIndex = 112;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 721);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 42);
            this.panel2.TabIndex = 113;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnResetFilter);
            this.panel9.Location = new System.Drawing.Point(1167, 108);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(55, 49);
            this.panel9.TabIndex = 114;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnResetFilter.Image")));
            this.btnResetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilter.Location = new System.Drawing.Point(-29, -22);
            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnResetFilter.Size = new System.Drawing.Size(89, 91);
            this.btnResetFilter.TabIndex = 3;
            this.btnResetFilter.Text = "         ";
            this.btnResetFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLogout.Controls.Add(this.btnPrint);
            this.pnLogout.Location = new System.Drawing.Point(1036, 555);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(191, 81);
            this.pnLogout.TabIndex = 125;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(-20, -14);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnPrint.Size = new System.Drawing.Size(223, 112);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "         PRINT SALES";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrintSales_Click);
            // 
            // formSalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1368, 763);
            this.Controls.Add(this.pnLogout);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Sales_History);
            this.Controls.Add(this.DateTimeToEnd);
            this.Controls.Add(this.DateTimeStartFrom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formSalesHistory";
            this.Text = "formSubmenu2";
            this.Load += new System.EventHandler(this.SalesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sales_History)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonDateTime DateTimeStartFrom;
        private ReaLTaiizor.Controls.PoisonDateTime DateTimeToEnd;
        public System.Windows.Forms.DataGridView dataGridView_Sales_History;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnPrint;
    }
}