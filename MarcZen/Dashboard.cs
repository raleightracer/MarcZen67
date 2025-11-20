using System;
using System.Windows.Forms;

namespace MarcZen
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            // Use the designer timer if present
            if (timerDate != null)
            {
                // prevent double-wiring
                timerDate.Tick -= Timer_Tick;
                timerDate.Tick += Timer_Tick;
                timerDate.Interval = 1000;
                timerDate.Start();
            }

            UpdateDateTimeLabel();
        }

        private void UpdateDateTimeLabel()
        {
            if (lblDate == null) return;
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form6 = new Reports();
            form6.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form6.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            // Create and show Payments inside try/catch so construction/load exceptions don't close the dashboard.
            try
            {
                var form7 = new Payments();

                // Restore the dashboard when payments closes instead of closing the application
                form7.FormClosed += (s, args) => this.Show();

                this.Hide(); // keep application message loop running
                form7.Show();
            }
            catch (Exception ex)
            {
                // If Payments constructor or Load throws, report and keep dashboard visible
                MessageBox.Show("Failed to open Payments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // previously used `Login` which likely does not exist — use LoginSigninLogout
            var form8 = new Login();
            form8.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form8.Show();
        }
    }
}
