using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace user_control_model
{
    public partial class student : Form
    {
        private int UserId;
        public student(int id) { UserId = id;



            this.FormClosing += CreateExamForm_FormClosing;
            InitializeComponent();




        }
        private void CreateExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
            reset();

            DashBoard_Click(sender, e);

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void reset()
        {
            // visible on dashboad click
            // AllSubjectChart.Visible = false;
            liconAddress.Visible = false;
            lFName1.Visible = false;
            llName.Visible = false;
            lEmail.Visible = false;
            lPhone.Visible = false;
            lGender.Visible = false;
            lBirthDate.Visible = false;
            lAddress.Visible = false;
            chooseSubject.Visible = false;
            allsubjectcheckbox.Visible= false;
            subjectcheckbox.Visible= false;
            viewattendancegridview.Visible = false;
            RegisterSubjectChecklist.Visible = false;
            liconPhone.Visible = false;
            studentImage.Visible = false;
            liconGender.Visible = false;
            liconBirth.Visible = false;
            liconEmail.Visible = false;
            lTextNumberSub.Visible = false;
            lNumSub.Visible = false;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Click(object sender, EventArgs e)
        {

            reset();

            // AllSubjectChart.Visible = true;
            liconBirth.Visible = true;
            lTextNumberSub.Visible = true;
            liconEmail.Visible = true;      
            liconAddress.Visible = true;    
            lFName1.Visible= true;
            liconGender.Visible = true;
            lNumSub.Visible = true;
            liconPhone.Visible = true;
            llName.Visible= true;
                lEmail.Visible= true;
                lPhone.Visible= true;
                lGender.Visible= true;
                lBirthDate.Visible = true;
                lAddress.Visible = true;
            studentImage.Visible = true;
            
            DataTable DT = BL.TeacherFunctions.GetTeacherData(UserId);
                DataTable dt1=BL.studentfunctions.studentnumberofsubject(UserId);
            if (dt1.Rows.Count > 0)
            {
                lNumSub.Text = dt1.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }

            if ( DT.Rows.Count > 0)
            {
                NameLabelFromDB.Text= DT.Rows[0][1].ToString()+" "+ DT.Rows[0][2].ToString();
                lFName1.Text = DT.Rows[0][1].ToString();
                llName.Text = DT.Rows[0][2].ToString();
                lEmail.Text = DT.Rows[0][3].ToString();
                lPhone.Text = DT.Rows[0][9].ToString();
                if(DT.Rows[0][10].ToString() == "F")
                {
                    lGender.Text ="Female";
                 
                }
                else
                {
                    lGender.Text = "Male";
                }
                lBirthDate.Text = DT.Rows[0][6].ToString();
                lAddress.Text = DT.Rows[0][8].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }

        }
           

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = subjectcheckbox.ToString();

            if (selectedItem == "PYTHON")
            {
            }
            else if (selectedItem == "JAVA")
            {
            }
            else if (selectedItem == "DOT NET")
            {
            }
            else if (selectedItem == " OOP ")
            {
            }
            else
                ;
        }

        private void MarkAttendance_btn_Click(object sender, EventArgs e)
        {
            reset();
            viewattendancegridview.Visible = true;
            viewattendancegridview.DataSource = BL.studentfunctions.ViewStudentAttendence(UserId);
            CustomizeDataGridView(viewattendancegridview);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        

        private void SubjectReport_btn_Click(object sender, EventArgs e)
        {
            reset();
            RegisterSubjectChecklist.Visible = true;


            DataTable dt = BL.studentfunctions.AllSubjects();


            DataTable dt2 = BL.studentfunctions.StudentCoursesName(UserId);


            List<string> CourseStudentNames = new List<string>();
            foreach (DataRow row in dt2.Rows)
            {
                CourseStudentNames.Add(row[0].ToString().Trim());
            }


            RegisterSubjectChecklist.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                RegisterSubjectChecklist.Items.Add(row[0].ToString().Trim());
            }


            for (int i = 0; i < RegisterSubjectChecklist.Items.Count; i++)
            {
                string courseName = RegisterSubjectChecklist.Items[i].ToString();

                if (CourseStudentNames.Contains(courseName))
                {
                    RegisterSubjectChecklist.SetItemChecked(i, true);
                }
            }
        }




        private void CustomizeDataGridView(DataGridView dataGridView)
        {
            
            dataGridView.RowTemplate.Height = 40; 
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black; 
            dataGridView.DefaultCellStyle.BackColor = Color.LightGray; 

           
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); 

          
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

           
            dataGridView.RowsDefaultCellStyle.BackColor = Color.LightCyan; 
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow; 

           
            dataGridView.RowHeadersVisible = false;


        }


        private void attendbtn_Click(object sender, EventArgs e)
        {

        }

        private void RegisterSubjectChecklist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string selectedCourseName = RegisterSubjectChecklist.Items[e.Index].ToString();
            int SubId = int.Parse(BL.TeacherFunctions.SubjectId(selectedCourseName).Rows[0][0].ToString());
            bool isChecked = e.NewValue == CheckState.Checked;
            BL.studentfunctions.ChangeStudentCourses(UserId, SubId, isChecked);



        }




        private void lFName_Click(object sender, EventArgs e)
        {
            
        }

        private void viewattendancegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void liconAddress_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterSubjectChecklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void NameLabelFromDB_Click(object sender, EventArgs e)
        {

        }

        private void studentImage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
