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
    public partial class reg_act : Form
    {
        //create global  lable
        public static string nameact;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public reg_act()
        {
            InitializeComponent();
        }
        //Back to menu btn
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            main_m fme = new main_m();
            fme.Show();
            Visible = false;
        }
        //submit btn
        private void sub_add_btn_Click(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();
            string url_act = add_link.Text;
            //check text length
            if (add_name.Text.Length < 1)
            {
                MessageBox.Show("enter your name");
            }
            else if (type_combo.SelectedIndex < 0)
            {
                MessageBox.Show("pls select your type act");
            }
            else if (add_detail.Text.Length < 1)
            {
                MessageBox.Show("pls enter your detail");
            }
            else if (add_location.Text.Length < 1)
            {
                MessageBox.Show("pls enter your location");
            }
            else if (add_name.Text.Length > 1)
            {
                //check data exist
                MySqlCommand check_add_ex = new MySqlCommand("Select * From lib2 where name = '" + add_name.Text + "'", conn);
                conn.Open();
                MySqlDataReader dr = check_add_ex.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("this name already exist");
                    
                }
                //check link url
                else if (Uri.IsWellFormedUriString(url_act, UriKind.Absolute))
                {
                    conn.Close();

                    conn.Open();
                    string theDate = add_date.Value.ToShortDateString();

                    //insert data to db
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO lib2 (name,type,detail,date,location,link) VALUES('" + add_name.Text + "', '" + type_combo.Text + "', '" + add_detail.Text + "', '" + theDate + "', '" + add_location.Text + "', '" + add_link.Text + "')", conn);

                    //insert to user history add activity
                    String sql_2 = "INSERT INTO user_history_add_" + lbshowname.Text + "(name,type,detail,date,location,link) VALUES('" + add_name.Text + "','" + type_combo.Text + "','" + add_detail.Text + "','" + theDate + "','" + add_location.Text + "','" + add_link.Text + "')";
                    MySqlCommand cmd_2 = new MySqlCommand(sql_2, conn);

                    //insert name activity to record
                    MySqlCommand cmd_re = new MySqlCommand("INSERT INTO record (name) VALUES('" + add_name.Text + "')", conn);

                    //count add activity to user record
                    MySqlCommand cmd_p_add = new MySqlCommand("UPDATE record_user SET user_add_activity_total = user_add_activity_total + 1 WHERE username = '" + lbshowname.Text + "'", conn);
                    

                    cmd.ExecuteNonQuery();
                    cmd_2.ExecuteNonQuery();
                    cmd_re.ExecuteNonQuery();                    
                    cmd_p_add.ExecuteNonQuery();

                    //show msg box
                    MessageBox.Show("successfully");

                    conn.Close();
                }
                else
                {
                    //show msg box
                    MessageBox.Show("url invalid");
                }
            }
        }
        //load global lable
        private void Form3_Load(object sender, EventArgs e)
        {
            lbshowname.Text = login_form.username;
        }
        //add pic form btn
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            nameact = add_name.Text;
            add_pic fme = new add_pic();
            fme.Show();
            
        }
    }
}
