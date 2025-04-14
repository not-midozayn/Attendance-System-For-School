
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace user_control_model
{

    public partial class login : Form
    {
        private void CreateExamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += CreateExamForm_FormClosing;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;

        }

       
      

        private void login_btn_Click(object sender, EventArgs e)
        {
            // this.Hide();
            // AdminDashBoard adminDashBoard = new AdminDashBoard();
            //adminDashBoard.Show();
           

           int id=  BL.UserLogin.Login(textBox2.Text, password_textbox.Text,this,invalidLogin);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void forgetpassword_btn_Click(object sender, EventArgs e)
        {
          //  this.Hide();
            //AdminDashBoard admin = new AdminDashBoard ();
          //  admin.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(password_textbox.UseSystemPasswordChar)
            {
                password_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
