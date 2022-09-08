namespace project_find_friend
{
    partial class his_fav
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
            this.table_fav = new System.Windows.Forms.DataGridView();
            this.del_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbshowname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_fav)).BeginInit();
            this.SuspendLayout();
            // 
            // table_fav
            // 
            this.table_fav.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.table_fav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_fav.Location = new System.Drawing.Point(32, 68);
            this.table_fav.Name = "table_fav";
            this.table_fav.RowHeadersWidth = 51;
            this.table_fav.Size = new System.Drawing.Size(1055, 593);
            this.table_fav.TabIndex = 0;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(825, 667);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(128, 36);
            this.del_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.del_btn.StateCommon.Border.Rounding = 20;
            this.del_btn.StateCommon.Border.Width = 1;
            this.del_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.del_btn.StateNormal.Back.Color2 = System.Drawing.Color.DarkTurquoise;
            this.del_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.del_btn.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.del_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.del_btn.TabIndex = 18;
            this.del_btn.Values.Text = "Unlike";
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(959, 667);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(128, 36);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.DarkTurquoise;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 19;
            this.kryptonButton1.Values.Text = "Back";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // lbshowname
            // 
            this.lbshowname.AutoSize = true;
            this.lbshowname.BackColor = System.Drawing.Color.Transparent;
            this.lbshowname.Font = new System.Drawing.Font("Mali", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbshowname.ForeColor = System.Drawing.Color.White;
            this.lbshowname.Location = new System.Drawing.Point(1026, -10);
            this.lbshowname.Name = "lbshowname";
            this.lbshowname.Size = new System.Drawing.Size(61, 40);
            this.lbshowname.TabIndex = 20;
            this.lbshowname.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mali", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(404, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 68);
            this.label2.TabIndex = 21;
            this.label2.Text = "My favorite activity";
            // 
            // his_fav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_find_friend.Properties.Resources.bgff;
            this.ClientSize = new System.Drawing.Size(1136, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbshowname);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.table_fav);
            this.Name = "his_fav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My favorite activity";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_fav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_fav;
        private ComponentFactory.Krypton.Toolkit.KryptonButton del_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label lbshowname;
        private System.Windows.Forms.Label label2;
    }
}