using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.GroupEvaluations
{
    internal class GroupEvaluationCRUD
    {
        public static SqlCommand ViewAllGroupEvaluation()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select GroupProject.GroupId, Concat(st.FirstName, ' ' , st.LastName) as StudetName,  Project.Title, Concat(ad.FirstName,' ', ad.LastName) as AdvisorName, sum(GroupEvaluation.ObtainedMarks) as TotalMarks From GroupProject inner join [Group] on [Group].Id = GroupProject.GroupId inner join GroupStudent on [Group].Id = GroupStudent.GroupId inner join Student on Student.Id = GroupStudent.StudentId inner join Person as st on st.Id = Student.Id inner join Project on GroupProject.ProjectId = Project.Id inner join ProjectAdvisor on ProjectAdvisor.ProjectId = Project.Id inner join Advisor on ProjectAdvisor.AdvisorId = Advisor.Id inner join Person as ad on ad.Id = Advisor.Id inner join GroupEvaluation on GroupEvaluation.GroupId = [Group].Id where GroupStudent.Status <> 4 GROUP BY GroupProject.GroupId, CONCAT(st.FirstName, ' ', st.LastName), Project.Title, CONCAT(ad.FirstName,' ', ad.LastName) order by GroupProject.GroupId", con);
            return cmd;
        }

        public static SqlCommand ViewGroupEvaluationByID(string id)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "Select * From GroupEvaluation where GroupId=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd;
        }

        public static SqlCommand ViewAllGroups()
        {
            var con = Configuration.getInstance().getConnection();
            string query2 = "Select [Group].Id, [Group].Created_on, Project.Title, Concat(ad.FirstName, ' ', ad.LastName) as AdvisorName From [Group] inner join GroupStudent on [Group].Id = GroupStudent.GroupId inner join Student on Student.Id = GroupStudent.StudentId inner join Person as st on Student.Id = st.Id inner join GroupProject on GroupProject.GroupId = [Group].Id inner join Project on Project.Id = GroupProject.ProjectId inner join ProjectAdvisor on ProjectAdvisor.ProjectId = Project.Id inner join Advisor on Advisor.Id = ProjectAdvisor.AdvisorId inner join Person as ad on Advisor.Id = ad.Id where GroupStudent.status <> 4 group BY   [Group].Id,  [Group].Created_on, Project.Title,    Concat(ad.FirstName, ' ', ad.LastName)";
            SqlCommand cmd = new SqlCommand(query2, con);
            return cmd;
        }

        public static void InsertIntoGroupEvaluation(string GroupID, string EvaluationID, double marks1, DateTime date)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into GroupEvaluation values (@GroupId, @EvaluationId,@ObtainedMarks, @EvaluationDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", GroupID);
            cmd.Parameters.AddWithValue("@EvaluationId", EvaluationID);
            cmd.Parameters.AddWithValue("@ObtainedMarks", marks1);
            cmd.Parameters.AddWithValue("@EvaluationDate", date);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateObtainedMarksInDatabase(string evaluationId, string groupId, string newObtainedMarks)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "UPDATE GroupEvaluation SET ObtainedMarks = @obtainedMarks WHERE EvaluationId = @evaluationId AND GroupId = @groupId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@obtainedMarks", newObtainedMarks);
            cmd.Parameters.AddWithValue("@evaluationId", evaluationId);
            cmd.Parameters.AddWithValue("@groupId", groupId);
            cmd.ExecuteNonQuery();
        }

        public static SqlCommand GetFromEvaluationTable(string id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select GroupEvaluation.GroupId, GroupEvaluation.EvaluationId, Evaluation.Name, Evaluation.TotalMarks, Evaluation.TotalWeightage, GroupEvaluation.EvaluationDate From GroupEvaluation inner join Evaluation on Evaluation.Id = GroupEvaluation.EvaluationId where GroupEvaluation.Groupid=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd;
        }

        public static string FetchObtainedMarksFromDatabase(string evaluationId, string groupId)
        {
            string obtainedMarks = "";
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select GroupEvaluation.ObtainedMarks From GroupEvaluation inner join Evaluation on Evaluation.Id = GroupEvaluation.EvaluationId where GroupEvaluation.Groupid=@grpid and GroupEvaluation.EvaluationId=@evId", con);
            cmd.Parameters.AddWithValue("@grpid", groupId);
            cmd.Parameters.AddWithValue("@evId", evaluationId);
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                obtainedMarks = result.ToString();
            }
            return obtainedMarks;
        }
    }
}
