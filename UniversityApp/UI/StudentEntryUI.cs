using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.BLL;
using UniversityApp.DAL.DAO;

namespace UniversityApp
{
    public partial class StudentEntryUI : Form
    {
        public StudentEntryUI()
        {
            InitializeComponent();
            ShowOnCombobox();
        }
        StudentBLL aStudentBll = new StudentBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            
            aStudent.Contact = contactTextBox.Text;
            aStudent.Email=emailTextBox.Text;
            aStudent.StudentName = nameTextBox.Text;
            aStudent.StudentRegNo = registerNoTextBox.Text;
            aStudent.ADepartment = (Department)departmentCombobox.SelectedItem;
            aStudent.Address = addressTextBox.Text;
            MessageBox.Show(aStudentBll.Save(aStudent));
        }

        void ShowOnCombobox()
        {
            
            departmentCombobox.DisplayMember = "code";
            departmentCombobox.DataSource = aStudentBll.GetAllDepartments();
        }
    }
}
