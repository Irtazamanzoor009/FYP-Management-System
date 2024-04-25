using MidProject.AdvisorsDL;
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

namespace MidProject.GroupEvaluations
{
    public partial class ManageEvaluationForm : UserControl
    {
        public ManageEvaluationForm()
        {
            InitializeComponent();
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            SqlCommand cmd = GroupEvaluationCRUD.ViewAllGroupEvaluation();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           // dataGridView1.Columns[0].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void addPanel(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                UpdateEvaluationForm1 upd = new UpdateEvaluationForm1(id);
                addPanel(upd);
                PopulateGrid();

            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Select Row first");

            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
