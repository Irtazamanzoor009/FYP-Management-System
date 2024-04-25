using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.GroupEvaluations
{
    public partial class GroupEvaluationMenu : UserControl
    {
        public GroupEvaluationMenu()
        {
            InitializeComponent();
        }

        private void addPanel(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            GroupEvaluationPanel.Controls.Clear();
            GroupEvaluationPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();

        }

        private void btnMarkEvaluation_Click(object sender, EventArgs e)
        {
            MarkEvaluations markev = new MarkEvaluations();
            addPanel(markev);
        }

        private void btnManageEvaluation_Click(object sender, EventArgs e)
        {
            ManageEvaluationForm mng = new ManageEvaluationForm();
            addPanel(mng);
        }
    }
}
