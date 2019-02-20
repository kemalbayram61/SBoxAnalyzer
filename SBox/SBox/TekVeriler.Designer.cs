namespace SBox
{
    partial class TekVeriler
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
            this.lblMaximumio = new System.Windows.Forms.Label();
            this.grpNonlinearity = new System.Windows.Forms.GroupBox();
            this.txtNMax = new System.Windows.Forms.TextBox();
            this.txtNMin = new System.Windows.Forms.TextBox();
            this.txtNAvg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBicsac = new System.Windows.Forms.Label();
            this.lblBicNonlinearity = new System.Windows.Forms.Label();
            this.grpSac = new System.Windows.Forms.GroupBox();
            this.txtSMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSMin = new System.Windows.Forms.TextBox();
            this.txtSAvg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaximumio = new System.Windows.Forms.TextBox();
            this.txtBicsac = new System.Windows.Forms.TextBox();
            this.txtBicnon = new System.Windows.Forms.TextBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.grpNonlinearity.SuspendLayout();
            this.grpSac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaximumio
            // 
            this.lblMaximumio.AutoSize = true;
            this.lblMaximumio.Location = new System.Drawing.Point(103, 51);
            this.lblMaximumio.Name = "lblMaximumio";
            this.lblMaximumio.Size = new System.Drawing.Size(96, 13);
            this.lblMaximumio.TabIndex = 0;
            this.lblMaximumio.Text = "Maximum I/O XOR";
            // 
            // grpNonlinearity
            // 
            this.grpNonlinearity.Controls.Add(this.txtNMax);
            this.grpNonlinearity.Controls.Add(this.txtNMin);
            this.grpNonlinearity.Controls.Add(this.txtNAvg);
            this.grpNonlinearity.Controls.Add(this.label4);
            this.grpNonlinearity.Controls.Add(this.label3);
            this.grpNonlinearity.Controls.Add(this.label2);
            this.grpNonlinearity.Location = new System.Drawing.Point(37, 104);
            this.grpNonlinearity.Name = "grpNonlinearity";
            this.grpNonlinearity.Size = new System.Drawing.Size(200, 200);
            this.grpNonlinearity.TabIndex = 1;
            this.grpNonlinearity.TabStop = false;
            this.grpNonlinearity.Text = "Nonlinearity";
            // 
            // txtNMax
            // 
            this.txtNMax.Enabled = false;
            this.txtNMax.Location = new System.Drawing.Point(44, 144);
            this.txtNMax.Name = "txtNMax";
            this.txtNMax.Size = new System.Drawing.Size(150, 20);
            this.txtNMax.TabIndex = 8;
            // 
            // txtNMin
            // 
            this.txtNMin.Enabled = false;
            this.txtNMin.Location = new System.Drawing.Point(44, 91);
            this.txtNMin.Name = "txtNMin";
            this.txtNMin.Size = new System.Drawing.Size(150, 20);
            this.txtNMin.TabIndex = 7;
            // 
            // txtNAvg
            // 
            this.txtNAvg.Enabled = false;
            this.txtNAvg.Location = new System.Drawing.Point(44, 41);
            this.txtNAvg.Name = "txtNAvg";
            this.txtNAvg.Size = new System.Drawing.Size(150, 20);
            this.txtNAvg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AVG";
            // 
            // lblBicsac
            // 
            this.lblBicsac.AutoSize = true;
            this.lblBicsac.Location = new System.Drawing.Point(78, 353);
            this.lblBicsac.Name = "lblBicsac";
            this.lblBicsac.Size = new System.Drawing.Size(48, 13);
            this.lblBicsac.TabIndex = 2;
            this.lblBicsac.Text = "BIC-SAC";
            // 
            // lblBicNonlinearity
            // 
            this.lblBicNonlinearity.AutoSize = true;
            this.lblBicNonlinearity.Location = new System.Drawing.Point(78, 417);
            this.lblBicNonlinearity.Name = "lblBicNonlinearity";
            this.lblBicNonlinearity.Size = new System.Drawing.Size(80, 13);
            this.lblBicNonlinearity.TabIndex = 3;
            this.lblBicNonlinearity.Text = "BIC-nonlinearity";
            // 
            // grpSac
            // 
            this.grpSac.Controls.Add(this.txtSMax);
            this.grpSac.Controls.Add(this.label7);
            this.grpSac.Controls.Add(this.txtSMin);
            this.grpSac.Controls.Add(this.txtSAvg);
            this.grpSac.Controls.Add(this.label8);
            this.grpSac.Controls.Add(this.label9);
            this.grpSac.Location = new System.Drawing.Point(260, 104);
            this.grpSac.Name = "grpSac";
            this.grpSac.Size = new System.Drawing.Size(200, 200);
            this.grpSac.TabIndex = 4;
            this.grpSac.TabStop = false;
            this.grpSac.Text = "SAC";
            // 
            // txtSMax
            // 
            this.txtSMax.Enabled = false;
            this.txtSMax.Location = new System.Drawing.Point(38, 144);
            this.txtSMax.Name = "txtSMax";
            this.txtSMax.Size = new System.Drawing.Size(150, 20);
            this.txtSMax.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Max";
            // 
            // txtSMin
            // 
            this.txtSMin.Enabled = false;
            this.txtSMin.Location = new System.Drawing.Point(38, 91);
            this.txtSMin.Name = "txtSMin";
            this.txtSMin.Size = new System.Drawing.Size(150, 20);
            this.txtSMin.TabIndex = 10;
            // 
            // txtSAvg
            // 
            this.txtSAvg.Enabled = false;
            this.txtSAvg.Location = new System.Drawing.Point(38, 41);
            this.txtSAvg.Name = "txtSAvg";
            this.txtSAvg.Size = new System.Drawing.Size(150, 20);
            this.txtSAvg.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "AVG";
            // 
            // txtMaximumio
            // 
            this.txtMaximumio.Enabled = false;
            this.txtMaximumio.Location = new System.Drawing.Point(205, 48);
            this.txtMaximumio.Name = "txtMaximumio";
            this.txtMaximumio.Size = new System.Drawing.Size(150, 20);
            this.txtMaximumio.TabIndex = 5;
            // 
            // txtBicsac
            // 
            this.txtBicsac.Enabled = false;
            this.txtBicsac.Location = new System.Drawing.Point(205, 350);
            this.txtBicsac.Name = "txtBicsac";
            this.txtBicsac.Size = new System.Drawing.Size(150, 20);
            this.txtBicsac.TabIndex = 9;
            // 
            // txtBicnon
            // 
            this.txtBicnon.Enabled = false;
            this.txtBicnon.Location = new System.Drawing.Point(205, 414);
            this.txtBicnon.Name = "txtBicnon";
            this.txtBicnon.Size = new System.Drawing.Size(150, 20);
            this.txtBicnon.TabIndex = 10;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(224, 453);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(101, 46);
            this.btnTamam.TabIndex = 11;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // TekVeriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtBicnon);
            this.Controls.Add(this.txtBicsac);
            this.Controls.Add(this.txtMaximumio);
            this.Controls.Add(this.grpSac);
            this.Controls.Add(this.lblBicNonlinearity);
            this.Controls.Add(this.lblBicsac);
            this.Controls.Add(this.grpNonlinearity);
            this.Controls.Add(this.lblMaximumio);
            this.MaximizeBox = false;
            this.Name = "TekVeriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TekVeriler";
            this.Load += new System.EventHandler(this.TekVeriler_Load);
            this.grpNonlinearity.ResumeLayout(false);
            this.grpNonlinearity.PerformLayout();
            this.grpSac.ResumeLayout(false);
            this.grpSac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaximumio;
        private System.Windows.Forms.GroupBox grpNonlinearity;
        private System.Windows.Forms.TextBox txtNMax;
        private System.Windows.Forms.TextBox txtNMin;
        private System.Windows.Forms.TextBox txtNAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBicsac;
        private System.Windows.Forms.Label lblBicNonlinearity;
        private System.Windows.Forms.GroupBox grpSac;
        private System.Windows.Forms.TextBox txtSMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSMin;
        private System.Windows.Forms.TextBox txtSAvg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaximumio;
        private System.Windows.Forms.TextBox txtBicsac;
        private System.Windows.Forms.TextBox txtBicnon;
        private System.Windows.Forms.Button btnTamam;
    }
}