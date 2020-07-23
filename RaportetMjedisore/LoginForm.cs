using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace RaportetMjedisore
{
    public partial class LoginForm : Form
    {

        string cs = "server=192.168.100.7;user id=dardan;persistsecurityinfo=True;database=raportet_komunale;password=Dr3n4sdr3n4s";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblcreateacc_Click(object sender, EventArgs e)
        {
          
        }
        
        private void lblcreateacc_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Userat.DataSource = LoginForm.asd();
        }
        public static List<object> asd()
        {
            List<object> a = new List<object>();
            string connStr = "server=192.168.100.7;user id=dardan;persistsecurityinfo=True;database=raportet_komunale;password=Dr3n4sdr3n4s;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
             
                
                conn.Open();

                string sql = "Select * from userkomunal";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   a.Add(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
              
            }
              return a;
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
        }
    }
}
