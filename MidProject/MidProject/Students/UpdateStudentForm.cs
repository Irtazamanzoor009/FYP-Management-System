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
    public partial class UpdateStudentForm : UserControl
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
            PopulateRegisteredStudentTable();
            
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string regno = txtRegNo.Text;
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            DateTime dateofbirth = txtdate.Value;
            string gender = StudentCRUD.GetGenderID(txtgender.Text).ToString();

            if (dataGridView1.SelectedRows.Count > 0)
            {

                string idvalue = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                StudentCRUD.UpdateStudentInformation(idvalue, regno, firstname, lastname, contact, email, dateofbirth, gender);
                MessageBoxInfo.InfoMessageBox("Student Record Updated Successfully");
                PopulateRegisteredStudentTable();
            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Please Select Row First");
            }

        }

        private void PopulateRegisteredStudentTable()
        {
            SqlCommand cmd = StudentCRUD.ViewRegisteredStuents();
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
                txtRegNo.Text = selectedRow.Cells["RegistrationNo"].Value.ToString();
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtContact.Text = selectedRow.Cells["Contact"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtdate.Text = selectedRow.Cells["DateOfBirth"].Value.ToString();
                txtgender.Text = selectedRow.Cells["Gender"].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
