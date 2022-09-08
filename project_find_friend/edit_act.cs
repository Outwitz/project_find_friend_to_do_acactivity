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
    
    public partial class edit_act : Form
    {
        //create global lable
        public static string nameact;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public edit_act()
        {
            InitializeComponent();
        }
        //main menu form btn
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            main_m fme = new main_m();
            fme.Show();
            Visible = false;
        }
        //get data from db to table
        public void populateGrid()
        {
            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand command;
            MySqlDataAdapter da;
            string query = "SELECT * FROM user_history_add_" + lbshowname.Text + "";
            command = new MySqlCommand(query, conn);
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            edit_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            edit_table.AllowUserToAddRows = false;
            
            da.Fill(table);
            edit_table.DataSource = table;
        }
        //load global lable 
        //show data in table
        private void edit_act_Load(object sender, EventArgs e)
        {
            lbshowname.Text = login_form.username;
            populateGrid();
        }
        //click table to textbox
        private void edit_table_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            e_name.Text = edit_table.CurrentRow.Cells["name"].Value.ToString();
            e_detail.Text = edit_table.CurrentRow.Cells["detail"].Value.ToString();
            e_loc.Text = edit_table.CurrentRow.Cells["location"].Value.ToString();
            e_link.Text = edit_table.CurrentRow.Cells["link"].Value.ToString();  
            lbact.Text = edit_table.CurrentRow.Cells["name"].Value.ToString();
        }
        //edit submit btn
        private void edit_sub_btn_Click(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();

            string url_act = e_link.Text;
            if (e_name.Text.Length < 1)
            {
                MessageBox.Show("pls enter your name");
            }
            else if (e_cb.SelectedIndex < 0)
            {
                MessageBox.Show("pls select your type act");
            }
            else if (e_detail.Text.Length < 1)
            {
                MessageBox.Show("pls enter your detail");
            }
            else if (e_loc.Text.Length < 1)
            {
                MessageBox.Show("pls enter your location");
            }
            //check link url
            else if (Uri.IsWellFormedUriString(url_act, UriKind.Absolute))
            {


                int selectedRow = edit_table.CurrentCell.RowIndex;
                DataGridViewRow row = edit_table.CurrentCell.OwningRow;
                int edit_Id = Convert.ToInt32(edit_table.Rows[selectedRow].Cells["id_act"].Value);
                string editby_name = row.Cells["name"].Value.ToString();
                string theDate = e_date.Value.ToShortDateString();
                //update data to db
                String sql_u1 = "UPDATE lib2 SET name = '" + e_name.Text + "',type = '" + e_cb.Text + "',detail = '" + e_detail.Text + "',date = '" + theDate + "',location = '" + e_loc.Text + "',link = '" + e_link.Text + "' WHERE name = '" + editby_name + "'";
                MySqlCommand cmd_1 = new MySqlCommand(sql_u1, conn);
                //update data to user history 
                String sql_u2 = "UPDATE user_history_add_" + lbshowname.Text + " SET name = '" + e_name.Text + "',type = '" + e_cb.Text + "',detail = '" + e_detail.Text + "',date = '" + theDate + "',location = '" + e_loc.Text + "',link = '" + e_link.Text + "' WHERE id_act = '" + edit_Id + "'";
                MySqlCommand cmd_2 = new MySqlCommand(sql_u2, conn);

                String sql_u11 = "UPDATE record SET name  = '" + e_name.Text + "' WHERE name ='" + lbact.Text + "'";
                MySqlCommand cmd_11 = new MySqlCommand(sql_u11, conn);

                String sql_pice = "UPDATE user_history_pic_" + lbshowname.Text + " SET name_activity  = '" + e_name.Text + "' WHERE name_activity ='" + lbact.Text + "'";
                MySqlCommand cmd_pice = new MySqlCommand(sql_pice, conn);

                String sql_pice_pre = "UPDATE lib_picture SET name_activity  = '" + e_name.Text + "' WHERE name_activity ='" + lbact.Text + "'";
                MySqlCommand cmd_pre = new MySqlCommand(sql_pice_pre, conn);
                //msg confirm
                DialogResult dialogResult = MessageBox.Show("are you sure to edit data", "confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conn.Open();
                    cmd_1.ExecuteNonQuery();
                    cmd_2.ExecuteNonQuery();
                    cmd_11.ExecuteNonQuery();
                    cmd_pice.ExecuteNonQuery();
                    cmd_pre.ExecuteNonQuery();
                    conn.Close();
                    //show msg box
                    MessageBox.Show("edit successfully");
                    populateGrid();
                }

            }
        }
        //edit pic form btn
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            nameact = e_name.Text;
            Edit_pic_from fme = new Edit_pic_from();
            fme.Show();
            Visible = false;
        }
    }
}
