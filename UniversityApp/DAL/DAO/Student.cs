using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.DAL.DAO
{
    class Student
    {
        public Department ADepartment { set; get; }
        public string StudentRegNo { set; get; }
        public string StudentName { set; get; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public string Address { get; set; }
        public int StudentId { set; get; }

        public Student()
        {
            ADepartment=new Department();
        }
    }
}
