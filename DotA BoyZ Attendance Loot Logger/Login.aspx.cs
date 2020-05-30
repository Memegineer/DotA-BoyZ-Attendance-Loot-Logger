using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;

namespace DotA_BoyZ_Attendance_Loot_Logger
{
    public partial class Login : System.Web.UI.Page
    {
        String username, password;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //this shit needs to be in config file; not in the code but whatever
            string connStr = "server=dotaboyzdatabase.cndqtsa4rfpy.us-west-1.rds.amazonaws.com; user=admin; database=dotaboyz; port=3306; password=fortheboyz";

            //object of mysqlconnection so we can connect to shit
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                //opens connection to mysql database
                conn.Open();

                //assigns user's input to variables
                username = txtUsername.Text;
                password = txtPassword.Text;

                //sql selection string that pulls unique username
                string sql = "SELECT Username, Password, Officer FROM login WHERE Username = '" + username + "'";

                //database reader helper shit
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //if inputted username/password is equal to mysqldb username/password
                    if (username.Equals(rdr.GetString(0)) && password.Equals(rdr.GetString(1)))
                    {
                        try
                        {
                            //if rdr is equal 1 then an officer is logging in
                            if (rdr.GetString(2).Equals("1"))
                            {
                                Response.Redirect("Officer.aspx", false);
                            }
                            //otherwise, if rdr is equal to 0 then a raider is logging in
                            else if (rdr.GetString(2).Equals("0"))
                            {
                                Response.Redirect("Raider.aspx", false);
                            }
                        }
                        catch (ThreadAbortException ex)
                        {
                            MessageBox.Show("Thread is being aborted!", "Notification", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!", "Notification", MessageBoxButtons.OK);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done");
        }
    }
}