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
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace project_find_friend
{
    public partial class reg_user : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public reg_user()
        {
            InitializeComponent();
        }
        // create randomcode
        String randomCode;
        public static String to;

        //back to login btn
        private void b_btn_Click(object sender, EventArgs e)
        {
            // new_windows 
            login_form fme_b = new login_form();
            fme_b.Show();
            Visible = false;
        }
        //submit btn
        private void submit_btn_Click(object sender, EventArgs e)
        {

            string check_user = add_u_box.Text;
            string check_pass = add_p_box.Text;
            string check_email = email_box.Text;
            //check pass not match
            if (add_p_box.Text != con_p_box.Text)
            {
                MessageBox.Show("Password not match");
            }
            //check textbox not empty
            else if (add_u_box.Text.Length == 0)
            {
                MessageBox.Show("pls enter your username");
            }
            //check textbox not empty
            else if (add_p_box.Text.Length == 0)
            {
                MessageBox.Show("pls enter your password");
            }
            //check otp verify
            else if (randomCode != (otp_verify.Text).ToString())
            {
                MessageBox.Show("Wrong Code");
            }
            //check input
            else if (add_u_box.Text.Length > 1 && add_p_box.Text.Length > 1 && email_box.Text.Length > 1)
            {
                //condb
                MySqlConnection conn = databaseConnection();
                //check data exist
                MySqlCommand check_ex = new MySqlCommand("Select * From account_user where username = '" + add_u_box.Text + "' and password = '" + add_p_box.Text + "' and email = '" + email_box.Text + "'", conn);
                conn.Open();
                MySqlDataReader dr = check_ex.ExecuteReader();
                if (dr.HasRows)
                {   
                    MessageBox.Show("Record already exist");

                }
                //check text eng and num only and email validation 
                else if (Regex.IsMatch(check_user, "^[a-zA-Z0-9]*$") && Regex.IsMatch(check_pass, "^[a-zA-Z0-9]*$") && Regex.IsMatch(check_email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {

                    conn.Close();
                    //if true insert data
                    conn.Open();
                    String sql = "INSERT INTO account_user (username,password,email) VALUES('" + add_u_box.Text + "','" + add_p_box.Text + "','" + email_box.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    //create user table 
                    MySqlCommand comand2 = new MySqlCommand("CREATE TABLE user_history_add_" + add_u_box.Text + "(id_act int NOT NULL AUTO_INCREMENT,name Varchar(255),type Varchar(255),detail Varchar(255),date Varchar(255),location Varchar(255),link Varchar(255),PRIMARY KEY (id_act));", conn);
                    MySqlCommand cmd3 = new MySqlCommand("CREATE TABLE user_history_like_" + add_u_box.Text + "(id_act int,name Varchar(255),type Varchar(255),detail Varchar(255),date Varchar(255),location Varchar(255),link Varchar(255));", conn);
                    MySqlCommand cmd4 = new MySqlCommand("CREATE TABLE user_history_reg_" + add_u_box.Text + "(id_act int,name Varchar(255),type Varchar(255),detail Varchar(255),date Varchar(255),location Varchar(255),link Varchar(255));", conn);
                    MySqlCommand cmd_re_add = new MySqlCommand("INSERT INTO record_user (username) VALUES('" + add_u_box.Text + "')", conn);
                    MySqlCommand cmd_pic = new MySqlCommand("CREATE TABLE user_history_pic_" + add_u_box.Text + "(id int NOT NULL AUTO_INCREMENT,name_activity Varchar(255),picture LONGBLOB,PRIMARY KEY (id,name_activity));", conn);


                    comand2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd_re_add.ExecuteNonQuery();
                    cmd_pic.ExecuteNonQuery();

                    conn.Close();
                    //show msg
                    MessageBox.Show("register successfully");
                    

                }
                else
                {
                    //if false show error
                    MessageBox.Show("username or password oremail invalid");
                }

            }
        }
        //hide password
        private void Form1_Load(object sender, EventArgs e)
        {
            
            add_p_box.UseSystemPasswordChar = true;
            con_p_box.UseSystemPasswordChar = true;
        }
        //show pass btn
        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            
            if (show_pass.Checked)
            {
                add_p_box.UseSystemPasswordChar = false;
                con_p_box.UseSystemPasswordChar = false;
            }
            else
            {
                add_p_box.UseSystemPasswordChar = true;
                con_p_box.UseSystemPasswordChar = true;
            }
        }
        //sent otp btn
        private void st_btn_Click(object sender, EventArgs e)
        {
            //sent otp func free 500 mail/day
            String from, pass, messageBody;
            //carete random func
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            //carete mailmsg func
            MailMessage message = new MailMessage();
            to = (email_box.Text).ToString();
            from = "findfriendproject@gmail.com";
            pass = "etojfegipcbnujnc";
            messageBody = "Your OTP code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";
            //setup smtp gmail server
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            //run code
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");
            }
            //catch error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
