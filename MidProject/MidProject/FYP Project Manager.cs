using MidProject.Advisors;
using MidProject.Evaluations;
using MidProject.GroupEvaluations;
using MidProject.Groups;
using MidProject.Project;
using MidProject.Reports;
using MidProject.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject
{
    public partial class FYP_Project_Manager : Form
    {
        public FYP_Project_Manager()
        {
            InitializeComponent();
        }

        private void AddPanel(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            StudentMenuForm stdMenu = new StudentMenuForm();
            AddPanel(stdMenu);

        }

        private void btnManageAdvisor_Click(object sender, EventArgs e)
        {
            AdvisorMenu advisor = new AdvisorMenu();
            AddPanel(advisor);
        }

        private void btnManageProjects_Click(object sender, EventArgs e)
        {
            ProjectMenuForm prjform = new ProjectMenuForm();
            AddPanel(prjform);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportMenuForm rpt = new ReportMenuForm();
            AddPanel(rpt);
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            GroupMenu grp = new GroupMenu();
            AddPanel(grp);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEvaluation_Click(object sender, EventArgs e)
        {
            EvaluationMenu evmenu = new EvaluationMenu();
            AddPanel(evmenu);
        }

        private void btnGroupEvaluations_Click(object sender, EventArgs e)
        {
            GroupEvaluationMenu grpevaluationmenu = new GroupEvaluationMenu();
            AddPanel(grpevaluationmenu);
        }
    }
}
