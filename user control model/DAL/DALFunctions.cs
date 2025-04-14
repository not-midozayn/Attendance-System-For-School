using System.Data;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
public class DALFunctions
{
    static SqlConnection con = new SqlConnection("Data Source=DESKTOP-QKUOFIR\\SQLEXPRESS;Initial Catalog=TeamCopy;Integrated Security=True;");
    public static DataTable Select(SqlCommand cmd)
    {
        DataTable dt = new DataTable();
        try
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TeamCopy;Integrated Security=True;"))
            {
                cmd.Connection = con; // Ensure the command is linked to the connection
                con.Open();  // Open connection

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dt;
    }



    public static int DML(SqlCommand cmd)
    {
        int result = 0;
        try
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TeamCopy;Integrated Security=True;"))
            {


                cmd.Connection = con;

                con.Open();
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        catch (Exception ex) {
            MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return result;



    }

}
