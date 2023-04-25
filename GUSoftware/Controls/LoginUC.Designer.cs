namespace GUSoftware.Controls
{
    partial class LoginUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.paswordTxt = new System.Windows.Forms.TextBox();
            this.gosterCb = new System.Windows.Forms.CheckBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginPb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxt.Location = new System.Drawing.Point(61, 14);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(140, 20);
            this.emailTxt.TabIndex = 1;
            // 
            // paswordTxt
            // 
            this.paswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paswordTxt.Location = new System.Drawing.Point(61, 40);
            this.paswordTxt.Name = "paswordTxt";
            this.paswordTxt.PasswordChar = '*';
            this.paswordTxt.Size = new System.Drawing.Size(140, 20);
            this.paswordTxt.TabIndex = 1;
            // 
            // gosterCb
            // 
            this.gosterCb.AutoSize = true;
            this.gosterCb.Location = new System.Drawing.Point(207, 43);
            this.gosterCb.Name = "gosterCb";
            this.gosterCb.Size = new System.Drawing.Size(57, 17);
            this.gosterCb.TabIndex = 2;
            this.gosterCb.Text = "Göster";
            this.gosterCb.UseVisualStyleBackColor = true;
            this.gosterCb.CheckedChanged += new System.EventHandler(this.gosterCb_CheckedChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.Location = new System.Drawing.Point(61, 66);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(140, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Giriş Yap";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // loginPb
            // 
            this.loginPb.Location = new System.Drawing.Point(61, 95);
            this.loginPb.Name = "loginPb";
            this.loginPb.Size = new System.Drawing.Size(140, 23);
            this.loginPb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loginPb.TabIndex = 4;
            this.loginPb.Visible = false;
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginPb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.gosterCb);
            this.Controls.Add(this.paswordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(262, 137);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox gosterCb;
        public System.Windows.Forms.TextBox emailTxt;
        public System.Windows.Forms.TextBox paswordTxt;
        public System.Windows.Forms.Button loginBtn;
        public System.Windows.Forms.ProgressBar loginPb;
    }
}
