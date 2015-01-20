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
    public partial class CourseEnrollmentUI : Form
    {
        public CourseEnrollmentUI()
        {
            InitializeComponent();
            showStudentOnCombobox();
            showCoursesOnCombobox();
        }

        private CourseEnrollmentBLL aCourseEnrollmentBll = new CourseEnrollmentBLL();
        private CourseEnrollment aCourseEnrollment = new CourseEnrollment();
        Student aStudent = new Student();
        Course aCourse=new Course();
        private void enrollButton_Click(object sender, EventArgs e)
        {
            aCourseEnrollment.AStudent = aStudent;
            aCourseEnrollment.ACourse = aCourse;
            aCourseEnrollment.EnroolmentTime = enrollmentDateTimePicker.Text;
            
            
            string message = aCourseEnrollmentBll.InsertIntoDataBase(aCourseEnrollment);
            MessageBox.Show(message);

        }

        private void showStudentOnCombobox()
        {
            studentRegCombbox.DisplayMember = "StudentRegNo";
            studentRegCombbox.DataSource = aCourseEnrollmentBll.GetAllStudent();

        }

        private void showCoursesOnCombobox()
        {
            courseTitleComboBox.DisplayMember = "CourseTitle";
            courseTitleComboBox.DataSource = aCourseEnrollmentBll.GetAllCourse();
        }

        private void studentRegCombbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            aStudent = (Student)studentRegCombbox.SelectedItem;
            nameTextBox.Text = aStudent.StudentName;
            emailTextBox.Text = aStudent.Email;
            aStudent.ADepartment = aCourseEnrollmentBll.GetStudentDepartment(aStudent.ADepartment.DepartmentId);
            departmentTextBox.Text = aStudent.ADepartment.Title;
        }

        private void courseTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aCourse = (Course)courseTitleComboBox.SelectedItem;
        }
    }
}
