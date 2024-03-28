namespace JJ
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.pnl_SifremiUnuttum = new System.Windows.Forms.Panel();
            this.btn_SifremiUnuttum = new System.Windows.Forms.Button();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Eposta = new System.Windows.Forms.TextBox();
            this.errorP_SifremiUnuttum = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_SifremiUnuttum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_SifremiUnuttum)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_SifremiUnuttum
            // 
            this.pnl_SifremiUnuttum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_SifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.pnl_SifremiUnuttum.Controls.Add(this.btn_SifremiUnuttum);
            this.pnl_SifremiUnuttum.Controls.Add(this.pb_Logo);
            this.pnl_SifremiUnuttum.Controls.Add(this.label1);
            this.pnl_SifremiUnuttum.Controls.Add(this.txt_Eposta);
            this.pnl_SifremiUnuttum.Location = new System.Drawing.Point(6, 11);
            this.pnl_SifremiUnuttum.Name = "pnl_SifremiUnuttum";
            this.pnl_SifremiUnuttum.Size = new System.Drawing.Size(500, 420);
            this.pnl_SifremiUnuttum.TabIndex = 9;
            // 
            // btn_SifremiUnuttum
            // 
            this.btn_SifremiUnuttum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SifremiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SifremiUnuttum.ForeColor = System.Drawing.Color.White;
            this.btn_SifremiUnuttum.Location = new System.Drawing.Point(196, 344);
            this.btn_SifremiUnuttum.Name = "btn_SifremiUnuttum";
            this.btn_SifremiUnuttum.Size = new System.Drawing.Size(109, 49);
            this.btn_SifremiUnuttum.TabIndex = 4;
            this.btn_SifremiUnuttum.Text = "Şifremi Gönder";
            this.btn_SifremiUnuttum.UseVisualStyleBackColor = true;
            this.btn_SifremiUnuttum.Click += new System.EventHandler(this.btn_SifremiUnuttum_Click);
            this.btn_SifremiUnuttum.MouseEnter += new System.EventHandler(this.btn_SifremiUnuttum_MouseEnter);
            this.btn_SifremiUnuttum.MouseLeave += new System.EventHandler(this.btn_SifremiUnuttum_MouseLeave);
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(156, 55);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(194, 183);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifrenizin gönderileceği e-Posta hesabını giriniz;";
            // 
            // txt_Eposta
            // 
            this.txt_Eposta.Location = new System.Drawing.Point(153, 302);
            this.txt_Eposta.Name = "txt_Eposta";
            this.txt_Eposta.Size = new System.Drawing.Size(195, 22);
            this.txt_Eposta.TabIndex = 3;
            this.txt_Eposta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Eposta_KeyPress);
            // 
            // errorP_SifremiUnuttum
            // 
            this.errorP_SifremiUnuttum.ContainerControl = this;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(512, 443);
            this.Controls.Add(this.pnl_SifremiUnuttum);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.Activated += new System.EventHandler(this.SifremiUnuttum_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SifremiUnuttum_FormClosed);
            this.pnl_SifremiUnuttum.ResumeLayout(false);
            this.pnl_SifremiUnuttum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_SifremiUnuttum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SifremiUnuttum;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Eposta;
        private System.Windows.Forms.Button btn_SifremiUnuttum;
        private System.Windows.Forms.ErrorProvider errorP_SifremiUnuttum;
    }
}