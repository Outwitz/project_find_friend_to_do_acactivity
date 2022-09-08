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
    public partial class his_fav : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public his_fav()
        {
            InitializeComponent();
        }
        //back to main menu form btn
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
            string query = "SELECT * FROM user_history_like_" + lbshowname.Text + "";
            command = new MySqlCommand(query, conn);
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            table_fav.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_fav.AllowUserToAddRows = false;
            da.Fill(table);
            table_fav.DataSource = table;
        }
        //load global lable
        //show data in table
        private void Form6_Load(object sender, EventArgs e)
        {
            lbshowname.Text = login_form.username;
            populateGrid();
        }
        //delete favorite btn
        private void del_btn_Click(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();

            int selectedRow = table_fav.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(table_fav.Rows[selectedRow].Cells["id_act"].Value);
            string deleteby_name = table_fav.Rows[selectedRow].Cells["name"].Value.ToString();
            //delete data from user like history
            String sql = "DELETE FROM user_history_like_" + lbshowname.Text + " WHERE id_act = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //discount like to record table
            MySqlCommand cmd_p_like = new MySqlCommand("UPDATE record SET person_like = person_like - 1 WHERE name = '" + deleteby_name + "'", conn);

            //discount like to record user
            MySqlCommand cmd_p_like_all = new MySqlCommand("UPDATE record_user SET user_activity_like_total = user_activity_like_total - 1 WHERE username = '" + lbshowname.Text + "'", conn);

            //confirm msg box
            DialogResult dialogResult = MessageBox.Show("are you sure to Unlike", "confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd_p_like.ExecuteNonQuery();
                cmd_p_like_all.ExecuteNonQuery();
                conn.Close();
                populateGrid();
                MessageBox.Show("Unlike successfully");
            }          
        }

    }
}
