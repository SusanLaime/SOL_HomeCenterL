using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DB.Data
{
    public class Connection
    {
        private String Base;
        private String Server;
        private String User;
        private String Password;
        private static Connection Con = null;

        //Constructor of the class
        private Connection()
        {
            this.Server = "DESKTOP-O9D8QEM";
            this.Base = "HomeCenterFinal";
            this.User = "FinalDB";
            this.Password = "12345";
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection DBcon = new SqlConnection();

            try
            {
                DBcon.ConnectionString = "Server=" + this.Server
                                     + ";Database=" + this.Base
                                     + ";User ID=" + this.User
                                     + ";Password=" + this.Password;
                return DBcon;
            }
            catch (Exception ex)
            {
                DBcon = null;
                throw new Exception("Database connection error: " + ex.Message);
            }

            //
        }
        public static Connection createInstance()
        {
            if (Con == null)
            {
                Con = new Connection();
            }
            return Con;
        }
    }
}
