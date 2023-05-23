namespace GUSoftware
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.ogrenciler_dgw = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_lbl = new System.Windows.Forms.Label();
            this.status_pb = new System.Windows.Forms.ProgressBar();
            this.datagrid_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciler_dgw)).BeginInit();
            this.panel1.SuspendLayout();
            this.datagrid_cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ogrenci_ekle_Click);
            // 
            // ogrenciler_dgw
            // 
            this.ogrenciler_dgw.AllowUserToAddRows = false;
            this.ogrenciler_dgw.AllowUserToDeleteRows = false;
            this.ogrenciler_dgw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogrenciler_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciler_dgw.ContextMenuStrip = this.datagrid_cms;
            this.ogrenciler_dgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ogrenciler_dgw.Location = new System.Drawing.Point(12, 58);
            this.ogrenciler_dgw.Name = "ogrenciler_dgw";
            this.ogrenciler_dgw.Size = new System.Drawing.Size(1240, 665);
            this.ogrenciler_dgw.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.status_lbl);
            this.panel1.Controls.Add(this.status_pb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 729);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 29);
            this.panel1.TabIndex = 2;
            // 
            // status_lbl
            // 
            this.status_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_lbl.Location = new System.Drawing.Point(3, 0);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.status_lbl.Size = new System.Drawing.Size(1048, 29);
            this.status_lbl.TabIndex = 1;
            this.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // status_pb
            // 
            this.status_pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_pb.Location = new System.Drawing.Point(1057, 3);
            this.status_pb.Name = "status_pb";
            this.status_pb.Size = new System.Drawing.Size(195, 23);
            this.status_pb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.status_pb.TabIndex = 0;
            this.status_pb.Visible = false;
            // 
            // datagrid_cms
            // 
            this.datagrid_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.datagrid_cms.Name = "datagrid_cms";
            this.datagrid_cms.Size = new System.Drawing.Size(181, 70);
            this.datagrid_cms.Opening += new System.ComponentModel.CancelEventHandler(this.datagrid_cms_Opening);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ogrenciler_dgw);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Gümüşhane Üniversitesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciler_dgw)).EndInit();
            this.panel1.ResumeLayout(false);
            this.datagrid_cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ogrenciler_dgw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.ProgressBar status_pb;
        private System.Windows.Forms.ContextMenuStrip datagrid_cms;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}