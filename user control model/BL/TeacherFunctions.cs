using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_control_model.BL
{
    public class TeacherFunctions
    {


        //DashBoard functions
        public static DataTable GetTeacherData(int userId)
        {



            SqlCommand cmd = new SqlCommand("SELECT * FROM SUser WHERE UserID = @UserID");
            cmd.Parameters.AddWithValue("@UserID", userId);

            DataTable dt = DALFunctions.Select(cmd);


            return dt;
        }

        public static DataTable GetTeacherSubjCount(int userId)
        {
            SqlCommand cmd = new SqlCommand("select  TeacherID , COUNT(TeacherID) from TeacherSubject where TeacherID = @userId   group by TeacherID ");
            cmd.Parameters.AddWithValue("userId" , userId);

            DataTable teachersubj = DALFunctions.Select(cmd);
            return teachersubj;
        }

        public static DataTable GetTeacherStudentsnum(int userId)
        {
            SqlCommand cmd = new SqlCommand("select  count(distinct StudentID) As totalstudents\r\nfrom StudentSubject ss inner join TeacherSubject ts\r\non ss.SubjectID=ts.SubjectID and TeacherID = @userId");
            cmd.Parameters.AddWithValue("userId", userId);

            DataTable teachstdcount = DALFunctions.Select(cmd);
            return teachstdcount;
        }

        public static DataTable WelcomeTeacher(int userId)
        {
            SqlCommand cmd = new SqlCommand("select CONCAT(FName,' ', LName)\r\nfrom SUser where UserID=@userId");
            cmd.Parameters.AddWithValue ("userId" , userId);
            DataTable dt = DALFunctions.Select(cmd);
            return dt;
        }

        //----------------------------------------------------

        //subject report functions

        public static DataTable ViewTeacherSubjectReport(int id)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"SubjectsReportMod {id}");

            dt = DALFunctions.Select(cmd);
            return dt;
        }

        // comboBox Subject report

        public static DataTable ComboBoxSubj(int userid)
        {
            
            SqlCommand cmd = new SqlCommand("\r\nselect s.SName\r\nfrom TeacherSubject ts , Subject s\r\nwhere ts.SubjectID=s.SubjectID and ts.TeacherID=@userid");
            cmd.Parameters.AddWithValue("userid", userid);

            DataTable dt = DALFunctions.Select(cmd);
            return dt;
        }

        //datagrid view for selected subject in comboBOx

        //public static DataTable ViewTeacherSubjectReportCombo(int id , int subjectid)
        //{
        //    DataTable dt = new DataTable();
        //    SqlCommand cmd = new SqlCommand($"[dbo].[ComboBoxSubjectsReportMod] {id} , {subjectid}");

        //    dt = DALFunctions.Select(cmd);
        //    return dt;
        //}


        public static DataTable ViewTeacherSubjectReportCombo(int id, string subjectname)
        {
            DataTable dt = new DataTable();
            //SqlCommand cmd1 = new SqlCommand("select SubjectID from ");
            SqlCommand cmd = new SqlCommand($"[dbo].[ComboBoxSubjectsReportModV2] {id} , '{subjectname}' ");

            dt = DALFunctions.Select(cmd);
            return dt;
        }

        public static DataTable MarkAttendence(string subjectName, int teacherid) {


            SqlCommand cmd = new SqlCommand($"MarkAttendence {teacherid},'{subjectName}'");
          return DALFunctions.Select(cmd);

        
        }

        public static DataTable SubjectId(string subjectName) {

            SqlCommand cmd = new SqlCommand("Select SubjectID from Subject where SName=@subjectName");
            cmd.Parameters.AddWithValue("subjectName",subjectName);
            return DALFunctions.Select(cmd);
        
        
        }

        public static int TakeAttendence(List<AttendenceType> li) {
        int result=0;
            int SubjectId = li[0].SubjectId;
            DateTime date = li[0].date;
            for (int i = 0; i < li.Count; i++) {
                int StudentId=li[i].StudentId;
                bool status = li[i].status;
                SqlCommand cmd = new SqlCommand("Insert into Attendance values(@SubjectId,@StudentId,@date,@status)");
                cmd.Parameters.AddWithValue("SubjectId",SubjectId);
                cmd.Parameters.AddWithValue("StudentId", StudentId);
                cmd.Parameters.AddWithValue("date",date);
                cmd.Parameters.AddWithValue ("status", status);
               result= DALFunctions.DML(cmd);
            
            
            }
        
        return result;
        }




        public static DataTable StudentTeacherReport(int teacherId) {
            SqlCommand cmd = new SqlCommand("StudentTeacherReport @teacherId");
            cmd.Parameters.AddWithValue("teacherId",teacherId);
            return DALFunctions.Select(cmd);
        
        }


    }
}
