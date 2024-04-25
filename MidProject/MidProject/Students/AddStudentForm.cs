using MidProject.StudentsDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Students
{
    public partial class AddStudentForm : UserControl
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // add student click ----- 
            string regno = txtRegNo.Text;
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            DateTime dateofbirth = txtdate.Value;
            string gender = StudentCRUD.GetGenderID(txtgender.Text).ToString();

            StudentCRUD.AddPerson(firstname,lastname,contact,email,dateofbirth,gender);         
            int lastID = StudentCRUD.GetLastPersonId();
            StudentCRUD.AddRegistrationNumber(lastID, regno);

            MessageBoxInfo.InfoMessageBox("Student Added Successfully");
            ClearTextBoxes();


        }

        private void ClearTextBoxes()
        {
            txtRegNo.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtdate.Text = string.Empty;
            txtgender.Text = string.Empty;
        }
    }
}
