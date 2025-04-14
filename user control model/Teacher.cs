using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace user_control_model
{

    public partial class Teacher : Form
    {

        private void CreateExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private int UserId;
        public Teacher()
        {
            InitializeComponent();
            this.FormClosing += CreateExamForm_FormClosing;
        }

        public Teacher(int id)
        {
            InitializeComponent();
            UserId = id;
            this.FormClosing += CreateExamForm_FormClosing;

        }

        public void GetDashBoardData(Label labelName , int ColNumber)
        {

            DataTable dt = BL.TeacherFunctions.GetTeacherData(UserId);
            labelName.Text = dt.Rows[0][ColNumber].ToString();

        }


        private void reset()
        {
            //////DashBoard
            lFName.Visible= false;
            llName.Visible= false;
            lAddress.Visible= false;
            liconAddress.Visible = false;
            lBirthDate.Visible= false;
            liconBirth.Visible = false;
            lEmail.Visible = false;
            liconEmail.Visible = false;
            lGender.Visible = false;
            liconGender.Visible = false;
            lPhone.Visible = false;
            liconPhone.Visible = false;
            lNumStd.Visible = false;
            lTextNumberStd.Visible = false;
            lNumSub.Visible = false;
            lTextNumberSub.Visible = false;
            teacherimage.Visible = false;
            //Mark Attendance
            lDateMarkAttendance.Visible= false;
            lSubjectMarkAttendance.Visible = false;
            CBSubjectMarkAttendance.Visible = false;
            DGVMarkAttendance.Visible = false;
            lMarkAttendance.Visible = false;
            dateTimeMarkAttendance.Visible = false;
            SubmitAttendence.Visible = false;
            //Subject Report 
            lSubjectReport.Visible= false;
            lSubjectSubjectReport.Visible= false;
            DGVSubjectReport.Visible = false;
            CBSubjectReport.Visible = false;
            btnExportSubjectReport.Visible = false;

            //Student Report
            DGVStudentReport.Visible= false;
            lStudentReport.Visible = false; 
            btnStudentReport.Visible= false;
    
        }
        private void TDashBoard_btn_Click(object sender, EventArgs e)
        {
            reset();
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
            lNumStd.Visible = true;
            lTextNumberStd.Visible = true;
            lNumSub.Visible = true;
            lTextNumberSub.Visible = true;
            teacherimage.Visible = true;




        }

        private void MarkAttendance_btn_Click(object sender, EventArgs e)
        {
            reset();
            lDateMarkAttendance.Visible = true;
            lSubjectMarkAttendance.Visible = true;
            CBSubjectMarkAttendance.Visible = true;
            DGVMarkAttendance.Visible = true;
            lMarkAttendance.Visible = true;
            dateTimeMarkAttendance.Visible = true;
            SubmitAttendence.Visible=true;
            DataTable dt = BL.TeacherFunctions.ComboBoxSubj(UserId);
            if (dt.Rows.Count > 0)
            {
               
                CBSubjectMarkAttendance.DataSource = dt;
                CBSubjectMarkAttendance.DisplayMember = "SName";
                CBSubjectMarkAttendance.SelectedIndex = 0;
                string subjname = CBSubjectMarkAttendance.Text;

                DataTable dt2 = BL.TeacherFunctions.MarkAttendence(subjname,UserId);
                DGVMarkAttendance.DataSource= dt2;
                StyleDataGridView(DGVMarkAttendance);


            }
            else
            {
                CBSubjectMarkAttendance.DataSource = null;
            }


        }

        private void SubjectReport_btn_Click(object sender, EventArgs e)
        {
            reset();
            lSubjectReport.Visible = true;
            lSubjectSubjectReport.Visible = true;
            DGVSubjectReport.Visible = true;
            CBSubjectReport.Visible = true;
            btnExportSubjectReport.Visible = true;

            CustomizeDataGridView();
            DGVSubjectReport.DataSource = BL.TeacherFunctions.ViewTeacherSubjectReport(UserId);

        }

        private void StudentReport_btn_Click(object sender, EventArgs e)
        {
            reset();
            DGVStudentReport.Visible = true;
            lStudentReport.Visible = true;
            btnStudentReport.Visible = true;
            CustomizeDataGridView2();
            DGVStudentReport.DataSource = BL.TeacherFunctions.StudentTeacherReport(UserId);
        }
        public void CustomizeDataGridView2()
        {
            
            DGVStudentReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            DGVStudentReport.Size = new Size(550, 269);

           
            DGVStudentReport.EnableHeadersVisualStyles = false;
            DGVStudentReport.RowHeadersVisible = false;

         
            DGVStudentReport.ScrollBars = ScrollBars.Both;

          
            int totalRowCount = DGVStudentReport.Rows.Count;
            int availableHeight = 269 - DGVStudentReport.ColumnHeadersHeight; 
            int rowHeight = (totalRowCount > 0) ? availableHeight / totalRowCount : 30; 
            rowHeight = Math.Max(rowHeight, 25); 

            foreach (DataGridViewRow row in DGVStudentReport.Rows)
            {
                row.Height = rowHeight;
            }

            
            int totalColumnCount = DGVStudentReport.Columns.Count;
            int availableWidth = 550; 
            int columnWidth = (totalColumnCount > 0) ? availableWidth / totalColumnCount : 50;
            columnWidth = Math.Max(columnWidth, 50); 

            foreach (DataGridViewColumn column in DGVStudentReport.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 
                column.Width = columnWidth;
            }

           
            DGVStudentReport.DefaultCellStyle.Padding = new Padding(5);

        
            DGVStudentReport.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGVStudentReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVStudentReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);

            DGVStudentReport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

           
            DGVStudentReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);

            DGVStudentReport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

          
            DGVStudentReport.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGVStudentReport.DefaultCellStyle.BackColor = Color.White;

            
            DGVStudentReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVStudentReport.GridColor = Color.SteelBlue;
        }
        private void Teacher_Load(object sender, EventArgs e)
        {
            reset();
            teacherimage.Visible = true;
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
            lNumStd.Visible = true;
            lTextNumberStd.Visible = true;
            lNumSub.Visible = true;
            lTextNumberSub.Visible = true;

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


           
            DataTable dt = BL.TeacherFunctions.GetTeacherSubjCount(UserId);
            string numofsubj = dt.Rows[0][1].ToString();
            lNumSub.Text = numofsubj;


            DataTable dt2 = BL.TeacherFunctions.GetTeacherStudentsnum(UserId);
            string teachstudents = dt2.Rows[0][0].ToString();
            lNumStd.Text = teachstudents;

          
            DataTable dt3 = BL.TeacherFunctions.WelcomeTeacher(UserId);
            string welcomename = dt3.Rows[0][0].ToString();
            NameLabelFromDB.Text = welcomename;



            //------------------------ComboBox Subject Report -----------------------

            DataTable dt4 = BL.TeacherFunctions.ComboBoxSubj(UserId);
            if (dt4.Rows.Count >0) 
            {
                DataRow ViewALlRows = dt4.NewRow();
                dt4.Rows.InsertAt(ViewALlRows, 0);
                ViewALlRows["SName"] = "View All";
                CBSubjectReport.DataSource = dt4;
                CBSubjectReport.DisplayMember = "SName";
                CBSubjectReport.SelectedIndex = 0;
                
                
            }
            else
            {
                CBSubjectReport.DataSource = null; 
            }
        }

        private void DGVSubjectReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void llName_Click(object sender, EventArgs e)
        {

        }

        private void lFName_Click(object sender, EventArgs e)
        {

        }

        private void lNumSub_Click(object sender, EventArgs e)
        {

        }

        private void lNumStd_Click(object sender, EventArgs e)
        {

        }

        private void NameLabelFromDB_Click(object sender, EventArgs e)
        {

        }

        private void CBSubjectReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSubjectReport.SelectedIndex > 0)
            {
                string subjname = CBSubjectReport.Text;
                string selectedSubject = CBSubjectReport.Text;
                DGVSubjectReport.DataSource = BL.TeacherFunctions.ViewTeacherSubjectReportCombo(UserId, subjname);
            }

            else
            {
                DGVSubjectReport.DataSource = BL.TeacherFunctions.ViewTeacherSubjectReport(UserId);
            }


        }


        //------------------------------------------------------------------


        public void CustomizeDataGridView()
        {
            
            DGVSubjectReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
            DGVSubjectReport.Size = new Size(550, 269);

         
            DGVSubjectReport.EnableHeadersVisualStyles = false;
            DGVSubjectReport.RowHeadersVisible = false;

        
            DGVSubjectReport.ScrollBars = ScrollBars.Both;

           
            int totalRowCount = DGVSubjectReport.Rows.Count;
            int availableHeight = 269 - DGVSubjectReport.ColumnHeadersHeight; 
            int rowHeight = (totalRowCount > 0) ? availableHeight / totalRowCount : 30; 
            rowHeight = Math.Max(rowHeight, 25); 

            foreach (DataGridViewRow row in DGVSubjectReport.Rows)
            {
                row.Height = rowHeight;
            }

            
            int totalColumnCount = DGVSubjectReport.Columns.Count;
            int availableWidth = 550; 
            int columnWidth = (totalColumnCount > 0) ? availableWidth / totalColumnCount : 50;
            columnWidth = Math.Max(columnWidth, 50); 

            foreach (DataGridViewColumn column in DGVSubjectReport.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; 
                column.Width = columnWidth;
            }

            
            DGVSubjectReport.DefaultCellStyle.Padding = new Padding(5);

          
            DGVSubjectReport.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            DGVSubjectReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DGVSubjectReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);

            DGVSubjectReport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            DGVSubjectReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);

            DGVSubjectReport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            
            DGVSubjectReport.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            DGVSubjectReport.DefaultCellStyle.BackColor = Color.White;

          
            DGVSubjectReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVSubjectReport.GridColor = Color.SteelBlue;
        }

        private void CBSubjectMarkAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SubjectName=CBSubjectMarkAttendance.Text;
            DataTable dt = BL.TeacherFunctions.MarkAttendence(SubjectName, UserId);
            DGVMarkAttendance.DataSource= dt;
            StyleDataGridView(DGVMarkAttendance);
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            
            if (dgv.Columns.Count == 0 || dgv.Rows.Count == 0)
                return;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = 35;
            }
            
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            if (dgv.Columns.Count > 0)
            {
                bool isFirstColumnEmpty = true;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Height = 30;
                    
                    if (row.Cells[0].Value != null && !string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                    {
                        isFirstColumnEmpty = false;

                        break;
                    }
                }

        
                if (isFirstColumnEmpty)

                    dgv.Columns.RemoveAt(0);
                
            }

        
            if (!dgv.Columns.Contains("Status"))
            {
                DataGridViewCheckBoxColumn statusColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Status",
                    HeaderText = "Status",
                    DataPropertyName = "Status",
                    TrueValue = true,
                    FalseValue = false
                };

                dgv.Columns.Add(statusColumn);

        
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells["Status"].Value = false;
                }
            }

          
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

      
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.GridColor = Color.DarkGray;
            dgv.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnExportSubjectReport_Click(object sender, EventArgs e)
        {


        }




        //-------------------------Export to pdf--------------------------------



        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = "SubjectsReport.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToPDF(DGVSubjectReport, sfd.FileName);
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

        private void SubmitAttendence_Click(object sender, EventArgs e)
        {
            List<AttendenceType> Li=new List<AttendenceType>();
               DateTime date= dateTimeMarkAttendance.Value;
                string SubjectName= CBSubjectMarkAttendance.Text;
            DataTable dt = BL.TeacherFunctions.SubjectId(SubjectName);
            int SubjectId = int.Parse(dt.Rows[0][0].ToString());

            int StudentId;
            bool status;
            foreach (DataGridViewRow row in DGVMarkAttendance.Rows)
            {
                if (row == null || row.IsNewRow || row.Cells[0].Value == null || row.Cells[2].Value == null)
                    continue;
               
                    Li.Add(new AttendenceType
                    {
                        StudentId = int.Parse(row.Cells[0].Value.ToString()),
                        SubjectId = SubjectId,
                        date = date,
                        status = (bool)(row.Cells[2].Value)
                    });
                
            }
            MessageBox.Show("Attendence Updated");
            BL.TeacherFunctions.TakeAttendence(Li);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            BL.UserLogin.UserLogout(this);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = "StudentsReport.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToPDF(DGVStudentReport, sfd.FileName);
                }
            }
        }

        private void DGVMarkAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teacherimage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
