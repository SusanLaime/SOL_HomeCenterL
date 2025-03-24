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
    public class TotalPurchasesPerSupllierDAL
    {
        public static DataTable GetTotalPurchasesPerSupplier()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();
                    string storedProcedure = "dbo.GetTotalPurchasesPerSupplier";

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while retrieving total purchases per supplier: " + ex.Message);
                }
            }

            return table;
        }
    }
}
