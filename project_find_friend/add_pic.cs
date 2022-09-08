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
    public partial class add_pic : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public add_pic()
        {
            InitializeComponent();
        }

        private void b_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_pic_Load(object sender, EventArgs e)
        {
            lbshowname.Text = login_form.username;
            name_act.Text = reg_act.nameact;

        }

        private void add_pic_btn_Click(object sender, EventArgs e)
        {
            MemoryStream ms= new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            //condb
            MySqlConnection conn = databaseConnection();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO lib_picture(name_activity,picture) VALUES (@name,@img)", conn);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_act.Text;
            cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;

            MySqlCommand cmd_2 = new MySqlCommand("INSERT INTO user_history_pic_" + lbshowname.Text + "(name_activity,picture) VALUES (@name,@img)", conn);
            cmd_2.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_act.Text;
            cmd_2.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;
            conn.Open();
            
            cmd.ExecuteNonQuery();
            cmd_2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert picture successfully");

       


        }
       
    }
}
