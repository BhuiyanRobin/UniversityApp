using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.Gateway;

namespace UniversityApp.BLL
{
    class StudentBLL
    {
        public List<Department> GetAllDepartments()
        {
            DepartmentGateway aDepartmentGateway = new DepartmentGateway();

            return aDepartmentGateway.GetAllDepartment();
        }
        public string Save(Student aStudent)
        {
            StudentGateway aStudentGateway=new StudentGateway();

            if (aStudentGateway.CheckAlreadyExist(aStudent) == false)
            {
                aStudentGateway.InsertIntoDatabase(aStudent);
                return "sucess";
            }
            else
            {
                return "Already exist";
            }
        }
    }
}
