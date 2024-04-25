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
    public partial class UpdateEvaluationForm1 : UserControl
    {
        string id;
        public UpdateEvaluationForm1(string id)
        {
            InitializeComponent();
            this.id = id;
            PopulateGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string evaluationId = row.Cells["EvaluationId"].Value.ToString();
                string groupId = row.Cells["GroupId"].Value.ToString();
                string newObtainedMarks = row.Cells["textBoxColumn"].Value.ToString();
                GroupEvaluationCRUD.UpdateObtainedMarksInDatabase(evaluationId, groupId, newObtainedMarks);
            }

            MessageBoxInfo.InfoMessageBox("Marks have been Updated successfully");

        }
        

        public void PopulateGrid()
        {
            SqlCommand cmd = GroupEvaluationCRUD.GetFromEvaluationTable(id);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            AddTextBoxInDataGridView();
            dataGridView1.Columns["GroupId"].ReadOnly = true;
            dataGridView1.Columns["EvaluationId"].ReadOnly = true;
            dataGridView1.Columns["Name"].ReadOnly = true;
            dataGridView1.Columns["TotalMarks"].ReadOnly = true;
            dataGridView1.Columns["TotalWeightage"].ReadOnly = true;
            dataGridView1.Columns["EvaluationDate"].ReadOnly = true;

            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        public void AddTextBoxInDataGridView()
        {
            DataGridViewTextBoxColumn textBoxColumn = new DataGridViewTextBoxColumn();
            textBoxColumn.HeaderText = "Obtained Marks";
            textBoxColumn.Name = "textBoxColumn";
            textBoxColumn.DefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.Columns.Insert(5, textBoxColumn);
            
           
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string evaluationId = row.Cells["EvaluationId"].Value.ToString();
                string groupId = row.Cells["GroupId"].Value.ToString();

                string obtainedMarks = GroupEvaluationCRUD.FetchObtainedMarksFromDatabase(evaluationId, groupId);
                row.Cells["textBoxColumn"].Value = obtainedMarks;
            }
        }

        
    }
}
