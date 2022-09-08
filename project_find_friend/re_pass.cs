using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace project_find_friend
{
    public partial class re_pass : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ff_project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public re_pass()
        {
            InitializeComponent();
        }
        String randomCode;
        public static String to;

        private void re_pass_Load(object sender, EventArgs e)
        {
            pass_re.UseSystemPasswordChar = true;
            con_pass_re.UseSystemPasswordChar = true;
        }

        private void submit_set_btn_Click(object sender, EventArgs e)
        {
            string check_user = user_re.Text;
            string check_pass = pass_re.Text;
            string check_email = email_re.Text;
            if (pass_re.Text != con_pass_re.Text)
            {
                MessageBox.Show("Password not match");
            }

            else if (user_re.Text.Length == 0)
            {
                MessageBox.Show("pls enter your username");
            }
            else if (pass_re.Text.Length == 0)
            {
                MessageBox.Show("pls enter your password");
            }
            else if (randomCode != (otp_check.Text).ToString())
            {
                MessageBox.Show("Wrong Code");
            }
            else 
            {

                //condb
                MySqlConnection conn = databaseConnection();
                conn.Open();
                String query = "SELECT * FROM account_user Where username  = '" + user_re.Text.Trim() + "' and email = '" + email_re.Text.Trim() + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    
                    String sql_u2 = "UPDATE account_user SET password = '" + pass_re.Text + "' WHERE username = '" + user_re.Text + "'";
                    MySqlCommand cmd_re = new MySqlCommand(sql_u2, conn);
                    cmd_re.ExecuteNonQuery();
                    MessageBox.Show("reset password Successfully");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("username or email invalid");
                }
                
            }
        }
        

        private void s_otp_btn_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (email_re.Text).ToString();
            from = "findfriendproject@gmail.com";
            pass = "etojfegipcbnujnc";
            messageBody = "Your OTP code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void back_set_btn_Click_1(object sender, EventArgs e)
        {
            login_form fme_b = new login_form();
            fme_b.Show();
            Visible = false;
        }

        private void show_pass_box_CheckedChanged(object sender, EventArgs e)
        {

            if (show_pass_box.Checked)
            {
                pass_re.UseSystemPasswordChar = false;
                con_pass_re.UseSystemPasswordChar = false;
            }
            else
            {
                pass_re.UseSystemPasswordChar = true;
                con_pass_re.UseSystemPasswordChar = true;
            }
        }
    }
}

        
    
