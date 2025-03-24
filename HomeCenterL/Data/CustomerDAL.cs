using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_DB.Data;

namespace HomeCenterL
{
    class CustomerDAL
    {
        public static int AddCustomer(Customer customer)
        {
            int returns = 0;

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open(); // Open the connection before executing the query

                    string query = "INSERT INTO Customer (customer_name, lastname, NIT, phone, c_address) VALUES(@CustomerName, @LastName, @NIT, @Phone, @Address);";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@CustomerName", customer.customer_name);
                        command.Parameters.AddWithValue("@LastName", customer.lastname);
                        command.Parameters.AddWithValue("@NIT", customer.NIT);
                        command.Parameters.AddWithValue("@Phone", customer.phone);
                        command.Parameters.AddWithValue("@Address", customer.c_address);


                        returns = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while inserting customer: " + ex.Message);
                }
            }

            return returns;

        }
    }
}
