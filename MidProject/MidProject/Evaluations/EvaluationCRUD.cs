using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.Evaluations
{
    internal class EvaluationCRUD
    {
        public static void UpdateEvaluation(string id,string name, string marks, string weightage)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Evaluation Set Name=@name, TotalMarks=@marks, TotalWeightage=@weightage where Id=@id", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@marks", marks);
            cmd.Parameters.AddWithValue("@weightage", weightage);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }

        public static void DeleteEvaluation(string id) 
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Delete From Evaluation where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void InsertIntoEvaluation(string name, string TotalMarks, string TotalWeightage)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Evaluation values (@Name, @TotalMarks,@TotalWeightage)", con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@TotalMarks", TotalMarks);
            cmd.Parameters.AddWithValue("@TotalWeightage", TotalWeightage);
            cmd.ExecuteNonQuery();
        }

        public static SqlCommand ViewAllEvaluation()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Evaluation", con);
            return cmd;
        }
    }
}
