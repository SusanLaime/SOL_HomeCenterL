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
using HomeCenterL.Data;
using HomeCenterL.Entities;

namespace HomeCenterL.Presentation
{
    public partial class frmRegisterSale : Form
    {
        private object txtUnitPrice;
        private bool loadThirdComboBox;

        public frmRegisterSale()
        {
            InitializeComponent();
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            LoadData(); // Call the method to fill the DataGridView when form loads
            LoadBranches();
            LoadPaymentMethod();
            LoadProducts(true, true);
            cmbBranchName.Text = "";
            cmbPaymentMethodSale.Text = "";
            cmbProductName1Sale.Text = "";
            cmbProductNameSale2.Text = "";
            cmbProductNameSale3.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Purchase object with UI inputs
                Sale sale = new Sale()
                {
                    CustomerName = txtCustomerName.Text,  // Ensure the Sale class has the correct property
                    BranchName = cmbBranchName.Text,  // Add this input control for Branch Name
                    EmployeeName = txtEmployeeName.Text,  // Add this input control for Employee Name
                    PaymentMethodName = cmbPaymentMethodSale.Text,  // Add this input control for Payment Method
                    SaleDetail = txtDetailSale.Text,  // Use the SaleDetail field (nullable)
                    ProductName1 = cmbProductName1Sale.Text,
                    Quantity1 = Convert.ToInt32(txtQuantitySale1.Text),
                    ProductName2 = string.IsNullOrWhiteSpace(cmbProductNameSale2.Text) ? null : cmbProductNameSale2.Text,
                    Quantity2 = string.IsNullOrWhiteSpace(txtQuantitySale2.Text) ? 0 : int.Parse(txtQuantitySale2.Text),
                    ProductName3 = string.IsNullOrWhiteSpace(cmbProductNameSale3.Text) ? null : cmbProductNameSale3.Text,
                    Quantity3 = string.IsNullOrWhiteSpace(txtQuantitySale3.Text) ? 0 : int.Parse(txtQuantitySale3.Text),
                };

                // Insert purchase
                int result = SaleDAL.RegisterSale(sale);

                // Show success/failure message
                if (result > 0)
                {
                    MessageBox.Show("Purchase registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // 🔹 Refresh DataGridView after successful purchase
                }
                else
                {
                    MessageBox.Show("Error registering purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Customer, Branch, Employee, Payment Method, Product, Quantity and Unit Price are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to refresh the DataGridView (implementation can vary depending on your data source)
        private void LoadData()
        {
            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                string query = @"
                SELECT s.sale_id, 
                       c.customer_name, 
                       b.branch_name, 
                       e.emp_name, 
                       pm.paymentMethod_name, 
                       p.product_name, 
                       sd.quantity, 
                       sd.unitary_price, 
                       (sd.quantity * sd.unitary_price) AS total_price, 
                       s.dateSale, 
                       s.detailSale
                FROM Sale s
                JOIN Customer c ON s.customer_id = c.customer_id
                JOIN Branch b ON s.branch_id = b.branch_id
                JOIN Employee e ON s.employee_id = e.employee_id
                JOIN PaymentMethod pm ON s.payment_method_id = pm.paymentMethod_id
                JOIN SaleDetail sd ON s.sale_id = sd.sale_id
                JOIN Products p ON sd.product_id = p.product_id
                ORDER BY s.sale_id DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvSaleList.DataSource = table; // Bind data to DataGridView
            }
        }

        // BRANCHES
        private void cmbBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranchName.SelectedIndex != -1) // Ensure a valid selection
            {
                DataTable dt = cmbBranchName.Tag as DataTable; // Retrieve stored DataTable
                if (dt != null)
                {
                    DataRow selectedRow = dt.Rows[cmbBranchName.SelectedIndex];
                    cmbBranchName.Text = selectedRow["branch_name"].ToString(); // Set cost in text box
                }
            }
        }

        //LOAD BRANCHES
        private void LoadBranches()
        {
            string query = @"
        SELECT  branch_id, branch_name FROM Branch"; // Adjust based on your schema
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
                            cmbBranchName.DataSource = dt;
                            cmbBranchName.DisplayMember = "branch_name"; // Shows only the product name
                            cmbBranchName.ValueMember = "branch_id";  // Stores the ID internally


                            // Store the entire DataTable for later access
                            cmbBranchName.Tag = dt;
                           


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        //PRODUCTS 1
        private void cmbProductName1Sale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductName1Sale.SelectedIndex != -1) // Ensure a valid selection
            {
                DataTable dt = cmbProductName1Sale.Tag as DataTable; // Retrieve stored DataTable
                if (dt != null)
                {
                    DataRow selectedRow = dt.Rows[cmbProductName1Sale.SelectedIndex];
                    txtUnitPrice1.Text = selectedRow["price"].ToString(); // Set cost in text box
                }
            }
        }


