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
    class CourseGateway
    {
        string Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }
        public bool InsertIntoDatabase(Course aCourse)
        {
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("INSERT INTO T_course VALUES('{0}','{1}',{2},{3})", aCourse.CourseCode,aCourse.CourseTitle,aCourse.Credit,aCourse.ADepartment.DepartmentId);

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
        public bool CheckAlreadyExist(Course aCourse)
        {
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("SELECT * FROM t_course WHERE (code='{0}' or title='{1}')", aCourse.CourseCode, aCourse.CourseTitle);

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
        public List<Course> GetAllCourses()
        {
            SqlConnection aConnection = new SqlConnection(Connection());
            List<Course> courseList = new List<Course>();
            string query = string.Format("SELECT * FROM t_course");

            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse=new Course();
                    aCourse.CourseID= (int)aReader[0];
                    aCourse.CourseCode = aReader[1].ToString();
                    aCourse.CourseTitle = aReader[2].ToString();
                    aCourse.Credit = (int)aReader[3];
                    courseList.Add(aCourse);
                }
            }
            aReader.Close();
            aConnection.Close();
            return courseList;
        }
    }
}
