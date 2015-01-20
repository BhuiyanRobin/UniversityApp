using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.DAL.Gateway
{
    internal class BaseGateway
    {
        
        private SqlConnection aConnection;

        public SqlConnection AConnection
        {
            get
            {
                aConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                return aConnection;
            }
            set
            {
                aConnection = value;
            }
        }

        

        public SqlCommand ACommand(string query)
        {
            SqlCommand aCommand=new SqlCommand(query,aConnection);
            return aCommand;
        }
    }

}
