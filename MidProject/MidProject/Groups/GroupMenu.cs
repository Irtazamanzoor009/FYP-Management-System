using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Groups
{
    public partial class GroupMenu : UserControl
    {
        public GroupMenu()
        {
            InitializeComponent();
        }

        private void addPanel(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            GroupMenuPanel.Controls.Clear();
            GroupMenuPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();

        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            CreateGroupForm crtgrpform = new CreateGroupForm();
            addPanel(crtgrpform);
        }

        private void btnAssignProject_Click(object sender, EventArgs e)
        {
            AssignProjects assignprojet = new AssignProjects();
            addPanel(assignprojet);
        }

        private void btnViewGroups_Click(object sender, EventArgs e)
        {
            ViewGroups viewgroup = new ViewGroups();
            addPanel(viewgroup);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAssignedProject viewassignproject = new ViewAssignedProject();
            addPanel(viewassignproject);
        }
    }
}
