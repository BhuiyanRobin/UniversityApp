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
    public partial class DepartmentEntryUI : Form
    {
        public DepartmentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment=new Department();
            DepartmentBLL aDepartmentBll=new DepartmentBLL();
            aDepartment.Code = departmentCodeTextBox.Text;
            aDepartment.Title = departmentTitleTextBox.Text;
            MessageBox.Show(aDepartmentBll.Save(aDepartment));

        }
    }
}
