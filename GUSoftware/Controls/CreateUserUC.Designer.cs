namespace GUSoftware.Controls
{
    partial class CreateUserUC
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
            this.createBtn = new System.Windows.Forms.Button();
            this.gosterCb = new System.Windows.Forms.CheckBox();
            this.paswordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Location = new System.Drawing.Point(55, 65);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(140, 23);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Kullanıcı Oluştur";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // gosterCb
            // 
            this.gosterCb.AutoSize = true;
            this.gosterCb.Location = new System.Drawing.Point(201, 42);
            this.gosterCb.Name = "gosterCb";
            this.gosterCb.Size = new System.Drawing.Size(57, 17);
            this.gosterCb.TabIndex = 8;
            this.gosterCb.Text = "Göster";
            this.gosterCb.UseVisualStyleBackColor = true;
            this.gosterCb.CheckedChanged += new System.EventHandler(this.gosterCb_CheckedChanged);
            // 
            // paswordTxt
            // 
            this.paswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paswordTxt.Location = new System.Drawing.Point(55, 39);
            this.paswordTxt.Name = "paswordTxt";
            this.paswordTxt.PasswordChar = '*';
            this.paswordTxt.Size = new System.Drawing.Size(140, 20);
            this.paswordTxt.TabIndex = 6;
            // 
            // emailTxt
            // 
            this.emailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTxt.Location = new System.Drawing.Point(55, 13);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(140, 20);
            this.emailTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "E Mail:";
            // 
            // CreateUserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.gosterCb);
            this.Controls.Add(this.paswordTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserUC";
            this.Size = new System.Drawing.Size(264, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox gosterCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button createBtn;
        public System.Windows.Forms.TextBox paswordTxt;
        public System.Windows.Forms.TextBox emailTxt;
    }
}
