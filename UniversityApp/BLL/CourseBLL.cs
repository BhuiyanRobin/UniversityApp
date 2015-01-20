using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.Gateway;

namespace UniversityApp.BLL
{
    class CourseBLL
    {
        public List<Department> GetAllDepartments()
        {
            DepartmentGateway aDepartmentGateway=new DepartmentGateway();

            return aDepartmentGateway.GetAllDepartment();
        }

        public string InsertIntoDataBase(Course aCourse)
        {
           CourseGateway aCourseGateway=new CourseGateway();

            
            if (aCourseGateway.CheckAlreadyExist(aCourse) == false)
            {
                aCourseGateway.InsertIntoDatabase(aCourse);
                return "sucess";

            }
            else
            {
                return "Already exist";
            }
        }

        

    }
}
