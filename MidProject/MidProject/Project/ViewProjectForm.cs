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
    public partial class ViewProjectForm : UserControl
    {
        public ViewProjectForm()
        {
            InitializeComponent();
            PopulateProjectsTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopulateProjectsTable()
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
