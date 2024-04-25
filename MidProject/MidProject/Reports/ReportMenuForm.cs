using MidProject.AdvisorsDL;
using MidProject.ProjectDL;
using MidProject.Students;
using MidProject.StudentsDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using iTextSharp.text;


namespace MidProject.Reports
{
    public partial class ReportMenuForm : UserControl
    {
       // private PrintDocument printDocument2_PrintPage;

        public ReportMenuForm()
        {
            InitializeComponent();
        }

        DataTable GetAllStudents()
        {
            DataTable student = new DataTable();
            student.Columns.Add("Registration No.");
            student.Columns.Add("First Name");
            student.Columns.Add("Last Name");
            student.Columns.Add("Contact");
            student.Columns.Add("Email");
            student.Columns.Add("DOB");
            student.Columns.Add("Gender");
            string q = "Select Student.RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, (Select Lookup.Value From Lookup where Lookup.Category = 'Gender' and Person.Gender = Lookup.ID) as Gender From Person inner join Student on Student.ID = Person.ID where RIGHT(RegistrationNo,2) <> '-D'";
            
            SqlCommand sqlcmd1 = new SqlCommand(q, Configuration.getInstance().getConnection());
            SqlDataReader dr = sqlcmd1.ExecuteReader();
            while (dr.Read())
            {
                student.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }

            return student;
        }

        DataTable GetAllAdvisors()
        {
            DataTable advisor = new DataTable();
            advisor.Columns.Add("First Name");
            advisor.Columns.Add("Last Name");
            advisor.Columns.Add("Contact");
            advisor.Columns.Add("Email");
            advisor.Columns.Add("DOB");
            advisor.Columns.Add("Gender");
            advisor.Columns.Add("Designation");
            advisor.Columns.Add("Salary");
            string q = "Select Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, (Select Lookup.Value From Lookup where Lookup.Category = 'Gender' and Lookup.ID = Person.Gender) as Gender, (Select Lookup.Value From Lookup where Lookup.Category = 'Designation' and Lookup.ID = Advisor.Designation) as Designation, Advisor.Salary From Person inner join Advisor on Advisor.ID = Person.ID where RIGHT(FirstName,2) <> '-D' and RIGHT(LastName,2) <> '-D'";

            SqlCommand sqlcmd1 = new SqlCommand(q, Configuration.getInstance().getConnection());
            SqlDataReader dr = sqlcmd1.ExecuteReader();
            while (dr.Read())
            {
                advisor.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }

            return advisor;
        }

        DataTable GetEvaluationMarks()
        {
            DataTable advisor = new DataTable();
            advisor.Columns.Add("Group ID");
            advisor.Columns.Add("Student Name");
            advisor.Columns.Add("Project Title");
            advisor.Columns.Add("Advisor Name");
            advisor.Columns.Add("Obtained Marks");
            string q = "Select GroupProject.GroupId, Concat(st.FirstName, ' ' , st.LastName) as StudetName,  Project.Title, Concat(ad.FirstName,' ', ad.LastName) as AdvisorName, sum(GroupEvaluation.ObtainedMarks) as TotalMarks From GroupProject inner join [Group] on [Group].Id = GroupProject.GroupId inner join GroupStudent on [Group].Id = GroupStudent.GroupId inner join Student on Student.Id = GroupStudent.StudentId inner join Person as st on st.Id = Student.Id inner join Project on GroupProject.ProjectId = Project.Id inner join ProjectAdvisor on ProjectAdvisor.ProjectId = Project.Id inner join Advisor on ProjectAdvisor.AdvisorId = Advisor.Id inner join Person as ad on ad.Id = Advisor.Id inner join GroupEvaluation on GroupEvaluation.GroupId = [Group].Id where GroupStudent.Status <> 4 GROUP BY GroupProject.GroupId, CONCAT(st.FirstName, ' ', st.LastName), Project.Title, CONCAT(ad.FirstName,' ', ad.LastName) order by GroupProject.GroupId ";

            SqlCommand sqlcmd1 = new SqlCommand(q, Configuration.getInstance().getConnection());
            SqlDataReader dr = sqlcmd1.ExecuteReader();
            while (dr.Read())
            {
                advisor.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }

            return advisor;
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            CreatePdfFromDataTable("Registered Students", GetAllStudents());
        }

        private void btnAllAdvisors_Click(object sender, EventArgs e)
        {
            CreatePdfFromDataTable("Registered Advisors", GetAllAdvisors());
        }


        private void btnEvaluationStatus_Click(object sender, EventArgs e)
        {
            
        }       


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewAssignedProjects_Click(object sender, EventArgs e)
        {
            CreatePdfFromDataTable("Assigned Projects", ViewAllAssignedProjects());
        }

        DataTable ViewAllAssignedProjects()
        {
            DataTable student = new DataTable();
            student.Columns.Add("Group ID");
            student.Columns.Add("Student Name");
            student.Columns.Add("Project Name");
            student.Columns.Add("Advisor Name");
            string q = "Select GroupProject.GroupId, Concat(st.FirstName, ' ' , st.LastName) as StudetName,  Project.Title, Concat(ad.FirstName,' ', ad.LastName) as AdvisorName From GroupProject inner join [Group] on [Group].Id = GroupProject.GroupId inner join GroupStudent on [Group].Id = GroupStudent.GroupId inner join Student on Student.Id = GroupStudent.StudentId inner join Person as st on st.Id = Student.Id inner join Project on GroupProject.ProjectId = Project.Id inner join ProjectAdvisor on ProjectAdvisor.ProjectId = Project.Id inner join Advisor on ProjectAdvisor.AdvisorId = Advisor.Id inner join Person as ad on ad.Id = Advisor.Id order by GroupProject.GroupId";
            SqlCommand sqlcmd1 = new SqlCommand(q, Configuration.getInstance().getConnection());
            SqlDataReader dr = sqlcmd1.ExecuteReader();
            while (dr.Read())
            {
                student.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }

            return student;
        }

        private void CreatePdfFromDataTable(string title, DataTable dataTable)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
            saveFileDialog.Title = "Export to PDF";
            saveFileDialog.FileName = title;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();
                Paragraph heading1 = new Paragraph("University of Engineering & Technology, Lahore", FontFactory.GetFont("Arial", 20));
                heading1.Alignment = Element.ALIGN_CENTER;
                document.Add(heading1);
                document.Add(new iTextSharp.text.Chunk("\n"));

                Paragraph heading2 = new Paragraph("Department of Computer Sciences", FontFactory.GetFont("Arial", 20));
                heading2.Alignment = Element.ALIGN_CENTER;
                document.Add(heading2);
                document.Add(new iTextSharp.text.Chunk("\n"));

                Paragraph heading = new Paragraph(title, FontFactory.GetFont("Arial", 20));
                heading.Alignment = Element.ALIGN_CENTER;
                document.Add(heading);
                document.Add(new iTextSharp.text.Chunk("\n"));

                iTextSharp.text.pdf.PdfPTable pdfTable = new iTextSharp.text.pdf.PdfPTable(dataTable.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataColumn column in dataTable.Columns)
                {
                    iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new Phrase(column.ColumnName));
                    pdfTable.AddCell(cell);
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        string cellText = item != null ? item.ToString() : "";
                        pdfTable.AddCell(cellText);
                    }
                }

                document.Add(pdfTable);

                document.Close();
                MessageBoxInfo.InfoMessageBox("PDF file has been saved in your system");
            }
        }

        private void btnEvaluationMarks_Click(object sender, EventArgs e)
        {
            CreatePdfFromDataTable("Student Marks", GetEvaluationMarks());
        }
    }
}
