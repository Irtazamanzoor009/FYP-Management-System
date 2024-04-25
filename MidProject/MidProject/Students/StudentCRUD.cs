using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MidProject.StudentsDL
{
    internal class StudentCRUD
    {
        public static int GetGenderID(string gender)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select id  from Lookup where Value = @Gender", con);
                cmd.Parameters.AddWithValue("@Gender", gender);
                int id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
            catch (SqlException ex)
            {
                return -1;
            }
        }

        public static string GetGenderValue(string gender)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select Value From Lookup where ID = @Gender",con);
                cmd.Parameters.AddWithValue("@Gender", gender);
                string getvalue = cmd.ExecuteScalar().ToString();
                return getvalue;
            }
            catch (SqlException ex) 
            {
                MessageBoxInfo.ErrorMessageBox(ex.Message);
                return "";
            }
        }

        public static int GetLastPersonId()
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select Max(ID) as LastID From Person", con);
                int ans = Convert.ToInt32(cmd.ExecuteScalar());
                return ans;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public static void AddRegistrationNumber(int id, string regno)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("insert into Student values (@ID,@RegistrationNo)", con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@RegistrationNo", regno);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return -1;
            }
        }

        public static void AddPerson(string firstname, string lastname, string contact, string email, DateTime dateofbirth, string gender)
        {
            try
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
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static SqlCommand ViewRegisteredStuents()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Person.ID, Student.RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, (Select Lookup.Value From Lookup where Lookup.Category = 'Gender' and Person.Gender = Lookup.ID) as Gender From Person inner join Student on Student.ID = Person.ID where RIGHT(RegistrationNo,2) <> '-D'", con);
            return cmd;
        }

        public static SqlCommand ViewDeletedStudents()
        {
            var con = Configuration.getInstance().getConnection();
             SqlCommand cmd = new SqlCommand("Select Person.ID, LEFT(Student.RegistrationNo, LEN(Student.RegistrationNo) - 2) as RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, (Select Lookup.Value From Lookup where Lookup.Category = 'Gender' and Person.Gender = Lookup.ID) as Gender From Person inner join Student on Student.ID = Person.ID where RIGHT(RegistrationNo,2) = '-D'", con);
            return cmd;
        }

        public static void UpdateStudentInformation(string idvalue, string regno, string firstname, string lastname, string contact, string email, DateTime dateofbirth, string gender)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand Updatecmd = new SqlCommand("Update Person Set FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender where ID = @ID", con);
            SqlCommand UpdateRegNo = new SqlCommand("Update Student Set RegistrationNo = @RegistrationNo where ID = @ID", con);

            UpdateRegNo.Parameters.AddWithValue("@ID", idvalue);
            UpdateRegNo.Parameters.AddWithValue("@RegistrationNo", regno);
            Updatecmd.Parameters.AddWithValue("@ID", idvalue);
            Updatecmd.Parameters.AddWithValue("@FirstName", firstname);
            Updatecmd.Parameters.AddWithValue("@LastName", lastname);
            Updatecmd.Parameters.AddWithValue("@Contact", contact);
            Updatecmd.Parameters.AddWithValue("@Email", email);
            Updatecmd.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
            Updatecmd.Parameters.AddWithValue("@Gender", gender);
            Updatecmd.ExecuteNonQuery();
            UpdateRegNo.ExecuteNonQuery();
        }

        public int CountGroupStudents(string studentId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select GroupId from GroupStudent where StudentId=@stid", con);
            cmd1.Parameters.AddWithValue("@stid", studentId);
            int count = 0;
            SqlCommand cmd = new SqlCommand("Select count(*) From GroupStudent where GroupId = @id",con);
           // cmd.Parameters.AddWithValue("@id", groupId);
            //cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count = Convert.ToInt32(reader["CountElements"]);
                }
            }
            reader.Close();
            return count;

        }

        public static void DeleteStudent(string regNo, string id)
        {
            var connection = Configuration.getInstance().getConnection();
            SqlCommand command = new SqlCommand("Update Student set RegistrationNo=@newReg where RegistrationNo=@regNo", connection);
            command.Parameters.AddWithValue("@regNo", regNo);
            command.Parameters.AddWithValue("@newReg", regNo + "-D");

            SqlCommand DeleteFromGroup = new SqlCommand("Update GroupStudent set Status=4 where StudentId=@id", connection);
            DeleteFromGroup.Parameters.AddWithValue("@id", id);
            DeleteFromGroup.ExecuteNonQuery();
            command.ExecuteNonQuery();
        }

        public static void DeleteAllStudents()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand deleteStudentCmd = new SqlCommand("DELETE FROM Student", con);
            deleteStudentCmd.ExecuteNonQuery();
            SqlCommand deleteGroupStudentCmd = new SqlCommand("DELETE FROM GroupStudent", con);
            deleteGroupStudentCmd.ExecuteNonQuery();
            SqlCommand deletePersonCmd = new SqlCommand("DELETE FROM Person", con);
            deletePersonCmd.ExecuteNonQuery();
        }
    }
}
