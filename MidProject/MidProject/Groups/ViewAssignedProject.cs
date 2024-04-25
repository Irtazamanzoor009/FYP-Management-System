using MidProject.AdvisorsDL;
using MidProject.GroupDL;
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

namespace MidProject.Groups
{
    public partial class ViewAssignedProject : UserControl
    {
        public ViewAssignedProject()
        {
            InitializeComponent();
            populateGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void populateGrid()
        {
            SqlCommand cmd = GroupCRUD.ViewAssignedProjects();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
