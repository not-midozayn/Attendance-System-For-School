using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_control_model
{
    public partial class UserControl1 : UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
        }

     
        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;


        }


        private void Attendance_System_Label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {


        }


        private void welcome_label_Click(object sender, EventArgs e)
        {
            welcome_label.Visible = true;
            welcome_label.BringToFront();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackgroundImageLayout = ImageLayout.Stretch; 

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Visible = true;
        }

        private void text_Click(object sender, EventArgs e)
        {
            text.Visible = true;
        }

        private void DashBoard_btn_Click(object sender, EventArgs e)
        {
            DashBoard_btn.Visible = true;
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    comboBox1.Size = new Size(191, 32);
        //    comboBox1.Text = "Student Options";
        //    comboBox1.Items.Add("Add Student");
        //    comboBox1.Items.Add("delete student");
        //    comboBox1.Items.Add("update student");
        //    comboBox1.Items.Add("view student");
           
        //    comboBox1.Items.Add("Print Student Report");
        //    comboBox1.Visible = true;
        //}

        private void toptext_Click(object sender, EventArgs e)
        {
            toptext.Visible = true;
        }

        private void panelback_Paint(object sender, PaintEventArgs e)
        {
            panelback.Visible = true;
        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Lable_Click(object sender, EventArgs e)
        {

        }

        private void ViewTeacher_btn_Click(object sender, EventArgs e)
        {

        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
          
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

       // private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       // {
            //comboBox1.Size = new Size(191, 32);
          //  comboBox1.Text = "Student Options";
            //comboBox1.Items.Add("Add Student");
            //comboBox1.Items.Add("delete student");
            //comboBox1.Items.Add("update student");
            //comboBox1.Items.Add("view student");

            //comboBox1.Items.Add("Print Student Report");
            //comboBox1.Visible = true;
      //  }
    }
}
