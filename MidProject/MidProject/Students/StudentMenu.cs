using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.Students
{
    public partial class StudentMenuForm : UserControl
    {
        public StudentMenuForm()
        {
            InitializeComponent();
        }

        private void addPanel(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            StudentMenuPanel.Controls.Clear();
            StudentMenuPanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();
            
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // iss ko khatam nai krna
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            AddStudentForm addstdfrom = new AddStudentForm();
            addPanel(addstdfrom);
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            ViewStudentForm viewstdform = new ViewStudentForm();
            addPanel(viewstdform);
        }

        private void btnDeleteStudents_Click(object sender, EventArgs e)
        {
            DeleteStudentForm deletestd = new DeleteStudentForm();
            addPanel(deletestd);
        }

        private void btnUpdateStudents_Click(object sender, EventArgs e)
        {
            UpdateStudentForm updtstdform = new UpdateStudentForm();
            addPanel(updtstdform);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StudentMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
