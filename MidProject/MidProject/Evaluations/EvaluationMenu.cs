using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Evaluations
{
    public partial class EvaluationMenu : UserControl
    {
        public EvaluationMenu()
        {
            InitializeComponent();
        }

        private void addPanel(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            evaluationPanel.Controls.Clear();
            evaluationPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();

        }

        private void btnCreateEvaluation_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateEvaluation_Click_1(object sender, EventArgs e)
        {
            CreateEvaluationForm crt = new CreateEvaluationForm();
            addPanel(crt);
        }

        private void btnManageEvaluation_Click(object sender, EventArgs e)
        {
            ManageEvaluationForm mng = new ManageEvaluationForm();
            addPanel(mng);
        }
    }
}
