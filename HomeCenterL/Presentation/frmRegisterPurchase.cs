using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_DB.Data;

namespace HomeCenterL.Presentation
{
    public partial class frmRegisterPurchase: Form
    {
        public frmRegisterPurchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            LoadData(); // Call the method to fill the DataGridView when form loads
            LoadSuppliers();
            LoadProducts(true);
            cmdSupplierName.Text = "";
            cmbProductName.Text = "";
            cmbProductName2.Text = "";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// /
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(cmdSupplierName.Text) ||
                    string.IsNullOrWhiteSpace(cmbProductName.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity1.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitaryCost1.Text))
                {
                    MessageBox.Show("Supplier, Product, Quantity, and Unitary Cost are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create a new Purchase object with UI inputs
                Purchase purchase = new Purchase()
                {
                    SupplierName = cmdSupplierName.Text.Trim(),
                    PurchaseDate = dtpPurchaseDate.Value,
                    Detail = txtDetail.Text.Trim(), // Optional field
                    ProductName1 = cmbProductName.Text.Trim()
                };

                // Convert and validate required numeric fields
                if (!int.TryParse(txtQuantity1.Text.Trim(), out int quantity1) || quantity1 <= 0)
                {
                    MessageBox.Show("Quantity must be a valid positive integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                purchase.Quantity1 = quantity1;

                if (!decimal.TryParse(txtUnitaryCost1.Text.Trim(), out decimal unitaryCost1) || unitaryCost1 <= 0)
                {
                    MessageBox.Show("Unitary Cost must be a valid positive number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                purchase.UnitaryCost1 = unitaryCost1;

                // Handle optional Product 2 fields safely
                purchase.ProductName2 = string.IsNullOrWhiteSpace(cmbProductName2.Text) ? null : cmbProductName2.Text.Trim();
                purchase.Quantity2 = string.IsNullOrWhiteSpace(txtQuantity2.Text) || !int.TryParse(txtQuantity2.Text.Trim(), out int quantity2) ? 0 : quantity2;
                purchase.UnitaryCost2 = string.IsNullOrWhiteSpace(txtUnitaryCost2.Text) || !decimal.TryParse(txtUnitaryCost2.Text.Trim(), out decimal unitaryCost2) ? 0 : unitaryCost2;

                // Insert purchase into the database
                int result = PurchaseDAL.RegisterPurchase(purchase);

                // Show success/failure message
                if (result > 0)
                {
                    MessageBox.Show("Purchase registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // 🔹 Refresh DataGridView after successful purchase
                }
                else
                {
                    MessageBox.Show("Error registering purchase. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void txtDetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            using(SqlConnection connection = Connection.createInstance().CreateConnection())

            {
                string query = @"
            SELECT 
                p.purchase_id AS [Purchase ID], 
                s.company_name AS [Supplier], 
                p.datePurchase AS [Date], 
                p.detail AS [Detail], 
                pr.product_name AS [Product], 
                pd.unitary_cost AS [Unit Cost], 
                pd.quantity AS [Quantity] 
            FROM Purchase p
            JOIN Supplier s ON p.supplier_id = s.supplier_id
            JOIN PurchaseDetail pd ON p.purchase_id = pd.purchase_id
            JOIN Products pr ON pd.product_id = pr.product_id
            ORDER BY p.purchase_id DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvList.DataSource = table; // Bind data to DataGridView
            }
        }

        private void btnCancelPurchase_Click(object sender, EventArgs e)
        {
            // Reset text fields
            cmdSupplierName.Text = "";
            txtDetail.Text = "";
            cmbProductName.Text = "";
            txtQuantity1.Text = "";
            txtUnitaryCost1.Text = "";
            cmbProductName2.Text = "";
            txtQuantity2.Text = "";
            txtUnitaryCost2.Text = "";

            // Reset date picker to today
            dtpPurchaseDate.Value = DateTime.Today;

            // Optionally, move the cursor to the first field
            cmdSupplierName.Focus();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            DataTable dt = (DataTable)dgvList.DataSource;

            if (dt == null)
            {
                MessageBox.Show("No data available.");
                return;
            }

            // Create a new sorted DataView
            DataView dv = new DataView(dt);

            // Filter rows where any column contains the search text
            string filter = "";
            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType == typeof(string)) // Only compare text columns
                {
                    if (!string.IsNullOrEmpty(filter))
                        filter += " OR ";

                    filter += $"CONVERT({col.ColumnName}, 'System.String') LIKE '%{searchText}%'";
                }
            }

            dv.RowFilter = filter;

            // Sorting by date column (replace 'date_column' with the actual column name)
            string dateColumn = "PurchaseDate"; // Change this to the actual date column name in your DataTable
            if (dt.Columns.Contains(dateColumn))
            {
                dv.Sort = $"{dateColumn} DESC"; // Sort descending (latest first)
            }

            if (dv.Count > 0)
            {
                // Assign sorted view to the DataGridView
                dgvList.DataSource = dv.ToTable();
            }
            else
            {
                MessageBox.Show("No matching records found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear the search box
            // Restore the original data source
            LoadData();
            
        }

        /// <summary>
        /// //////////////////////////////////
        /// COMBO BOXES
        private void LoadSuppliers()
        {
            string query = "SELECT supplier_id, company_name FROM Supplier";

            using (SqlConnection conn = Connection.createInstance().CreateConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // Bind data to ComboBox
                            cmdSupplierName.DataSource = dt;
                            cmdSupplierName.DisplayMember = "company_name"; // Shows only the name
                            cmdSupplierName.ValueMember = "supplier_id";  // Stores the ID internally
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading suppliers: " + ex.Message);
                }
            }
        }

        //LOAD PRODUCTS 1
        private void LoadProducts(bool loadSecondComboBox)
        {
            string query = @"
        SELECT 
            pr.product_id AS [Product ID], 
            pr.product_name AS [Product], 
            MIN(pd.unitary_cost) AS [Unit Cost] 
        FROM PurchaseDetail pd
        JOIN Products pr ON pd.product_id = pr.product_id
        GROUP BY pr.product_id, pr.product_name
        ORDER BY pr.product_id;"; // Adjust based on your schema
        // Adjust table/column names if needed

            using (SqlConnection conn = Connection.createInstance().CreateConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // Bind data to ComboBox
                            cmbProductName.DataSource = dt;
                            cmbProductName.DisplayMember = "Product"; // Shows only the product name
                            cmbProductName.ValueMember = "Product ID";  // Stores the ID internally

                            // If loadSecondComboBox is true, bind data to the second ComboBox (cmbProductName2)
                            if (loadSecondComboBox)
                            {
                                cmbProductName2.DataSource = dt.Copy();  // Use a copy of the DataTable for the second ComboBox
                                cmbProductName2.DisplayMember = "Product"; // Shows only the product name
                                cmbProductName2.ValueMember = "Product ID";  // Stores the ID internally
                            }
                            else
                            {
                                // If not loading, clear the second ComboBox
                                cmbProductName2.DataSource = null;
                            }

                            // Store the entire DataTable for later access
                            cmbProductName.Tag = dt;
                            cmbProductName2.Tag = loadSecondComboBox ? dt.Copy() : null; // Optionally store the copy for the second ComboBox


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductName.SelectedIndex != -1) // Ensure a valid selection
            {
                DataTable dt = cmbProductName.Tag as DataTable; // Retrieve stored DataTable
                if (dt != null)
                {
                    DataRow selectedRow = dt.Rows[cmbProductName.SelectedIndex];
                    txtUnitaryCost1.Text = selectedRow["Unit Cost"].ToString(); // Set cost in text box
                }
            }
        }

        private void cmbProductName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductName2.SelectedIndex != -1) // Ensure a valid selection
            {
                DataTable dt = cmbProductName2.Tag as DataTable; // Retrieve stored DataTable
                if (dt != null)
                {
                    DataRow selectedRow = dt.Rows[cmbProductName2.SelectedIndex];
                    txtUnitaryCost2.Text = selectedRow["Unit Cost"].ToString(); // Set cost in text box
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
