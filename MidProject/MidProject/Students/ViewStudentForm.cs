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
    public partial class ViewStudentForm : UserControl
    {
        public ViewStudentForm()
        {
            InitializeComponent();
            PopulateDataInTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewStudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PopulateDataInTable()
        {
            SqlCommand cmd = StudentCRUD.ViewRegisteredStuents();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
