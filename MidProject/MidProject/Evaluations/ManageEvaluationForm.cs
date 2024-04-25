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

namespace MidProject.Evaluations
{
    public partial class ManageEvaluationForm : UserControl
    {
        public ManageEvaluationForm()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void PopulateGrid()
        {
            SqlCommand cmd = EvaluationCRUD.ViewAllEvaluation();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // new 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string marks = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string weightage = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                UpdateEvaluationForm updateEvaluation = new UpdateEvaluationForm(id,name, marks, weightage);
                updateEvaluation.ShowDialog();
                PopulateGrid();

            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Select Row first");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                EvaluationCRUD.DeleteEvaluation(id);
                MessageBoxInfo.InfoMessageBox("Evaluation Have Been Deleted Successfully");
                PopulateGrid();

            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Select Row first");

            }
        }
    }
}
