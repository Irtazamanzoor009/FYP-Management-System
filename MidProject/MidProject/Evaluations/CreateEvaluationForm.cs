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
    public partial class CreateEvaluationForm : UserControl
    {
        public CreateEvaluationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create evaluation

            string name = textBox1.Text;
            string TotalMarks = textBox2.Text;
            string TotalWeightage = textBox3.Text;
            EvaluationCRUD.InsertIntoEvaluation(name, TotalMarks, TotalWeightage);
            MessageBoxInfo.InfoMessageBox("Evaluation Created successfully");
            ClearFields();

        }

        public void ClearFields()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
