using MidProject.AdvisorsDL;
using MidProject.GroupDL;
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

namespace MidProject.Groups
{
    public partial class AssignProjects : UserControl
    {
        private string GroupID;
        private string ProjectID;
        public AssignProjects()
        {
            InitializeComponent();
            PopulateGroupTable();
            gridOfProjects.Visible = false;
            btnSelectProject.Visible = false;
            comboBox1.Visible = false;
            btnSelectAdvisor.Visible = false;
        }

        private void gridOfGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void PopulateGroupTable()
        {
            SqlCommand cmd = GroupCRUD.ViewGroups();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridOfGroups.DataSource = dt;
            
        }

        public void PopulateProjectsTable()
        {
            SqlCommand cmd = GroupCRUD.GetAllProjects();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridOfProjects.DataSource = dt;
        }

        private void btnSelectGroup_Click(object sender, EventArgs e)
        {
            if (gridOfGroups.SelectedRows.Count > 0)
            {
                GroupID = gridOfGroups.SelectedRows[0].Cells[0].Value.ToString();
                gridOfProjects.Visible = true;
                btnSelectProject.Visible = true;
                PopulateProjectsTable();
               
            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Select 1 Group");

            }
        }

        private void btnSelectProject_Click(object sender, EventArgs e)
        {
            if (gridOfProjects.SelectedRows.Count > 0)
            {
                ProjectID = gridOfProjects.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Visible = true;
                btnSelectAdvisor.Visible = true;
                PopulateComboBox();
                
            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Select 1 Project");

            }
        }

        public void PopulateComboBox()
        {
            SqlCommand cmd = GroupCRUD.GetValuesInComboBox();
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private void btnSelectAdvisor_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string[] parts = name.Split(new[] {' '},2 );
            string firstname = parts[0];
            string lastname = parts[1];
            DateTime date = DateTime.Now;
            string AdvisorID = AdvisorsCRUD.GetAdvisorID(firstname,lastname).ToString();
            GroupCRUD.InsertIntoGroupProject(ProjectID, GroupID, date);
            GroupCRUD.InsertIntoProjectAdvisor(AdvisorID, ProjectID, date);
            MessageBoxInfo.InfoMessageBox("Project and advisor added successfully");
            PopulateGroupTable();
            gridOfProjects.Visible = false;
            btnSelectProject.Visible = false;
            comboBox1.Visible = false;
            btnSelectAdvisor.Visible = false;
        }

        private void gridOfProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
