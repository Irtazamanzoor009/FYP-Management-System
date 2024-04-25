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

namespace MidProject.GroupEvaluations
{
    public partial class UpdateEvaluationForm : Form
    {
        string id, firstname, lastname;
        public UpdateEvaluationForm(string id, string firstname, string lastname, string marks)
        {
            InitializeComponent();
            lblId.Text = id;
            lblname.Text = firstname + lastname;
            txtMarks.Text = marks;
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        private void UpdateEvaluationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update GroupEvaluation set ObtainedMarks=@newmarks From GroupEvaluation inner join [Group] on [Group].Id = GroupEvaluation.GroupId inner join GroupStudent on GroupStudent.GroupId = [Group].Id inner join Student on GroupStudent.StudentId = StudentId inner join Person on Person.Id = Student.Id where GroupEvaluation.GroupId=@id and Person.FirstName = @firstname and Person.LastName = @lastname", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@newmarks",txtMarks.Text);
            cmd.ExecuteNonQuery();

            MessageBoxInfo.InfoMessageBox("Student Marks have been updated Successfully");
        }
    }
}
