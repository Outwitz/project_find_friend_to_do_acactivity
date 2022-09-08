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
    public partial class Edit_pic_from : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Edit_pic_from()
        {
            InitializeComponent();
        }
        //browse pic btn
        private void brw_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
        //back to edit act btn
        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            edit_act fme = new edit_act();
            fme.Show();
            Visible = false;
        }
        //load global lable
        //show data in table
        private void Edit_from_Load(object sender, EventArgs e)
        {
            lbshowname.Text = login_form.username;
            name_act.Text = edit_act.nameact;
            FillDVG();
            

        }
        //get data form db to table
        public void FillDVG()
        {
            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM user_history_pic_" + lbshowname.Text + " WHERE name_activity = '" + name_act.Text + "'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            data_pic_table.RowTemplate.Height = 60;
            data_pic_table.AllowUserToAddRows = false;
            data_pic_table.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)data_pic_table.Columns["picture"];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            data_pic_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //click pic to edit
        private void data_pic_table_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])data_pic_table.CurrentRow.Cells["picture"].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
        }

        //update pic btn
        private void up_btn_Click(object sender, EventArgs e)
        {

            //condb
            MySqlConnection conn = databaseConnection();

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            //update pic to user history
            MySqlCommand cmd1 = new MySqlCommand("UPDATE user_history_pic_" + lbshowname.Text + " SET picture=@img WHERE name_activity = '" + name_act.Text + "'", conn);
            cmd1.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;
            //
            MySqlCommand cmd2 = new MySqlCommand("UPDATE lib_picture SET picture = @img WHERE name_activity = '" + name_act.Text + "'", conn);
            cmd2.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;
            conn.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
            //show msg box
            MessageBox.Show("update picture successfully");
            FillDVG();
            
        }
        //delete btn
        private void del_btn_Click(object sender, EventArgs e)
        {
            //condb
            MySqlConnection conn = databaseConnection();

            data_pic_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int selectedRow = data_pic_table.CurrentCell.RowIndex;
            DataGridViewRow row = data_pic_table.CurrentCell.OwningRow;
            int deleteId = Convert.ToInt32(data_pic_table.Rows[selectedRow].Cells["id"].Value);
            string deleteby_name = row.Cells["name_activity"].Value.ToString();

            //delete data from user history
            String sql = "DELETE FROM user_history_pic_" + lbshowname.Text + " WHERE id = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            //delete data from db
            String sql2 = "DELETE FROM lib2 WHERE name = '" + deleteby_name + "'";
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

            //confirm msg
            DialogResult dialogResult = MessageBox.Show("are you sure to delete data", "confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
                //show msg
                MessageBox.Show("edit successfully");
                //refresh table
                FillDVG();
                
            }
        }
    }
    
}
