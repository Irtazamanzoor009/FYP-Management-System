using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Project
{
    public partial class ProjectMenuForm : UserControl
    {
        public ProjectMenuForm()
        {
            InitializeComponent();
        }

        private void addPanel(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            ProjectMenuPanel.Controls.Clear();
            ProjectMenuPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();

        }

        private void btnViewProjects_Click(object sender, EventArgs e)
        {
            ViewProjectForm viewproject = new ViewProjectForm();
            addPanel(viewproject);
        }

        private void btnAddProjects_Click(object sender, EventArgs e)
        {
            AddProjectForm addprojectform = new AddProjectForm();
            addPanel(addprojectform);
        }

        private void btnUpdateProjects_Click(object sender, EventArgs e)
        {
            UpdateProjectForm updtProjectForm = new UpdateProjectForm();
            addPanel(updtProjectForm);
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            DeleteProjectForm deleteproject = new DeleteProjectForm();
            addPanel(deleteproject);
        }
    }
}
