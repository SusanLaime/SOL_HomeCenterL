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
    public class TotalSalesPerBranchDAL
    {
        public static DataTable GetTotalSalesPerCategory()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();
                    string storedProcedure = "dbo.GetTotalSalesPerBranch";
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
                    throw new Exception("Error while retrieving total sales per branch: " + ex.Message);
                }
            }
            return table;
        }
    }
}
