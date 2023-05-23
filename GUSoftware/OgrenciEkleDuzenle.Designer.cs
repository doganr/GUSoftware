namespace GUSoftware
{
    partial class OgrenciEkleDuzenle
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
            this.numara_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.ogrenciekle_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resim_pB = new System.Windows.Forms.PictureBox();
            this.resimsec_btn = new System.Windows.Forms.Button();
            this.ogrenci_prbar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.resim_pB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // numara_txt
            // 
            this.numara_txt.Location = new System.Drawing.Point(62, 234);
            this.numara_txt.Name = "numara_txt";
            this.numara_txt.Size = new System.Drawing.Size(201, 20);
            this.numara_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(62, 260);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(201, 20);
            this.ad_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // soyad_txt
            // 
            this.soyad_txt.Location = new System.Drawing.Point(62, 286);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(201, 20);
            this.soyad_txt.TabIndex = 3;
            // 
            // ogrenciekle_btn
            // 
            this.ogrenciekle_btn.Location = new System.Drawing.Point(168, 312);
            this.ogrenciekle_btn.Name = "ogrenciekle_btn";
            this.ogrenciekle_btn.Size = new System.Drawing.Size(95, 23);
            this.ogrenciekle_btn.TabIndex = 4;
            this.ogrenciekle_btn.Text = "Ekle";
            this.ogrenciekle_btn.UseVisualStyleBackColor = true;
            this.ogrenciekle_btn.Click += new System.EventHandler(this.ogrenciekle_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resim";
            // 
            // resim_pB
            // 
            this.resim_pB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resim_pB.Location = new System.Drawing.Point(62, 12);
            this.resim_pB.Name = "resim_pB";
            this.resim_pB.Size = new System.Drawing.Size(201, 216);
            this.resim_pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim_pB.TabIndex = 6;
            this.resim_pB.TabStop = false;
            // 
            // resimsec_btn
            // 
            this.resimsec_btn.Location = new System.Drawing.Point(221, 201);
            this.resimsec_btn.Name = "resimsec_btn";
            this.resimsec_btn.Size = new System.Drawing.Size(38, 23);
            this.resimsec_btn.TabIndex = 7;
            this.resimsec_btn.Text = "Seç";
            this.resimsec_btn.UseVisualStyleBackColor = true;
            this.resimsec_btn.Click += new System.EventHandler(this.resimsec_btn_Click);
            // 
            // ogrenci_prbar
            // 
            this.ogrenci_prbar.Location = new System.Drawing.Point(62, 312);
            this.ogrenci_prbar.Name = "ogrenci_prbar";
            this.ogrenci_prbar.Size = new System.Drawing.Size(100, 23);
            this.ogrenci_prbar.TabIndex = 8;
            this.ogrenci_prbar.Visible = false;
            // 
            // OgrenciEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 346);
            this.Controls.Add(this.ogrenci_prbar);
            this.Controls.Add(this.resimsec_btn);
            this.Controls.Add(this.resim_pB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogrenciekle_btn);
            this.Controls.Add(this.soyad_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ad_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numara_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgrenciEkleDuzenle";
            this.Text = "Öğrenci Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.resim_pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox numara_txt;
        public System.Windows.Forms.TextBox ad_txt;
        public System.Windows.Forms.TextBox soyad_txt;
        public System.Windows.Forms.Button ogrenciekle_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resimsec_btn;
        private System.Windows.Forms.ProgressBar ogrenci_prbar;
        public System.Windows.Forms.PictureBox resim_pB;
    }
}