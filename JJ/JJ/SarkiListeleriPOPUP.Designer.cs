﻿namespace JJ
{
    partial class SarkiListeleriPOPUP
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
            this.btn_SarkiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şarkı Listesi:";
            // 
            // cb_SarkiListeleri
            // 
            this.cb_SarkiListeleri.FormattingEnabled = true;
            this.cb_SarkiListeleri.Location = new System.Drawing.Point(194, 75);
            this.cb_SarkiListeleri.Name = "cb_SarkiListeleri";
            this.cb_SarkiListeleri.Size = new System.Drawing.Size(174, 24);
            this.cb_SarkiListeleri.TabIndex = 2;
            this.cb_SarkiListeleri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_SarkiListeleri_KeyDown);
            // 
            // btn_SarkiEkle
            // 
            this.btn_SarkiEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SarkiEkle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SarkiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SarkiEkle.ForeColor = System.Drawing.Color.White;
            this.btn_SarkiEkle.Location = new System.Drawing.Point(157, 122);
            this.btn_SarkiEkle.Name = "btn_SarkiEkle";
            this.btn_SarkiEkle.Size = new System.Drawing.Size(106, 28);
            this.btn_SarkiEkle.TabIndex = 3;
            this.btn_SarkiEkle.Text = "Şarkı Ekle";
            this.btn_SarkiEkle.UseVisualStyleBackColor = true;
            this.btn_SarkiEkle.Click += new System.EventHandler(this.btn_SarkiEkle_Click);
            this.btn_SarkiEkle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SarkiEkle_KeyDown);
            // 
            // SarkiListeleriPOPUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(420, 175);
            this.Controls.Add(this.btn_SarkiEkle);
            this.Controls.Add(this.cb_SarkiListeleri);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SarkiListeleriPOPUP";
            this.Load += new System.EventHandler(this.SarkiListeleriPOPUP_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SarkiListeleriPOPUP_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_SarkiListeleri;
        private System.Windows.Forms.Button btn_SarkiEkle;
    }
}