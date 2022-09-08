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
using System.Diagnostics;

namespace project_find_friend
{
    public partial class main_m : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public main_m()
        {
            InitializeComponent();
        }
        //logout btn
        private void log_o_btn_Click(object sender, EventArgs e)
        {
            login_form fme = new login_form();
            fme.Show();
            Visible = false;
            MessageBox.Show("Logout successfully");
            
        }
        //register act btn
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            reg_act fme = new reg_act();
            fme.Show();
            Visible = false;
        }
        //history add act btn
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            his_add fme = new his_add();
            fme.Show();
            Visible = false;
        }
        //history favorite act btn
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            his_fav fme = new his_fav();
            fme.Show();
            Visible = false;
        }
        //edit act btn
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            edit_act fme = new edit_act();
            fme.Show();
            Visible = false;
        }
        //get data from db to show in table 
        public void populateGrid()
        {
            main_data_table.AllowUserToAddRows = false;


            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand command;
            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM lib2";
            command = new MySqlCommand(selectQuery, conn);
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            main_data_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            da.Fill(table);
            main_data_table.DataSource = table;

        }
        //load data gridview
        private void Form2_Load(object sender, EventArgs e)
        {
            populateGrid();
            lbshowname.Text = login_form.username;
            
        }
        //search func
        public void TextboxFilter()
        {
            //condb
            MySqlConnection conn = databaseConnection();

            conn.Open();
            string query = "SELECT * FROM lib2 WHERE type like '" + ser_type_combo.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query,conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            main_data_table.DataSource = ds.Tables[0];
            conn.Close();
        }
        //serch btn
        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }
        //refresh btn
        private void Re_btn_Click(object sender, EventArgs e)
        {
            populateGrid();
        }
        //like btn
        private void like_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in main_data_table.Rows)
            {
                
                //checkbox to like
                bool select1 = Convert.ToBoolean(row.Cells["cb1"].Value);
                
                
                
                if (select1)
                {
                    //condb
                    MySqlConnection conn = databaseConnection();

                    //insert to user like history 
                    MySqlCommand cmd1 = new MySqlCommand("Insert into user_history_like_" + lbshowname.Text + "(id_act,name,type,detail,date,location,link)Values(@id_act,@name,@type,@detail,@date,@location,@link)",conn);
                    cmd1.Parameters.AddWithValue("id_act", row.Cells["id_act"].Value);
                    cmd1.Parameters.AddWithValue("name", row.Cells["name"].Value);
                    cmd1.Parameters.AddWithValue("type", row.Cells["type"].Value);
                    cmd1.Parameters.AddWithValue("detail", row.Cells["detail"].Value);
                    cmd1.Parameters.AddWithValue("date", row.Cells["date"].Value);
                    cmd1.Parameters.AddWithValue("location", row.Cells["location"].Value);
                    cmd1.Parameters.AddWithValue("link", row.Cells["link"].Value);

                    //count  to act like record 
                    MySqlCommand cmd_p_like = new MySqlCommand("UPDATE record SET person_like = person_like + 1 WHERE name = @name", conn);
                    cmd_p_like.Parameters.AddWithValue("name", row.Cells["name"].Value);

                    //count to user like record 
                    MySqlCommand cmd_p_add = new MySqlCommand("UPDATE record_user SET user_activity_like_total = user_activity_like_total + 1 WHERE username = '" + lbshowname.Text + "'", conn);

                    //check like already
                    MySqlCommand check_ex = new MySqlCommand("Select * From user_history_like_" + lbshowname.Text + " where name = @name", conn);
                    check_ex.Parameters.AddWithValue("name", row.Cells["name"].Value);
                    conn.Open();
                    MySqlDataReader dr = check_ex.ExecuteReader();
                    
                    if (dr.HasRows)
                    {
                        //show msg box
                        MessageBox.Show("you like this activity already");
                        conn.Close();

                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        cmd_p_like.ExecuteNonQuery();

                        cmd1.ExecuteNonQuery();

                        cmd_p_add.ExecuteNonQuery();
                        conn.Close();
                        //show msg box
                        MessageBox.Show("you like this activity");
                    }
                }
                
            }
            
        }
        //report form btn
        private void report_btn_Click(object sender, EventArgs e)
        {
            report_form fme_r = new report_form();
            fme_r.Show();
            Visible = false;
        }
        
        //click row to open link
        private void main_data_table_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            var url = main_data_table.CurrentRow.Cells["link"].Value.ToString();
            Process.Start("chrome.exe", url);

            
        }
        //record form btn
        private void rec_btn_Click(object sender, EventArgs e)
        {
            rec_form fme_r_rec = new rec_form();
            fme_r_rec.Show();
            Visible = false;
        }

        //register btn
        private void reg_like_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in main_data_table.Rows)
            {
                
                //checkbox to register
                bool select1 = Convert.ToBoolean(row.Cells["cb1"].Value);
               

                
                if (select1)
                {
                    //condb
                    MySqlConnection conn = databaseConnection();
                    //insert to user register history
                    MySqlCommand cmd1 = new MySqlCommand("Insert into user_history_reg_" + lbshowname.Text + "(id_act,name,type,detail,date,location,link)Values(@id_act,@name,@type,@detail,@date,@location,@link)", conn);
                    cmd1.Parameters.AddWithValue("id_act", row.Cells["id_act"].Value);
                    cmd1.Parameters.AddWithValue("name", row.Cells["name"].Value);
                    cmd1.Parameters.AddWithValue("type", row.Cells["type"].Value);
                    cmd1.Parameters.AddWithValue("detail", row.Cells["detail"].Value);
                    cmd1.Parameters.AddWithValue("date", row.Cells["date"].Value);
                    cmd1.Parameters.AddWithValue("location", row.Cells["location"].Value);
                    cmd1.Parameters.AddWithValue("link", row.Cells["link"].Value);

                    //+1 to act register record
                    MySqlCommand cmd_p_like = new MySqlCommand("UPDATE record SET person_registry = person_registry + 1 WHERE name = @name", conn);
                    cmd_p_like.Parameters.AddWithValue("name", row.Cells["name"].Value);

                    //+1 to user register record
                    MySqlCommand cmd_p_add = new MySqlCommand("UPDATE record_user SET user_registry_like_total = user_registry_like_total + 1 WHERE username = '" + lbshowname.Text + "'", conn);

                    //check register already
                    MySqlCommand check_ex = new MySqlCommand("Select * From user_history_reg_" + lbshowname.Text + " where name = @name", conn);
                    check_ex.Parameters.AddWithValue("name", row.Cells["name"].Value);
                    conn.Open();
                    MySqlDataReader dr = check_ex.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("you registry this activity already");
                        conn.Close();

                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        cmd1.ExecuteNonQuery();
                        cmd_p_like.ExecuteNonQuery();
                        cmd_p_add.ExecuteNonQuery();
                      
                        conn.Close();
                        MessageBox.Show("you registry this activity");
                    }
                    

                }

            }
        }
        //history register form btn
        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            his_reg fme_r_reg = new his_reg();
            fme_r_reg.Show();
            Visible = false;
        }
        //user record form
        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            rec_user fme_r_m = new rec_user();
            fme_r_m.Show();
            Visible = false;
        }
        //preview activity picture
        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            preview_pic fme = new preview_pic();
            fme.Show();
            Visible = false;
        }

        private void edit_acc_btn_Click(object sender, EventArgs e)
        {
            edit_acc fme = new edit_acc();
            fme.Show();
            Visible = false;
        }
    }
}
