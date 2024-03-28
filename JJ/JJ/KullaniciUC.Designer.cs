namespace JJ
{
    partial class KullaniciUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Geri = new System.Windows.Forms.Button();
            this.pnl_Kullanici = new System.Windows.Forms.Panel();
            this.btn_SifreDegistir = new System.Windows.Forms.Button();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Eposta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Cinsiyet = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_DogumTarihi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Kullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackgroundImage = global::JJ.Properties.Resources.previousButton;
            this.btn_Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Geri.FlatAppearance.BorderSize = 0;
            this.btn_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Geri.Location = new System.Drawing.Point(-1, -1);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(55, 55);
            this.btn_Geri.TabIndex = 1;
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // pnl_Kullanici
            // 
            this.pnl_Kullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Kullanici.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Kullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Kullanici.Controls.Add(this.label5);
            this.pnl_Kullanici.Controls.Add(this.btn_Geri);
            this.pnl_Kullanici.Controls.Add(this.btn_SifreDegistir);
            this.pnl_Kullanici.Controls.Add(this.txt_Sifre);
            this.pnl_Kullanici.Controls.Add(this.label1);
            this.pnl_Kullanici.Controls.Add(this.label3);
            this.pnl_Kullanici.Controls.Add(this.label2);
            this.pnl_Kullanici.Controls.Add(this.lbl_Eposta);
            this.pnl_Kullanici.Controls.Add(this.label4);
            this.pnl_Kullanici.Controls.Add(this.lbl_Cinsiyet);
            this.pnl_Kullanici.Controls.Add(this.lbl_Telefon);
            this.pnl_Kullanici.Controls.Add(this.lbl_DogumTarihi);
            this.pnl_Kullanici.Location = new System.Drawing.Point(0, 73);
            this.pnl_Kullanici.Name = "pnl_Kullanici";
            this.pnl_Kullanici.Size = new System.Drawing.Size(765, 496);
            this.pnl_Kullanici.TabIndex = 18;
            // 
            // btn_SifreDegistir
            // 
            this.btn_SifreDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SifreDegistir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SifreDegistir.ForeColor = System.Drawing.Color.White;
            this.btn_SifreDegistir.Location = new System.Drawing.Point(325, 349);
            this.btn_SifreDegistir.Name = "btn_SifreDegistir";
            this.btn_SifreDegistir.Size = new System.Drawing.Size(111, 28);
            this.btn_SifreDegistir.TabIndex = 27;
            this.btn_SifreDegistir.Text = "Şifre Değiştir";
            this.btn_SifreDegistir.UseVisualStyleBackColor = true;
            this.btn_SifreDegistir.Click += new System.EventHandler(this.btn_SifreDegistir_Click);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(326, 291);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(298, 22);
            this.txt_Sifre.TabIndex = 26;
            this.txt_Sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sifre_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "e-Posta :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Doğum Tarihi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telefon :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Eposta
            // 
            this.lbl_Eposta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Eposta.ForeColor = System.Drawing.Color.White;
            this.lbl_Eposta.Location = new System.Drawing.Point(322, 117);
            this.lbl_Eposta.Name = "lbl_Eposta";
            this.lbl_Eposta.Size = new System.Drawing.Size(437, 20);
            this.lbl_Eposta.TabIndex = 18;
            this.lbl_Eposta.Text = "e-Posta";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cinsiyet :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cinsiyet.ForeColor = System.Drawing.Color.White;
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(322, 246);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(439, 20);
            this.lbl_Cinsiyet.TabIndex = 21;
            this.lbl_Cinsiyet.Text = "Cinsiyet";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Telefon.ForeColor = System.Drawing.Color.White;
            this.lbl_Telefon.Location = new System.Drawing.Point(322, 160);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(439, 20);
            this.lbl_Telefon.TabIndex = 19;
            this.lbl_Telefon.Text = "Telefon";
            // 
            // lbl_DogumTarihi
            // 
            this.lbl_DogumTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DogumTarihi.ForeColor = System.Drawing.Color.White;
            this.lbl_DogumTarihi.Location = new System.Drawing.Point(322, 203);
            this.lbl_DogumTarihi.Name = "lbl_DogumTarihi";
            this.lbl_DogumTarihi.Size = new System.Drawing.Size(439, 20);
            this.lbl_DogumTarihi.TabIndex = 20;
            this.lbl_DogumTarihi.Text = "Dogum Tarihi";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Şifreni Değiştir :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KullaniciUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JJ.Properties.Resources.JJ_Logo_b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.pnl_Kullanici);
            this.DoubleBuffered = true;
            this.Name = "KullaniciUC";
            this.Size = new System.Drawing.Size(765, 569);
            this.Load += new System.EventHandler(this.KullaniciUC_Load);
            this.pnl_Kullanici.ResumeLayout(false);
            this.pnl_Kullanici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Panel pnl_Kullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Eposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_DogumTarihi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_SifreDegistir;
        private System.Windows.Forms.Label label5;
    }
}
