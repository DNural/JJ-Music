namespace JJ
{
    partial class SarkiListesiUC
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
            this.pnl_Sarkilar = new System.Windows.Forms.Panel();
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
            this.btn_Geri.TabIndex = 1;
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
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
            this.pnl_Sarkilar.TabIndex = 3;
            // 
            // SarkiListesiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Sarkilar);
            this.Controls.Add(this.btn_Geri);
            this.Name = "SarkiListesiUC";
            this.Size = new System.Drawing.Size(658, 487);
            this.Load += new System.EventHandler(this.SarkiListesiUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Panel pnl_Sarkilar;
    }
}
