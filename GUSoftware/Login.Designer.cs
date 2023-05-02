namespace GUSoftware
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.importloginBtn = new System.Windows.Forms.Button();
            this.importcreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 279);
            this.panel1.TabIndex = 0;
            // 
            // importloginBtn
            // 
            this.importloginBtn.Location = new System.Drawing.Point(12, 12);
            this.importloginBtn.Name = "importloginBtn";
            this.importloginBtn.Size = new System.Drawing.Size(93, 23);
            this.importloginBtn.TabIndex = 0;
            this.importloginBtn.Text = "Kullanıcı Girişi";
            this.importloginBtn.UseVisualStyleBackColor = true;
            this.importloginBtn.Click += new System.EventHandler(this.importloginBtn_Click);
            // 
            // importcreateBtn
            // 
            this.importcreateBtn.Location = new System.Drawing.Point(111, 12);
            this.importcreateBtn.Name = "importcreateBtn";
            this.importcreateBtn.Size = new System.Drawing.Size(93, 23);
            this.importcreateBtn.TabIndex = 1;
            this.importcreateBtn.Text = "Yeni Kullanıcı";
            this.importcreateBtn.UseVisualStyleBackColor = true;
            this.importcreateBtn.Click += new System.EventHandler(this.importcreateBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 335);
            this.Controls.Add(this.importcreateBtn);
            this.Controls.Add(this.importloginBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button importloginBtn;
        private System.Windows.Forms.Button importcreateBtn;
    }
}

