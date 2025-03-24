using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_DB.Data;
using HomeCenterL.Entities;

namespace HomeCenterL.Data
{
    class EmployeeSalesStatsDAL
    {
        public static EmployeeSalesStats GetEmployeeSalesStats(string firstName, string lastName, DateTime startDate, DateTime endDate)
        {
            EmployeeSalesStats stats = new EmployeeSalesStats
            {
                EmployeeName = firstName,
                EmployeeLastname = lastName,
                StartDate = startDate,
                EndDate = endDate,
                TotalSales = 0,
                TotalAmount = 0
            };

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open();
                    DataTable table = new DataTable();
                    using (SqlCommand command = new SqlCommand("dbo.GetEmployeeSalesStats", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input Parameters
                        command.Parameters.AddWithValue("@EmployeeName", firstName);
                        command.Parameters.AddWithValue("@EmployeeLastname", lastName);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        // Output Parameters
                        SqlParameter totalSalesParam = new SqlParameter("@TotalSales", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(totalSalesParam);

                        SqlParameter totalAmountParam = new SqlParameter("@TotalAmount", SqlDbType.Decimal)
                        {
                            Precision = 10,
                            Scale = 2,
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(totalAmountParam);

                        // Execute stored procedure
                        command.ExecuteNonQuery();

                        // Retrieve output values
                        stats.TotalSales = (int)command.Parameters["@TotalSales"].Value;
                        stats.TotalAmount = (decimal)command.Parameters["@TotalAmount"].Value;

                        // Execute query and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving employee sales statistics: " + ex.Message);
                }
            }
            return stats;
        }
    }
}
