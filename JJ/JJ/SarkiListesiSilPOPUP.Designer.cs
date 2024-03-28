namespace JJ
{
    partial class SarkiListesiSilPOPUP
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
            this.cb_SarkiListeleri = new System.Windows.Forms.ComboBox();
            this.btn_SarkiListesiSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şarkı Listesi:";
            // 
            // cb_SarkiListeleri
            // 
            this.cb_SarkiListeleri.FormattingEnabled = true;
            this.cb_SarkiListeleri.Location = new System.Drawing.Point(201, 75);
            this.cb_SarkiListeleri.Name = "cb_SarkiListeleri";
            this.cb_SarkiListeleri.Size = new System.Drawing.Size(160, 24);
            this.cb_SarkiListeleri.TabIndex = 2;
            this.cb_SarkiListeleri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_SarkiListeleri_KeyDown);
            // 
            // btn_SarkiListesiSil
            // 
            this.btn_SarkiListesiSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SarkiListesiSil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SarkiListesiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SarkiListesiSil.ForeColor = System.Drawing.Color.White;
            this.btn_SarkiListesiSil.Location = new System.Drawing.Point(134, 122);
            this.btn_SarkiListesiSil.Name = "btn_SarkiListesiSil";
            this.btn_SarkiListesiSil.Size = new System.Drawing.Size(153, 28);
            this.btn_SarkiListesiSil.TabIndex = 4;
            this.btn_SarkiListesiSil.Text = "Şarkı Listesini Sil";
            this.btn_SarkiListesiSil.UseVisualStyleBackColor = true;
            this.btn_SarkiListesiSil.Click += new System.EventHandler(this.btn_SarkiListesiSil_Click);
            this.btn_SarkiListesiSil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SarkiListesiSil_KeyDown);
            // 
            // SarkiListesiSilPOPUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(420, 175);
            this.Controls.Add(this.btn_SarkiListesiSil);
            this.Controls.Add(this.cb_SarkiListeleri);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SarkiListesiSilPOPUP";
            this.Text = "SarkiListesiSilPOPUP";
            this.Load += new System.EventHandler(this.SarkiListesiSilPOPUP_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SarkiListesiSilPOPUP_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_SarkiListeleri;
        private System.Windows.Forms.Button btn_SarkiListesiSil;
    }
}