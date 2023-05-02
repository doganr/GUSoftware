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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // numara_txt
            // 
            this.numara_txt.Location = new System.Drawing.Point(62, 19);
            this.numara_txt.Name = "numara_txt";
            this.numara_txt.Size = new System.Drawing.Size(201, 20);
            this.numara_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(62, 45);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(201, 20);
            this.ad_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // soyad_txt
            // 
            this.soyad_txt.Location = new System.Drawing.Point(62, 71);
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(201, 20);
            this.soyad_txt.TabIndex = 3;
            // 
            // ogrenciekle_btn
            // 
            this.ogrenciekle_btn.Location = new System.Drawing.Point(62, 97);
            this.ogrenciekle_btn.Name = "ogrenciekle_btn";
            this.ogrenciekle_btn.Size = new System.Drawing.Size(201, 23);
            this.ogrenciekle_btn.TabIndex = 4;
            this.ogrenciekle_btn.Text = "Ekle";
            this.ogrenciekle_btn.UseVisualStyleBackColor = true;
            this.ogrenciekle_btn.Click += new System.EventHandler(this.ogrenciekle_btn_Click);
            // 
            // OgrenciEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 135);
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
    }
}