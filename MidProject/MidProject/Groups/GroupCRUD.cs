using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.GroupDL
{
    internal class GroupCRUD
    {
        public static SqlCommand ViewStudents()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Student.ID,  Student.RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, (SELECT Lookup.Value FROM Lookup WHERE Lookup.Category = 'Gender' AND Person.Gender = Lookup.ID) AS Gender FROM Student INNER JOIN Person ON Student.ID = Person.ID LEFT JOIN GroupStudent ON Student.ID = GroupStudent.StudentId WHERE RIGHT(Student.RegistrationNo, 2) <> '-D' AND GroupStudent.StudentId IS NULL;";
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd;
        }

        public static void CreateGroup(DateTime creationDate)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into [Group] values (@CreationDate)", con);
            cmd.Parameters.AddWithValue("@CreationDate", creationDate.ToString());
            cmd.ExecuteNonQuery();
        }

        public static int GetMaxGroupNumber()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("Select max(Id) from [Group]", con);
            int ans = Convert.ToInt32(cmd2.ExecuteScalar());
            cmd2.ExecuteNonQuery();
            return ans;
        }

        public static void InsertIntoGroupStudent(int grpid, string studentId, DateTime date)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO GroupStudent (GroupID, StudentID, Status, AssignmentDate) VALUES (@GroupID ,@StudentID, @Status, @AssignmentDate)", con);

            sqlCommand.Parameters.AddWithValue("@GroupID", grpid);
            sqlCommand.Parameters.AddWithValue("@StudentID", studentId);
            sqlCommand.Parameters.AddWithValue("@Status", 3);
            sqlCommand.Parameters.AddWithValue("@AssignmentDate", date.ToString("yyyy-MM-dd"));

            sqlCommand.ExecuteNonQuery();
        }

        public static SqlCommand ViewGroups()
        {
            var con = Configuration.getInstance().getConnection(); 
            SqlCommand cmd = new SqlCommand("SELECT [Group].Id, [Group].Created_On FROM [Group] LEFT JOIN GroupProject ON [Group].Id = GroupProject.GroupId inner join GroupStudent on [Group].Id = GroupStudent.GroupId WHERE GroupProject.GroupId IS NULL and GroupStudent.Status <> 4 group by [Group].Id,[Group].Created_On", con);
            return cmd;
        }

        public static SqlCommand GetAllProjects()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Project", con);
            return cmd;
        }

        public static SqlCommand GetValuesInComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Person.FirstName + ' ' + Person.LastName From Person inner join Advisor on Advisor.ID = Person.ID where RIGHT(FirstName,2) <> '-D' and RIGHT(LastName,2) <> '-D'", con);
            return cmd;
        }

        public static void InsertIntoGroupProject(string ProjectID, string GroupID, DateTime date)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand sqlCommand = new SqlCommand("Insert into GroupProject (ProjectId,GroupId,AssignmentDate) values (@PId,@GId, @date)", con);
            sqlCommand.Parameters.AddWithValue("@PId", ProjectID);
            sqlCommand.Parameters.AddWithValue("@GId", GroupID);
            sqlCommand.Parameters.AddWithValue("@date", date.ToString());
            sqlCommand.ExecuteNonQuery();
        }

        public static void InsertIntoProjectAdvisor(string AdvisorID, string ProjectID, DateTime date)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into ProjectAdvisor Values (@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)", con);
            cmd.Parameters.AddWithValue("@AdvisorId", AdvisorID);
            cmd.Parameters.AddWithValue("@ProjectId", ProjectID);
            cmd.Parameters.AddWithValue("@AdvisorRole", 11);
            cmd.Parameters.AddWithValue("@AssignmentDate", date);
            cmd.ExecuteNonQuery();
        }

        public static SqlCommand ViewAssignedProjects()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select GroupProject.GroupId, GroupStudent.StudentId, Concat(st.FirstName, ' ' , st.LastName) as StudetName, GroupProject.ProjectId, Project.Title, ProjectAdvisor.AdvisorId, Concat(ad.FirstName,' ', ad.LastName) as AdvisorName From GroupProject inner join [Group] on [Group].Id = GroupProject.GroupId inner join GroupStudent on [Group].Id = GroupStudent.GroupId inner join Student on Student.Id = GroupStudent.StudentId inner join Person as st on st.Id = Student.Id inner join Project on GroupProject.ProjectId = Project.Id inner join ProjectAdvisor on ProjectAdvisor.ProjectId = Project.Id inner join Advisor on ProjectAdvisor.AdvisorId = Advisor.Id inner join Person as ad on ad.Id = Advisor.Id where GroupStudent.Status <> 4 order by GroupProject.GroupId ";
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd;
        }

        public static SqlCommand ViewGroups1()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT GroupStudent.GroupId, GroupStudent.StudentId, CONCAT(Person.FirstName , ' ' , Person.LastName) AS Name FROM GroupStudent INNER JOIN Student ON GroupStudent.StudentId = Student.Id INNER JOIN Person ON Student.Id = Person.Id INNER JOIN Lookup AS StatusLookup ON GroupStudent.Status = StatusLookup.Id WHERE StatusLookup.Value = 'Active'", con);
            return cmd;
        }
    }
}

