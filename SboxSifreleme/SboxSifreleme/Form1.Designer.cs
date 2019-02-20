namespace SboxSifreleme
{
    partial class Form1
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
            this.txtGirdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBic = new System.Windows.Forms.Button();
            this.btnBig = new System.Windows.Forms.Button();
            this.btnDpf = new System.Windows.Forms.Button();
            this.btnNonlin = new System.Windows.Forms.Button();
            this.btnSac = new System.Windows.Forms.Button();
            this.btnDizial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirdi
            // 
            this.txtGirdi.Location = new System.Drawing.Point(12, 28);
            this.txtGirdi.Multiline = true;
            this.txtGirdi.Name = "txtGirdi";
            this.txtGirdi.Size = new System.Drawing.Size(378, 198);
            this.txtGirdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matris";
            // 
            // btnBic
            // 
            this.btnBic.Enabled = false;
            this.btnBic.Location = new System.Drawing.Point(396, 28);
            this.btnBic.Name = "btnBic";
            this.btnBic.Size = new System.Drawing.Size(108, 35);
            this.btnBic.TabIndex = 2;
            this.btnBic.Text = "Bıc Nonlinearty";
            this.btnBic.UseVisualStyleBackColor = true;
            this.btnBic.Click += new System.EventHandler(this.btnBic_Click);
            // 
            // btnBig
            // 
            this.btnBig.Enabled = false;
            this.btnBig.Location = new System.Drawing.Point(396, 69);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(108, 35);
            this.btnBig.TabIndex = 3;
            this.btnBig.Text = "Big Sac";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // btnDpf
            // 
            this.btnDpf.Enabled = false;
            this.btnDpf.Location = new System.Drawing.Point(396, 110);
            this.btnDpf.Name = "btnDpf";
            this.btnDpf.Size = new System.Drawing.Size(108, 35);
            this.btnDpf.TabIndex = 3;
            this.btnDpf.Text = "Dpf";
            this.btnDpf.UseVisualStyleBackColor = true;
            this.btnDpf.Click += new System.EventHandler(this.btnDpf_Click);
            // 
            // btnNonlin
            // 
            this.btnNonlin.Enabled = false;
            this.btnNonlin.Location = new System.Drawing.Point(396, 151);
            this.btnNonlin.Name = "btnNonlin";
            this.btnNonlin.Size = new System.Drawing.Size(108, 35);
            this.btnNonlin.TabIndex = 3;
            this.btnNonlin.Text = "Nonlinearty";
            this.btnNonlin.UseVisualStyleBackColor = true;
            this.btnNonlin.Click += new System.EventHandler(this.btnNonlin_Click);
            // 
            // btnSac
            // 
            this.btnSac.Enabled = false;
            this.btnSac.Location = new System.Drawing.Point(396, 191);
            this.btnSac.Name = "btnSac";
            this.btnSac.Size = new System.Drawing.Size(108, 35);
            this.btnSac.TabIndex = 3;
            this.btnSac.Text = "Sac";
            this.btnSac.UseVisualStyleBackColor = true;
            // 
            // btnDizial
            // 
            this.btnDizial.Location = new System.Drawing.Point(12, 232);
            this.btnDizial.Name = "btnDizial";
            this.btnDizial.Size = new System.Drawing.Size(492, 35);
            this.btnDizial.TabIndex = 4;
            this.btnDizial.Text = "Dizi Al";
            this.btnDizial.UseVisualStyleBackColor = true;
            this.btnDizial.Click += new System.EventHandler(this.btnDizial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 273);
            this.Controls.Add(this.btnDizial);
            this.Controls.Add(this.btnSac);
            this.Controls.Add(this.btnNonlin);
            this.Controls.Add(this.btnDpf);
            this.Controls.Add(this.btnBig);
            this.Controls.Add(this.btnBic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGirdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBic;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnDpf;
        private System.Windows.Forms.Button btnNonlin;
        private System.Windows.Forms.Button btnSac;
        private System.Windows.Forms.Button btnDizial;
    }
}

