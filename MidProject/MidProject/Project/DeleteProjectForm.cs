using MidProject.AdvisorsDL;
using MidProject.ProjectDL;
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
    public partial class DeleteProjectForm : UserControl
    {
        public DeleteProjectForm()
        {
            InitializeComponent();
            PopulateProjectTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ProjectCRUD.DeleteProject(id);
                MessageBoxInfo.InfoMessageBox("Project Record Deleted Successfully");
                PopulateProjectTable();

            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Select Row first");

            }
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
    }

}
