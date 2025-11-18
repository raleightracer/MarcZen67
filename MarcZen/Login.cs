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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var form1 = new Dashboard();
            form1.FormClosed += (s, args) => this.Close(); // close main when form2 closes
            this.Hide(); // keep application message loop running
            form1.Show();
        }
    }
}
