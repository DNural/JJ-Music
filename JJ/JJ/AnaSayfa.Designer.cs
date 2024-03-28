namespace JJ
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.pnl_AnaSayfa_Sol = new System.Windows.Forms.Panel();
            this.btn_SarkiListesiSil = new System.Windows.Forms.Button();
            this.btn_SarkiListesiEkle = new System.Windows.Forms.Button();
            this.lb_SarkiListeleri = new System.Windows.Forms.ListBox();
            this.pb_CalanSarki = new System.Windows.Forms.PictureBox();
            this.lbl_Kullanici = new System.Windows.Forms.Label();
            this.pnl_AnaSayfa_Orta = new System.Windows.Forms.Panel();
            this.pnl_AnaSayfa_Alt = new System.Windows.Forms.Panel();
            this.lbl_CalanSarkici = new System.Windows.Forms.Label();
            this.lbl_CalanSarki = new System.Windows.Forms.Label();
            this.lbl_Ses = new System.Windows.Forms.Label();
            this.tb_Ses = new System.Windows.Forms.TrackBar();
            this.lbl_ToplamSure = new System.Windows.Forms.Label();
            this.lbl_GecenSure = new System.Windows.Forms.Label();
            this.tb_Sure = new System.Windows.Forms.TrackBar();
            this.WMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_Onceki = new System.Windows.Forms.Button();
            this.btn_Sonraki = new System.Windows.Forms.Button();
            this.btn_Baslat = new System.Windows.Forms.Button();
            this.timer_GecenSure = new System.Windows.Forms.Timer(this.components);
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_AnaSayfa_Sol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CalanSarki)).BeginInit();
            this.pnl_AnaSayfa_Alt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Sure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AnaSayfa_Sol
            // 
            this.pnl_AnaSayfa_Sol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_AnaSayfa_Sol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnl_AnaSayfa_Sol.Controls.Add(this.pb_Logo);
            this.pnl_AnaSayfa_Sol.Controls.Add(this.btn_SarkiListesiSil);
            this.pnl_AnaSayfa_Sol.Controls.Add(this.btn_SarkiListesiEkle);
            this.pnl_AnaSayfa_Sol.Controls.Add(this.lb_SarkiListeleri);
            this.pnl_AnaSayfa_Sol.Controls.Add(this.pb_CalanSarki);
            this.pnl_AnaSayfa_Sol.Controls.Add(this.lbl_Kullanici);
            this.pnl_AnaSayfa_Sol.Location = new System.Drawing.Point(0, 1);
            this.pnl_AnaSayfa_Sol.Name = "pnl_AnaSayfa_Sol";
            this.pnl_AnaSayfa_Sol.Size = new System.Drawing.Size(255, 600);
            this.pnl_AnaSayfa_Sol.TabIndex = 0;
            // 
            // btn_SarkiListesiSil
            // 
            this.btn_SarkiListesiSil.BackgroundImage = global::JJ.Properties.Resources.deleteButton;
            this.btn_SarkiListesiSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SarkiListesiSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SarkiListesiSil.FlatAppearance.BorderSize = 0;
            this.btn_SarkiListesiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SarkiListesiSil.Location = new System.Drawing.Point(155, 201);
            this.btn_SarkiListesiSil.Name = "btn_SarkiListesiSil";
            this.btn_SarkiListesiSil.Size = new System.Drawing.Size(33, 31);
            this.btn_SarkiListesiSil.TabIndex = 13;
            this.btn_SarkiListesiSil.UseVisualStyleBackColor = true;
            this.btn_SarkiListesiSil.Click += new System.EventHandler(this.btn_SarkiListesiSil_Click);
            // 
            // btn_SarkiListesiEkle
            // 
            this.btn_SarkiListesiEkle.BackgroundImage = global::JJ.Properties.Resources.addButton;
            this.btn_SarkiListesiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SarkiListesiEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SarkiListesiEkle.FlatAppearance.BorderSize = 0;
            this.btn_SarkiListesiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SarkiListesiEkle.Location = new System.Drawing.Point(67, 201);
            this.btn_SarkiListesiEkle.Name = "btn_SarkiListesiEkle";
            this.btn_SarkiListesiEkle.Size = new System.Drawing.Size(33, 31);
            this.btn_SarkiListesiEkle.TabIndex = 12;
            this.btn_SarkiListesiEkle.UseVisualStyleBackColor = true;
            this.btn_SarkiListesiEkle.Click += new System.EventHandler(this.btn_SarkiListesiEkle_Click);
            // 
            // lb_SarkiListeleri
            // 
            this.lb_SarkiListeleri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SarkiListeleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lb_SarkiListeleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_SarkiListeleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_SarkiListeleri.ForeColor = System.Drawing.Color.White;
            this.lb_SarkiListeleri.FormattingEnabled = true;
            this.lb_SarkiListeleri.HorizontalScrollbar = true;
            this.lb_SarkiListeleri.ItemHeight = 25;
            this.lb_SarkiListeleri.Location = new System.Drawing.Point(3, 257);
            this.lb_SarkiListeleri.Name = "lb_SarkiListeleri";
            this.lb_SarkiListeleri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_SarkiListeleri.Size = new System.Drawing.Size(246, 125);
            this.lb_SarkiListeleri.TabIndex = 10;
            this.lb_SarkiListeleri.SelectedIndexChanged += new System.EventHandler(this.lb_SarkiListeleri_SelectedIndexChanged);
            // 
            // pb_CalanSarki
            // 
            this.pb_CalanSarki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_CalanSarki.Location = new System.Drawing.Point(0, 388);
            this.pb_CalanSarki.Name = "pb_CalanSarki";
            this.pb_CalanSarki.Size = new System.Drawing.Size(255, 207);
            this.pb_CalanSarki.TabIndex = 9;
            this.pb_CalanSarki.TabStop = false;
            // 
            // lbl_Kullanici
            // 
            this.lbl_Kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kullanici.ForeColor = System.Drawing.Color.White;
            this.lbl_Kullanici.Location = new System.Drawing.Point(12, 150);
            this.lbl_Kullanici.Name = "lbl_Kullanici";
            this.lbl_Kullanici.Size = new System.Drawing.Size(237, 28);
            this.lbl_Kullanici.TabIndex = 1;
            this.lbl_Kullanici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Kullanici.Click += new System.EventHandler(this.lbl_Kullanici_Click);
            // 
            // pnl_AnaSayfa_Orta
            // 
            this.pnl_AnaSayfa_Orta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_AnaSayfa_Orta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnl_AnaSayfa_Orta.Location = new System.Drawing.Point(255, 4);
            this.pnl_AnaSayfa_Orta.Name = "pnl_AnaSayfa_Orta";
            this.pnl_AnaSayfa_Orta.Size = new System.Drawing.Size(927, 595);
            this.pnl_AnaSayfa_Orta.TabIndex = 2;
            // 
            // pnl_AnaSayfa_Alt
            // 
            this.pnl_AnaSayfa_Alt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_AnaSayfa_Alt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pnl_AnaSayfa_Alt.Controls.Add(this.lbl_CalanSarkici);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.lbl_CalanSarki);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.lbl_Ses);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.tb_Ses);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.lbl_ToplamSure);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.lbl_GecenSure);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.tb_Sure);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.WMediaPlayer);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.btn_Onceki);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.btn_Sonraki);
            this.pnl_AnaSayfa_Alt.Controls.Add(this.btn_Baslat);
            this.pnl_AnaSayfa_Alt.Location = new System.Drawing.Point(0, 596);
            this.pnl_AnaSayfa_Alt.Name = "pnl_AnaSayfa_Alt";
            this.pnl_AnaSayfa_Alt.Size = new System.Drawing.Size(1182, 160);
            this.pnl_AnaSayfa_Alt.TabIndex = 0;
            // 
            // lbl_CalanSarkici
            // 
            this.lbl_CalanSarkici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_CalanSarkici.AutoSize = true;
            this.lbl_CalanSarkici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CalanSarkici.ForeColor = System.Drawing.Color.White;
            this.lbl_CalanSarkici.Location = new System.Drawing.Point(21, 76);
            this.lbl_CalanSarkici.Name = "lbl_CalanSarkici";
            this.lbl_CalanSarkici.Size = new System.Drawing.Size(0, 20);
            this.lbl_CalanSarkici.TabIndex = 11;
            // 
            // lbl_CalanSarki
            // 
            this.lbl_CalanSarki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_CalanSarki.AutoSize = true;
            this.lbl_CalanSarki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CalanSarki.ForeColor = System.Drawing.Color.White;
            this.lbl_CalanSarki.Location = new System.Drawing.Point(21, 44);
            this.lbl_CalanSarki.Name = "lbl_CalanSarki";
            this.lbl_CalanSarki.Size = new System.Drawing.Size(0, 25);
            this.lbl_CalanSarki.TabIndex = 10;
            // 
            // lbl_Ses
            // 
            this.lbl_Ses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Ses.AutoSize = true;
            this.lbl_Ses.ForeColor = System.Drawing.Color.White;
            this.lbl_Ses.Location = new System.Drawing.Point(973, 81);
            this.lbl_Ses.Name = "lbl_Ses";
            this.lbl_Ses.Size = new System.Drawing.Size(0, 17);
            this.lbl_Ses.TabIndex = 8;
            this.lbl_Ses.Click += new System.EventHandler(this.lbl_Ses_Click);
            // 
            // tb_Ses
            // 
            this.tb_Ses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Ses.Location = new System.Drawing.Point(850, 78);
            this.tb_Ses.Maximum = 100;
            this.tb_Ses.Name = "tb_Ses";
            this.tb_Ses.Size = new System.Drawing.Size(117, 56);
            this.tb_Ses.TabIndex = 7;
            this.tb_Ses.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_Ses.Value = 100;
            this.tb_Ses.Scroll += new System.EventHandler(this.tb_Ses_Scroll);
            this.tb_Ses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_Ses_MouseDown);
            // 
            // lbl_ToplamSure
            // 
            this.lbl_ToplamSure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ToplamSure.AutoSize = true;
            this.lbl_ToplamSure.ForeColor = System.Drawing.Color.White;
            this.lbl_ToplamSure.Location = new System.Drawing.Point(800, 81);
            this.lbl_ToplamSure.Name = "lbl_ToplamSure";
            this.lbl_ToplamSure.Size = new System.Drawing.Size(44, 17);
            this.lbl_ToplamSure.TabIndex = 6;
            this.lbl_ToplamSure.Text = "00:00";
            // 
            // lbl_GecenSure
            // 
            this.lbl_GecenSure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_GecenSure.AutoSize = true;
            this.lbl_GecenSure.ForeColor = System.Drawing.Color.White;
            this.lbl_GecenSure.Location = new System.Drawing.Point(339, 81);
            this.lbl_GecenSure.Name = "lbl_GecenSure";
            this.lbl_GecenSure.Size = new System.Drawing.Size(44, 17);
            this.lbl_GecenSure.TabIndex = 5;
            this.lbl_GecenSure.Text = "00:00";
            // 
            // tb_Sure
            // 
            this.tb_Sure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Sure.LargeChange = 1;
            this.tb_Sure.Location = new System.Drawing.Point(389, 78);
            this.tb_Sure.Name = "tb_Sure";
            this.tb_Sure.Size = new System.Drawing.Size(405, 56);
            this.tb_Sure.TabIndex = 4;
            this.tb_Sure.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_Sure.Scroll += new System.EventHandler(this.tb_Sure_Scroll);
            this.tb_Sure.ValueChanged += new System.EventHandler(this.tb_Sure_ValueChanged);
            this.tb_Sure.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_Sure_MouseDown);
            // 
            // WMediaPlayer
            // 
            this.WMediaPlayer.Enabled = true;
            this.WMediaPlayer.Location = new System.Drawing.Point(0, 107);
            this.WMediaPlayer.Name = "WMediaPlayer";
            this.WMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMediaPlayer.OcxState")));
            this.WMediaPlayer.Size = new System.Drawing.Size(10, 50);
            this.WMediaPlayer.TabIndex = 3;
            this.WMediaPlayer.Visible = false;
            // 
            // btn_Onceki
            // 
            this.btn_Onceki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Onceki.BackgroundImage = global::JJ.Properties.Resources.previousButton;
            this.btn_Onceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Onceki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Onceki.FlatAppearance.BorderSize = 0;
            this.btn_Onceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Onceki.Location = new System.Drawing.Point(516, 32);
            this.btn_Onceki.Name = "btn_Onceki";
            this.btn_Onceki.Size = new System.Drawing.Size(40, 40);
            this.btn_Onceki.TabIndex = 2;
            this.btn_Onceki.UseVisualStyleBackColor = true;
            this.btn_Onceki.Click += new System.EventHandler(this.btn_Onceki_Click);
            // 
            // btn_Sonraki
            // 
            this.btn_Sonraki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sonraki.BackgroundImage = global::JJ.Properties.Resources.nextButton;
            this.btn_Sonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sonraki.FlatAppearance.BorderSize = 0;
            this.btn_Sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sonraki.Location = new System.Drawing.Point(641, 32);
            this.btn_Sonraki.Name = "btn_Sonraki";
            this.btn_Sonraki.Size = new System.Drawing.Size(40, 40);
            this.btn_Sonraki.TabIndex = 1;
            this.btn_Sonraki.UseVisualStyleBackColor = true;
            this.btn_Sonraki.Click += new System.EventHandler(this.btn_Sonraki_Click);
            // 
            // btn_Baslat
            // 
            this.btn_Baslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Baslat.BackgroundImage = global::JJ.Properties.Resources.playButton;
            this.btn_Baslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Baslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Baslat.FlatAppearance.BorderSize = 0;
            this.btn_Baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Baslat.Location = new System.Drawing.Point(571, 27);
            this.btn_Baslat.Name = "btn_Baslat";
            this.btn_Baslat.Size = new System.Drawing.Size(55, 50);
            this.btn_Baslat.TabIndex = 0;
            this.btn_Baslat.UseVisualStyleBackColor = true;
            this.btn_Baslat.Click += new System.EventHandler(this.btn_Baslat_Click);
            // 
            // timer_GecenSure
            // 
            this.timer_GecenSure.Tick += new System.EventHandler(this.timer_GecenSure_Tick);
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = global::JJ.Properties.Resources.JJ_Logo_b;
            this.pb_Logo.Location = new System.Drawing.Point(58, 11);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(139, 136);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 14;
            this.pb_Logo.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.pnl_AnaSayfa_Alt);
            this.Controls.Add(this.pnl_AnaSayfa_Orta);
            this.Controls.Add(this.pnl_AnaSayfa_Sol);
            this.Name = "AnaSayfa";
            this.Text = "JJ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.pnl_AnaSayfa_Sol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CalanSarki)).EndInit();
            this.pnl_AnaSayfa_Alt.ResumeLayout(false);
            this.pnl_AnaSayfa_Alt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Sure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_AnaSayfa_Sol;
        private System.Windows.Forms.Label lbl_Kullanici;
        private System.Windows.Forms.Panel pnl_AnaSayfa_Alt;
        private System.Windows.Forms.Button btn_Baslat;
        private System.Windows.Forms.Button btn_Onceki;
        private System.Windows.Forms.Button btn_Sonraki;
        private AxWMPLib.AxWindowsMediaPlayer WMediaPlayer;
        private System.Windows.Forms.Panel pnl_AnaSayfa_Orta;
        private System.Windows.Forms.TrackBar tb_Sure;
        private System.Windows.Forms.Timer timer_GecenSure;
        private System.Windows.Forms.Label lbl_ToplamSure;
        private System.Windows.Forms.Label lbl_GecenSure;
        private System.Windows.Forms.TrackBar tb_Ses;
        private System.Windows.Forms.Label lbl_Ses;
        private System.Windows.Forms.PictureBox pb_CalanSarki;
        private System.Windows.Forms.Label lbl_CalanSarki;
        private System.Windows.Forms.Label lbl_CalanSarkici;
        private System.Windows.Forms.ListBox lb_SarkiListeleri;
        private System.Windows.Forms.Button btn_SarkiListesiEkle;
        private System.Windows.Forms.Button btn_SarkiListesiSil;
        private System.Windows.Forms.PictureBox pb_Logo;
    }
}