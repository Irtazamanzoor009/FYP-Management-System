using MidProject.AdvisorsDL;
using MidProject.ProjectDL;
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

namespace MidProject.Project
{
    public partial class UpdateProjectForm : UserControl
    {
        public UpdateProjectForm()
        {
            InitializeComponent();
            PopulateProjectTable();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void PopulateProjectTable()
        {
            SqlCommand cmd = ProjectCRUD.ViewProjects();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }


        private void btnUpdateProject_Click_1(object sender, EventArgs e)
        {
            string title = txtProjectTitle.Text;
            string description = txtDescription.Text;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idvalue = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ProjectCRUD.UpdateProjectInformation(title, description, idvalue);
                MessageBoxInfo.InfoMessageBox("Project Record Updated Successfully");
                PopulateProjectTable();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtProjectTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();
            }
        }
    }
}
