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
using System.Text.RegularExpressions;

namespace project_find_friend
{
    public partial class edit_acc : Form
    {
        
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public edit_acc()
        {
            InitializeComponent();
        }

        private void edit_acc_Load(object sender, EventArgs e)
        {
            lbshowname.Text = login_form.username;
            getdata();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            main_m fme = new main_m();
            fme.Show();
            Visible = false;

            
        }
        public void getdata()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select username,password,email from account_user where username ='" + lbshowname.Text + "'", conn);
            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                editacc_uname.Text = reader1["username"].ToString();
                editacc_pass.Text = reader1["password"].ToString();
                editacc_email.Text = reader1["email"].ToString();
            }
            conn.Close();
        }

        private void sub_edit_acc_btn_Click(object sender, EventArgs e)
        {
            string email_check = editacc_email.Text;    
            MySqlConnection conn = databaseConnection();

            if (editacc_uname.Text.Length < 1)
            {
                MessageBox.Show("pls enter your username");
            }
            else if(editacc_pass.Text.Length < 1)
            {
                MessageBox.Show("pls enter your password");
            }
            else if(Regex.IsMatch(email_check, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                String sql_u1 = "UPDATE account_user SET username = '" + editacc_uname.Text + "',password = '" + editacc_pass.Text + "',email = '" + editacc_email.Text + "' WHERE username ='" + lbshowname.Text + "'";
                MySqlCommand cmd_1 = new MySqlCommand(sql_u1, conn);

                String sql_uu = "UPDATE record_user SET username = '" + editacc_uname.Text + "' WHERE username ='" + lbshowname.Text + "'";
                MySqlCommand cmd_uu = new MySqlCommand(sql_uu, conn);

                MySqlCommand cmd2 = new MySqlCommand("ALTER TABLE user_history_add_" + lbshowname.Text + " RENAME user_history_add_" + editacc_uname.Text + "", conn);
                MySqlCommand cmd3 = new MySqlCommand("ALTER TABLE user_history_like_" + lbshowname.Text + " RENAME user_history_like_" + editacc_uname.Text + "", conn);
                MySqlCommand cmd4 = new MySqlCommand("ALTER TABLE user_history_pic_" + lbshowname.Text + " RENAME user_history_pic_" + editacc_uname.Text + "", conn);
                MySqlCommand cmd5 = new MySqlCommand("ALTER TABLE user_history_reg_" + lbshowname.Text + " RENAME user_history_reg_" + editacc_uname.Text + "", conn);

                conn.Open();
                cmd_1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd_uu.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("edit account successfully");

            }
            
        }

        private void del_acc_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd_d1 = new MySqlCommand("DROP TABLE user_history_add_" + lbshowname.Text + "", conn);
            MySqlCommand cmd_d2 = new MySqlCommand("DROP TABLE user_history_like_" + lbshowname.Text + "", conn);
            MySqlCommand cmd_d3 = new MySqlCommand("DROP TABLE user_history_pic_" + lbshowname.Text + "", conn);
            MySqlCommand cmd_d4 = new MySqlCommand("DROP TABLE user_history_reg_" + lbshowname.Text + "", conn);

            MySqlCommand cmd_del_ac = new MySqlCommand("DELETE FROM account_user WHERE username ='" + lbshowname.Text + "'", conn);

         

            DialogResult dialogResult = MessageBox.Show("are you sure to delete account", "confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                cmd_d1.ExecuteNonQuery();
                cmd_d2.ExecuteNonQuery();
                cmd_d3.ExecuteNonQuery();
                cmd_d4.ExecuteNonQuery();
                cmd_del_ac.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("delete account successfully");

            }




        }
    }
}