        //LOAD PRODUCTS 1
        private void LoadProducts(bool loadSecondComboBox, bool loadThirdComboBox)
        {
            string query = @"
        SELECT product_id, product_name, price 
        FROM Products
        ORDER BY product_name ASC"; // Adjust based on your schema
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
                            cmbProductName1Sale.DataSource = dt;
                            cmbProductName1Sale.DisplayMember = "product_name"; // Shows only the product name
                            cmbProductName1Sale.ValueMember = "product_id";  // Stores the ID internally

                            // If loadSecondComboBox is true, bind data to the second ComboBox (cmbProductName2)
                            if (loadSecondComboBox)
                            {
                                cmbProductNameSale2.DataSource = dt.Copy();  // Use a copy of the DataTable for the second ComboBox
                                cmbProductNameSale2.DisplayMember = "product_name"; // Shows only the product name
                                cmbProductNameSale2.ValueMember = "product_id";  // Stores the ID internally
                            }
                            else
                            {
                                // If not loading, clear the second ComboBox
                                cmbProductNameSale2.DataSource = null;
                            }

                            if (loadThirdComboBox)
                            {
                                cmbProductNameSale3.DataSource = dt.Copy();  // Use a copy of the DataTable for the second ComboBox
                                cmbProductNameSale3.DisplayMember = "product_name"; // Shows only the product name
                                cmbProductNameSale3.ValueMember = "product_id";  // Stores the ID internally
                            }
                            else
                            {
                                // If not loading, clear the second ComboBox
                                cmbProductNameSale3.DataSource = null;
                            }
                            // Store the entire DataTable for later access
                            cmbProductName1Sale.Tag = dt;
                            cmbProductNameSale2.Tag = loadSecondComboBox ? dt.Copy() : null; // Optionally store the copy for the second ComboBox
                            cmbProductNameSale3.Tag = loadThirdComboBox ? dt.Copy() : null;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }
        //PRODUCT 2
        private void cmbProductName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductNameSale2.SelectedIndex != -1) // Ensure a valid selection
            {
                DataTable dt = cmbProductNameSale2.Tag as DataTable; // Retrieve stored DataTable
                if (dt != null)
                {
                    DataRow selectedRow = dt.Rows[cmbProductNameSale2.SelectedIndex];
                    txtUnitPrice2.Text = selectedRow["price"].ToString(); // Set cost in text box
                }
            }
        }

        //PRODUCT 3
        private void cmbProductName3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductNameSale3.SelectedIndex != -1) // Ensure a valid selection
            {
                DataTable dt = cmbProductNameSale3.Tag as DataTable; // Retrieve stored DataTable
                if (dt != null)
                {
                    DataRow selectedRow = dt.Rows[cmbProductNameSale3.SelectedIndex];
                    txtUnitPrice3.Text = selectedRow["price"].ToString(); // Set cost in text box
                }
            }
        }

        //PAYMENT METHOD
        private void cmbPaymentMethodSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentMethodSale.SelectedIndex != -1) // Ensure a valid selection
            {
                DataTable dt = cmbPaymentMethodSale.Tag as DataTable; // Retrieve stored DataTable
                if (dt != null)
                {
                    DataRow selectedRow = dt.Rows[cmbPaymentMethodSale.SelectedIndex];
                    cmbPaymentMethodSale.Text = selectedRow["paymentMethod_name"].ToString(); // Set cost in text box
                }
            }
        }
        //LOAD PAYMENT METHOD
        private void LoadPaymentMethod()
        {
            string query = @"
        SELECT * FROM PaymentMethod"; // Adjust based on your schema
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
                            cmbPaymentMethodSale.DataSource = dt;
                            cmbPaymentMethodSale.DisplayMember = "paymentMethod_name"; // Shows only the product name
                            cmbPaymentMethodSale.ValueMember = "paymentMethod_id";  // Stores the ID internally


                            // Store the entire DataTable for later access
                            cmbPaymentMethodSale.Tag = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        private void btnCancelPurchase_Click(object sender, EventArgs e)
        {
            // Reset text fields
            txtCustomerName.Text = "";
            cmbBranchName.Text = "";
            txtEmployeeName.Text = "";
            cmbPaymentMethodSale.Text = "";
            txtDetailSale.Text = "";
            cmbProductName1Sale.Text = "";
            cmbProductNameSale2.Text = "";
            cmbProductNameSale3.Text = "";
            txtQuantitySale1.Text = "";
            txtQuantitySale2.Text = "";
            txtQuantitySale3.Text = "";
            txtUnitPrice1.Text = "";
            txtUnitPrice2.Text = "";
            txtUnitPrice3.Text = "";

            // Reset date picker to today
            dtpSaleDate.Value = DateTime.Today;

            // Optionally, move the cursor to the first field
            txtCustomerName.Focus();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchSale.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            DataTable dt = (DataTable)dgvSaleList.DataSource;

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
                dgvSaleList.DataSource = dv.ToTable();
            }
            else
            {
                MessageBox.Show("No matching records found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearchSale.Text = ""; // Clear the search box
            // Restore the original data source
            LoadData();
        }
    }
}
