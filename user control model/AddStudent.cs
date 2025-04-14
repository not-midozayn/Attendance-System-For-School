using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using user_control_model.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComponentFactory.Krypton.Toolkit;
namespace user_control_model
{
    public partial class AddStudent : KryptonForm
    {
        private int UserId;

        public AddStudent()
        {
            InitializeComponent();
            this.FormClosing += CreateExamForm_FormClosing;
        }
        public AddStudent(int id)
        {
            InitializeComponent();
            UserId = id;
            this.FormClosing += CreateExamForm_FormClosing;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   this.Hide();
            // AdminDashBoard adminDashBoard = new AdminDashBoard();
            //  adminDashBoard.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void printreport_btn_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_btn_Click(object sender, EventArgs e)
        {


        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void DashBoard_btn_Click_1(object sender, EventArgs e)
        {
            //////DashBoard
            reset();
            panel8.Visible = true;
            profileLabel.Visible = true;
            lFName.Visible = true;
            llName.Visible = true;
            lAddress.Visible = true;
            liconAddress.Visible = true;
            lBirthDate.Visible = true;
            liconBirth.Visible = true;
            lEmail.Visible = true;
            liconEmail.Visible = true;
            lGender.Visible = true;
            liconGender.Visible = true;
            lPhone.Visible = true;
            liconPhone.Visible = true;
            lTextNumberSub.Visible = true;
            lNumSub.Visible = true;
            lTextNumberSub.Visible = true;
            NumberTeachers.Visible = true;
            NumberTeachersNum.Visible = true;
            lTextNumberStd.Visible = true;
            lNumStd.Visible = true;
            //number of subjects 

            DataTable dt = BL.ViewTable.GetAllSubjCount();

            lNumSub.Text = dt.Rows[0][0].ToString();

            ////number of students 

            DataTable dt2 = BL.ViewTable.GetAllStudentsnum();

            lNumStd.Text = dt2.Rows[0][0].ToString();
            //Number of all Teachers 
            DataTable dt4 = BL.ViewTable.GetAllTeachersSum();
            NumberTeachersNum.Text = dt4.Rows[0][0].ToString();
            dgvTeacherDashBoard.Visible = true;
        }

        private void EditStudent_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //EditSTUDENT editStudent = new EditSTUDENT();
            //editStudent.Show();

        }
        private void reset()
        {
            //////DashBoard
            lFName.Visible = false;
            llName.Visible = false;
            lAddress.Visible = false;
            liconAddress.Visible = false;
            lBirthDate.Visible = false;
            liconBirth.Visible = false;
            lEmail.Visible = false;
            liconEmail.Visible = false;
            lGender.Visible = false;
            liconGender.Visible = false;
            lPhone.Visible = false;
            liconPhone.Visible = false;
           label6.Visible = false;
            dgvTeacherDashBoard.Visible = false;
            txId.Visible = false;
            panel8.Visible = false;
            txAddress.Visible = false;
            txFName.Visible = false;
            txLName.Visible = false;
            txPhone.Visible = false;
            txPass.Visible = false;
            IdLabel2.Visible = false;
           
            EmailLabel2.Visible = false;
            PassLabel.Visible = false;

            label3.Visible = false;
            label4.Visible = false;

            G2Label.Visible = false;
            U2Label.Visible = false;

            TxEmail.Visible = false;

            IDLabel.Visible = false;
            PhoneLabel2.Visible = false;
            toptext.Visible = false;
            Labeladmin.Visible = false;
            AddLabel.Visible = false;
            AddLabel.Text = "User Address";
            dateTimePicker1.Visible = false;
            dataGridView1.Visible = false;
            checkedListBox3.Visible = false;
            checkedListBox4.Visible = false;
            SubjectHoursLabel.Visible = false;
            SubjectNameLabel.Visible = false;
            TxShours.Visible = false;
            TxSName.Visible = false;
            dataGridView4GettingTeacher.Visible = false;
            SelectedOnes.Visible = false;
            SelectedLabel.Visible = false;
            profileLabel.Visible= false;
            Savebtn2.Visible = false;
            clearBtn2.Visible = false;

            Updatebtn2.Visible = false;
            SubjectHoursLabel.Visible = false;
            SubjectNameLabel.Visible = false;
            TxShours.Visible = false;
            TxSName.Visible = false;
            dataGridView4GettingTeacher.Visible = false;
            SelectedOnes.Visible = false;
         
            txId.Visible = false;
            txAddress.Visible = false;
            txFName.Visible = false;
            txLName.Visible = false;
            txPhone.Visible = false;
            txPass.Visible = false;
            IdLabel2.Visible = false;
            PhoneLabel2.Visible = false;
            
            LNameLabel.Visible = false;
            AddLabel.Visible = false;
            dateTimePicker2.Visible = false;
            DOBLabel.Visible = false;
            dataGridView1.Visible = false;
            checkedListBox3.Visible = false;
            checkedListBox4.Visible = false;
            Savebtn2.Visible = false;
            clearBtn2.Visible = false;
            Updatebtn2.Visible = false;
            toptext.Visible = false;
            Labeladmin.Visible = false;
            PrintReport.Visible = false;
            ViewLabel.Visible = false;
            AddSubject.Visible = false;
            iconEdit.Visible = false;
            iconsweep.Visible = false;
            tabControl1.Visible = false;
            Searchbtn.Visible = false;
            DeleteBtn2.Visible = false;

            SubjectId.Visible = false;
            txSubjectId.Visible = false;
            tabControl2.Visible = false;
            SpecificDateLabel.Visible = false;  
            dateTimePickerMontorAttendednce1.Visible = false;
            dateTimePickerMontorAttendednce2.Visible = false;
            btnExportSubjectReport.Visible = false;
            lTextNumberSub.Visible = false;
            lNumSub.Visible = false;
            NumberTeachers.Visible = false;
            NumberTeachersNum.Visible = false;
            lTextNumberStd.Visible = false;
            lNumStd.Visible = false;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();


            ResetDataGridViewStyle();
        }


        private void CustomizeDataGridView()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;

           
            dataGridView1.ScrollBars = ScrollBars.Both;

            
            dataGridView1.RowTemplate.Height = 250; 

     
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; 
            }

        
            dataGridView1.DefaultCellStyle.Padding = new Padding(10); 

           
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

           
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells.Cast<DataGridViewCell>().Any(c => c.Value != null && c.Value.ToString().Trim() != ""))
                {
                    row.Height = 100;
                }
            }
           
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.SteelBlue;
        }




        private void button3_Click(object sender, EventArgs e)
        {


            this.reset();
            label6.Visible = true;
            dataGridView1.Visible = true;
            AddSubject.Visible = true;
            SubjectHoursLabel.Visible = true;
            SubjectNameLabel.Visible = true;
            SubjectId.Visible = true;
            txSubjectId.Visible = true;
            TxShours.Visible = true;
            TxSName.Visible = true;
            dataGridView4GettingTeacher.Visible = true;
            SelectedOnes.Visible = true;
            SelectedLabel.Visible = true;
         
            Savebtn2.Visible = true;
            clearBtn2.Visible = true;
            iconEdit.Visible = true;
            iconsweep.Visible = true;
            Updatebtn2.Visible = true;
            Searchbtn.Visible = true;
            //DeleteBtn.Visible = true;
            DeleteBtn2.Visible = true;
            DataTable dt2 = BL.ViewTable.SearchTeacherForCourse();

            if (dt2.Rows.Count > 0)
            {

                dataGridView4GettingTeacher.DataSource = dt2;


            }
            DataTable selectedTeachers = new DataTable();
            selectedTeachers.Columns.Add("UserId", typeof(int));
            selectedTeachers.Columns.Add("FName", typeof(string));
            SelectedOnes.DataSource = selectedTeachers;
            StyleGridView(dataGridView4GettingTeacher);
            StyleGridView(SelectedOnes);
            dataGridView4GettingTeacher.CellClick += DataGridView4GettingTeacher_CellClick;


        }

        private void AddTeacher_btn_Click(object sender, EventArgs e)
        {
            ////this.Hide();
            //AddTeacher addTeacher = new AddTeacher();
            //addTeacher.Show();
        }

        private void EditTeacher_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //EditTeacherAdmin editTeacher = new EditTeacherAdmin();
            //editTeacher.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewStudent_btn_Click(object sender, EventArgs e)
        {


            reset();

            dataGridView1.Visible = true;
            ViewLabel.Visible = true;
            dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAll();
            tabControl1.Visible = true;
            btnExportSubjectReport.Visible = true;
            CustomizeDataGridView();

        }

        private void printreport_btn_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //PrintReportAdmin printreportadmin = new PrintReportAdmin();
            //printreportadmin.Show();
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void GetDashBoardData(Label labelName, int ColNumber)
        {

            DataTable dt = BL.TeacherFunctions.GetTeacherData(UserId);
            //MessageBox.Show(lFName.Text = dt.Rows[0][1].ToString());
            labelName.Text = dt.Rows[0][ColNumber].ToString();

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

            reset();
            panel8.Visible = true;
            Labeladmin.Visible = true;
            dataGridView4GettingTeacher.CellClick += DataGridView4GettingTeacher_CellClick;
            SelectedOnes.CellClick += SelectedOnes_CellClick;
            lFName.Visible = true;
            llName.Visible = true;
            lAddress.Visible = true;
            liconAddress.Visible = true;
            lBirthDate.Visible = true;
            liconBirth.Visible = true;
            lEmail.Visible = true;
            liconEmail.Visible = true;
            lGender.Visible = true;
            liconGender.Visible = true;
            lPhone.Visible = true;
            liconPhone.Visible = true;
            lTextNumberSub.Visible = true;
            lNumSub.Visible = true;
            NumberTeachers.Visible = true;
            NumberTeachersNum.Visible = true;
            lTextNumberStd.Visible = true;
            lNumStd.Visible = true;
            dgvTeacherDashBoard.Visible = true;
            //--------------DashBoard-----------------

            GetDashBoardData(lFName, 1);
            GetDashBoardData(llName, 2);
            GetDashBoardData(lEmail, 3);
            GetDashBoardData(lAddress, 8);
            GetDashBoardData(lPhone, 9);
            GetDashBoardData(lBirthDate, 6);
            GetDashBoardData(lGender, 10);
            if (lGender.Text == "F")
            {
                lGender.Text = "Female";
            }
            else
            {
                lGender.Text = "Male";
            }
            GetDashBoardData(lBirthDate, 6);


            //number of subjects 
        
                DataTable dt = BL.ViewTable.GetAllSubjCount();
             
                lNumSub.Text = dt.Rows[0][0].ToString();

            ////number of students 

            DataTable dt2 = BL.ViewTable.GetAllStudentsnum();
                
                lNumStd.Text = dt2.Rows[0][0].ToString();
            //Number of all Teachers 
            DataTable dt4=BL.ViewTable.GetAllTeachersSum();
                NumberTeachersNum.Text=dt4.Rows[0][0].ToString();   

            // welcome teacher
            DataTable dt3 = BL.TeacherFunctions.WelcomeTeacher(UserId);
                string welcomename = dt3.Rows[0][0].ToString();
                NameLabelFromDB.Text = welcomename;
            //}

        }
        private void SelectedOnes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedOnes.Rows.RemoveAt(e.RowIndex);
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txFEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void Role_label_Click(object sender, EventArgs e)
        {

        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            if (SubjectNameLabel.Visible == false)
            {
                if (!string.IsNullOrEmpty(txId.Text) && int.TryParse(txId.Text, out int userId))
                {
                    string Gender = "";
                    string Role = "";

                    foreach (int index in checkedListBox3.CheckedIndices)
                    {
                        Gender = index == 0 ? "F" : "M";
                        break;
                    }

                    foreach (int index in checkedListBox4.CheckedIndices)
                    {
                        Role = index == 0 ? "Student" : "Teacher";
                        break;
                    }

                    if (long.TryParse(txPhone.Text, out long phoneNumber))
                    {
                        int result = BL.ViewTable.Update(userId, txFName.Text, txLName.Text, txPass.Text, dateTimePicker2.Value, txAddress.Text, phoneNumber, Gender, Role);

                        MessageBox.Show(result > 0 ? "User Updated" : "No User Updated");
                    }
                    else
                    {
                        MessageBox.Show("Invalid phone number. Please enter a valid numeric value.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID. Please enter a valid numeric value.");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txSubjectId.Text) && int.TryParse(txSubjectId.Text, out int subjectId))
                {
                    if (int.TryParse(TxShours.Text, out int subjectHours))
                    {
                        int result = BL.ViewTable.UpdateCourses(subjectId, TxSName.Text, subjectHours);
                        List<int> TeacherIds = GetSelectedTeacherIds();
                        int result2 = BL.ViewTable.UpdateTeacherCourses(subjectId, TeacherIds);

                        if (result == 0)
                            MessageBox.Show("No update happened in the Subject table.");

                        if (result2 == 0)
                            MessageBox.Show("No update happened in the TeacherCourse table.");
                    }
                }
            }
        }
        private List<int> GetSelectedTeacherIds()
        {
            List<int> teacherIds = new List<int>();

            if (SelectedOnes.DataSource != null)
            {
                DataTable dt = (DataTable)SelectedOnes.DataSource;

                foreach (DataRow row in dt.Rows)
                {
                    // Check if the row is deleted before accessing its data
                    if (row.RowState == DataRowState.Deleted)
                        continue;

                    // Ensure the row is not null and UserId exists
                    if (row["UserId"] != DBNull.Value)
                    {
                        teacherIds.Add(Convert.ToInt32(row["UserId"]));
                    }
                }
            }

            return teacherIds;
        }


        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addstudent_btn_Click(object sender, EventArgs e)
        {
            reset();

            txId.Visible = true;
            txAddress.Visible = true;
            txFName.Visible = true;
            txLName.Visible = true;
            txPhone.Visible = true;
            txPass.Visible = true;
            IdLabel2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            EmailLabel2.Visible = true;
            PassLabel.Visible = true;
            DOBLabel.Visible = true;
            Searchbtn.Visible = true;
            G2Label.Visible = true;
            U2Label.Visible = true;
            TxEmail.Visible = true;
            IDLabel.Visible = true;
            PhoneLabel2.Visible = true;
            toptext.Visible = true;
            Labeladmin.Visible = false;
            AddLabel.Visible = true;
            dateTimePicker2.Visible = true;
            dataGridView1.Visible = true;
            checkedListBox3.Visible = true;
            checkedListBox4.Visible = true;
            Savebtn2.Visible = true;
            clearBtn2.Visible = true;
            Updatebtn2.Visible = true;
            iconEdit.Visible = true;
            iconsweep.Visible = true;
            DeleteBtn2.Visible = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void SubjectHoursLabel_Click(object sender, EventArgs e)
        {

        }

        private void TxSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void TxShours_TextChanged(object sender, EventArgs e)
        {

        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Students")
            {
                dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAll();


            }
            else if (tabControl1.SelectedTab.Text == "Teachers")
            {
                dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAllTeacher();
            }
            CustomizeDataGridView();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Students")
            {
                dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAll();


            }
            else if (tabControl1.SelectedTab.Text == "Teachers")
            {
                dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAllTeacher();
            }
            CustomizeDataGridView();
        }
        private void Students_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Students")
            {
                dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAll();


            }
            else if (tabControl1.SelectedTab.Text == "Teachers")
            {
                dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAllTeacher();
            }
            CustomizeDataGridView();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Text == "Students")
            {
                dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAll();
            }
            else if (e.TabPage.Text == "Teachers")
            {
                dataGridView1.DataSource = (DataTable)BL.ViewTable.ViewAllTeacher();
            }

            CustomizeDataGridView();
            dataGridView1.Refresh();
        }

        private void CreateExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

    
        private void button7_Click(object sender, EventArgs e)
        {
            if (SubjectNameLabel.Visible == false)
            {
                if (!string.IsNullOrEmpty(txId.Text) && int.TryParse(txId.Text, out int studentId))
                {
                    for (int i = 0; i < checkedListBox3.Items.Count; i++)
                    {
                        checkedListBox3.SetItemChecked(i, false);
                        checkedListBox4.SetItemChecked(i, false);
                    }

                    DataTable dt = BL.ViewTable.SearchByStudent(studentId);
                    if (dt.Rows.Count > 0)
                    {
                        txFName.Text = dt.Rows[0][0].ToString();
                        txLName.Text = dt.Rows[0][1].ToString();
                        TxEmail.Text = dt.Rows[0][2].ToString();
                        txAddress.Text = dt.Rows[0][4].ToString();
                        txPhone.Text = dt.Rows[0][5].ToString();
                        dateTimePicker2.Value = (DateTime)dt.Rows[0][3];

                        checkedListBox3.SetItemChecked(dt.Rows[0][6].ToString() == "M" ? 1 : 0, true);
                        checkedListBox4.SetItemChecked(dt.Rows[0][7].ToString() == "Student" ? 0 : 1, true);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID. Please enter a valid numeric value.");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txSubjectId.Text) && int.TryParse(txSubjectId.Text, out int subjectId))
                {
                    DataTable dt = BL.ViewTable.SearchByCourse(subjectId);
                    DataTable dt2 = BL.ViewTable.SearchTeacherForCourse();
                    DataTable dt3 = BL.ViewTable.SelectedTeachers(subjectId);

                    if (dt.Rows.Count > 0)
                    {
                        TxSName.Text = dt.Rows[0][0].ToString();
                        TxShours.Text = dt.Rows[0][1].ToString();
                    }
                    if (dt2.Rows.Count > 0)
                    {
                        dataGridView4GettingTeacher.DataSource = dt2;
                    }
                    if (dt3.Rows.Count > 0)
                    {
                        SelectedOnes.DataSource = dt3;
                    }
                    if (SelectedOnes.DataSource == null)
                    {
                        DataTable selectedTeachers = new DataTable();
                        selectedTeachers.Columns.Add("UserId", typeof(int));
                        selectedTeachers.Columns.Add("FName", typeof(string));
                        SelectedOnes.DataSource = selectedTeachers;
                    }

                    StyleGridView(dataGridView4GettingTeacher);
                    StyleGridView(SelectedOnes);
                    dataGridView4GettingTeacher.CellClick += DataGridView4GettingTeacher_CellClick;
                }
                else
                {
                    MessageBox.Show("Invalid Subject ID. Please enter a valid numeric value.");
                }
            }
        }

        private void StyleGridView(DataGridView gridView)
        {
            gridView.RowHeadersVisible = false; 
            gridView.AllowUserToAddRows = false; 
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.RowTemplate.Height = 40;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                row.Height = 40; 
            }

           
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
            gridView.DefaultCellStyle.BackColor = Color.White;
            gridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void DataGridView4GettingTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow selectedRow = dataGridView4GettingTeacher.Rows[e.RowIndex];

                int teacherId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);
                string teacherName = selectedRow.Cells["FName"].Value.ToString();

                
                DataTable dt = (DataTable)SelectedOnes.DataSource;

                
                bool exists = dt.AsEnumerable().Any(row => row.Field<int>("UserId") == teacherId);

                if (!exists)
                {
                    dt.Rows.Add(teacherId, teacherName);
                }
            }
        }

        private void clearBtn2_Click(object sender, EventArgs e)
        {
            if (SubjectNameLabel.Visible == false)
            {
                for (int i = 0; i < checkedListBox3.Items.Count; i++)
                {
                    checkedListBox3.SetItemChecked(i, false);
                    checkedListBox4.SetItemChecked(i, false);
                }

                txId.Clear();
                txFName.Clear();
                txLName.Clear();
                txAddress.Clear();
                txPhone.Clear();
                txPass.Clear();
                TxEmail.Clear();

                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {

                TxShours.Clear();
                TxSName.Clear();
                txSubjectId.Clear();
        
            }
        }

        private void Savebtn2_Click(object sender, EventArgs e)
        {
            if (SubjectNameLabel.Visible == false)
            {
                if (!string.IsNullOrEmpty(txPhone.Text) && long.TryParse(txPhone.Text, out long phoneNumber))
                {
                    string Gender = "";
                    string Role = "";

                    foreach (int index in checkedListBox3.CheckedIndices)
                    {
                        Gender = index == 0 ? "F" : "M";
                        break;
                    }

                    foreach (int index in checkedListBox4.CheckedIndices)
                    {
                        Role = index == 0 ? "Student" : "Teacher";
                        break;
                    }

                    int result = BL.ViewTable.Insert(txFName.Text, txLName.Text, TxEmail.Text, txPass.Text, dateTimePicker2.Value, txAddress.Text, phoneNumber, Gender, Role);

                    MessageBox.Show(result > 0 ? "User Inserted" : "No User Inserted");
                }
                else
                {
                    MessageBox.Show("Invalid phone number. Please enter a valid numeric value.");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(TxShours.Text) && int.TryParse(TxShours.Text, out int subjectHours))
                {
                    int result = BL.ViewTable.InsertCourse(TxSName.Text, subjectHours);
                    List<int> TeacherIds = GetSelectedTeacherIds();
                    int result2 = BL.ViewTable.InsertTeacherCourses(TeacherIds);

                    if (result > 0)
                        MessageBox.Show("Subject Inserted");
                    else
                        MessageBox.Show("Failed to create subject");
                }
                else
                {
                    MessageBox.Show("Invalid subject hours. Please enter a valid numeric value.");
                }
            }

            clearBtn2_Click(null, null);
        }


        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

    
        private void DeleteBtn2_Click(object sender, EventArgs e)
        {
            if (SubjectNameLabel.Visible == false)
            {
                if (!string.IsNullOrEmpty(txId.Text) && int.TryParse(txId.Text, out int userId))
                {
                    int result = BL.ViewTable.Delete(userId);
                    MessageBox.Show(result > 0 ? "User Deleted" : "No User Deleted");
                    clearBtn2_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Invalid User ID. Please enter a valid numeric value.");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txSubjectId.Text) && int.TryParse(txSubjectId.Text, out int subjectId))
                {
                    int result = BL.ViewTable.DeleteCourse(subjectId);
                    MessageBox.Show(result > 0 ? "Subject Deleted" : "Error Deleting Subject");
                    clearBtn2_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Invalid Subject ID. Please enter a valid numeric value");
                }
            }
        }
        

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SelectedOnes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            reset();
            dataGridView1.Visible = true;
            SpecificDateLabel.Visible = true;
            dateTimePickerMontorAttendednce1.Visible = true;
            dateTimePickerMontorAttendednce2.Visible = true;
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = BL.ViewTable.ViewStudentAttendence();
            StyleAndFormatDataGridView(dataGridView1);
            tabControl2.Visible = true;
        }

        private void StyleAndFormatDataGridView(DataGridView dataGridView)
        {
            if (dataGridView.DataSource == null) return; 

            dataGridView.Visible = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoResizeColumns();

            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.RowTemplate.Height = 80;
            dataGridView.DefaultCellStyle.Padding = new Padding(5);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = 50;
            }

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.DefaultCellStyle.BackColor = Color.White;

         
            if (!dataGridView.Columns.Contains("Percentage"))
            {
                DataGridViewTextBoxColumn percentageColumn = new DataGridViewTextBoxColumn
                {
                    Name = "Percentage",
                    HeaderText = "Percentage",
                    ReadOnly = true
                };
                dataGridView.Columns.Add(percentageColumn);
            }

            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells.Count >= 4 && row.Cells[2].Value != null && row.Cells[3].Value != null)
                {
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out decimal value1) &&
                        decimal.TryParse(row.Cells[3].Value.ToString(), out decimal value2) &&
                        value2 != 0)
                    {
                        row.Cells["Percentage"].Value = Math.Round((value1 / value2) * 100, 2) + " %";
                    }
                    else
                    {
                        row.Cells["Percentage"].Value = "N/A";
                    }
                }
            }
        }

        private void StyleAndFormatDataGridView2(DataGridView dataGridView)
        {
            if (dataGridView.DataSource == null) return;

            dataGridView.Visible = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoResizeColumns();

            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.RowTemplate.Height = 80;
            dataGridView.DefaultCellStyle.Padding = new Padding(5);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = 50;
            }

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.DefaultCellStyle.BackColor = Color.White;

           
            if (!dataGridView.Columns.Contains("Percentage"))
            {
                DataGridViewTextBoxColumn percentageColumn = new DataGridViewTextBoxColumn
                {
                    Name = "Percentage",
                    HeaderText = "Percentage",
                    ReadOnly = true
                };
                dataGridView.Columns.Add(percentageColumn);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells.Count >= 3 && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    if (decimal.TryParse(row.Cells[1].Value.ToString(), out decimal value1) &&
                        decimal.TryParse(row.Cells[2].Value.ToString(), out decimal value2) &&
                        value2 != 0)
                    {
                        row.Cells["Percentage"].Value = Math.Round((value1 / value2) * 100, 2) + " %";
                    }
                    else
                    {
                        row.Cells["Percentage"].Value = "N/A";
                    }
                }
            }
        }

        private void tabControl2_Selecting(object sender, TabControlCancelEventArgs e)
        {
            dataGridView1.Columns.Clear(); 

            if (e.TabPage.Text == "Students")
            {
                dataGridView1.DataSource = BL.ViewTable.ViewStudentAttendence();
                StyleAndFormatDataGridView(dataGridView1);
            }
            else if (e.TabPage.Text == "Courses")
            {
                dataGridView1.DataSource = BL.ViewTable.ViewCoursesAttendence();
                StyleAndFormatDataGridView2(dataGridView1);
            }
            else if (e.TabPage.Text == "SpecificDate")
            {
                dataGridView1.DataSource = BL.ViewTable.ViewAttendenceDate(dateTimePickerMontorAttendednce1.Value, dateTimePickerMontorAttendednce2.Value);

            }

            dataGridView1.Refresh();
        }

        private void liconBirth_Click(object sender, EventArgs e)
        {

        }

        private void panelback_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            BL.UserLogin.UserLogout(this);
        }

        private void label7_Click_2(object sender, EventArgs e)
        {

        }

        private void DateTab_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerMontorAttendednce1_ValueChanged(object sender, EventArgs e)
        {

           
            UpdateAttendanceGrid();
        }

        private void dateTimePickerMontorAttendednce2_ValueChanged(object sender, EventArgs e)
        {
         
            UpdateAttendanceGrid();
        }

        private void UpdateAttendanceGrid()
        {
            if (tabControl2.SelectedTab != null && tabControl2.SelectedTab.Text == "SpecificDate")
            {
                dataGridView1.DataSource = BL.ViewTable.ViewAttendenceDate(
                    dateTimePickerMontorAttendednce1.Value,
                    dateTimePickerMontorAttendednce2.Value
                );
            }
        }




        private void btnExportPDF_Click(object sender, EventArgs e)
        {


            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = "SubjectsReport.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToPDF(dataGridView1, sfd.FileName);
                }
            }
        }

        private void ExportDataGridViewToPDF(DataGridView dataGridView, string filePath)
        {
            try
            {
                Document document = new Document(PageSize.A4, 10, 10, 10, 10);
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                document.Open();
                PdfPTable pdfTable = new PdfPTable(dataGridView.ColumnCount)
                {
                    WidthPercentage = 100
                };

                // Add headers
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                    {
                        BackgroundColor = new BaseColor(0, 102, 204),
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        Padding = 5
                    };
                    pdfTable.AddCell(cell);
                }

             
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow) 
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }
                }

                document.Add(pdfTable);
                document.Close();
                writer.Close();

                MessageBox.Show("PDF Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lNumStd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4GettingTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ResetDataGridViewStyle()
        {
            
            dataGridView1.EnableHeadersVisualStyles = true;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.RowTemplate.Height = 22;

            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            }

        
            dataGridView1.DefaultCellStyle.Padding = new Padding(0);

          
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

         
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Empty;
            dataGridView1.DefaultCellStyle.BackColor = Color.Empty;

            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Height = 22; 
                }
            }

            
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = SystemColors.ControlDark;
            if (dataGridView1.Columns.Contains("Percentage"))
            {
                dataGridView1.Columns.Remove("Percentage");
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
