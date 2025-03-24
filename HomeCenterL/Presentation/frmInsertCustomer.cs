using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCenterL.Presentation
{
    public partial class frmInsertCustomer : Form
    {
        public frmInsertCustomer()
        {
            InitializeComponent();
        }


        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a Customer object
                Customer customer = new Customer
                {
                    customer_name = txtCustomerName.Text.Trim(),
                    lastname = txtLastnameCustomer.Text.Trim(),
                    phone = txtPhoneCustomer.Text.Trim(),
                    c_address = txtAddressCustomer.Text.Trim()
                };

                // Validate inputs
                if (string.IsNullOrWhiteSpace(customer.customer_name) ||
                    string.IsNullOrWhiteSpace(customer.lastname) ||
                    string.IsNullOrWhiteSpace(txtNIT.Text) || // NIT should be explicitly checked
                    string.IsNullOrWhiteSpace(customer.phone) ||
                    string.IsNullOrWhiteSpace(customer.c_address))
                {
                    MessageBox.Show("All fields must be filled in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate NIT conversion
                if (!int.TryParse(txtNIT.Text.Trim(), out int nit))
                {
                    MessageBox.Show("NIT must be a valid integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                customer.NIT = nit;

                // Call DAL method to save the customer
                int result = CustomerDAL.AddCustomer(customer);

                // Check the result
                if (result > 0)
                {
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Error adding customer. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelICustomer_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtLastnameCustomer.Text = "";
            txtPhoneCustomer.Text = "";
            txtAddressCustomer.Text = "";
            txtNIT.Text = "";
        }
    }
}