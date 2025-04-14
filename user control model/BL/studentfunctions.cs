using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_control_model.BL
{
    internal class studentfunctions
    {
        public static DataTable studentnumberofsubject(int id) 
        {
            
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM SUser s INNER JOIN StudentSubject ss ON s.UserID = ss.StudentID where s.UserID=@id;");
              cmd.Parameters.AddWithValue("@id", id);
            DataTable dt = DALFunctions.Select(cmd);
            return dt;

        }
        public static DataTable ViewStudentAttendence(int id)
        {
            SqlCommand cmd = new SqlCommand("ViewStudentAttendence @id ");
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dt = DALFunctions.Select(cmd);
            return dt;
        }

        public static DataTable AllSubjects() {

            SqlCommand cmd = new SqlCommand("Select Sname from Subject order by SubjectId");
            return DALFunctions.Select(cmd);
        }

        public static int ChangeStudentCourses(int StudentId, int SubjectId, bool check) {
            if (check)
            {
                SqlCommand cmd2 = new SqlCommand("Select * from StudentSubject where StudentId=@Studentid and SubjectId=@SubjectId");
                cmd2.Parameters.AddWithValue("SubjectId", SubjectId);
                cmd2.Parameters.AddWithValue("StudentId", StudentId);
                DataTable dataTable = DALFunctions.Select(cmd2);
                if (dataTable.Rows.Count == 0)
                {
                    SqlCommand cmd = new SqlCommand("Insert into StudentSubject values(@SubjectId,@Studentid)");
                    cmd.Parameters.AddWithValue("SubjectId", SubjectId);
                    cmd.Parameters.AddWithValue("StudentId", StudentId);
                    return DALFunctions.DML(cmd);
                }
                else { return -1; }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Delete from StudentSubject where SubjectId=@SubjectId and StudentId=@Studentid");
                cmd.Parameters.AddWithValue("SubjectId", SubjectId);
                cmd.Parameters.AddWithValue("StudentId", StudentId);
                return DALFunctions.DML(cmd);



            }



        }


        public static DataTable StudentCoursesName(int StudentId) {



            SqlCommand cmd = new SqlCommand("Select s.Sname from Subject s , StudentSubject ss where s.SubjectId=ss.SubjectId and ss.StudentId=@studentid");
            cmd.Parameters.AddWithValue("studentid",StudentId);
            return DALFunctions.Select(cmd);
        
        
        
        }
    }
    
}
