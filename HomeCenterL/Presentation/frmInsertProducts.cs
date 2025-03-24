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
    public partial class frmInsertProducts : Form
    {
        public frmInsertProducts()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a Product object
                Product product = new Product
                {
                    category_id = txtidCategory.Text.Trim(),
                    product_name = txtnameProduct.Text.Trim()
                };

                // Validate inputs
                if (string.IsNullOrWhiteSpace(product.category_id) ||
                    string.IsNullOrWhiteSpace(product.product_name) ||
                    string.IsNullOrWhiteSpace(txtPriceProduct.Text) ||
                    string.IsNullOrWhiteSpace(txtStockProduct.Text))
                {
                    MessageBox.Show("All fields must be filled in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate and convert price
                if (!double.TryParse(txtPriceProduct.Text.Trim(), out double price) || price < 0)
                {
                    MessageBox.Show("Price must be a valid positive number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                product.price = price;

                // Validate and convert stock
                if (!int.TryParse(txtStockProduct.Text.Trim(), out int stock) || stock < 0)
                {
                    MessageBox.Show("Stock must be a valid non-negative integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                product.stock = stock;

                // Call DAL method to save the product
                int result = ProductDAL.AddProduct(product);

                // Check the result
                if (result > 0)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error adding product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelIProduct_Click(object sender, EventArgs e)
        {
            txtidCategory.Text = "";
            txtnameProduct.Text = "";
            txtPriceProduct.Text = "";
            txtStockProduct.Text = "";

        }
    }
}
