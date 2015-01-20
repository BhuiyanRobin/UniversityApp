using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.DAL.DAO;

namespace UniversityApp
{
    public partial class UniversityManagementSystemForm : Form
    {
        public UniversityManagementSystemForm()
        {
            InitializeComponent();
        }

        private void departmentEntryButton_Click(object sender, EventArgs e)
        {
            DepartmentEntryUI aDepartmentEntryUi = new DepartmentEntryUI();
            aDepartmentEntryUi.Show();
        }

        private void studentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryUI aStudentEntryUi=new StudentEntryUI();
            aStudentEntryUi.Show();
        }

        private void courseEntryButton_Click(object sender, EventArgs e)
        {
            CourseEntryUI aCourseEntryUi=new CourseEntryUI();
            aCourseEntryUi.Show();
        }

        private void enrollmnetButton_Click(object sender, EventArgs e)
        {
            CourseEnrollmentUI aCourseEnrollmentUi=new CourseEnrollmentUI();
            aCourseEnrollmentUi.Show();
        }

        
    }
}
