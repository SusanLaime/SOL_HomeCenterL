using System;
using System.Data;
using System.Data.SqlClient;
using Final_DB.Data;

namespace HomeCenterL
{
    class ProductDAL
    {
        public static int AddProduct(Product product)
        {
            int returns = 0;

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open(); // Open the connection before executing the query

                    // Specify the stored procedure name
                    string storedProcedure = "InsertProduct"; // Name of your stored procedure

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        // Set the command type to StoredProcedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the parameters required by the stored procedure
                        command.Parameters.AddWithValue("@CategoryID", product.category_id);
                        command.Parameters.AddWithValue("@ProductName", product.product_name);
                        command.Parameters.AddWithValue("@Price", product.price);
                        command.Parameters.AddWithValue("@Stock", product.stock != 0 ? (object)product.stock : DBNull.Value);  // Handle null stock as DBNull

                        // Execute the stored procedure and get the number of rows affected
                        returns = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while inserting product: " + ex.Message);
                }
            }

            return returns;
        }
    }
}
