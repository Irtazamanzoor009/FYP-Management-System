using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Advisors
{
    public partial class AdvisorMenu : UserControl
    {
        public AdvisorMenu()
        {
            InitializeComponent();
        }

        private void addPanel(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            AdvisorMenuPanel.Controls.Clear();
            AdvisorMenuPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();

        }

        private void btnViewAdvisors_Click(object sender, EventArgs e)
        {
            ViewAdvisorsForm viewadv = new ViewAdvisorsForm();
            addPanel(viewadv);
        }

        private void btnAddAdivsors_Click(object sender, EventArgs e)
        {
            AddAdvisorsForm addadv = new AddAdvisorsForm();
            addPanel(addadv);
        }

        private void btnUpdateAdivsors_Click(object sender, EventArgs e)
        {
            UpdateAdvisorsForm updtadv = new UpdateAdvisorsForm();
            addPanel(updtadv);
        }

        private void btnDeleteAdvisors_Click(object sender, EventArgs e)
        {
            DeleteAdvisorForm deltadv = new DeleteAdvisorForm();
            addPanel(deltadv);
        }
    }
}
