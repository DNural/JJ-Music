namespace JJ
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SifreTekrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_Erkek = new System.Windows.Forms.RadioButton();
            this.rb_Kadin = new System.Windows.Forms.RadioButton();
            this.dtp_DogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.errorP_Kayit = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_Kayit = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Kayit)).BeginInit();
            this.pnl_Kayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(202, 24);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(194, 183);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(203, 277);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(195, 22);
            this.txt_Ad.TabIndex = 5;
            this.txt_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adınız :";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(203, 305);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(195, 22);
            this.txt_Soyad.TabIndex = 7;
            this.txt_Soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Soyad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyadınız :";
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(203, 333);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(195, 22);
            this.txt_Eposta.TabIndex = 9;
            this.txt_Eposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Eposta_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "e-Postanız :";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(203, 361);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(195, 22);
            this.txt_Sifre.TabIndex = 11;
            this.txt_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sifre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(121, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifreniz :";
            // 
            // txt_SifreTekrar
            // 
            this.txt_SifreTekrar.Location = new System.Drawing.Point(203, 389);
            this.txt_SifreTekrar.Name = "txt_SifreTekrar";
            this.txt_SifreTekrar.Size = new System.Drawing.Size(195, 22);
            this.txt_SifreTekrar.TabIndex = 13;
            this.txt_SifreTekrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SifreTekrar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(93, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şifre Tekrar :";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(203, 473);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(195, 22);
            this.txt_Telefon.TabIndex = 21;
            this.txt_Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefon_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doğum Tarihiniz :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(98, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cinsiyetiniz :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Telefon Numaranız :";
            // 
            // rb_Erkek
            // 
            this.rb_Erkek.AutoSize = true;
            this.rb_Erkek.ForeColor = System.Drawing.Color.White;
            this.rb_Erkek.Location = new System.Drawing.Point(237, 449);
            this.rb_Erkek.Name = "rb_Erkek";
            this.rb_Erkek.Size = new System.Drawing.Size(65, 21);
            this.rb_Erkek.TabIndex = 19;
            this.rb_Erkek.TabStop = true;
            this.rb_Erkek.Text = "Erkek";
            this.rb_Erkek.UseVisualStyleBackColor = true;
            this.rb_Erkek.CheckedChanged += new System.EventHandler(this.rb_Erkek_CheckedChanged);
            // 
            // rb_Kadin
            // 
            this.rb_Kadin.AutoSize = true;
            this.rb_Kadin.ForeColor = System.Drawing.Color.White;
            this.rb_Kadin.Location = new System.Drawing.Point(302, 449);
            this.rb_Kadin.Name = "rb_Kadin";
            this.rb_Kadin.Size = new System.Drawing.Size(65, 21);
            this.rb_Kadin.TabIndex = 20;
            this.rb_Kadin.TabStop = true;
            this.rb_Kadin.Text = "Kadın";
            this.rb_Kadin.UseVisualStyleBackColor = true;
            this.rb_Kadin.CheckedChanged += new System.EventHandler(this.rb_Kadin_CheckedChanged);
            // 
            // dtp_DogumTarihi
            // 
            this.dtp_DogumTarihi.Location = new System.Drawing.Point(203, 420);
            this.dtp_DogumTarihi.Name = "dtp_DogumTarihi";
            this.dtp_DogumTarihi.Size = new System.Drawing.Size(195, 22);
            this.dtp_DogumTarihi.TabIndex = 15;
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kayit.ForeColor = System.Drawing.Color.White;
            this.btn_Kayit.Location = new System.Drawing.Point(244, 513);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(112, 28);
            this.btn_Kayit.TabIndex = 22;
            this.btn_Kayit.Text = "Hesap Oluştur";
            this.btn_Kayit.UseVisualStyleBackColor = true;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            this.btn_Kayit.MouseEnter += new System.EventHandler(this.btn_Kayit_MouseEnter);
            this.btn_Kayit.MouseLeave += new System.EventHandler(this.btn_Kayit_MouseLeave);
            // 
            // errorP_Kayit
            // 
            this.errorP_Kayit.ContainerControl = this;
            // 
            // pnl_Kayit
            // 
            this.pnl_Kayit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Kayit.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Kayit.Controls.Add(this.pb_Logo);
            this.pnl_Kayit.Controls.Add(this.btn_Kayit);
            this.pnl_Kayit.Controls.Add(this.label1);
            this.pnl_Kayit.Controls.Add(this.dtp_DogumTarihi);
            this.pnl_Kayit.Controls.Add(this.txt_Ad);
            this.pnl_Kayit.Controls.Add(this.rb_Kadin);
            this.pnl_Kayit.Controls.Add(this.label2);
            this.pnl_Kayit.Controls.Add(this.rb_Erkek);
            this.pnl_Kayit.Controls.Add(this.txt_Soyad);
            this.pnl_Kayit.Controls.Add(this.label8);
            this.pnl_Kayit.Controls.Add(this.label3);
            this.pnl_Kayit.Controls.Add(this.label7);
            this.pnl_Kayit.Controls.Add(this.txt_Eposta);
            this.pnl_Kayit.Controls.Add(this.txt_Telefon);
            this.pnl_Kayit.Controls.Add(this.label4);
            this.pnl_Kayit.Controls.Add(this.label6);
            this.pnl_Kayit.Controls.Add(this.txt_Sifre);
            this.pnl_Kayit.Controls.Add(this.txt_SifreTekrar);
            this.pnl_Kayit.Controls.Add(this.label5);
            this.pnl_Kayit.Location = new System.Drawing.Point(10, 6);
            this.pnl_Kayit.Name = "pnl_Kayit";
            this.pnl_Kayit.Size = new System.Drawing.Size(600, 565);
            this.pnl_Kayit.TabIndex = 23;
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(620, 577);
            this.Controls.Add(this.pnl_Kayit);
            this.Name = "Kayit";
            this.Text = "Hesap Oluştur";
            this.Activated += new System.EventHandler(this.Kayit_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kayit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Kayit)).EndInit();
            this.pnl_Kayit.ResumeLayout(false);
            this.pnl_Kayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SifreTekrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_Erkek;
        private System.Windows.Forms.RadioButton rb_Kadin;
        private System.Windows.Forms.DateTimePicker dtp_DogumTarihi;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.ErrorProvider errorP_Kayit;
        private System.Windows.Forms.Panel pnl_Kayit;
    }
}