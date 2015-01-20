using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.BLL;
using UniversityApp.DAL.DAO;

namespace UniversityApp
{
    public partial class CourseEntryUI : Form
    {
        public CourseEntryUI()
        {
            InitializeComponent();
            ShowOnCombobox();
        }
        CourseBLL aCourseBll = new CourseBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Course aCourse=new Course();
            aCourse.ADepartment = (Department)departmentComboBox.SelectedItem;
            aCourse.CourseCode = courseCodeTextBox.Text;
            aCourse.CourseTitle = courseTitleTextBox.Text;
            aCourse.Credit = Convert.ToInt32(courseCreditTextBox.Text);
            MessageBox.Show(aCourseBll.InsertIntoDataBase(aCourse));
        }

        void ShowOnCombobox()
        {
            CourseBLL aCourseBll=new CourseBLL();
            departmentComboBox.DisplayMember = "code";
            departmentComboBox.DataSource = aCourseBll.GetAllDepartments();
        }
       
    }
}
