using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_DB.Data;

namespace HomeCenterL
{
    class EmployeeDAL
    {
        public static int AddEmployee(Employee employee)
        {
            int returns = 0;

            using (SqlConnection connection = Connection.createInstance().CreateConnection())
            {
                try
                {
                    connection.Open(); // Open the connection before executing the query
                    string query = "dbo.InsertEmployee";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //Specify the stored procedure name
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        // Use parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@BranchName", employee.branch_name);
                        command.Parameters.AddWithValue("@EmpName", employee.emp_name);
                        command.Parameters.AddWithValue("@EmpLastName", employee.emp_lastname);
                        command.Parameters.AddWithValue("@Position", employee.position);
                        command.Parameters.AddWithValue("@Phone", employee.phone);


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
