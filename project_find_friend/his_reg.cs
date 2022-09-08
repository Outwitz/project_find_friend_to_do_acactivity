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
    public partial class his_reg : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public his_reg()
        {
            InitializeComponent();
        }
        //load global lable
        //show data in table
        private void Form1_Load(object sender, EventArgs e)
        {
            lbshowname.Text = login_form.username;
            populateGrid();
        }
        //get data
        public void populateGrid()
        {
            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand command;
            MySqlDataAdapter da;
            string query = "SELECT * FROM user_history_reg_" + lbshowname.Text + "";
            command = new MySqlCommand(query, conn);
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            table_reg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_reg.AllowUserToAddRows = false;
            da.Fill(table);
            table_reg.DataSource = table;
        }
        //cancel register btn
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();


            int selectedRow = table_reg.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(table_reg.Rows[selectedRow].Cells["id_act"].Value);
            string deleteby_name = table_reg.Rows[selectedRow].Cells["name"].Value.ToString();

            String sql = "DELETE FROM user_history_reg_" + lbshowname.Text + " WHERE id_act = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);


            MySqlCommand cmd_p_likeeeee1 = new MySqlCommand("UPDATE record SET person_registry = person_registry - 1 WHERE name = '" + deleteby_name + "'", conn);

            MySqlCommand cmd_p_likeeeee2 = new MySqlCommand("UPDATE record_user SET user_registry_like_total = user_registry_like_total - 1 WHERE username = '" + lbshowname.Text + "'", conn);

            DialogResult dialogResult = MessageBox.Show("are you sure to Cancel registration", "confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd_p_likeeeee1.ExecuteNonQuery();
                cmd_p_likeeeee2.ExecuteNonQuery();
                conn.Close();
                populateGrid();
                MessageBox.Show("Cancel successfully");
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            main_m fme_r_reg = new main_m();
            fme_r_reg.Show();
            Visible = false;
        }
    }
}
