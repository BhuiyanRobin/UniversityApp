using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.Gateway;

namespace UniversityApp.BLL
{
    class CourseEnrollmentBLL
    {
        public List<Student> GetAllStudent()
        {
            StudentGateway aStudentGateway=new StudentGateway();
            return aStudentGateway.GetAllStudent();
        }
        public List<Course> GetAllCourse()
        {
            CourseGateway aCourseGateway=new CourseGateway();
            return aCourseGateway.GetAllCourses();
        }

        public Department GetStudentDepartment(int departmentId)
        {
            DepartmentGateway aDepartmentGateway=new DepartmentGateway();

            return aDepartmentGateway.FindDepartment(departmentId);
        }
        public string InsertIntoDataBase(CourseEnrollment aCourseEnrollment)
        {
            CourseEnrollmentGateway aCourseEnrollmentGateway=new CourseEnrollmentGateway();


            if (aCourseEnrollmentGateway.HowMuchCourseTaken(aCourseEnrollment.AStudent.StudentId)<3)
            {
                if (aCourseEnrollmentGateway.CheckAlreadyExist(aCourseEnrollment) == false)
                {
                    aCourseEnrollmentGateway.InsertIntoDatabase(aCourseEnrollment);
                    return "sucess";

                }
                else
                {
                    return "Already Taken This subject";
                }
            }
            else
            {
                return "You Can not take more than three subject";
            }
            
        }
    }
}
