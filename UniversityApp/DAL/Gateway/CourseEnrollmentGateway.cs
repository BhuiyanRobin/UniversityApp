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
    class CourseEnrollmentGateway
    {
        string Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }
        public bool InsertIntoDatabase(CourseEnrollment aCourseEnrollment)
        {
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("INSERT INTO t_course_enrollment VALUES({0},{1},{2})",
                aCourseEnrollment.AStudent.StudentId, aCourseEnrollment.ACourse.CourseID,aCourseEnrollment.EnroolmentTime );

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

        public bool CheckAlreadyExist(CourseEnrollment aCourseEnrollment)
        {
            
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("SELECT * FROM t_course_enrollment WHERE (student_id={0} AND course_id={1})", aCourseEnrollment.AStudent.StudentId, aCourseEnrollment.ACourse.CourseID);

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
        public int HowMuchCourseTaken(int id)
        {

            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("SELECT COUNT(student_id) FROM t_course_enrollment WHERE(student_id={0}) ", id);
            SqlCommand aCommand = new SqlCommand(query, aConnection);

            aConnection.Open();
            int times =(int) aCommand.ExecuteScalar();
            aConnection.Close();
            return times;

        }
    }
}
