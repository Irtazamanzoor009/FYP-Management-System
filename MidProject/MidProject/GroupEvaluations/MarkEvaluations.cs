using MidProject.AdvisorsDL;
using MidProject.Evaluations;
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
    public partial class MarkEvaluations : UserControl
    {
        string GroupID;
        string EvaluationID;
        string TotalMarks;
        string TotalWeightage;
        public MarkEvaluations()
        {
            InitializeComponent();
            PopulateGroups();
        }

        private void GroupEvaluationMenu_Load(object sender, EventArgs e)
        {

        }

        public void PopulateEvaluationGroup(string id)
        {
            SqlCommand cmd = GroupEvaluationCRUD.ViewGroupEvaluationByID(id);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridPopulateEvaluationGroup.DataSource = dt;
        }

        public void PopulateEvaluations()
        {
            SqlCommand cmd = EvaluationCRUD.ViewAllEvaluation();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridPopulateEvaluation.DataSource = dt;
        }

        public void PopulateGroups()
        {
            SqlCommand cmd = GroupEvaluationCRUD.ViewAllGroups();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridPopulateGroup.DataSource = dt;
        }

        private void gridPopulateGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateEvaluations();
            if (gridPopulateGroup.SelectedRows.Count > 0)
            {
                GroupID = gridPopulateGroup.SelectedRows[0].Cells[0].Value.ToString();
                PopulateEvaluationGroup(GroupID);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marks = textBox1.Text;
            Double marks1 = ((Convert.ToDouble(marks) / Convert.ToDouble(TotalMarks))*Convert.ToDouble(TotalWeightage));
            DateTime date = DateTime.Now;
            GroupEvaluationCRUD.InsertIntoGroupEvaluation(GroupID, EvaluationID, marks1, date);
            MessageBoxInfo.InfoMessageBox("Evaluation Added Successfully");
            PopulateEvaluationGroup(GroupID);
        }

        private void gridPopulateEvaluation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridPopulateEvaluation.SelectedRows.Count > 0)
            {
                EvaluationID = gridPopulateEvaluation.SelectedRows[0].Cells[0].Value.ToString();
                TotalMarks = gridPopulateEvaluation.SelectedRows[0].Cells[2].Value.ToString();
                TotalWeightage = gridPopulateEvaluation.SelectedRows[0].Cells[3].Value.ToString();
            }
             
        }

        private void gridPopulateEvaluationGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
