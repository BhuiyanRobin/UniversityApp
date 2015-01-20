using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.DAL.DAO
{
    class Course
    {
        public int CourseID { set; get; }
        public string CourseCode { set; get; }
        public string CourseTitle { set; get; }
        public Department ADepartment { set; get; }
        public int Credit { set; get; }
    }
}
