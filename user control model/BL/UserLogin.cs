using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace user_control_model.BL
{
    public class UserLogin
    {

        public static int Login(string email, string password,Form current,Label lb)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT UserID,Email, Password, Role FROM [TeamCopy].[dbo].[SUser] WHERE Email=@Email AND Password=@Password"))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    DataTable dt = DALFunctions.Select(cmd);

                    if (dt.Rows.Count > 0)
                    {
                        string role = dt.Rows[0]["Role"].ToString();
                        string dbEmail = dt.Rows[0]["Email"].ToString();
                        string dbPassword = dt.Rows[0]["Password"].ToString();
                        int id=int.Parse(dt.Rows[0]["UserID"].ToString());

                        // Debugging Message
               //         MessageBox.Show($"Found: {dbEmail}, {dbPassword}, {role}");

                        if (role == "Admin")
                        {
                            current.Hide();
                           AddStudent A=   new AddStudent(id);
                            A.Show();  
                            return id;
                        }
                        else if (role == "Teacher")
                        {
                            current.Hide();
                            Teacher t = new Teacher(id);
                            t.Show();
                            return id;
                        }
                        else if (role == "Student")
                        {
                            current.Hide();
                            student s= new student(id);   
                            s.Show();
                            return id;
                        }
                    }
                    else
                    {
                        //MessageBox.Show("No Data Found", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lb.Visible = true;
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public static void UserLogout(Form current) { 
        
        current.Hide();
        login l = new login();
            l.Show();
        }
       
    }
   
    }



