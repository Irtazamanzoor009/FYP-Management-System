using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProject.AdvisorsDL
{
    internal class AdvisorsCRUD
    {
        public static int GetDesignationID(string designation)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select id  from Lookup where Value = @Designation", con);
                cmd.Parameters.AddWithValue("@Designation", designation);
                int designationValue = int.Parse(cmd.ExecuteScalar().ToString());
                return designationValue;
            }
            catch (SqlException ex)
            {
                return -1;
            }
        }

        public static string GetDesignationValue(string designation)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select Value From Lookup where ID = @Designation", con);
                cmd.Parameters.AddWithValue("@Designation", designation);
                string getvalue = cmd.ExecuteScalar().ToString();
                return getvalue;
            }
            catch (SqlException ex)
            {
                MessageBoxInfo.ErrorMessageBox(ex.Message);
                return "";
            }
        }

        public static string GetAdvisorID(string firstname, string lastname)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select ID From Person where FirstName = @firstname and LastName = @lastname", con);
                cmd.Parameters.AddWithValue("@FirstName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                string getId = cmd.ExecuteScalar().ToString();
                return getId;
            }
            catch(SqlException ex)
            {
                MessageBoxInfo.ErrorMessageBox(ex.Message);
                return "";
            }
        }

        public static void AddAdvisorPerson(string firstname, string lastname, string contact, string email, DateTime dateofbirth, string gender)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Person values (@FirstName, @LastName,@Contact, @Email, @DateOfBirth, @Gender)", con);

            cmd.Parameters.AddWithValue("@FirstName", firstname);
            cmd.Parameters.AddWithValue("@LastName", lastname);
            cmd.Parameters.AddWithValue("@Contact", contact);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.ExecuteNonQuery();
        }

        public static void AddAdvisor(int id, string designation, string salary)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("insert into Advisor values (@ID ,@Designation, @Salary)", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Designation", designation);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return -1;
            }
        }

        public static SqlCommand ViewRegisteredAdvisor()
        {
            var con = Configuration.getInstance().getConnection();            
            SqlCommand cmd = new SqlCommand("Select Person.ID, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, (Select Lookup.Value From Lookup where Lookup.Category = 'Gender' and Lookup.ID = Person.Gender) as Gender, (Select Lookup.Value From Lookup where Lookup.Category = 'Designation' and Lookup.ID = Advisor.Designation) as Designation, Advisor.Salary From Person inner join Advisor on Advisor.ID = Person.ID where RIGHT(FirstName,2) <> '-D' and RIGHT(LastName,2) <> '-D'", con);
            return cmd;
        }

        public static SqlCommand ViewDeletedAdvisor()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Person.ID, LEFT(Person.FirstName, LEN(Person.FirstName) - 2) as FirstName, LEFT(Person.LastName, LEN(Person.LastName) - 2) as LastName, Person.Contact, Person.Email, Person.DateOfBirth, (SELECT Lookup.Value FROM Lookup WHERE Lookup.Category = 'Gender' AND Lookup.ID = Person.Gender) AS Gender, (SELECT Lookup.Value FROM Lookup WHERE Lookup.Category = 'Designation' AND Lookup.ID = Advisor.Designation) AS Designation, Advisor.Salary FROM Person INNER JOIN Advisor ON Advisor.ID = Person.ID WHERE RIGHT(FirstName, 2) = '-D' AND RIGHT(LastName, 2) = '-D'", con);

            //SqlCommand cmd = new SqlCommand("Select Person.ID, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, (Select Lookup.Value From Lookup where Lookup.Category = 'Gender' and Lookup.ID = Person.Gender) as Gender, (Select Lookup.Value From Lookup where Lookup.Category = 'Designation' and Lookup.ID = Advisor.Designation) as Designation, Advisor.Salary From Person inner join Advisor on Advisor.ID = Person.ID where RIGHT(FirstName,2) = '-D' and RIGHT(LastName,2) = '-D'", con);
            return cmd;
        }

        public static void UpdateAdvisorInformation(string idvalue, string firstname, string lastname, string contact, string email, DateTime dateofbirth, string gender, string designation, string salary)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand Updatecmd = new SqlCommand("Update Person Set FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender where ID = @ID", con);
            SqlCommand UpdateAdv = new SqlCommand("Update Advisor Set Designation = @Designation, Salary = @Salary where ID = @ID", con);

            UpdateAdv.Parameters.AddWithValue("@ID", idvalue);
            UpdateAdv.Parameters.AddWithValue("@Designation", designation);
            UpdateAdv.Parameters.AddWithValue("@Salary", salary);

            Updatecmd.Parameters.AddWithValue("@ID", idvalue);
            Updatecmd.Parameters.AddWithValue("@FirstName", firstname);
            Updatecmd.Parameters.AddWithValue("@LastName", lastname);
            Updatecmd.Parameters.AddWithValue("@Contact", contact);
            Updatecmd.Parameters.AddWithValue("@Email", email);
            Updatecmd.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
            Updatecmd.Parameters.AddWithValue("@Gender", gender);

            Updatecmd.ExecuteNonQuery();
            UpdateAdv.ExecuteNonQuery();
        }

        public static void DeleteAdvisor(string FirstName, string LastName, string id)
        {
            var connection = Configuration.getInstance().getConnection();
            SqlCommand command = new SqlCommand("Update Person set FirstName=@NewFirstName,LastName=@NewLastName where FirstName=@FirstName and LastName =@LastName", connection);
            command.Parameters.AddWithValue("@NewFirstName", FirstName + "-D");
            command.Parameters.AddWithValue("@NewLastName", LastName + "-D");
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Select ProjectId from ProjectAdvisor where AdvisorId=@id", connection);
            cmd2.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd2.ExecuteReader();
            List<string> projectIds = new List<string>();
            while (reader.Read())
            {
                projectIds.Add(reader["ProjectId"].ToString());
            }
            reader.Close();

            foreach (string projectId in projectIds)
            {
                SqlCommand cmd3 = new SqlCommand("Delete From GroupProject where ProjectId=@pid", connection);
                cmd3.Parameters.AddWithValue("@pid", projectId);
                cmd3.ExecuteNonQuery();
            }

            SqlCommand cmd = new SqlCommand("Delete From ProjectAdvisor where AdvisorId=@id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();


        }
    }
}
