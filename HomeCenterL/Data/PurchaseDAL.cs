using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_DB.Data;

namespace HomeCenterL
{
    class PurchaseDAL
    {
        public static int RegisterPurchase(Purchase purchase)
        {
            int result = 0;

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();
                    string storedProcedure = "dbo.RegisterPurchase";

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@SupplierName", purchase.SupplierName);
                        command.Parameters.AddWithValue("@PurchaseDate", purchase.PurchaseDate);
                        command.Parameters.AddWithValue("@Detail", purchase.Detail);
                        command.Parameters.AddWithValue("@ProductName1", purchase.ProductName1);
                        command.Parameters.AddWithValue("@Quantity1", purchase.Quantity1);
                        command.Parameters.AddWithValue("@UnitaryCost1", purchase.UnitaryCost1);

                        // Optional Product 2 parameters
                        if (!string.IsNullOrEmpty(purchase.ProductName2))
                        {
                            command.Parameters.AddWithValue("@ProductName2", purchase.ProductName2);
                            command.Parameters.AddWithValue("@Quantity2", purchase.Quantity2);
                            command.Parameters.AddWithValue("@UnitaryCost2", purchase.UnitaryCost2);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ProductName2", DBNull.Value);
                            command.Parameters.AddWithValue("@Quantity2", 0);
                            command.Parameters.AddWithValue("@UnitaryCost2", 0);
                        }

                        result = command.ExecuteNonQuery(); // Execute stored procedure
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while registering purchase: " + ex.Message);
                }
            }

            return result;
        }
    }
}
