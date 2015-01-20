using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;

namespace UniversityApp.DAL.Gateway
{
    class DepartmentGateway:BaseGateway
    {
        string Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }
        public bool InsertIntoDatabase(Department aDepartment)
        {
            
            string query = string.Format("INSERT INTO T_DEPARTMENT VALUES('{0}','{1}')", aDepartment.Code,
                aDepartment.Title);

            AConnection.Open();

           int chk = ACommand(query).ExecuteNonQuery();

           AConnection.Close();
         
            if (chk>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Department> GetAllDepartment()
        {
            
            List<Department> departmentlList=new List<Department>();
            string query = string.Format("SELECT * FROM t_department");

            AConnection.Open();

            SqlDataReader aReader = ACommand(query).ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartment=new Department();
                    aDepartment.DepartmentId = (int)aReader[0];
                    aDepartment.Code = aReader[1].ToString();
                    aDepartment.Title = aReader[2].ToString();
                    departmentlList.Add(aDepartment);
                }
            }
            AConnection.Close();
            return departmentlList;
        }

        public bool CheckAlreadyExist(Department aDepartment)
        {
            
           
            string query = string.Format("SELECT * FROM t_department WHERE (code='{0}' or title='{1}')",aDepartment.Code,aDepartment.Title);

            

            AConnection.Open();
            SqlDataReader aReader = ACommand(query).ExecuteReader();

            if (aReader.HasRows)
            {
                aReader.Close();
                AConnection.Close();
                return true;
            }
            else
            {
                aReader.Close();
                AConnection.Close();
                return false;
            }
            
            
        }

        public Department FindDepartment(int departmentId)
        {
            SqlConnection aConnection = new SqlConnection(Connection());
            Department aDepartment = new Department();
            string query = string.Format("SELECT * FROM t_department WHERE (id={0})",departmentId);

            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aDepartment.DepartmentId = (int)aReader[0];
                    aDepartment.Code = aReader[1].ToString();
                    aDepartment.Title = aReader[2].ToString();
                }
            }
            return aDepartment;
        }
    }
}
