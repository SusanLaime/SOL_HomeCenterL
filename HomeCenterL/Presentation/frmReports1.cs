using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeCenterL.Data;
using HomeCenterL.Entities;

namespace HomeCenterL.Presentation
{
    public partial class frmReports1: Form
    {
        public frmReports1()
        {
            InitializeComponent();
        }

        private void btnSaveReports1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data from the stored procedure
                DataTable resultTable = TotalPurchasesPerSupllierDAL.GetTotalPurchasesPerSupplier();

                if (resultTable.Rows.Count > 0)
                {
                    dgvReports.DataSource = resultTable; // Bind results to DataGridView
                }
                else
                {
                    MessageBox.Show("No purchases found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalesPerBranch_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable resultTable = TotalSalesPerBranchDAL.GetTotalSalesPerCategory();

                if (resultTable.Rows.Count > 0)
                {
                    dgvReports.DataSource = resultTable;
                }
                else
                {
                    MessageBox.Show("No sales found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalesBeetweenDates_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected dates from DateTimePickers
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                // Retrieve data from the stored procedure
                DataTable resultTable = SalesBetweenDatesDAL.GetSalesBetweenDates(startDate, endDate);

                if (resultTable.Rows.Count > 0)
                {
                    dgvReports.DataSource = resultTable; // Bind results to DataGridView
                }
                else
                {
                    MessageBox.Show("No sales found in the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving sales report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalesByCategory_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable resultTable = TotalSalesPerCategoryDAL.GetTotalSalesPerCategory();

                if (resultTable.Rows.Count > 0)
                {
                    dgvReports.DataSource = resultTable;
                }
                else
                {
                    MessageBox.Show("No sales found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTop5Employees_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable resultTable = Top5EmployeesDAL.GetTop5Employees();

                if (resultTable.Rows.Count > 0)
                {
                    dgvReports.DataSource = resultTable;
                }
                else
                {
                    MessageBox.Show("No sales found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalesByCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los TextBox
                string customerName = txtCustomerName.Text.Trim();
                string customerLastname = txtCustomerLastname.Text.Trim();

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerLastname))
                {
                    MessageBox.Show("Please enter both first and last name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método con los parámetros
                DataTable resultTable = TotalSalesByCustomerDAL.GetTotalSalesByCustomer(customerName, customerLastname);

                if (resultTable != null && resultTable.Rows.Count > 0)
                {
                    dgvReports.DataSource = resultTable;
                }
                else
                {
                    MessageBox.Show("No sales found for the specified customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalesByEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from TextBoxes
                string employeeName = txtEmployeeName.Text.Trim();
                string employeeLastname = txtEmployeeLastName.Text.Trim();
                DateTime startDate, endDate;

                // Validate input fields
                if (string.IsNullOrWhiteSpace(employeeName) || string.IsNullOrWhiteSpace(employeeLastname))
                {
                    MessageBox.Show("Please enter both the employee's first and last name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DateTime.TryParse(dateTimePickerSalesE1.Text, out startDate) || !DateTime.TryParse(dateTimePickerSalesE2.Text, out endDate))
                {
                    MessageBox.Show("Please enter valid start and end dates.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (startDate > endDate)
                {
                    MessageBox.Show("Start date cannot be later than end date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call DAL method
                EmployeeSalesStats stats = EmployeeSalesStatsDAL.GetEmployeeSalesStats(employeeName, employeeLastname, startDate, endDate);

                // Create DataTable to store results
                DataTable table = new DataTable();
                table.Columns.Add("Employee Name", typeof(string));
                table.Columns.Add("Employee Lastname", typeof(string));
                table.Columns.Add("Total Sales", typeof(int));
                table.Columns.Add("Total Amount", typeof(decimal));

                // Add retrieved data to DataTable
                table.Rows.Add(stats.EmployeeName, stats.EmployeeLastname, stats.TotalSales, stats.TotalAmount);

                // Bind DataTable to DataGridView
                dgvReports.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employee sales statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
