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
    public partial class rec_user : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public rec_user()
        {
            InitializeComponent();
        }
        public void populateGrid()
        {
            dataGridVieww.AllowUserToAddRows = false;


            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand command;
            MySqlDataAdapter da;
            string selectQuery = "SELECT * FROM record_user";
            command = new MySqlCommand(selectQuery, conn);
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            dataGridVieww.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            da.Fill(table);
            dataGridVieww.DataSource = table;

        }
        private void conbo_box_db()
        {
            //condb
            MySqlConnection conn = databaseConnection();


            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from record_user", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cmd.ExecuteNonQuery();
            ser_re_combo_u.DataSource = ds.Tables[0];
            ser_re_combo_u.DisplayMember = "username";
            ser_re_combo_u.ValueMember = "id_act";



            conn.Close();
        }
        public void TextboxFilter()
        {
            //condb
            MySqlConnection conn = databaseConnection();

            conn.Open();
            string query = "SELECT * FROM record_user WHERE username like '" + ser_re_combo_u.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridVieww.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void rec_user_Load(object sender, EventArgs e)
        {
            populateGrid();
            conbo_box_db();
        }

        private void ser_re_btn_u_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void ref_btn_u_Click(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void b_rec_btn_u_Click(object sender, EventArgs e)
        {
            main_m fme_r_m = new main_m();
            fme_r_m.Show();
            Visible = false;
        }
    }
}
