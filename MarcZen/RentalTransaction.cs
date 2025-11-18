using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcZen
{
    public partial class RentalTransaction : Form
    {
        public RentalTransaction()
        {
            InitializeComponent();
        }

        private void MarcZen_Load(object sender, EventArgs e)
        {
            // Start the timer on load
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateDateTimeLabel();
        }

        private void UpdateDateTimeLabel()
        {
            DateTime now = DateTime.Now; // local system time
            lblDate.Text = now.ToString("dddd, MMMM dd yyyy  |  hh:mm tt");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var form1 = new Dashboard();
            form1.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form1.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            var form2 = new Inventory();
            form2.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form2.Show();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            var form4 = new Maintenance();
            form4.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form4.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var form5 = new Customers();
            form5.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form5.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form6 = new Reports();
            form6.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form6.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            var form7 = new Payments();
            form7.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form7.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var form8 = new Login();
            form8.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form8.Show();
        }

    }
}
