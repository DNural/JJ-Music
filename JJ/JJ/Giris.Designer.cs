namespace JJ
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.lbl_HesapOlustur = new System.Windows.Forms.Label();
            this.lbl_SifremiUnuttum = new System.Windows.Forms.Label();
            this.errorP_Giris = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_Giris = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Giris)).BeginInit();
            this.pnl_Giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(153, 26);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(194, 183);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // btn_Giris
            // 
            this.btn_Giris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.ForeColor = System.Drawing.Color.White;
            this.btn_Giris.Location = new System.Drawing.Point(209, 366);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(80, 28);
            this.btn_Giris.TabIndex = 1;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            this.btn_Giris.MouseEnter += new System.EventHandler(this.btn_Giris_MouseEnter);
            this.btn_Giris.MouseLeave += new System.EventHandler(this.btn_Giris_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "e-Posta :";
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(153, 262);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(195, 22);
            this.txt_Eposta.TabIndex = 3;
            this.txt_Eposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Eposta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(152, 301);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(195, 22);
            this.txt_Sifre.TabIndex = 5;
            this.txt_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sifre_KeyPress);
            // 
            // lbl_HesapOlustur
            // 
            this.lbl_HesapOlustur.AutoSize = true;
            this.lbl_HesapOlustur.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_HesapOlustur.Location = new System.Drawing.Point(146, 336);
            this.lbl_HesapOlustur.Name = "lbl_HesapOlustur";
            this.lbl_HesapOlustur.Size = new System.Drawing.Size(99, 17);
            this.lbl_HesapOlustur.TabIndex = 6;
            this.lbl_HesapOlustur.Text = "Hesap Oluştur";
            this.lbl_HesapOlustur.Click += new System.EventHandler(this.lbl_HesapOlustur_Click);
            this.lbl_HesapOlustur.MouseEnter += new System.EventHandler(this.lbl_HesapOlustur_MouseEnter);
            this.lbl_HesapOlustur.MouseLeave += new System.EventHandler(this.lbl_HesapOlustur_MouseLeave);
            // 
            // lbl_SifremiUnuttum
            // 
            this.lbl_SifremiUnuttum.AutoSize = true;
            this.lbl_SifremiUnuttum.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_SifremiUnuttum.Location = new System.Drawing.Point(247, 336);
            this.lbl_SifremiUnuttum.Name = "lbl_SifremiUnuttum";
            this.lbl_SifremiUnuttum.Size = new System.Drawing.Size(108, 17);
            this.lbl_SifremiUnuttum.TabIndex = 7;
            this.lbl_SifremiUnuttum.Text = "Şifremi Unuttum";
            this.lbl_SifremiUnuttum.Click += new System.EventHandler(this.lbl_SifremiUnuttum_Click);
            this.lbl_SifremiUnuttum.MouseEnter += new System.EventHandler(this.lbl_SifremiUnuttum_MouseEnter);
            this.lbl_SifremiUnuttum.MouseLeave += new System.EventHandler(this.lbl_SifremiUnuttum_MouseLeave);
            // 
            // errorP_Giris
            // 
            this.errorP_Giris.ContainerControl = this;
            // 
            // pnl_Giris
            // 
            this.pnl_Giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Giris.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Giris.Controls.Add(this.pb_Logo);
            this.pnl_Giris.Controls.Add(this.lbl_SifremiUnuttum);
            this.pnl_Giris.Controls.Add(this.btn_Giris);
            this.pnl_Giris.Controls.Add(this.lbl_HesapOlustur);
            this.pnl_Giris.Controls.Add(this.label1);
            this.pnl_Giris.Controls.Add(this.txt_Sifre);
            this.pnl_Giris.Controls.Add(this.txt_Eposta);
            this.pnl_Giris.Controls.Add(this.label2);
            this.pnl_Giris.Location = new System.Drawing.Point(6, 11);
            this.pnl_Giris.Name = "pnl_Giris";
            this.pnl_Giris.Size = new System.Drawing.Size(500, 420);
            this.pnl_Giris.TabIndex = 8;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(512, 443);
            this.Controls.Add(this.pnl_Giris);
            this.Name = "Giris";
            this.Text = "JJ";
            this.Activated += new System.EventHandler(this.Giris_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Giris_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Giris)).EndInit();
            this.pnl_Giris.ResumeLayout(false);
            this.pnl_Giris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label lbl_HesapOlustur;
        private System.Windows.Forms.Label lbl_SifremiUnuttum;
        private System.Windows.Forms.ErrorProvider errorP_Giris;
        private System.Windows.Forms.Panel pnl_Giris;
    }
}

