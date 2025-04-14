using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace user_control_model.BL
{
    public class ViewTable
    {
        public static DataTable SearchByStudent(int id)
        {

            SqlCommand cmd = new SqlCommand("Select FName,LName,Email,DOB,Address,PNumber,Gender,Role from [TeamCopy].[dbo].[SUser]" +
                "  where UserID=@id");
            cmd.Parameters.AddWithValue("id", id);
            DataTable dt = DALFunctions.Select(cmd);
            return dt;
        }
        public static DataTable ViewAll()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM [TeamCopy].[dbo].[SUser] where Role='Student'");


            DataTable dt = DALFunctions.Select(cmd);

            return dt;
        }



        public static DataTable ViewAllTeacher()
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM [TeamCopy].[dbo].[SUser] where Role='Teacher'");


            DataTable dt = DALFunctions.Select(cmd);

            return dt;
        }

        public static int Update(int id, string Fname, string Lname, string password, DateTime DOB, string address, long PNumber, string Gender, string Role)
        {



            SqlCommand cmd = new SqlCommand(@"Update SUser set FName=@Fname,LName=@Lname  ,Password=@password ,Role=@Role ,DOB=@Dob
                     ,Address=@Address ,PNumber=@Phone ,Gender=@Gender where UserID=@Id ");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("Fname", Fname);
            cmd.Parameters.AddWithValue("Lname", Lname);
            cmd.Parameters.AddWithValue("Password", password);
            cmd.Parameters.AddWithValue("Role", Role);
            cmd.Parameters.AddWithValue("Dob", DOB);
            cmd.Parameters.AddWithValue("Address", address);
            cmd.Parameters.AddWithValue("Phone", PNumber);
            cmd.Parameters.AddWithValue("Gender", Gender);


            return DALFunctions.DML(cmd);


        }
        public static int Insert(string Fname, string Lname, string Email, string password, DateTime DOB, string address, long PNumber, string Gender, string Role)
        {


            SqlCommand cmd = new SqlCommand(@"Insert into  SUser  (FName,LName,Email,Password,Role,DOB
                     ,Address,PNumber,Gender) values (@Fname,@Lname,@Email,@password,@Role,@Dob
                     ,@Address,@Phone,@Gender)  ");
            cmd.Parameters.AddWithValue("Fname", Fname);
            cmd.Parameters.AddWithValue("Lname", Lname);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Password", password);
            cmd.Parameters.AddWithValue("Role", Role);
            cmd.Parameters.AddWithValue("Dob", DOB);
            cmd.Parameters.AddWithValue("Address", address);
            cmd.Parameters.AddWithValue("Phone", PNumber);
            cmd.Parameters.AddWithValue("Gender", Gender);


            return DALFunctions.DML(cmd);


        }

        public static int Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("Delete from SUser where UserId=@id");
            cmd.Parameters.AddWithValue("id", id);
            return DALFunctions.DML(cmd);

        }


        public static DataTable SearchByCourse(int SubjectId)
        {

            SqlCommand cmd = new SqlCommand("Select SName,Hours from Subject where SubjectID=@id");
            cmd.Parameters.AddWithValue("id", SubjectId);

            return DALFunctions.Select(cmd);
        }
        public static DataTable SearchTeacherForCourse()
        {

            SqlCommand cmd = new SqlCommand("Select UserId,FName from SUser where Role='Teacher'");


            return DALFunctions.Select(cmd);
        }

        public static DataTable SelectedTeachers(int SubjectId)
        {

            SqlCommand cmd = new SqlCommand("Select U.UserId,U.FName from SUser U inner join TeacherSubject ts on U.UserId=ts.TeacherId where ts.SubjectId=@subId");

            cmd.Parameters.AddWithValue("subId", SubjectId);
            return DALFunctions.Select(cmd);
        }

        public static int UpdateCourses(int id, string name, int hours)
        {

            SqlCommand cmd = new SqlCommand("Update Subject set SName=@name , Hours=@hours where SubjectID=@id");
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("hours", hours);
            cmd.Parameters.AddWithValue("id", id);
            return DALFunctions.DML(cmd);


        }

        public static int UpdateTeacherCourses(int id, List<int> TeacherIDs)
        {
            int result = 0;


            SqlCommand cmd = new SqlCommand("DELETE FROM TeacherSubject WHERE SubjectID = @id");
            cmd.Parameters.AddWithValue("@id", id);
            DALFunctions.DML(cmd);


            foreach (int teacherId in TeacherIDs)
            {
                using (SqlCommand cmd2 = new SqlCommand("INSERT INTO TeacherSubject (TeacherID, SubjectID) VALUES (@TeacherID, @SubjectID2)"))
                {
                    cmd2.Parameters.AddWithValue("@TeacherID", teacherId);
                    cmd2.Parameters.AddWithValue("@SubjectID2", id);

                    result = DALFunctions.DML(cmd2);
                }
            }

            return result;
        }


        public static int InsertCourse(string name, int hours)
        {
            SqlCommand cmd = new SqlCommand("Insert into Subject values (@name,@hours)");
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("hours", hours);

            return DALFunctions.DML(cmd);
        }

        public static int InsertTeacherCourses(List<int> TeacherIDs)
        {
            int result = 0;


            SqlCommand cmd = new SqlCommand("SELECT MAX(SubjectID)  FROM Subject;");

            DataTable dt = DALFunctions.Select(cmd);
            int id = int.Parse(dt.Rows[0][0].ToString());

            foreach (int teacherId in TeacherIDs)
            {
                using (SqlCommand cmd2 = new SqlCommand("INSERT INTO TeacherSubject (TeacherID, SubjectID) VALUES (@TeacherID, @SubjectID2)"))
                {
                    cmd2.Parameters.AddWithValue("@TeacherID", teacherId);
                    cmd2.Parameters.AddWithValue("@SubjectID2", id);

                    result = DALFunctions.DML(cmd2);
                }
            }

            return result;
        }

        public static int DeleteCourse(int id)
        {
            // int result = 0;
            SqlCommand cmd = new SqlCommand("Delete from Subject where SubjectID=@id");
            cmd.Parameters.AddWithValue("id", id);
            return DALFunctions.DML(cmd);

        }


        public static DataTable ViewStudentAttendence()
        {
            SqlCommand cmd = new SqlCommand("StudentsReportAdmin");
            DataTable dt = DALFunctions.Select(cmd);
            return dt;

        }
        public static DataTable ViewCoursesAttendence()
        {


            SqlCommand cmd = new SqlCommand("SubjectsReport");
            DataTable dataTable = DALFunctions.Select(cmd);
            return dataTable;
        }

        public static DataTable ViewAttendenceDate(DateTime d1, DateTime d2) {
            SqlCommand cmd = new SqlCommand("ViewAttendenceDate @d1 ,@d2");
            cmd.Parameters.AddWithValue("d1",d1);
            cmd.Parameters.AddWithValue("d2",d2);

        
            return DALFunctions.Select(cmd);
        }
        public static DataTable GetAllSubjCount() {
            SqlCommand cmd = new SqlCommand("Select count(*) from Subject");
            return DALFunctions.Select(cmd);
        
        }
        public static DataTable GetAllStudentsnum() {
            SqlCommand cmd = new SqlCommand("Select count(*) from SUser where Role='Student'");

            return DALFunctions.Select(cmd);

        }

        public static DataTable GetAllTeachersSum() {
            SqlCommand cmd = new SqlCommand("Select count(*) from SUser where Role='Teacher'");

            return DALFunctions.Select(cmd);


        }
    }
}
