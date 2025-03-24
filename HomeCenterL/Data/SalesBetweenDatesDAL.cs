using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_DB.Data;

namespace HomeCenterL.Entities
{
    class SalesBetweenDatesDAL
    {
        public static DataTable GetSalesBetweenDates(DateTime startDate, DateTime endDate)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();
                    string storedProcedure = "dbo.GetSalesBetweenDates";

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters for Sale
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        // Execute query and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving sales between dates: " + ex.Message);
                }
            }
            return table;
        }
    }
}
