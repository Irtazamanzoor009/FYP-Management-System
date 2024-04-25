using MidProject.GroupDL;
using MidProject.StudentsDL;
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
    public partial class CreateGroupForm : UserControl
    {

        private bool checkBoxColumnAdded = false;
        public List<int> selectedrow = new List<int>();
       
        public CreateGroupForm()
        {
            InitializeComponent();
            PopulateGroupTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Cells["checkBoxColumn"].Value = Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue);
                if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
                {
                    selectedrow.Add(e.RowIndex);
                }
                if (!Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
                {
                    selectedrow.Remove(e.RowIndex);
                }
            }
        }


        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int count = selectedrow.Count();
            if (selectedrow.Count() == 2)
            {
                GroupCRUD.CreateGroup(date);

                int grpid = GroupCRUD.GetMaxGroupNumber();

                foreach (var i in selectedrow)
                {
                    string studentId = dataGridView1.Rows[i].Cells["ID"].Value.ToString();

                    GroupCRUD.InsertIntoGroupStudent(grpid, studentId, date);
                }
                MessageBoxInfo.InfoMessageBox("Group Added Successfully");
            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Please Select Only 2 students");
                selectedrow.Clear();
            }
            PopulateGroupTable();

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Cells["checkBoxColumn"].Value = Convert.ToBoolean(row.Cells["checkBoxColumn"].EditedFormattedValue);
                if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
                {
                    selectedrow.Add(e.RowIndex);
                }
                if (!Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
                {
                    selectedrow.Remove(e.RowIndex);
                }
            }
        }

        private void PopulateGroupTable()
        {
            SqlCommand cmd = GroupCRUD.ViewStudents();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (!checkBoxColumnAdded)
            {
                AddCheckBoxColumn();
                checkBoxColumnAdded = true; 
            }
        }

        private void AddCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "checkBoxColumn";
            dataGridView1.Columns.Add(checkBoxColumn);
        }

        
    }
}
