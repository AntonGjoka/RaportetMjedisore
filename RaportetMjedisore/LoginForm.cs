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
        private static string connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
    
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
            Userat.DataSource = asd();
        }
        public static List<object> asd()
        {

            using (MySqlConnection connection = Conexao())
            {
               
                try
                {
                    List<object> result = null;
                    using (MySqlCommand comand = new MySqlCommand("select * from userkomunal"))
                    {
                        comand.CommandType = CommandType.Text;
                        using (MySqlDataReader reader=comand.ExecuteReader())
                        {
                            result = new List<object>();
                            while (reader.Read())
                            {
                                result.Add(reader[0] + " -- " + reader[1]);
                            }
                        }
                    }
                    return result;
                }
                

                catch (Exception)
                {

                    throw;
                }
            }

            

            //using (MySqlConnection con = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        List<object> a = new List<object>();

            //        conn.Open();

            //        string sql = "Select * from userkomunal";
            //        MySqlCommand cmd = new MySqlCommand(sql, conn);
            //        MySqlDataReader rdr = cmd.ExecuteReader();

            //        while (rdr.Read())
            //        {
            //            a.Add(rdr[0] + " -- " + rdr[1]);
            //        }
            //        rdr.Close();
            //        return a;
            //    }


            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.ToString());
            //    }

            //    conn.Close();
        }
        public static MySqlConnection Conexao()
        {
            string strConexao = "Server=192.168.0.16;Port=3306;Database=raportet_komunale;Uid=dardan;Pwd=Dr3n4sdr3n4s;";
            MySqlConnection conn = new MySqlConnection();
            conn = new MySqlConnection(strConexao);

            conn.Open();

            return conn;
        }
    }
}

