using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_DB.Data;

namespace HomeCenterL.Data
{
    class SaleDAL
    {
        public static int RegisterSale(Sale sale)
        {
            int result = 0;

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();
                    string storedProcedure = "dbo.RegisterSale";

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters for Sale
                        command.Parameters.AddWithValue("@CustomerName", sale.CustomerName);
                        command.Parameters.AddWithValue("@BranchName", sale.BranchName);
                        command.Parameters.AddWithValue("@EmployeeName", sale.EmployeeName);
                        command.Parameters.AddWithValue("@PaymentMethodName", sale.PaymentMethodName);
                        command.Parameters.AddWithValue("@SaleDetail", string.IsNullOrWhiteSpace(sale.SaleDetail) ? (object)DBNull.Value : sale.SaleDetail);
                        command.Parameters.AddWithValue("@ProductName1", sale.ProductName1);
                        command.Parameters.AddWithValue("@Quantity1", sale.Quantity1);
                        command.Parameters.AddWithValue("@ProductName2", string.IsNullOrEmpty(sale.ProductName2) ? (object)DBNull.Value : sale.ProductName2);
                        command.Parameters.AddWithValue("@Quantity2", sale.Quantity2);
                        command.Parameters.AddWithValue("@ProductName3", string.IsNullOrEmpty(sale.ProductName3) ? (object)DBNull.Value : sale.ProductName3);
                        command.Parameters.AddWithValue("@Quantity3", sale.Quantity3);

                        result = command.ExecuteNonQuery(); // Execute stored procedure
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while registering sale: " + ex.Message);
                }
            }

            return result;
        }
    }
}
