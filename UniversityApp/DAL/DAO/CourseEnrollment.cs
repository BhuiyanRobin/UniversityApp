using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.DAL.DAO
{
    class CourseEnrollment
    {
        public Student AStudent { set; get; }
      //  public Department ADepartment { set; get; }
        public Course ACourse { set; get; }
        public string EnroolmentTime { set; get; }

        public CourseEnrollment()
        {
            AStudent=new Student();
            ACourse=new Course();
        }
    }
}
