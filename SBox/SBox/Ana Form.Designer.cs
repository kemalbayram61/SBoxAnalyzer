namespace SBox
{
    partial class anaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSbox = new System.Windows.Forms.TextBox();
            this.lblSbox = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnYorumla = new System.Windows.Forms.Button();
            this.btnSonuclar = new System.Windows.Forms.Button();
            this.bul = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtSbox
            // 
            this.txtSbox.Location = new System.Drawing.Point(12, 99);
            this.txtSbox.Multiline = true;
            this.txtSbox.Name = "txtSbox";
            this.txtSbox.Size = new System.Drawing.Size(510, 348);
            this.txtSbox.TabIndex = 0;
            // 
            // lblSbox
            // 
            this.lblSbox.AutoSize = true;
            this.lblSbox.Location = new System.Drawing.Point(9, 74);
            this.lblSbox.Name = "lblSbox";
            this.lblSbox.Size = new System.Drawing.Size(35, 13);
            this.lblSbox.TabIndex = 1;
            this.lblSbox.Text = "S Box";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(421, 41);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(101, 46);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnYorumla
            // 
            this.btnYorumla.Location = new System.Drawing.Point(314, 453);
            this.btnYorumla.Name = "btnYorumla";
            this.btnYorumla.Size = new System.Drawing.Size(101, 46);
            this.btnYorumla.TabIndex = 2;
            this.btnYorumla.Text = "Yorumla";
            this.btnYorumla.UseVisualStyleBackColor = true;
            this.btnYorumla.Click += new System.EventHandler(this.btnYorumla_Click);
            // 
            // btnSonuclar
            // 
            this.btnSonuclar.Enabled = false;
            this.btnSonuclar.Location = new System.Drawing.Point(421, 453);
            this.btnSonuclar.Name = "btnSonuclar";
            this.btnSonuclar.Size = new System.Drawing.Size(101, 46);
            this.btnSonuclar.TabIndex = 3;
            this.btnSonuclar.Text = "Sonuçlar";
            this.btnSonuclar.UseVisualStyleBackColor = true;
            this.btnSonuclar.Click += new System.EventHandler(this.btnSonuclar_Click);
            // 
            // bul
            // 
            this.bul.Filter = "Txt Dosyaları(*.txt)|*.txt";
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 511);
            this.Controls.Add(this.btnSonuclar);
            this.Controls.Add(this.btnYorumla);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.lblSbox);
            this.Controls.Add(this.txtSbox);
            this.MaximizeBox = false;
            this.Name = "anaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.anaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSbox;
        private System.Windows.Forms.Label lblSbox;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnYorumla;
        private System.Windows.Forms.Button btnSonuclar;
        private System.Windows.Forms.OpenFileDialog bul;
    }
}

