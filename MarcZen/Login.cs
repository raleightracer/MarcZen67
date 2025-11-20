using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MarcZen
{
    partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Helper that reads text from either a normal TextBox or your RoundedTextBoxContainer (TextValue)
        private string GetControlText(Control c)
        {
            if (c == null) return string.Empty;
            var prop = c.GetType().GetProperty("TextValue");
            if (prop != null)
            {
                var val = prop.GetValue(c) as string;
                return val ?? string.Empty;
            }
            return c.Text ?? string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Read text using helper (handles RoundedTextBoxContainer and normal TextBox)
            string username = GetControlText(txtUsername).Trim();
            string password = GetControlText(txtPassword).Trim();

            /*MessageBox.Show(
                $"Username Control Name: {txtUsername?.Name}, Text: '{username}'\n" +
                $"Password Control Name: {txtPassword?.Name}, Text: '{password}'"
            );*/

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MarcZenDB;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar, 255).Value = password;

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful!");
                        Dashboard form1 = new Dashboard();
                        form1.FormClosed += (s, args) => this.Close();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}


