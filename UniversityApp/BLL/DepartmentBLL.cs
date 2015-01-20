using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.Gateway;

namespace UniversityApp.BLL
{
    class DepartmentBLL
    {
        public string Save(Department aDepartment)
        {
            DepartmentGateway aDepartmentGateway=new DepartmentGateway();

            if (aDepartmentGateway.CheckAlreadyExist(aDepartment)==false)
            {
                aDepartmentGateway.InsertIntoDatabase(aDepartment);
                
                return "sucess";
            }
            else
            {
                return "Already exist";
            }
        }
    }
}
