using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProject.ProjectDL
{
    internal class ProjectCRUD
    {
        public static void AddProject(string title, string description)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("insert into Project values (@Description ,@Title)", con);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBoxInfo.ErrorMessageBox(ex.Message);
            }
        }

        public static SqlCommand ViewProjects()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Id, Title, Description From Project", con);
            return cmd;
        }

        public static void UpdateProjectInformation(string title, string description, string id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand Updatecmd = new SqlCommand("Update Project Set Title = @Title, Description = @Description where ID = @ID", con);

            Updatecmd.Parameters.AddWithValue("@ID", id);
            Updatecmd.Parameters.AddWithValue("@Title", title);
            Updatecmd.Parameters.AddWithValue("@Description", description);

            Updatecmd.ExecuteNonQuery();
        }

        public static void DeleteProject(string id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand Deletecmd = new SqlCommand("Delete From Project where id=@id",con);
            SqlCommand DeleteGroupProject = new SqlCommand("Delete From GroupProject where ProjectId=@id", con);
            SqlCommand DeleteGroupAdvisor = new SqlCommand("Delete From ProjectAdvisor where ProjectId=@id", con);
            DeleteGroupAdvisor.Parameters.AddWithValue("@id", id);
            DeleteGroupProject.Parameters.AddWithValue("@id", id);
            Deletecmd.Parameters.AddWithValue("@id", id);
            DeleteGroupAdvisor.ExecuteNonQuery ();
            DeleteGroupProject.ExecuteNonQuery();
            Deletecmd.ExecuteNonQuery();
        }
    }
}
