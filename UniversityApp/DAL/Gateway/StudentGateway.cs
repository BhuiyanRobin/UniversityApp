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
    class StudentGateway
    {
        string Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }
        public bool InsertIntoDatabase(Student aStudent)
        {
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("INSERT INTO t_student VALUES('{0}','{1}','{2}','{3}','{4}',{5})", aStudent.StudentRegNo, aStudent.StudentName, aStudent.Email, aStudent.Contact, aStudent.Address, aStudent.ADepartment.DepartmentId);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            int chk = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (chk > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckAlreadyExist(Student aStudent)
        {
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("SELECT * FROM t_student WHERE (register_no='{0}')", aStudent.StudentRegNo);

            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                aReader.Close();
                aConnection.Close();
                return true;
            }
            else
            {
                aReader.Close();
                aConnection.Close();
                return false;
            }
            
        }
        public List<Student> GetAllStudent()
        {
            SqlConnection aConnection = new SqlConnection(Connection());
            List<Student> studentList = new List<Student>();
            string query = string.Format("SELECT * FROM t_student");

            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Student aStudent=new Student();
                    aStudent.StudentId= (int)aReader[0];
                    aStudent.StudentRegNo = aReader[1].ToString();
                    aStudent.StudentName = aReader[2].ToString();
                    aStudent.Email = aReader[3].ToString();
                    aStudent.Contact = aReader[4].ToString();
                    aStudent.Email = aReader[5].ToString();
                    aStudent.ADepartment.DepartmentId =(int) aReader[6];
                    studentList.Add(aStudent);
                }
            }
            aReader.Close();
            aConnection.Close();
            return studentList;
        }
    }
}
