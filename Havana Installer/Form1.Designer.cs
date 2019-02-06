namespace Havana_Installer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_Install = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_token = new System.Windows.Forms.Label();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.lbl_pref = new System.Windows.Forms.Label();
            this.lbl_shardCount = new System.Windows.Forms.Label();
            this.lbl_owners = new System.Windows.Forms.Label();
            this.txt_prefix = new System.Windows.Forms.TextBox();
            this.txt_shard = new System.Windows.Forms.TextBox();
            this.txt_owner = new System.Windows.Forms.TextBox();
            this.lbl_api = new System.Windows.Forms.Label();
            this.txt_api = new System.Windows.Forms.TextBox();
            this.lbl_cooldown = new System.Windows.Forms.Label();
            this.txt_cooldown = new System.Windows.Forms.TextBox();
            this.lbl_mcooldown = new System.Windows.Forms.Label();
            this.txt_mass = new System.Windows.Forms.TextBox();
            this.lbl_playing = new System.Windows.Forms.Label();
            this.txt_playing = new System.Windows.Forms.TextBox();
            this.lbl_steam = new System.Windows.Forms.Label();
            this.txt_steam = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.prg = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.progress);
            this.panel2.Location = new System.Drawing.Point(-9, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 10);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 65);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(480, -2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 31);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_mini
            // 
            this.btn_mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mini.ForeColor = System.Drawing.Color.White;
            this.btn_mini.Location = new System.Drawing.Point(456, -2);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(24, 31);
            this.btn_mini.TabIndex = 5;
            this.btn_mini.Text = "-";
            this.btn_mini.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mini.UseVisualStyleBackColor = false;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_Install
            // 
            this.btn_Install.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Install.FlatAppearance.BorderSize = 2;
            this.btn_Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Install.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Install.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Install.Location = new System.Drawing.Point(414, 309);
            this.btn_Install.Name = "btn_Install";
            this.btn_Install.Size = new System.Drawing.Size(75, 33);
            this.btn_Install.TabIndex = 0;
            this.btn_Install.Text = "Install";
            this.btn_Install.UseVisualStyleBackColor = true;
            this.btn_Install.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.prg);
            this.panel1.Controls.Add(this.txt_steam);
            this.panel1.Controls.Add(this.lbl_steam);
            this.panel1.Controls.Add(this.txt_playing);
            this.panel1.Controls.Add(this.lbl_playing);
            this.panel1.Controls.Add(this.txt_mass);
            this.panel1.Controls.Add(this.lbl_mcooldown);
            this.panel1.Controls.Add(this.txt_cooldown);
            this.panel1.Controls.Add(this.lbl_cooldown);
            this.panel1.Controls.Add(this.txt_api);
            this.panel1.Controls.Add(this.lbl_api);
            this.panel1.Controls.Add(this.txt_owner);
            this.panel1.Controls.Add(this.txt_shard);
            this.panel1.Controls.Add(this.txt_prefix);
            this.panel1.Controls.Add(this.lbl_owners);
            this.panel1.Controls.Add(this.lbl_shardCount);
            this.panel1.Controls.Add(this.lbl_pref);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 215);
            this.panel1.TabIndex = 6;
            // 
            // lbl_token
            // 
            this.lbl_token.AutoSize = true;
            this.lbl_token.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_token.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_token.ForeColor = System.Drawing.Color.White;
            this.lbl_token.Location = new System.Drawing.Point(9, 317);
            this.lbl_token.Name = "lbl_token";
            this.lbl_token.Size = new System.Drawing.Size(49, 18);
            this.lbl_token.TabIndex = 0;
            this.lbl_token.Text = "Token:";
            // 
            // txt_token
            // 
            this.txt_token.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_token.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_token.ForeColor = System.Drawing.Color.White;
            this.txt_token.Location = new System.Drawing.Point(64, 317);
            this.txt_token.Name = "txt_token";
            this.txt_token.PasswordChar = '•';
            this.txt_token.Size = new System.Drawing.Size(269, 20);
            this.txt_token.TabIndex = 1;
            // 
            // lbl_pref
            // 
            this.lbl_pref.AutoSize = true;
            this.lbl_pref.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pref.ForeColor = System.Drawing.Color.White;
            this.lbl_pref.Location = new System.Drawing.Point(13, 12);
            this.lbl_pref.Name = "lbl_pref";
            this.lbl_pref.Size = new System.Drawing.Size(48, 18);
            this.lbl_pref.TabIndex = 2;
            this.lbl_pref.Text = "Prefix:";
            // 
            // lbl_shardCount
            // 
            this.lbl_shardCount.AutoSize = true;
            this.lbl_shardCount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shardCount.ForeColor = System.Drawing.Color.White;
            this.lbl_shardCount.Location = new System.Drawing.Point(13, 45);
            this.lbl_shardCount.Name = "lbl_shardCount";
            this.lbl_shardCount.Size = new System.Drawing.Size(87, 18);
            this.lbl_shardCount.TabIndex = 3;
            this.lbl_shardCount.Text = "Shard Count:";
            // 
            // lbl_owners
            // 
            this.lbl_owners.AutoSize = true;
            this.lbl_owners.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_owners.ForeColor = System.Drawing.Color.White;
            this.lbl_owners.Location = new System.Drawing.Point(13, 81);
            this.lbl_owners.Name = "lbl_owners";
            this.lbl_owners.Size = new System.Drawing.Size(54, 18);
            this.lbl_owners.TabIndex = 4;
            this.lbl_owners.Text = "Owner:";
            // 
            // txt_prefix
            // 
            this.txt_prefix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_prefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prefix.ForeColor = System.Drawing.Color.White;
            this.txt_prefix.Location = new System.Drawing.Point(67, 12);
            this.txt_prefix.Name = "txt_prefix";
            this.txt_prefix.Size = new System.Drawing.Size(144, 20);
            this.txt_prefix.TabIndex = 7;
            // 
            // txt_shard
            // 
            this.txt_shard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_shard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shard.ForeColor = System.Drawing.Color.White;
            this.txt_shard.Location = new System.Drawing.Point(106, 45);
            this.txt_shard.Name = "txt_shard";
            this.txt_shard.Size = new System.Drawing.Size(105, 20);
            this.txt_shard.TabIndex = 8;
            // 
            // txt_owner
            // 
            this.txt_owner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_owner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_owner.ForeColor = System.Drawing.Color.White;
            this.txt_owner.Location = new System.Drawing.Point(73, 81);
            this.txt_owner.Name = "txt_owner";
            this.txt_owner.Size = new System.Drawing.Size(138, 20);
            this.txt_owner.TabIndex = 9;
            // 
            // lbl_api
            // 
            this.lbl_api.AutoSize = true;
            this.lbl_api.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_api.ForeColor = System.Drawing.Color.White;
            this.lbl_api.Location = new System.Drawing.Point(13, 119);
            this.lbl_api.Name = "lbl_api";
            this.lbl_api.Size = new System.Drawing.Size(33, 18);
            this.lbl_api.TabIndex = 10;
            this.lbl_api.Text = "API:";
            // 
            // txt_api
            // 
            this.txt_api.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_api.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_api.ForeColor = System.Drawing.Color.White;
            this.txt_api.Location = new System.Drawing.Point(52, 120);
            this.txt_api.Name = "txt_api";
            this.txt_api.Size = new System.Drawing.Size(159, 20);
            this.txt_api.TabIndex = 11;
            this.txt_api.Text = "api.qoilo.com";
            // 
            // lbl_cooldown
            // 
            this.lbl_cooldown.AutoSize = true;
            this.lbl_cooldown.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cooldown.ForeColor = System.Drawing.Color.White;
            this.lbl_cooldown.Location = new System.Drawing.Point(13, 161);
            this.lbl_cooldown.Name = "lbl_cooldown";
            this.lbl_cooldown.Size = new System.Drawing.Size(75, 18);
            this.lbl_cooldown.TabIndex = 12;
            this.lbl_cooldown.Text = "Cooldown:";
            // 
            // txt_cooldown
            // 
            this.txt_cooldown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cooldown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cooldown.ForeColor = System.Drawing.Color.White;
            this.txt_cooldown.Location = new System.Drawing.Point(94, 161);
            this.txt_cooldown.Name = "txt_cooldown";
            this.txt_cooldown.Size = new System.Drawing.Size(117, 20);
            this.txt_cooldown.TabIndex = 13;
            // 
            // lbl_mcooldown
            // 
            this.lbl_mcooldown.AutoSize = true;
            this.lbl_mcooldown.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mcooldown.ForeColor = System.Drawing.Color.White;
            this.lbl_mcooldown.Location = new System.Drawing.Point(253, 11);
            this.lbl_mcooldown.Name = "lbl_mcooldown";
            this.lbl_mcooldown.Size = new System.Drawing.Size(109, 18);
            this.lbl_mcooldown.TabIndex = 14;
            this.lbl_mcooldown.Text = "Mass Cooldown:";
            // 
            // txt_mass
            // 
            this.txt_mass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mass.ForeColor = System.Drawing.Color.White;
            this.txt_mass.Location = new System.Drawing.Point(368, 10);
            this.txt_mass.Name = "txt_mass";
            this.txt_mass.Size = new System.Drawing.Size(92, 20);
            this.txt_mass.TabIndex = 15;
            // 
            // lbl_playing
            // 
            this.lbl_playing.AutoSize = true;
            this.lbl_playing.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playing.ForeColor = System.Drawing.Color.White;
            this.lbl_playing.Location = new System.Drawing.Point(253, 45);
            this.lbl_playing.Name = "lbl_playing";
            this.lbl_playing.Size = new System.Drawing.Size(57, 18);
            this.lbl_playing.TabIndex = 16;
            this.lbl_playing.Text = "Playing:";
            // 
            // txt_playing
            // 
            this.txt_playing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_playing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_playing.ForeColor = System.Drawing.Color.White;
            this.txt_playing.Location = new System.Drawing.Point(316, 46);
            this.txt_playing.Name = "txt_playing";
            this.txt_playing.Size = new System.Drawing.Size(144, 20);
            this.txt_playing.TabIndex = 17;
            // 
            // lbl_steam
            // 
            this.lbl_steam.AutoSize = true;
            this.lbl_steam.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_steam.ForeColor = System.Drawing.Color.White;
            this.lbl_steam.Location = new System.Drawing.Point(253, 81);
            this.lbl_steam.Name = "lbl_steam";
            this.lbl_steam.Size = new System.Drawing.Size(51, 18);
            this.lbl_steam.TabIndex = 18;
            this.lbl_steam.Text = "Steam:";
            // 
            // txt_steam
            // 
            this.txt_steam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_steam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_steam.ForeColor = System.Drawing.Color.White;
            this.txt_steam.Location = new System.Drawing.Point(310, 82);
            this.txt_steam.Name = "txt_steam";
            this.txt_steam.Size = new System.Drawing.Size(150, 20);
            this.txt_steam.TabIndex = 19;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progress.Location = new System.Drawing.Point(3, -13);
            this.progress.MarqueeAnimationSpeed = 10;
            this.progress.Maximum = 10;
            this.progress.Name = "progress";
            this.progress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progress.Size = new System.Drawing.Size(462, 23);
            this.progress.Step = 1;
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress.TabIndex = 7;
            this.progress.UseWaitCursor = true;
            this.progress.Visible = false;
            // 
            // prg
            // 
            this.prg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prg.AutoSize = true;
            this.prg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prg.ForeColor = System.Drawing.Color.White;
            this.prg.Location = new System.Drawing.Point(212, 192);
            this.prg.Name = "prg";
            this.prg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prg.Size = new System.Drawing.Size(151, 23);
            this.prg.TabIndex = 7;
            this.prg.Text = "Beginning Install...";
            this.prg.Visible = false;
            this.prg.Click += new System.EventHandler(this.prg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(502, 352);
            this.Controls.Add(this.txt_token);
            this.Controls.Add(this.lbl_token);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Install);
            this.Controls.Add(this.btn_mini);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Havana Installer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_Install;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_token;
        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Label lbl_pref;
        private System.Windows.Forms.TextBox txt_steam;
        private System.Windows.Forms.Label lbl_steam;
        private System.Windows.Forms.TextBox txt_playing;
        private System.Windows.Forms.Label lbl_playing;
        private System.Windows.Forms.TextBox txt_mass;
        private System.Windows.Forms.Label lbl_mcooldown;
        private System.Windows.Forms.TextBox txt_cooldown;
        private System.Windows.Forms.Label lbl_cooldown;
        private System.Windows.Forms.TextBox txt_api;
        private System.Windows.Forms.Label lbl_api;
        private System.Windows.Forms.TextBox txt_owner;
        private System.Windows.Forms.TextBox txt_shard;
        private System.Windows.Forms.TextBox txt_prefix;
        private System.Windows.Forms.Label lbl_owners;
        private System.Windows.Forms.Label lbl_shardCount;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label prg;
    }
}

