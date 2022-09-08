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
   
    public partial class login_form : Form
    {
        //create global text
        public static string username;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";

            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public login_form()
        {
            InitializeComponent();
        }
        //exit app btn
        private void exit_btn_Click(object sender, EventArgs e)
        {
            //exit app
            Application.Exit();
        }
        //login btn
        private void log_btn_Click(object sender, EventArgs e)
        {
            //login btn
            username = log_user.Text;
            //conn db
            MySqlConnection conn = databaseConnection();
            //check user in table to login
            conn.Open();
            String query = "SELECT * FROM account_user Where username  = '" + log_user.Text.Trim() + "' and password = '" + log_pass.Text.Trim() + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                main_m fme = new main_m();
                fme.Show();
                Visible = false;
                MessageBox.Show("Login successfully");
                conn.Close();
            }
            //login as admin
            else if (log_user.Text == "admin" && log_pass.Text == "admin")
            {
                admin_form fme_ad = new admin_form();
                fme_ad.Show();
                Visible = false;
                MessageBox.Show("Login as administrator");
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }
        //show password btn
        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            //show password check box
            if (show_pass.Checked)
            {
                log_pass.UseSystemPasswordChar = false;

            }
            else
            {
                log_pass.UseSystemPasswordChar = true;

            }
        }
        //use password char like "*"
        private void login_form_Load(object sender, EventArgs e)
        {
            
            log_pass.UseSystemPasswordChar = true;
        }
        //create account btn
        private void c_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //create account
            reg_user fme_r = new reg_user();
            fme_r.Show();
            Visible = false;
        }
        //reset password btn
        private void forget_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //reset pass windows
            re_pass fme_r = new re_pass();
            fme_r.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
