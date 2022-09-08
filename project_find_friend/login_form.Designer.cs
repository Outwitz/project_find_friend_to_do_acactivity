namespace project_find_friend
{
    partial class login_form
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
            this.forget_btn = new System.Windows.Forms.LinkLabel();
            this.c_btn = new System.Windows.Forms.LinkLabel();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.exit_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.log_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.log_pass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.log_user = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.forget_btn);
            this.groupBox1.Controls.Add(this.c_btn);
            this.groupBox1.Controls.Add(this.show_pass);
            this.groupBox1.Controls.Add(this.exit_btn);
            this.groupBox1.Controls.Add(this.log_btn);
            this.groupBox1.Controls.Add(this.log_pass);
            this.groupBox1.Controls.Add(this.log_user);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(758, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // forget_btn
            // 
            this.forget_btn.AutoSize = true;
            this.forget_btn.LinkColor = System.Drawing.Color.Black;
            this.forget_btn.Location = new System.Drawing.Point(56, 353);
            this.forget_btn.Name = "forget_btn";
            this.forget_btn.Size = new System.Drawing.Size(91, 13);
            this.forget_btn.TabIndex = 9;
            this.forget_btn.TabStop = true;
            this.forget_btn.Text = "forget password ?";
            this.forget_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forget_btn_LinkClicked);
            // 
            // c_btn
            // 
            this.c_btn.AutoSize = true;
            this.c_btn.LinkColor = System.Drawing.Color.Black;
            this.c_btn.Location = new System.Drawing.Point(142, 457);
            this.c_btn.Name = "c_btn";
            this.c_btn.Size = new System.Drawing.Size(79, 13);
            this.c_btn.TabIndex = 8;
            this.c_btn.TabStop = true;
            this.c_btn.Text = "create account";
            this.c_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.c_btn_LinkClicked);
            // 
            // show_pass
            // 
            this.show_pass.AutoSize = true;
            this.show_pass.Location = new System.Drawing.Point(205, 353);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(99, 17);
            this.show_pass.TabIndex = 7;
            this.show_pass.Text = "show password";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(192, 410);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(128, 36);
            this.exit_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exit_btn.StateCommon.Border.Rounding = 20;
            this.exit_btn.StateCommon.Border.Width = 1;
            this.exit_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.exit_btn.StateNormal.Back.Color2 = System.Drawing.Color.DarkTurquoise;
            this.exit_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.exit_btn.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.exit_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Values.Text = "Exit";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // log_btn
            // 
            this.log_btn.Location = new System.Drawing.Point(48, 410);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(128, 36);
            this.log_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.log_btn.StateCommon.Border.Rounding = 20;
            this.log_btn.StateCommon.Border.Width = 1;
            this.log_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.log_btn.StateNormal.Back.Color2 = System.Drawing.Color.DarkTurquoise;
            this.log_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.log_btn.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.log_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.log_btn.TabIndex = 5;
            this.log_btn.Values.Text = "Login";
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // log_pass
            // 
            this.log_pass.Location = new System.Drawing.Point(48, 312);
            this.log_pass.Name = "log_pass";
            this.log_pass.Size = new System.Drawing.Size(248, 35);
            this.log_pass.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.log_pass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.log_pass.StateCommon.Border.Rounding = 20;
            this.log_pass.StateCommon.Border.Width = 1;
            this.log_pass.TabIndex = 4;
            // 
            // log_user
            // 
            this.log_user.Location = new System.Drawing.Point(48, 183);
            this.log_user.Name = "log_user";
            this.log_user.Size = new System.Drawing.Size(248, 35);
            this.log_user.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.log_user.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.log_user.StateCommon.Border.Rounding = 20;
            this.log_user.StateCommon.Border.Width = 1;
            this.log_user.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mali", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(6, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mali", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mali", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(-5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project we are friend";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_find_friend.Properties.Resources.bgff;
            this.ClientSize = new System.Drawing.Size(1136, 729);
            this.Controls.Add(this.groupBox1);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox log_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton exit_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton log_btn;
        private System.Windows.Forms.CheckBox show_pass;
        private System.Windows.Forms.LinkLabel c_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox log_user;
        private System.Windows.Forms.LinkLabel forget_btn;
    }
}

