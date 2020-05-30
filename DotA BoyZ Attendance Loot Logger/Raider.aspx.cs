using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Windows.Forms;
using System.Data;

namespace DotA_BoyZ_Attendance_Loot_Logger
{
    public partial class Raider : System.Web.UI.Page
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rdr;
        string raid, boss, item, character;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindData(string inRaid, string inBoss, string inItem, string inCharacter)
        {
            try
            {

                //this shit needs to be in config file; not in the code but whatever
                string connStr = "server=dotaboyzdatabase.cndqtsa4rfpy.us-west-1.rds.amazonaws.com; user=admin; database=dotaboyz; port=3306; password=fortheboyz";

                //object of mysqlconnection so we can connect to shit
                MySqlConnection conn = new MySqlConnection(connStr);

                //opens connection to mysql database
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT Character FROM players_loot_list", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            /*
            raid = DropDownList1.Text;
            boss = txtBoss.Text;
            item = txtItem.Text;
            character = txtCharacter.Text;
            BindData(raid, boss, item, character);
            */
        }
    }
}