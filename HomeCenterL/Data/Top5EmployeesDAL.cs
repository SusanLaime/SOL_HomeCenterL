using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Final_DB.Data;    

namespace HomeCenterL.Entities
{
    public class Top5EmployeesDAL
    {
        public static DataTable GetTop5Employees()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();
                    string storedProcedure = "dbo.GetTop5Employees";
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
                    throw new Exception("Error while retrieving top 5 employees: " + ex.Message);
                }
            }
            return table;
        }
    }
}
