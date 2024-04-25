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
    public partial class DeleteAdvisorForm : UserControl
    {
        public DeleteAdvisorForm()
        {
            InitializeComponent();
            PopulateAdvisorTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string firstname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string lastname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                AdvisorsCRUD.DeleteAdvisor(firstname, lastname, id);
                MessageBoxInfo.InfoMessageBox("Advisor Record Deleted Successfully");
                PopulateAdvisorTable();

            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Select Row first");

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

        }

        private void DeleteStudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
