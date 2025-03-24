using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_DB.Data;

namespace HomeCenterL.Entities
{
    public class TotalSalesByCustomerDAL
    {
        public static DataTable GetTotalSalesByCustomer(string customerName, string customerLastname)
        {
            DataTable table = new DataTable();

            // Validar que los parámetros no sean nulos o vacíos
            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerLastname))
            {
                throw new ArgumentException("Customer name and last name cannot be empty.");
            }

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();
                    string storedProcedure = "GetTotalSalesByCustomer"; // No es necesario "dbo." al llamar un procedimiento almacenado

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Definir los parámetros con el mismo tipo de dato que en SQL Server
                        command.Parameters.Add("@customerName", SqlDbType.VarChar, 30).Value = customerName;
                        command.Parameters.Add("@customerLastname", SqlDbType.VarChar, 30).Value = customerLastname;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception("Database error retrieving total sales by customer.", sqlEx);
                }
            }

            return table;
        }

        internal static DataTable GetTotalSalesByCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
