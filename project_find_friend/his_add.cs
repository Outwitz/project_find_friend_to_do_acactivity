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
    public partial class his_add : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public his_add()
        {
            InitializeComponent();
        }
        //back to main menu btn
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            main_m fme = new main_m();
            fme.Show();
            Visible = false;
        }
        //get data form db to table
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
            table_add.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_add.AllowUserToAddRows = false;
            da.Fill(table);
            table_add.DataSource = table;
        }
        //load global lable
        //show data in table
        private void Form4_Load(object sender, EventArgs e)
        {
            lbshowname.Text = login_form.username;
            populateGrid();
        }
        //delete btn
        private void del_btnz_Click(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();

            table_add.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int selectedRow = table_add.CurrentCell.RowIndex;
            DataGridViewRow row = table_add.CurrentCell.OwningRow;
            int deleteId = Convert.ToInt32(table_add.Rows[selectedRow].Cells["id_act"].Value);
            string deleteby_name = row.Cells["name"].Value.ToString();

            //delete data from user history
            String sql = "DELETE FROM user_history_add_" + lbshowname.Text + " WHERE id_act = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //delete data from user
            String sql2 = "DELETE FROM lib2 WHERE name = '" + deleteby_name + "'";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

            //discount add act to record
            String sql3 = "DELETE FROM record WHERE name = '" + deleteby_name + "'";
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);

            //discount add act to user record
            MySqlCommand cmd_p_add_all = new MySqlCommand("UPDATE record_user SET user_add_activity_total = user_add_activity_total - 1 WHERE username = '" + lbshowname.Text + "'", conn);
            
            DialogResult dialogResult = MessageBox.Show("are you sure to delete", "confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd_p_add_all.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                conn.Close();
                //refresh table
                populateGrid();
                //show msg box
                MessageBox.Show("Delete successfully");
            }
        }
    }
}
