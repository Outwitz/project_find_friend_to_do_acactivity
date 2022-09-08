namespace project_find_friend
{
    partial class admin_form
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
            this.del_btn = new System.Windows.Forms.Button();
            this.back_ad_btn = new System.Windows.Forms.Button();
            this.admin_table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admin_table)).BeginInit();
            this.SuspendLayout();
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.del_btn.Location = new System.Drawing.Point(576, 540);
            this.del_btn.Margin = new System.Windows.Forms.Padding(2);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(131, 37);
            this.del_btn.TabIndex = 0;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // back_ad_btn
            // 
            this.back_ad_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.back_ad_btn.Location = new System.Drawing.Point(712, 540);
            this.back_ad_btn.Margin = new System.Windows.Forms.Padding(2);
            this.back_ad_btn.Name = "back_ad_btn";
            this.back_ad_btn.Size = new System.Drawing.Size(131, 37);
            this.back_ad_btn.TabIndex = 1;
            this.back_ad_btn.Text = "Back";
            this.back_ad_btn.UseVisualStyleBackColor = false;
            this.back_ad_btn.Click += new System.EventHandler(this.back_ad_btn_Click);
            // 
            // admin_table
            // 
            this.admin_table.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.admin_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_table.Location = new System.Drawing.Point(21, 47);
            this.admin_table.Margin = new System.Windows.Forms.Padding(2);
            this.admin_table.Name = "admin_table";
            this.admin_table.RowHeadersWidth = 51;
            this.admin_table.RowTemplate.Height = 24;
            this.admin_table.Size = new System.Drawing.Size(798, 488);
            this.admin_table.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.label1.Font = new System.Drawing.Font("Mali", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(383, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project_find_friend.Properties.Resources.bgff;
            this.ClientSize = new System.Drawing.Size(850, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.admin_table);
            this.Controls.Add(this.back_ad_btn);
            this.Controls.Add(this.del_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.admin_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button back_ad_btn;
        private System.Windows.Forms.DataGridView admin_table;
        private System.Windows.Forms.Label label1;
    }
}