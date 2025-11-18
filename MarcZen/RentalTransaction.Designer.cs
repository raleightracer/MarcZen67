namespace MarcZen
{
    partial class RentalTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalTransaction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedButton9 = new RoundedButton();
            this.roundedButton8 = new RoundedButton();
            this.roundedButton7 = new RoundedButton();
            this.roundedButton6 = new RoundedButton();
            this.roundedButton5 = new RoundedButton();
            this.roundedButton4 = new RoundedButton();
            this.btnInventory = new RoundedButton();
            this.btnDashboard = new RoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.lblNameAdmin = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewRental = new RoundedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.btnExport = new RoundedButton();
            this.tbSearch = new RoundedTextBoxContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilter = new RoundedComboBoxContainer();
            this.dataRentalTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRentalTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.roundedButton9);
            this.panel1.Controls.Add(this.roundedButton8);
            this.panel1.Controls.Add(this.roundedButton7);
            this.panel1.Controls.Add(this.roundedButton6);
            this.panel1.Controls.Add(this.roundedButton5);
            this.panel1.Controls.Add(this.roundedButton4);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 1043);
            this.panel1.TabIndex = 12;
            // 
            // roundedButton9
            // 
            this.roundedButton9.BackColor = System.Drawing.Color.Black;
            this.roundedButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton9.CornerRadius = 20;
            this.roundedButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton9.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roundedButton9.FlatAppearance.BorderSize = 5;
            this.roundedButton9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundedButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundedButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton9.ForeColor = System.Drawing.Color.White;
            this.roundedButton9.Location = new System.Drawing.Point(-1, 976);
            this.roundedButton9.Name = "roundedButton9";
            this.roundedButton9.Size = new System.Drawing.Size(308, 46);
            this.roundedButton9.TabIndex = 7;
            this.roundedButton9.Text = "Logout";
            this.roundedButton9.UseVisualStyleBackColor = false;
            this.roundedButton9.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // roundedButton8
            // 
            this.roundedButton8.BackColor = System.Drawing.Color.Black;
            this.roundedButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton8.CornerRadius = 20;
            this.roundedButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roundedButton8.FlatAppearance.BorderSize = 5;
            this.roundedButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundedButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundedButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton8.ForeColor = System.Drawing.Color.White;
            this.roundedButton8.Location = new System.Drawing.Point(-1, 733);
            this.roundedButton8.Name = "roundedButton8";
            this.roundedButton8.Size = new System.Drawing.Size(308, 46);
            this.roundedButton8.TabIndex = 6;
            this.roundedButton8.Text = "Payments";
            this.roundedButton8.UseVisualStyleBackColor = false;
            this.roundedButton8.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // roundedButton7
            // 
            this.roundedButton7.BackColor = System.Drawing.Color.Black;
            this.roundedButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton7.CornerRadius = 20;
            this.roundedButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roundedButton7.FlatAppearance.BorderSize = 5;
            this.roundedButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundedButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton7.ForeColor = System.Drawing.Color.White;
            this.roundedButton7.Location = new System.Drawing.Point(-1, 655);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.Size = new System.Drawing.Size(308, 46);
            this.roundedButton7.TabIndex = 5;
            this.roundedButton7.Text = "Reports";
            this.roundedButton7.UseVisualStyleBackColor = false;
            this.roundedButton7.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // roundedButton6
            // 
            this.roundedButton6.BackColor = System.Drawing.Color.Black;
            this.roundedButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton6.CornerRadius = 20;
            this.roundedButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roundedButton6.FlatAppearance.BorderSize = 5;
            this.roundedButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundedButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton6.ForeColor = System.Drawing.Color.White;
            this.roundedButton6.Location = new System.Drawing.Point(-1, 577);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.Size = new System.Drawing.Size(308, 46);
            this.roundedButton6.TabIndex = 4;
            this.roundedButton6.Text = "Customers";
            this.roundedButton6.UseVisualStyleBackColor = false;
            this.roundedButton6.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // roundedButton5
            // 
            this.roundedButton5.BackColor = System.Drawing.Color.Gray;
            this.roundedButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton5.CornerRadius = 20;
            this.roundedButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton5.Enabled = false;
            this.roundedButton5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roundedButton5.FlatAppearance.BorderSize = 2;
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton5.ForeColor = System.Drawing.Color.White;
            this.roundedButton5.Location = new System.Drawing.Point(-1, 421);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.Size = new System.Drawing.Size(308, 46);
            this.roundedButton5.TabIndex = 3;
            this.roundedButton5.Text = "Rental Transaction";
            this.roundedButton5.UseVisualStyleBackColor = false;
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.Black;
            this.roundedButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedButton4.CornerRadius = 20;
            this.roundedButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.roundedButton4.FlatAppearance.BorderSize = 5;
            this.roundedButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundedButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Location = new System.Drawing.Point(-1, 499);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(308, 46);
            this.roundedButton4.TabIndex = 3;
            this.roundedButton4.Text = "Maintenance";
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Black;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInventory.CornerRadius = 20;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInventory.FlatAppearance.BorderSize = 5;
            this.btnInventory.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(-1, 343);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(308, 46);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashboard.CornerRadius = 20;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDashboard.FlatAppearance.BorderSize = 5;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(-1, 265);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(308, 46);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(27, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 135);
            this.panel2.TabIndex = 0;
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // lblNameAdmin
            // 
            this.lblNameAdmin.AutoSize = true;
            this.lblNameAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAdmin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNameAdmin.Location = new System.Drawing.Point(1535, 49);
            this.lblNameAdmin.Name = "lblNameAdmin";
            this.lblNameAdmin.Size = new System.Drawing.Size(213, 24);
            this.lblNameAdmin.TabIndex = 15;
            this.lblNameAdmin.Text = "Admin - Christina Ponce";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDate.Location = new System.Drawing.Point(1400, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(25, 24);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.vehicleDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataRentalTransactionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1451, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnNewRental
            // 
            this.btnNewRental.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewRental.CornerRadius = 20;
            this.btnNewRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRental.FlatAppearance.BorderSize = 0;
            this.btnNewRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRental.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRental.ForeColor = System.Drawing.Color.White;
            this.btnNewRental.Location = new System.Drawing.Point(1293, 88);
            this.btnNewRental.Name = "btnNewRental";
            this.btnNewRental.Size = new System.Drawing.Size(193, 35);
            this.btnNewRental.TabIndex = 0;
            this.btnNewRental.Text = "New Rental";
            this.btnNewRental.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rental Transaction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rental Transaction";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.AutoScroll = true;
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderThickness = 1;
            this.roundedPanel2.Controls.Add(this.label4);
            this.roundedPanel2.CornerRadius = 15;
            this.roundedPanel2.Location = new System.Drawing.Point(341, 734);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(1528, 354);
            this.roundedPanel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transaction Details";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.btnExport);
            this.roundedPanel1.Controls.Add(this.tbSearch);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.cbFilter);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.dataGridView1);
            this.roundedPanel1.Controls.Add(this.btnNewRental);
            this.roundedPanel1.CornerRadius = 15;
            this.roundedPanel1.Location = new System.Drawing.Point(341, 223);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1528, 495);
            this.roundedPanel1.TabIndex = 10;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Black;
            this.btnExport.CornerRadius = 20;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1292, 23);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(193, 35);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BackColorCustom = System.Drawing.Color.White;
            this.tbSearch.BorderColor = System.Drawing.Color.Black;
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.Location = new System.Drawing.Point(113, 88);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tbSearch.Size = new System.Drawing.Size(377, 35);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextValue = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Filter:";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BackColorCustom = System.Drawing.Color.White;
            this.cbFilter.BorderColor = System.Drawing.Color.Black;
            this.cbFilter.BorderRadius = 10;
            this.cbFilter.Location = new System.Drawing.Point(592, 88);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.cbFilter.SelectedTextValue = "";
            this.cbFilter.Size = new System.Drawing.Size(374, 35);
            this.cbFilter.TabIndex = 8;
            // 
            // dataRentalTransactionBindingSource
            // 
            this.dataRentalTransactionBindingSource.DataMember = "DataRentalTransaction";
            this.dataRentalTransactionBindingSource.DataSource = typeof(MarcZen.DataRentalTransaction);
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "Transaction ID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "Transaction ID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // vehicleDataGridViewTextBoxColumn
            // 
            this.vehicleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vehicleDataGridViewTextBoxColumn.DataPropertyName = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.HeaderText = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.Name = "vehicleDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "Start Date";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "End Date";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // RentalTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNameAdmin);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "RentalTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarcZenRentals";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRentalTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundedButton roundedButton9;
        private RoundedButton roundedButton8;
        private RoundedButton roundedButton7;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton5;
        private RoundedButton roundedButton4;
        private RoundedButton btnInventory;
        private RoundedButton btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Label lblNameAdmin;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundedButton btnNewRental;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label4;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label6;
        private RoundedComboBoxContainer cbFilter;
        private RoundedTextBoxContainer tbSearch;
        private RoundedButton btnExport;
        private System.Windows.Forms.BindingSource dataRentalTransactionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}