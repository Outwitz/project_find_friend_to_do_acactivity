namespace project_find_friend
{
    partial class report_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_r = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.sub_re_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.b_re_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cb_r_name = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_r_name)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mali", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(247, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.cb_r);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sub_re_btn);
            this.groupBox1.Controls.Add(this.b_re_btn);
            this.groupBox1.Controls.Add(this.cb_r_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(96, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(647, 467);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cb_r
            // 
            this.cb_r.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_r.DropDownWidth = 373;
            this.cb_r.Items.AddRange(new object[] {
            "Cancel activity",
            "Postpone activity",
            "Change location"});
            this.cb_r.Location = new System.Drawing.Point(185, 206);
            this.cb_r.Margin = new System.Windows.Forms.Padding(2);
            this.cb_r.Name = "cb_r";
            this.cb_r.Size = new System.Drawing.Size(289, 33);
            this.cb_r.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cb_r.StateCommon.ComboBox.Border.Rounding = 20;
            this.cb_r.StateCommon.ComboBox.Border.Width = 1;
            this.cb_r.TabIndex = 8;
            // 
            // sub_re_btn
            // 
            this.sub_re_btn.Location = new System.Drawing.Point(232, 292);
            this.sub_re_btn.Margin = new System.Windows.Forms.Padding(2);
            this.sub_re_btn.Name = "sub_re_btn";
            this.sub_re_btn.Size = new System.Drawing.Size(106, 37);
            this.sub_re_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sub_re_btn.StateCommon.Border.Rounding = 20;
            this.sub_re_btn.StateCommon.Border.Width = 1;
            this.sub_re_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.sub_re_btn.StateNormal.Back.Color2 = System.Drawing.Color.DarkTurquoise;
            this.sub_re_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.sub_re_btn.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.sub_re_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sub_re_btn.TabIndex = 7;
            this.sub_re_btn.Values.Text = "Submit";
            this.sub_re_btn.Click += new System.EventHandler(this.sub_re_btn_Click);
            // 
            // b_re_btn
            // 
            this.b_re_btn.Location = new System.Drawing.Point(343, 292);
            this.b_re_btn.Margin = new System.Windows.Forms.Padding(2);
            this.b_re_btn.Name = "b_re_btn";
            this.b_re_btn.Size = new System.Drawing.Size(107, 37);
            this.b_re_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_re_btn.StateCommon.Border.Rounding = 20;
            this.b_re_btn.StateCommon.Border.Width = 1;
            this.b_re_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.b_re_btn.StateNormal.Back.Color2 = System.Drawing.Color.DarkTurquoise;
            this.b_re_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.b_re_btn.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.b_re_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.b_re_btn.TabIndex = 6;
            this.b_re_btn.Values.Text = "Back";
            this.b_re_btn.Click += new System.EventHandler(this.b_re_btn_Click);
            // 
            // cb_r_name
            // 
            this.cb_r_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_r_name.DropDownWidth = 373;
            this.cb_r_name.Location = new System.Drawing.Point(185, 127);
            this.cb_r_name.Margin = new System.Windows.Forms.Padding(2);
            this.cb_r_name.Name = "cb_r_name";
            this.cb_r_name.Size = new System.Drawing.Size(289, 33);
            this.cb_r_name.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cb_r_name.StateCommon.ComboBox.Border.Rounding = 20;
            this.cb_r_name.StateCommon.ComboBox.Border.Width = 1;
            this.cb_r_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(80, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reason";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mali", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name activity";
            // 
            // report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_find_friend.Properties.Resources.bgff;
            this.ClientSize = new System.Drawing.Size(850, 586);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "report_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.report_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_r_name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cb_r_name;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cb_r;
        private ComponentFactory.Krypton.Toolkit.KryptonButton sub_re_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton b_re_btn;
    }
}