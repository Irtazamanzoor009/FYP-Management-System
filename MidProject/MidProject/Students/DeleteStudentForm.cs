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

namespace MidProject.Students
{
    public partial class DeleteStudentForm : UserControl
    {
        public DeleteStudentForm()
        {
            InitializeComponent();
            PopulateRegisterdStudentTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // cell content click
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PopulateRegisterdStudentTable()
        {
            SqlCommand cmd = StudentCRUD.ViewRegisteredStuents();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].Visible = false;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            StudentCRUD.DeleteAllStudents();
            MessageBoxInfo.InfoMessageBox("All Students Data have been deleted");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string regno = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (regno != string.Empty)
                {
                    StudentCRUD.DeleteStudent(regno,id);
                    MessageBoxInfo.InfoMessageBox("Student Record Deleted Successfully");
                    PopulateRegisterdStudentTable();
                }
                
            }
            else
            {
                MessageBoxInfo.ErrorMessageBox("Select Row first");

            }

        }

        private void DeleteStudentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
