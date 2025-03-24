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
using HomeCenterL.Entities;

namespace HomeCenterL.Presentation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form frmRegisterSale = new frmRegisterSale();
            AddFormRegisterSale(frmRegisterSale, TabControl1.TabPages[6]);
            Form frmRegisterPurchase = new frmRegisterPurchase();
            AddFormRegisterPurchase(frmRegisterPurchase, TabControl1.TabPages[5]);
            Form frmReports1 = new frmReports1();
            AddFormReports(frmReports1, TabControl1.TabPages[7]);
            Form frmInsertEmployee = new frmInsertEmployee();
            AddFormInsertEmployee(frmInsertEmployee, TabControl1.TabPages[1]);
            Form frmInsertCustomer = new frmInsertCustomer();
            AddFormInsertCustomer(frmInsertCustomer, TabControl1.TabPages[2]);
            Form frmInsertProduct = new frmInsertProducts();
            AddFormInsertProduct(frmInsertProduct, TabControl1.TabPages[3]);
            Form frmInsertSupplier = new frmInsertSupplier();
            AddFormInsertSupplier(frmInsertSupplier, TabControl1.TabPages[4]);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        //INSERT EMPLOYEE
        private void AddFormInsertEmployee(Form frmInsertEmployee, TabPage employee)
        {
            frmInsertEmployee.TopLevel = false;  // Make it a child control
            frmInsertEmployee.FormBorderStyle = FormBorderStyle.None; // Remove borders
            frmInsertEmployee.Dock = DockStyle.Fill; // Fill the tab
            employee.Controls.Clear();  // Clear previous controls in the TabPage
            employee.Controls.Add(frmInsertEmployee); // Add form to the tab
            frmInsertEmployee.Show(); // Show form inside tab
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        //INSERT CUSTOMER
        private void AddFormInsertCustomer(Form frmInsertCustomer, TabPage customer)
        {
            frmInsertCustomer.TopLevel = false;  // Make it a child control
            frmInsertCustomer.FormBorderStyle = FormBorderStyle.None; // Remove borders
            frmInsertCustomer.Dock = DockStyle.Fill; // Fill the tab
            customer.Controls.Clear();  // Clear previous controls in the TabPage
            customer.Controls.Add(frmInsertCustomer); // Add form to the tab
            frmInsertCustomer.Show(); // Show form inside tab
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            if (TabControl1.TabPages[0].Controls.Count > 0)
            {
                frmInsertCustomer form = TabControl1.TabPages[2].Controls[2] as frmInsertCustomer;
                if (form != null)
                {
                    form.BringToFront();
                    form.Activate();
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        //INSERT PRODUCT
        private void AddFormInsertProduct(Form frmInsertProduct, TabPage product)
        {
            frmInsertProduct.TopLevel = false;  // Make it a child control
            frmInsertProduct.FormBorderStyle = FormBorderStyle.None; // Remove borders
            frmInsertProduct.Dock = DockStyle.Fill; // Fill the tab
            product.Controls.Clear();  // Clear previous controls in the TabPage
            product.Controls.Add(frmInsertProduct); // Add form to the tab
            frmInsertProduct.Show(); // Show form inside tab
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {
            if (TabControl1.TabPages[3].Controls.Count > 0)
            {
                frmInsertProducts form = TabControl1.TabPages[1].Controls[1] as frmInsertProducts;
                if (form != null)
                {
                    form.BringToFront();
                    form.Activate();
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////

        //REGISTER SALE
        private void AddFormRegisterSale(Form frmRegisterSale, TabPage Sale)
        {
            frmRegisterSale.TopLevel = false;  // Make it a child control
            frmRegisterSale.FormBorderStyle = FormBorderStyle.None; // Remove borders
            frmRegisterSale.Dock = DockStyle.Fill; // Fill the tab
            Sale.Controls.Clear();  // Clear previous controls in the TabPage
            Sale.Controls.Add(frmRegisterSale); // Add form to the tab
            frmRegisterSale.Show(); // Show form inside tab
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (TabControl1.TabPages[0].Controls.Count > 0)
            {
                frmRegisterSale form = TabControl1.TabPages[6].Controls[6] as frmRegisterSale;
                if (form != null)
                {
                    form.BringToFront();
                    form.Activate();
                }
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //REGISTER PURCHASE
        private void AddFormRegisterPurchase(Form frmRegisterPurchase, TabPage purchase)
        {
            frmRegisterPurchase.TopLevel = false;  // Make it a child control
            frmRegisterPurchase.FormBorderStyle = FormBorderStyle.None; // Remove borders
            frmRegisterPurchase.Dock = DockStyle.Fill; // Fill the tab
            purchase.Controls.Clear();  // Clear previous controls in the TabPage
            purchase.Controls.Add(frmRegisterPurchase); // Add form to the tab
            frmRegisterPurchase.Show(); // Show form inside tab
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            if (TabControl1.TabPages[0].Controls.Count > 0)
            {
                frmRegisterPurchase form = TabControl1.TabPages[5].Controls[5] as frmRegisterPurchase;
                if (form != null)
                {
                    form.BringToFront();
                    form.Activate();
                }
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        //INSERT SUPPLIER
        private void AddFormInsertSupplier(Form frmInsertSupplier, TabPage supplier)
        {
            frmInsertSupplier.TopLevel = false;  // Make it a child control
            frmInsertSupplier.FormBorderStyle = FormBorderStyle.None; // Remove borders
            frmInsertSupplier.Dock = DockStyle.Fill; // Fill the tab
            supplier.Controls.Clear();  // Clear previous controls in the TabPage
            supplier.Controls.Add(frmInsertSupplier); // Add form to the tab
            frmInsertSupplier.Show(); // Show form inside tab
        }
        private void tabPage5_Click(object sender, EventArgs e)
        {
            if (TabControl1.TabPages[3].Controls.Count > 0)
            {
                frmInsertSupplier form = TabControl1.TabPages[1].Controls[1] as frmInsertSupplier;
                if (form != null)
                {
                    form.BringToFront();
                    form.Activate();
                }
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        //VIEW REPORTS
        private void AddFormReports(Form frmReports, TabPage Reports)
        {
            frmReports.TopLevel = false;  // Make it a child control
            frmReports.FormBorderStyle = FormBorderStyle.None; // Remove borders
            frmReports.Dock = DockStyle.Fill; // Fill the tab
            Reports.Controls.Clear();  // Clear previous controls in the TabPage
            Reports.Controls.Add(frmReports); // Add form to the tab
            frmReports.Show(); // Show form inside tab
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {
            if (TabControl1.TabPages[7].Controls.Count > 0)
            {
                frmReports1 form = TabControl1.TabPages[7].Controls[7] as frmReports1;
                if (form != null)
                {
                    form.BringToFront();
                    form.Activate();
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }





        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }

}
