using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Evaluations
{
    public partial class UpdateEvaluationForm : Form
    {
        string id;
        public UpdateEvaluationForm(string id,string name, string marks, string weightage)
        {
            InitializeComponent();
            this.id = id;
            txtMarks.Text = marks;
            txtName.Text = name;
            txtWeightage.Text = weightage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // update button
            string name = txtName.Text;
            string marks = txtMarks.Text;
            string weightage = txtWeightage.Text;

            EvaluationCRUD.UpdateEvaluation(id, name, marks, weightage);
            MessageBoxInfo.InfoMessageBox("Evaluation have been updated Successfully");

        }
    }
}
