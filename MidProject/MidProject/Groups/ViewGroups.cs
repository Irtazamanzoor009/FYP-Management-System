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
    public partial class ViewGroups : UserControl
    {
        public ViewGroups()
        {
            InitializeComponent();
            PopulateGroups();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void PopulateGroups()
        {
            SqlCommand cmd = GroupCRUD.ViewGroups1();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
