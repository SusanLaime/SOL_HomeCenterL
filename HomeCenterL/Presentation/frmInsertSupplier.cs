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
    public partial class frmInsertSupplier : Form
    {
        public frmInsertSupplier()
        {
            InitializeComponent();
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                // Create Supplier object
                Supplier supplier = new Supplier
                {
                    country_name = txtNameCountrySupplier.Text.Trim(), // Ensure no leading/trailing spaces
                    company_name = txtCompanyNameSupplier.Text.Trim(),
                    contact_name = txtNameSupplier.Text.Trim(),
                    contact_phone = txtPhoneSupplier.Text.Trim(),
                    email = txtEmailSupplier.Text.Trim(),
                    s_address = txtAddressSupplier.Text.Trim()
                };

                // Validate required fields
                if (string.IsNullOrWhiteSpace(supplier.country_name) ||
                    string.IsNullOrWhiteSpace(supplier.company_name) ||
                    string.IsNullOrWhiteSpace(supplier.contact_name) ||
                    string.IsNullOrWhiteSpace(supplier.contact_phone) ||
                    string.IsNullOrWhiteSpace(supplier.email) ||
                    string.IsNullOrWhiteSpace(supplier.s_address))
                {
                    MessageBox.Show("All fields must be filled in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Email Format
                if (!supplier.email.Contains("@") || !supplier.email.Contains("."))
                {
                    MessageBox.Show("Invalid email format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Phone Number (Only Digits)
                if (!supplier.contact_phone.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must contain only digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call DAL method to save the supplier
                int result = SupplierDAL.AddSupplier(supplier);

                // Show success/failure message
                if (result > 0)
                {
                    MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error adding supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frmInsertSupplier_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelISupplier_Click(object sender, EventArgs e)
        {
            txtNameCountrySupplier.Text = "";
            txtCompanyNameSupplier.Text = "";
            txtNameSupplier.Text = "";
            txtPhoneSupplier.Text = "";
            txtEmailSupplier.Text = "";
            txtAddressSupplier.Text = "";

        }
    }
}
