using System;
using System.Windows.Forms;

namespace MarcZen
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();

            // Ensure the timer is hooked and running (designer declares timerDate)
            if (timerDate != null)
            {
                timerDate.Tick -= Timer_Tick; // avoid double-wiring if designer wired it already
                timerDate.Tick += Timer_Tick;
                timerDate.Interval = 1000;
                timerDate.Start();
            }

            UpdateDateTimeLabel();
        }

        private void UpdateDateTimeLabel()
        {
            if (lblDate != null)
                lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy  |  hh:mm tt");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
            if (lblDate != null)
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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

        private void btnRentalTransaction_Click(object sender, EventArgs e)
        {
            var form3 = new RentalTransaction();
            form3.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form3.Show();
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
