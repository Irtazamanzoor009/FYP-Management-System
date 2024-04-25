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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Advisors
{
    public partial class ViewAdvisorsForm : UserControl
    {
        public ViewAdvisorsForm()
        {
            InitializeComponent();
            PopulateAdvisorTable();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            //dataGridView1.Columns["Title"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewStudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
