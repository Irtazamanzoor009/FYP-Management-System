using MidProject.AdvisorsDL;
using MidProject.StudentsDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Advisors
{
    public partial class UpdateAdvisorsForm : UserControl
    {
        public UpdateAdvisorsForm()
        {
            InitializeComponent();
            PopulateAdvisorTable();
        }

        private void btnUpdateAdvisors_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            DateTime dateofbirth = txtdate.Value;
            string gender = StudentCRUD.GetGenderID(txtgender.Text).ToString();
            string designation = AdvisorsCRUD.GetDesignationID(txtDesignation.Text).ToString();
            string salary = txtSalary.Text;

            if(dataGridView1.SelectedRows.Count > 0 )
            {
                string idvalue = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                AdvisorsCRUD.UpdateAdvisorInformation(idvalue, firstname, lastname, contact, email, dateofbirth, gender, designation, salary);
                MessageBoxInfo.InfoMessageBox("Advisor Record Updated Successfully");
                PopulateAdvisorTable();
            }
        }

        private void PopulateAdvisorTable()
        {
            SqlCommand cmd = AdvisorsCRUD.ViewRegisteredAdvisor();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtContact.Text = selectedRow.Cells["Contact"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtdate.Text = selectedRow.Cells["DateOfBirth"].Value.ToString();
                txtgender.Text = selectedRow.Cells["Gender"].Value.ToString();
                txtDesignation.Text = selectedRow.Cells["Designation"].Value.ToString();
                txtSalary.Text = selectedRow.Cells["Salary"].Value.ToString();
            }
        }
    }
}
