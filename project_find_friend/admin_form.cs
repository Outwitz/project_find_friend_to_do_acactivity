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
    public partial class admin_form : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public admin_form()
        {
            InitializeComponent();
        }
        //login form btn
        private void back_ad_btn_Click(object sender, EventArgs e)
        {
            login_form fme_b = new login_form();
            fme_b.Show();
            Visible = false;
        }
        //get data from db to show in table 
        public void populateGrid()
        {
            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand command;
            MySqlDataAdapter da;
            string query = "SELECT * FROM report";
            command = new MySqlCommand(query, conn);
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            admin_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            admin_table.AllowUserToAddRows = false;
            da.Fill(table);
            admin_table.DataSource = table;
        }
        private void admin_form_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();

            admin_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int selectedRow = admin_table.CurrentCell.RowIndex;
            DataGridViewRow row = admin_table.CurrentCell.OwningRow;
            int deleteId = Convert.ToInt32(admin_table.Rows[selectedRow].Cells["id_report"].Value);
            string deleteby_name = row.Cells["name"].Value.ToString();

            String sql = "DELETE FROM report WHERE id_report = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            String sql2 = "DELETE FROM lib2 WHERE name = '" + deleteby_name + "'";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
            populateGrid();
            MessageBox.Show("Delete successfully");
        }
    }
}
