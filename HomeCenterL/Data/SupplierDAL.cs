using System;
using System.Data;
using System.Data.SqlClient;
using Final_DB.Data;

namespace HomeCenterL
{
    class SupplierDAL
    {
        public static int AddSupplier(Supplier supplier)
        {
            int returns = 0;

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();

                    //procedure name
                    string storedProcedure = "InsertSupplier";

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        // Set the command type to StoredProcedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the parameters required by the stored procedure
                        command.Parameters.AddWithValue("@CountryName", supplier.country_name);
                        command.Parameters.AddWithValue("@CompanyName", supplier.company_name);
                        command.Parameters.AddWithValue("@ContactName", supplier.contact_name);

                        // Fix for CS8957
                        if (string.IsNullOrEmpty(supplier.contact_phone))
                        {
                            command.Parameters.AddWithValue("@ContactPhone", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ContactPhone", supplier.contact_phone);
                        }

                        if (string.IsNullOrEmpty(supplier.email))
                        {
                            command.Parameters.AddWithValue("@Email", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Email", supplier.email);
                        }

                        if (string.IsNullOrEmpty(supplier.s_address))
                        {
                            command.Parameters.AddWithValue("@Address", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Address", supplier.s_address);
                        }

                        // Execute the stored procedure and get the number of rows affected
                        returns = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while inserting supplier: " + ex.Message);
                }
            }

            return returns;
        }
    }
}
