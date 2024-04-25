using MidProject.AdvisorsDL;
using MidProject.StudentsDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Advisors
{
    public partial class AddAdvisorsForm : UserControl
    {
        public AddAdvisorsForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            DateTime dateofbirth = txtdate.Value;
            string gender = StudentCRUD.GetGenderID(txtgender.Text).ToString();
            string designation = AdvisorsCRUD.GetDesignationID(txtDesignation.Text).ToString();
            string salary = txtSalary.Text;

            AdvisorsCRUD.AddAdvisorPerson(firstname, lastname, contact, email, dateofbirth, gender);
            int maxid = StudentCRUD.GetLastPersonId();
            AdvisorsCRUD.AddAdvisor(maxid, designation, salary);

            MessageBoxInfo.InfoMessageBox("Advisor Added Successfully");
            ClearTextBoxes();

        }

        private void ClearTextBoxes()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtdate.Text = string.Empty;
            txtgender.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            txtSalary.Text = string.Empty;
        }
    }
}
