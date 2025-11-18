namespace MarcZen
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNameAdmin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new RoundedButton();
            this.btnPayments = new RoundedButton();
            this.btnReports = new RoundedButton();
            this.btnCustomers = new RoundedButton();
            this.btnRentalTransaction = new RoundedButton();
            this.btnMaintenance = new RoundedButton();
            this.btnInventory = new RoundedButton();
            this.btnDashboard = new RoundedButton();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.roundedPanel8 = new RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roundedPanel1 = new RoundedPanel();
            this.roundedPanel2 = new RoundedPanel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label8 = new System.Windows.Forms.Label();
            this.roundedPanel7 = new RoundedPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.roundedPanel6 = new RoundedPanel();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.roundedPictureBox4 = new RoundedPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roundedPanel5 = new RoundedPanel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.roundedPictureBox3 = new RoundedPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel4 = new RoundedPanel();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.roundedPictureBox2 = new RoundedPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new RoundedPanel();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.roundedPictureBox1 = new RoundedPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.roundedPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox4)).BeginInit();
            this.roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox3)).BeginInit();
            this.roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox2)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDate.Location = new System.Drawing.Point(1401, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(25, 24);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "...";
            // 
            // lblNameAdmin
            // 
            this.lblNameAdmin.AutoSize = true;
            this.lblNameAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAdmin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNameAdmin.Location = new System.Drawing.Point(1536, 50);
            this.lblNameAdmin.Name = "lblNameAdmin";
            this.lblNameAdmin.Size = new System.Drawing.Size(213, 24);
            this.lblNameAdmin.TabIndex = 16;
            this.lblNameAdmin.Text = "Admin - Christina Ponce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(28, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 135);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnPayments);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnRentalTransaction);
            this.panel1.Controls.Add(this.btnMaintenance);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 1043);
            this.panel1.TabIndex = 13;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.CornerRadius = 20;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 5;
            this.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 977);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(308, 46);
            this.btnLogout.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Black;
            this.btnPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayments.CornerRadius = 20;
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPayments.FlatAppearance.BorderSize = 5;
            this.btnPayments.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Location = new System.Drawing.Point(0, 734);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(308, 46);
            this.btnPayments.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Black;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReports.CornerRadius = 20;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReports.FlatAppearance.BorderSize = 5;
            this.btnReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 656);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(308, 46);
            this.btnReports.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Black;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomers.CornerRadius = 20;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCustomers.FlatAppearance.BorderSize = 5;
            this.btnCustomers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(0, 578);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(308, 46);
            this.btnCustomers.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRentalTransaction
            // 
            this.btnRentalTransaction.BackColor = System.Drawing.Color.Black;
            this.btnRentalTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRentalTransaction.CornerRadius = 20;
            this.btnRentalTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentalTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRentalTransaction.FlatAppearance.BorderSize = 2;
            this.btnRentalTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalTransaction.ForeColor = System.Drawing.Color.White;
            this.btnRentalTransaction.Location = new System.Drawing.Point(0, 422);
            this.btnRentalTransaction.Name = "btnRentalTransaction";
            this.btnRentalTransaction.Size = new System.Drawing.Size(308, 46);
            this.btnRentalTransaction.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnRentalTransaction.TabIndex = 3;
            this.btnRentalTransaction.Text = "Rental Transaction";
            this.btnRentalTransaction.UseVisualStyleBackColor = false;
            this.btnRentalTransaction.Click += new System.EventHandler(this.btnRentalTransaction_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.Black;
            this.btnMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaintenance.CornerRadius = 20;
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMaintenance.FlatAppearance.BorderSize = 5;
            this.btnMaintenance.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 500);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(308, 46);
            this.btnMaintenance.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnMaintenance.TabIndex = 3;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
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
            this.btnInventory.Location = new System.Drawing.Point(0, 344);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(308, 46);
            this.btnInventory.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Gray;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashboard.CornerRadius = 20;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Enabled = false;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDashboard.FlatAppearance.BorderSize = 5;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 266);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(308, 46);
            this.btnDashboard.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 1000;
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.White;
            this.roundedPanel8.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel8.BorderThickness = 1;
            this.roundedPanel8.Controls.Add(this.label4);
            this.roundedPanel8.Controls.Add(this.dataGridView1);
            this.roundedPanel8.CornerRadius = 15;
            this.roundedPanel8.Location = new System.Drawing.Point(345, 760);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(1498, 283);
            this.roundedPanel8.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Income Trend";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1438, 202);
            this.dataGridView1.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.AutoScroll = true;
            this.roundedPanel1.BackColor = System.Drawing.Color.Gray;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.roundedPanel7);
            this.roundedPanel1.Controls.Add(this.roundedPanel6);
            this.roundedPanel1.Controls.Add(this.roundedPanel5);
            this.roundedPanel1.Controls.Add(this.roundedPanel4);
            this.roundedPanel1.Controls.Add(this.roundedPanel3);
            this.roundedPanel1.CornerRadius = 15;
            this.roundedPanel1.Location = new System.Drawing.Point(345, 224);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1498, 512);
            this.roundedPanel1.TabIndex = 11;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.BorderThickness = 1;
            this.roundedPanel2.Controls.Add(this.cartesianChart1);
            this.roundedPanel2.Controls.Add(this.label8);
            this.roundedPanel2.CornerRadius = 15;
            this.roundedPanel2.Location = new System.Drawing.Point(778, 198);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(688, 291);
            this.roundedPanel2.TabIndex = 7;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(26, 49);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(636, 231);
            this.cartesianChart1.TabIndex = 9;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Active Rentals";
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.BackColor = System.Drawing.Color.White;
            this.roundedPanel7.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel7.BorderThickness = 1;
            this.roundedPanel7.Controls.Add(this.chart1);
            this.roundedPanel7.Controls.Add(this.label7);
            this.roundedPanel7.CornerRadius = 15;
            this.roundedPanel7.Location = new System.Drawing.Point(28, 198);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(688, 291);
            this.roundedPanel7.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 49);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(636, 222);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Income Trend";
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.White;
            this.roundedPanel6.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel6.BorderThickness = 1;
            this.roundedPanel6.Controls.Add(this.lblMaintenance);
            this.roundedPanel6.Controls.Add(this.roundedPictureBox4);
            this.roundedPanel6.Controls.Add(this.label6);
            this.roundedPanel6.CornerRadius = 15;
            this.roundedPanel6.Location = new System.Drawing.Point(1153, 26);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(313, 140);
            this.roundedPanel6.TabIndex = 5;
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.AutoSize = true;
            this.lblMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.Location = new System.Drawing.Point(91, 18);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(39, 42);
            this.lblMaintenance.TabIndex = 11;
            this.lblMaintenance.Text = "0";
            // 
            // roundedPictureBox4
            // 
            this.roundedPictureBox4.BackColor = System.Drawing.Color.LightCoral;
            this.roundedPictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox4.BackgroundImage")));
            this.roundedPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPictureBox4.BorderColor = System.Drawing.Color.Black;
            this.roundedPictureBox4.BorderThickness = 2;
            this.roundedPictureBox4.CornerRadius = 20;
            this.roundedPictureBox4.Location = new System.Drawing.Point(27, 16);
            this.roundedPictureBox4.Name = "roundedPictureBox4";
            this.roundedPictureBox4.Size = new System.Drawing.Size(49, 50);
            this.roundedPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundedPictureBox4.TabIndex = 10;
            this.roundedPictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Maintenance";
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.White;
            this.roundedPanel5.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel5.BorderThickness = 1;
            this.roundedPanel5.Controls.Add(this.lblRevenue);
            this.roundedPanel5.Controls.Add(this.roundedPictureBox3);
            this.roundedPanel5.Controls.Add(this.label3);
            this.roundedPanel5.CornerRadius = 15;
            this.roundedPanel5.Location = new System.Drawing.Point(778, 26);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(313, 140);
            this.roundedPanel5.TabIndex = 4;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(90, 14);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(39, 42);
            this.lblRevenue.TabIndex = 10;
            this.lblRevenue.Text = "0";
            // 
            // roundedPictureBox3
            // 
            this.roundedPictureBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.roundedPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundedPictureBox3.BorderColor = System.Drawing.Color.Black;
            this.roundedPictureBox3.BorderThickness = 2;
            this.roundedPictureBox3.CornerRadius = 20;
            this.roundedPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox3.Image")));
            this.roundedPictureBox3.Location = new System.Drawing.Point(26, 12);
            this.roundedPictureBox3.Name = "roundedPictureBox3";
            this.roundedPictureBox3.Size = new System.Drawing.Size(49, 50);
            this.roundedPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundedPictureBox3.TabIndex = 9;
            this.roundedPictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Revenue";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.White;
            this.roundedPanel4.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel4.BorderThickness = 1;
            this.roundedPanel4.Controls.Add(this.lblCustomers);
            this.roundedPanel4.Controls.Add(this.roundedPictureBox2);
            this.roundedPanel4.Controls.Add(this.label1);
            this.roundedPanel4.CornerRadius = 15;
            this.roundedPanel4.Location = new System.Drawing.Point(403, 26);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(313, 140);
            this.roundedPanel4.TabIndex = 3;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(86, 14);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(39, 42);
            this.lblCustomers.TabIndex = 9;
            this.lblCustomers.Text = "0";
            // 
            // roundedPictureBox2
            // 
            this.roundedPictureBox2.BackColor = System.Drawing.Color.White;
            this.roundedPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox2.BackgroundImage")));
            this.roundedPictureBox2.BorderColor = System.Drawing.Color.Black;
            this.roundedPictureBox2.BorderThickness = 2;
            this.roundedPictureBox2.CornerRadius = 20;
            this.roundedPictureBox2.Location = new System.Drawing.Point(21, 12);
            this.roundedPictureBox2.Name = "roundedPictureBox2";
            this.roundedPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.roundedPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundedPictureBox2.TabIndex = 8;
            this.roundedPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Customers";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel3.BorderThickness = 1;
            this.roundedPanel3.Controls.Add(this.lblVehicles);
            this.roundedPanel3.Controls.Add(this.roundedPictureBox1);
            this.roundedPanel3.Controls.Add(this.label2);
            this.roundedPanel3.CornerRadius = 15;
            this.roundedPanel3.Location = new System.Drawing.Point(28, 26);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(313, 140);
            this.roundedPanel3.TabIndex = 2;
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicles.Location = new System.Drawing.Point(86, 14);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(39, 42);
            this.lblVehicles.TabIndex = 8;
            this.lblVehicles.Text = "0";
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.roundedPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.BackgroundImage")));
            this.roundedPictureBox1.BorderColor = System.Drawing.Color.Black;
            this.roundedPictureBox1.BorderThickness = 2;
            this.roundedPictureBox1.CornerRadius = 20;
            this.roundedPictureBox1.Location = new System.Drawing.Point(21, 12);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.roundedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundedPictureBox1.TabIndex = 7;
            this.roundedPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Vehicles";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.roundedPanel8);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNameAdmin);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarcZenRentals";
            this.panel1.ResumeLayout(false);
            this.roundedPanel8.ResumeLayout(false);
            this.roundedPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel7.ResumeLayout(false);
            this.roundedPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox4)).EndInit();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox3)).EndInit();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox2)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNameAdmin;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label5;
        private RoundedButton btnLogout;
        private RoundedButton btnPayments;
        private RoundedButton btnReports;
        private RoundedButton btnCustomers;
        private RoundedButton btnMaintenance;
        private RoundedButton btnInventory;
        private RoundedButton btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private RoundedButton btnRentalTransaction;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel7;
        private RoundedPanel roundedPanel6;
        private RoundedPanel roundedPanel5;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerDate;
        private RoundedPictureBox roundedPictureBox1;
        private RoundedPictureBox roundedPictureBox2;
        private RoundedPictureBox roundedPictureBox4;
        private RoundedPictureBox roundedPictureBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblCustomers;
    }
}