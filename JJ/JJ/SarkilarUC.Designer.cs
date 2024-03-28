namespace JJ
{
    partial class SarkilarUC
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
            this.pb_Sarkici = new System.Windows.Forms.PictureBox();
            this.pnl_Sarkilar = new System.Windows.Forms.Panel();
            this.lbl_Sarkici = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sarkici)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackgroundImage = global::JJ.Properties.Resources.previousButton;
            this.btn_Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Geri.FlatAppearance.BorderSize = 0;
            this.btn_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Geri.Location = new System.Drawing.Point(0, 0);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(55, 55);
            this.btn_Geri.TabIndex = 0;
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // pb_Sarkici
            // 
            this.pb_Sarkici.Location = new System.Drawing.Point(118, 3);
            this.pb_Sarkici.Name = "pb_Sarkici";
            this.pb_Sarkici.Size = new System.Drawing.Size(107, 136);
            this.pb_Sarkici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Sarkici.TabIndex = 1;
            this.pb_Sarkici.TabStop = false;
            // 
            // pnl_Sarkilar
            // 
            this.pnl_Sarkilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Sarkilar.AutoScroll = true;
            this.pnl_Sarkilar.Location = new System.Drawing.Point(3, 175);
            this.pnl_Sarkilar.Name = "pnl_Sarkilar";
            this.pnl_Sarkilar.Size = new System.Drawing.Size(655, 309);
            this.pnl_Sarkilar.TabIndex = 2;
            // 
            // lbl_Sarkici
            // 
            this.lbl_Sarkici.AutoSize = true;
            this.lbl_Sarkici.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sarkici.ForeColor = System.Drawing.Color.White;
            this.lbl_Sarkici.Location = new System.Drawing.Point(309, 53);
            this.lbl_Sarkici.Name = "lbl_Sarkici";
            this.lbl_Sarkici.Size = new System.Drawing.Size(0, 32);
            this.lbl_Sarkici.TabIndex = 3;
            // 
            // SarkilarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.lbl_Sarkici);
            this.Controls.Add(this.pnl_Sarkilar);
            this.Controls.Add(this.pb_Sarkici);
            this.Controls.Add(this.btn_Geri);
            this.Name = "SarkilarUC";
            this.Size = new System.Drawing.Size(658, 487);
            this.Load += new System.EventHandler(this.SarkilarUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Sarkici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.PictureBox pb_Sarkici;
        private System.Windows.Forms.Panel pnl_Sarkilar;
        private System.Windows.Forms.Label lbl_Sarkici;
    }
}
