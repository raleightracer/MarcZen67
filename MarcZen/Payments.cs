using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace MarcZen
{
    public partial class Payments : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MarcZenDB;Integrated Security=True;";

        // Selection state (for update/delete)
        private int? selectedPaymentId = null;
        private string origCustomer, origCar, origMode, origStatus;
        private decimal? origAmount;

        public Payments()
        {
            InitializeComponent();

            // Wire optional events (designer may already wire them)
            if (dgvPayments != null)
                dgvPayments.CellClick += dgvPayments_CellClick;

            if (btnAdd != null)
                btnAdd.Click += btnButton_Click; // Add

            if (btnUpdate != null)
                btnUpdate.Click += btnUpdate_Click; // Update

            // Use the designer timer if present
            if (timerDate != null)
            {
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
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy  |  hh:mm tt");
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
            form1.FormClosed += (s, args) => this.Close();
            this.Hide();
            form1.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            var form2 = new Inventory();
            form2.FormClosed += (s, args) => this.Close();
            this.Hide();
            form2.Show();
        }

        private void btnRentalTransaction_Click(object sender, EventArgs e)
        {
            var form3 = new RentalTransaction();
            form3.FormClosed += (s, args) => this.Close();
            this.Hide();
            form3.Show();
        }

        private void btnMaintenance_Click(object sender, EventArgs e) { }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var form5 = new Customers();
            form5.FormClosed += (s, args) => this.Close();
            this.Hide();
            form5.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form6 = new Reports();
            form6.FormClosed += (s, args) => this.Close();
            this.Hide();
            form6.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var form8 = new Login();
            form8.FormClosed += (s, args) => this.Close();
            this.Hide();
            form8.Show();
        }

        // Helper: read text from normal TextBox/ComboBox or custom containers that expose TextValue/SelectedTextValue
        private string GetControlText(Control c)
        {
            if (c == null) return string.Empty;
            var p = c.GetType().GetProperty("TextValue");
            if (p != null) return (p.GetValue(c) as string) ?? string.Empty;
            p = c.GetType().GetProperty("SelectedTextValue");
            if (p != null) return (p.GetValue(c) as string) ?? string.Empty;
            if (c is ComboBox cb) return cb.Text ?? string.Empty;
            return c.Text ?? string.Empty;
        }

        private void SetControlText(Control c, string value)
        {
            if (c == null) return;
            var p = c.GetType().GetProperty("TextValue");
            if (p != null) { p.SetValue(c, value); return; }
            p = c.GetType().GetProperty("SelectedTextValue");
            if (p != null) { p.SetValue(c, value); return; }
            if (c is ComboBox cb) { cb.Text = value; return; }
            c.Text = value ?? string.Empty;
        }

        // new: clear input fields and reset selection state
        private void ClearInputs()
        {
            SetControlText(txtCustomerName, string.Empty);
            SetControlText(cmbTypeOfCar, string.Empty);
            SetControlText(cmbModeOfPayment, string.Empty);
            SetControlText(cmbPaymentStatus, string.Empty);
            SetControlText(txtAmount, string.Empty);

            selectedPaymentId = null;
            origCustomer = origCar = origMode = origStatus = null;
            origAmount = null;

            // put focus back to customer name if available
            if (txtCustomerName != null && txtCustomerName is Control) txtCustomerName.Focus();
        }

        // Check if Payments table has a column
        private bool TableHasColumn(string columnName)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Payments' AND COLUMN_NAME = @col", conn))
            {
                cmd.Parameters.AddWithValue("@col", columnName);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private string BuildSelectColumns()
        {
            string cols = "CustomerName, TypeOfCar, ModeOfPayment, PaymentStatus, Amount";
            if (TableHasColumn("PaymentID"))
                cols = "PaymentID, " + cols;
            return cols;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadPayments(GetFilterValue());
        }

        private void SearchPayments(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT " + BuildSelectColumns() + " FROM Payments " +
                               "WHERE CustomerName LIKE @kw OR TypeOfCar LIKE @kw OR ModeOfPayment LIKE @kw";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPayments.DataSource = dt;
                dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dt.Columns.Contains("Amount") && dgvPayments.Columns.Contains("Amount"))
                    dgvPayments.Columns["Amount"].DefaultCellStyle.Format = "C2";
            }
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // Populate filter safely
            try
            {
                if (cbFilter is ComboBox cb)
                {
                    cb.Items.Clear();
                    cb.Items.Add("All");
                    cb.Items.Add("Paid");
                    cb.Items.Add("Not Yet Paid");
                    cb.SelectedIndex = 0;
                }
                else
                {
                    SetControlText(cbFilter, "All");
                }
            }
            catch
            {
                SetControlText(cbFilter, "All");
            }

            LoadPayments(GetFilterValue());
        }

        private string GetFilterValue()
        {
            var f = GetControlText(cbFilter);
            return string.IsNullOrEmpty(f) ? "All" : f;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayments(GetFilterValue());
        }

        private void LoadPayments(string filter)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT " + BuildSelectColumns() + " FROM Payments";

                if (filter != "All")
                    query += " WHERE PaymentStatus = @status";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                if (filter != "All")
                    da.SelectCommand.Parameters.AddWithValue("@status", filter);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPayments.DataSource = dt;
                dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dt.Columns.Contains("Amount") && dgvPayments.Columns.Contains("Amount"))
                    dgvPayments.Columns["Amount"].DefaultCellStyle.Format = "C2";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = GetControlText(tbSearch).Trim();
            if (string.IsNullOrEmpty(keyword))
                LoadPayments(GetFilterValue());
            else
                SearchPayments(keyword);
        }

        // -------------------- Selection, Add, Update, Remove --------------------

        private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPayments.Rows[e.RowIndex];

            selectedPaymentId = null;
            if (dgvPayments.Columns.Contains("PaymentID") && row.Cells["PaymentID"].Value != null && int.TryParse(row.Cells["PaymentID"].Value.ToString(), out int pid))
                selectedPaymentId = pid;

            origCustomer = row.Cells["CustomerName"].Value?.ToString();
            origCar = row.Cells["TypeOfCar"].Value?.ToString();
            origMode = row.Cells["ModeOfPayment"].Value?.ToString();
            origStatus = row.Cells["PaymentStatus"].Value?.ToString();

            if (row.Cells["Amount"].Value != null && decimal.TryParse(row.Cells["Amount"].Value.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out decimal dec))
                origAmount = dec;
            else
                origAmount = null;

            SetControlText(txtCustomerName, origCustomer ?? string.Empty);
            SetControlText(cmbTypeOfCar, origCar ?? string.Empty);
            SetControlText(cmbModeOfPayment, origMode ?? string.Empty);
            SetControlText(cmbPaymentStatus, origStatus ?? string.Empty);
            SetControlText(txtAmount, origAmount?.ToString("F2") ?? string.Empty);
        }

        // support designer wiring if it uses a different handler name
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //btnButton_Click(sender, e);
        }

        // Add
        private void btnButton_Click(object sender, EventArgs e)
        {
            string cust = GetControlText(txtCustomerName).Trim();
            string car = GetControlText(cmbTypeOfCar).Trim();
            string mode = GetControlText(cmbModeOfPayment).Trim();
            string status = GetControlText(cmbPaymentStatus).Trim();
            string amountText = GetControlText(txtAmount).Trim();

            if (string.IsNullOrEmpty(cust))
            {
                MessageBox.Show("Customer name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountText, NumberStyles.Currency | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out decimal amount))
            {
                MessageBox.Show("Amount must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertSql = "INSERT INTO Payments (CustomerName, TypeOfCar, ModeOfPayment, PaymentStatus, Amount) " +
                               "VALUES (@cust, @car, @mode, @status, @amount)";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@cust", cust);
                    cmd.Parameters.AddWithValue("@car", (object)car ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@mode", (object)mode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@amount", amount);

                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0)
                    {
                        MessageBox.Show("Record added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPayments(GetFilterValue());

                        // clear inputs after successful add
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Insert failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cust = GetControlText(txtCustomerName).Trim();
            string car = GetControlText(cmbTypeOfCar).Trim();
            string mode = GetControlText(cmbModeOfPayment).Trim();
            string status = GetControlText(cmbPaymentStatus).Trim();
            string amountText = GetControlText(txtAmount).Trim();

            if (string.IsNullOrEmpty(cust))
            {
                MessageBox.Show("Customer name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountText, NumberStyles.Currency | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out decimal amount))
            {
                MessageBox.Show("Amount must be a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedPaymentId.HasValue && TableHasColumn("PaymentID"))
            {
                string updateSql = "UPDATE Payments SET CustomerName = @cust, TypeOfCar = @car, ModeOfPayment = @mode, PaymentStatus = @status, Amount = @amount WHERE PaymentID = @id";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(updateSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cust", cust);
                        cmd.Parameters.AddWithValue("@car", (object)car ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@mode", (object)mode ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@id", selectedPaymentId.Value);

                        conn.Open();
                        int affected = cmd.ExecuteNonQuery();
                        if (affected > 0)
                        {
                            MessageBox.Show("Record updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPayments(GetFilterValue());
                            // clear inputs after successful update
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("No record updated. It may have been changed or removed.", "Not updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }

            // Fallback: update by matching original values (fragile)
            string updateFallback = @"
UPDATE Payments SET CustomerName = @cust, TypeOfCar = @car, ModeOfPayment = @mode, PaymentStatus = @status, Amount = @amount
WHERE CustomerName = @origCust AND TypeOfCar = @origCar AND ModeOfPayment = @origMode AND PaymentStatus = @origStatus
  AND ( (Amount = @origAmount) OR (@origAmount IS NULL AND Amount IS NULL) )";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(updateFallback, conn))
                {
                    cmd.Parameters.AddWithValue("@cust", cust);
                    cmd.Parameters.AddWithValue("@car", (object)car ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@mode", (object)mode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@amount", amount);

                    cmd.Parameters.AddWithValue("@origCust", (object)origCustomer ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@origCar", (object)origCar ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@origMode", (object)origMode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@origStatus", (object)origStatus ?? DBNull.Value);

                    if (origAmount.HasValue)
                        cmd.Parameters.AddWithValue("@origAmount", origAmount.Value);
                    else
                        cmd.Parameters.AddWithValue("@origAmount", DBNull.Value);

                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0)
                    {
                        MessageBox.Show("Record updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPayments(GetFilterValue());
                        // clear inputs after successful update
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("No matching record was updated. Consider adding a PaymentID primary key.", "Not updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Remove (already implemented previously) - keep existing method name if wired in designer
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            DataGridViewRow selectedRow = null;
            if (dgvPayments.SelectedRows != null && dgvPayments.SelectedRows.Count > 0)
                selectedRow = dgvPayments.SelectedRows[0];
            else if (dgvPayments.CurrentRow != null)
                selectedRow = dgvPayments.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Please select a row to remove.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string cust = selectedRow.Cells["CustomerName"].Value?.ToString();
            string car = selectedRow.Cells["TypeOfCar"].Value?.ToString();
            string mode = selectedRow.Cells["ModeOfPayment"].Value?.ToString();
            string status = selectedRow.Cells["PaymentStatus"].Value?.ToString();
            object amountObj = selectedRow.Cells["Amount"].Value;

            var ans = MessageBox.Show($"Delete payment for '{cust}'?\nThis will remove the record from the database.", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ans != DialogResult.Yes) return;

            // If PaymentID exists, delete by id
            if (selectedPaymentId.HasValue && TableHasColumn("PaymentID"))
            {
                string delById = "DELETE FROM Payments WHERE PaymentID = @id";
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    using (var cmd = new SqlCommand(delById, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedPaymentId.Value);
                        conn.Open();
                        int affected = cmd.ExecuteNonQuery();
                        if (affected > 0)
                        {
                            MessageBox.Show("Record deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPayments(GetFilterValue());
                            // clear inputs after successful delete
                            ClearInputs();
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Fallback delete by matching displayed columns
            string deleteSql = @"
DELETE FROM Payments
WHERE CustomerName = @cust
  AND TypeOfCar = @car
  AND ModeOfPayment = @mode
  AND PaymentStatus = @status
  AND ( (Amount = @amount) OR (@amount IS NULL AND Amount IS NULL) )";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                {
                    cmd.Parameters.AddWithValue("@cust", (object)cust ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@car", (object)car ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@mode", (object)mode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status", (object)status ?? DBNull.Value);

                    if (amountObj == null || amountObj == DBNull.Value || string.IsNullOrWhiteSpace(amountObj.ToString()))
                        cmd.Parameters.AddWithValue("@amount", DBNull.Value);
                    else if (decimal.TryParse(amountObj.ToString(), out decimal dec))
                        cmd.Parameters.AddWithValue("@amount", dec);
                    else
                        cmd.Parameters.AddWithValue("@amount", amountObj.ToString());

                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("Record deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPayments(GetFilterValue());
                        // clear inputs after successful delete
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("No matching record found to delete. It may have already been removed or the table lacks a unique identifier.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

