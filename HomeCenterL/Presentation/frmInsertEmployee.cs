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
    public partial class frmInsertEmployee: Form
    {
        public frmInsertEmployee()
        {
            InitializeComponent();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an Employee object
                Employee employee = new Employee
                {
                    branch_name = txtNameBranchEmployee.Text.Trim(),
                    emp_name = txtNameEmployee.Text.Trim(),
                    emp_lastname = txtLastnameEmployee.Text.Trim(),
                    position = txtPositionEmployee.Text.Trim(),
                    phone = txtPhoneEmployee.Text.Trim()
                };

                // Validate inputs
                if (string.IsNullOrWhiteSpace(employee.branch_name) ||
                    string.IsNullOrWhiteSpace(employee.emp_name) ||
                    string.IsNullOrWhiteSpace(employee.emp_lastname) ||
                    string.IsNullOrWhiteSpace(employee.position) ||
                    string.IsNullOrWhiteSpace(employee.phone))
                {
                    MessageBox.Show("All fields must be filled in.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Call DAL method to save the employee
                int result = EmployeeDAL.AddEmployee(employee);

                // Check the result
                if (result > 0)
                {
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error adding employee. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelIEmployee_Click(object sender, EventArgs e)
        {
            txtNameBranchEmployee.Text = "";
            txtNameEmployee.Text = "";
            txtLastnameEmployee.Text = "";
            txtPositionEmployee.Text = "";
            txtPhoneEmployee.Text = "";

        }
    }
}
