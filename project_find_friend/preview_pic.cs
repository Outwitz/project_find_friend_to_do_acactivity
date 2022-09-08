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
using System.IO;

namespace project_find_friend
{
    public partial class preview_pic : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public preview_pic()
        {
            InitializeComponent();
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            main_m fme = new main_m();
            fme.Show();
            Visible = false;
        }
        public void FillDVG()
        {
            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM lib_picture", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns["picture"];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void preview_pic_Load(object sender, EventArgs e)
        {
            FillDVG();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells["picture"].Value;
            
            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
