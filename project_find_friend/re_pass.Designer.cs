namespace project_find_friend
{
    partial class re_pass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show_pass_box = new System.Windows.Forms.CheckBox();
            this.s_otp_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.otp_check = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.con_pass_re = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.email_re = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pass_re = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.user_re = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.submit_set_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.back_set_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.show_pass_box);
            this.groupBox1.Controls.Add(this.s_otp_btn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.otp_check);
            this.groupBox1.Controls.Add(this.con_pass_re);
            this.groupBox1.Controls.Add(this.email_re);
            this.groupBox1.Controls.Add(this.pass_re);
            this.groupBox1.Controls.Add(this.user_re);
            this.groupBox1.Location = new System.Drawing.Point(45, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(632, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // show_pass_box
            // 
            this.show_pass_box.AutoSize = true;
            this.show_pass_box.Location = new System.Drawing.Point(536, 287);
            this.show_pass_box.Margin = new System.Windows.Forms.Padding(2);
            this.show_pass_box.Name = "show_pass_box";
            this.show_pass_box.Size = new System.Drawing.Size(99, 17);
            this.show_pass_box.TabIndex = 16;
            this.show_pass_box.Text = "show password";
            this.show_pass_box.UseVisualStyleBackColor = true;
            this.show_pass_box.CheckedChanged += new System.EventHandler(this.show_pass_box_CheckedChanged);
            // 
            // s_otp_btn
            // 
            this.s_otp_btn.Location = new System.Drawing.Point(545, 157);
            this.s_otp_btn.Margin = new System.Windows.Forms.Padding(2);
            this.s_otp_btn.Name = "s_otp_btn";
            this.s_otp_btn.Size = new System.Drawing.Size(64, 29);
            this.s_otp_btn.TabIndex = 15;
            this.s_otp_btn.Text = "Sent OTP";
            this.s_otp_btn.UseVisualStyleBackColor = true;
            this.s_otp_btn.Click += new System.EventHandler(this.s_otp_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mali", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(189, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 57);
            this.label6.TabIndex = 14;
            this.label6.Text = "Reset password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mali", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(5, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 57);
            this.label5.TabIndex = 13;
            this.label5.Text = "OTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mali", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(5, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 57);
            this.label4.TabIndex = 12;
            this.label4.Text = "confirm password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mali", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(5, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 57);
            this.label3.TabIndex = 11;
            this.label3.Text = "New password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mali", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(5, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 57);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mali", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // otp_check
            // 
            this.otp_check.Location = new System.Drawing.Point(278, 319);
            this.otp_check.Name = "otp_check";
            this.otp_check.Size = new System.Drawing.Size(248, 35);
            this.otp_check.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.otp_check.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.otp_check.StateCommon.Border.Rounding = 20;
            this.otp_check.StateCommon.Border.Width = 1;
            this.otp_check.TabIndex = 8;
            // 
            // con_pass_re
            // 
            this.con_pass_re.Location = new System.Drawing.Point(278, 271);
            this.con_pass_re.Name = "con_pass_re";
            this.con_pass_re.Size = new System.Drawing.Size(248, 35);
            this.con_pass_re.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.con_pass_re.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.con_pass_re.StateCommon.Border.Rounding = 20;
            this.con_pass_re.StateCommon.Border.Width = 1;
            this.con_pass_re.TabIndex = 7;
            // 
            // email_re
            // 
            this.email_re.Location = new System.Drawing.Point(278, 154);
            this.email_re.Name = "email_re";
            this.email_re.Size = new System.Drawing.Size(248, 35);
            this.email_re.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.email_re.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.email_re.StateCommon.Border.Rounding = 20;
            this.email_re.StateCommon.Border.Width = 1;
            this.email_re.TabIndex = 6;
            // 
            // pass_re
            // 
            this.pass_re.Location = new System.Drawing.Point(278, 213);
            this.pass_re.Name = "pass_re";
            this.pass_re.Size = new System.Drawing.Size(248, 35);
            this.pass_re.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.pass_re.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pass_re.StateCommon.Border.Rounding = 20;
            this.pass_re.StateCommon.Border.Width = 1;
            this.pass_re.TabIndex = 5;
            // 
            // user_re
            // 
            this.user_re.Location = new System.Drawing.Point(278, 96);
            this.user_re.Name = "user_re";
            this.user_re.Size = new System.Drawing.Size(248, 35);
            this.user_re.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.user_re.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.user_re.StateCommon.Border.Rounding = 20;
            this.user_re.StateCommon.Border.Width = 1;
            this.user_re.TabIndex = 4;
            // 
            // submit_set_btn
            // 
            this.submit_set_btn.Location = new System.Drawing.Point(206, 444);
            this.submit_set_btn.Name = "submit_set_btn";
            this.submit_set_btn.Size = new System.Drawing.Size(128, 36);
            this.submit_set_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submit_set_btn.StateCommon.Border.Rounding = 20;
            this.submit_set_btn.StateCommon.Border.Width = 1;
            this.submit_set_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.submit_set_btn.StateNormal.Back.Color2 = System.Drawing.Color.DarkTurquoise;
            this.submit_set_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.submit_set_btn.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.submit_set_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.submit_set_btn.TabIndex = 6;
            this.submit_set_btn.Values.Text = "Submit";
            this.submit_set_btn.Click += new System.EventHandler(this.submit_set_btn_Click);
            // 
            // back_set_btn
            // 
            this.back_set_btn.Location = new System.Drawing.Point(350, 444);
            this.back_set_btn.Name = "back_set_btn";
            this.back_set_btn.Size = new System.Drawing.Size(128, 36);
            this.back_set_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.back_set_btn.StateCommon.Border.Rounding = 20;
            this.back_set_btn.StateCommon.Border.Width = 1;
            this.back_set_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.back_set_btn.StateNormal.Back.Color2 = System.Drawing.Color.DarkTurquoise;
            this.back_set_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.back_set_btn.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.back_set_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.back_set_btn.TabIndex = 7;
            this.back_set_btn.Values.Text = "Back";
            this.back_set_btn.Click += new System.EventHandler(this.back_set_btn_Click_1);
            // 
            // re_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_find_friend.Properties.Resources.bgff;
            this.ClientSize = new System.Drawing.Size(699, 491);
            this.Controls.Add(this.back_set_btn);
            this.Controls.Add(this.submit_set_btn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "re_pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset password";
            this.Load += new System.EventHandler(this.re_pass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton submit_set_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton back_set_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox user_re;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox otp_check;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox con_pass_re;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox email_re;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pass_re;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button s_otp_btn;
        private System.Windows.Forms.CheckBox show_pass_box;
    }
}