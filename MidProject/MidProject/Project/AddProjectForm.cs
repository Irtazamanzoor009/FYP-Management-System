using MidProject.ProjectDL;
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
    public partial class AddProjectForm : UserControl
    {
        public AddProjectForm()
        {
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            string projecttitle = txtProjectTitle.Text;
            string projectdescription = txtDescription.Text;

            ProjectCRUD.AddProject(projecttitle, projectdescription);
            MessageBoxInfo.InfoMessageBox("Project Added Successfully");
            ClearContents();
        }

        private void ClearContents()
        {
            txtProjectTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }
    }
}
