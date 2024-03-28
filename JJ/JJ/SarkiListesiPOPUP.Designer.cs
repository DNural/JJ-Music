namespace JJ
{
    partial class SarkiListesiPOPUP
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
            this.tb_SarkiListesiAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şarkı Listesi:";
            // 
            // tb_SarkiListesiAdi
            // 
            this.tb_SarkiListesiAdi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_SarkiListesiAdi.Location = new System.Drawing.Point(194, 76);
            this.tb_SarkiListesiAdi.Name = "tb_SarkiListesiAdi";
            this.tb_SarkiListesiAdi.Size = new System.Drawing.Size(173, 22);
            this.tb_SarkiListesiAdi.TabIndex = 1;
            this.tb_SarkiListesiAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SarkiListesiAdi_KeyDown);
            // 
            // SarkiListesiPOPUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(420, 175);
            this.Controls.Add(this.tb_SarkiListesiAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SarkiListesiPOPUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SarkiListesiAdi;
    }
}