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


namespace project_find_friend
{
    public partial class report_form : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public report_form()
        {
            InitializeComponent();
        }

        private void report_form_Load(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from lib2",conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            cmd.ExecuteNonQuery();
            cb_r_name.DataSource = ds.Tables[0];
            cb_r_name.DisplayMember = "name";
            cb_r_name.ValueMember = "id_act";



            conn.Close();
        }

        private void b_re_btn_Click(object sender, EventArgs e)
        {
            main_m fme_r_b = new main_m();
            fme_r_b.Show();
            Visible = false;
        }

        private void sub_re_btn_Click(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO report (name,reason) VALUES('" + cb_r_name.Text + "','" + cb_r.Text + "')", conn);
            DialogResult dialogResult = MessageBox.Show("please confirm to report", "confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thank you for report");

            }
        }
    }
}
