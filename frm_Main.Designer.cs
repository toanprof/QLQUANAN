
namespace QLQUANAN
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcĐơnMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslb_NgayGio = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtn_QuanLyNhanVien = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_ThucDonMon = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_GoiMon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtn_GioiThieu = new System.Windows.Forms.ToolStripButton();
            this.tsBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem1,
            this.thựcĐơnMónToolStripMenuItem,
            this.đặtMónToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem});
            this.quảnLýToolStripMenuItem1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.quảnLýToolStripMenuItem1.Name = "quảnLýToolStripMenuItem1";
            this.quảnLýToolStripMenuItem1.Size = new System.Drawing.Size(82, 27);
            this.quảnLýToolStripMenuItem1.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // thựcĐơnMónToolStripMenuItem
            // 
            this.thựcĐơnMónToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.thựcĐơnMónToolStripMenuItem.Name = "thựcĐơnMónToolStripMenuItem";
            this.thựcĐơnMónToolStripMenuItem.Size = new System.Drawing.Size(125, 27);
            this.thựcĐơnMónToolStripMenuItem.Text = "Thực đơn món";
            this.thựcĐơnMónToolStripMenuItem.Click += new System.EventHandler(this.thựcĐơnMónToolStripMenuItem_Click);
            // 
            // đặtMónToolStripMenuItem
            // 
            this.đặtMónToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.đặtMónToolStripMenuItem.Name = "đặtMónToolStripMenuItem";
            this.đặtMónToolStripMenuItem.Size = new System.Drawing.Size(86, 27);
            this.đặtMónToolStripMenuItem.Text = "Gọi món";
            this.đặtMónToolStripMenuItem.Click += new System.EventHandler(this.đặtMónToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(90, 27);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslb_NgayGio});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1306, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslb_NgayGio
            // 
            this.tslb_NgayGio.Name = "tslb_NgayGio";
            this.tslb_NgayGio.Size = new System.Drawing.Size(118, 17);
            this.tslb_NgayGio.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtn_QuanLyNhanVien,
            this.tsBtn_ThucDonMon,
            this.tsBtn_GoiMon,
            this.toolStripSeparator1,
            this.tsBtn_GioiThieu,
            this.tsBtn_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1306, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtn_QuanLyNhanVien
            // 
            this.tsBtn_QuanLyNhanVien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_QuanLyNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_QuanLyNhanVien.Image")));
            this.tsBtn_QuanLyNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_QuanLyNhanVien.Name = "tsBtn_QuanLyNhanVien";
            this.tsBtn_QuanLyNhanVien.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_QuanLyNhanVien.Text = "Quản lý nhân viên";
            this.tsBtn_QuanLyNhanVien.Click += new System.EventHandler(this.tsBtn_QuanLyNhanVien_Click);
            // 
            // tsBtn_ThucDonMon
            // 
            this.tsBtn_ThucDonMon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_ThucDonMon.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_ThucDonMon.Image")));
            this.tsBtn_ThucDonMon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_ThucDonMon.Name = "tsBtn_ThucDonMon";
            this.tsBtn_ThucDonMon.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_ThucDonMon.Text = "Thực đơn món";
            this.tsBtn_ThucDonMon.Click += new System.EventHandler(this.tsBtn_ThucDonMon_Click);
            // 
            // tsBtn_GoiMon
            // 
            this.tsBtn_GoiMon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_GoiMon.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_GoiMon.Image")));
            this.tsBtn_GoiMon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_GoiMon.Name = "tsBtn_GoiMon";
            this.tsBtn_GoiMon.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_GoiMon.Text = "Gọi món";
            this.tsBtn_GoiMon.Click += new System.EventHandler(this.tsBtn_GoiMon_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtn_GioiThieu
            // 
            this.tsBtn_GioiThieu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_GioiThieu.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_GioiThieu.Image")));
            this.tsBtn_GioiThieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_GioiThieu.Name = "tsBtn_GioiThieu";
            this.tsBtn_GioiThieu.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_GioiThieu.Text = "Giới thiệu";
            this.tsBtn_GioiThieu.Click += new System.EventHandler(this.tsBtn_GioiThieu_Click);
            // 
            // tsBtn_Thoat
            // 
            this.tsBtn_Thoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("tsBtn_Thoat.Image")));
            this.tsBtn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtn_Thoat.Name = "tsBtn_Thoat";
            this.tsBtn_Thoat.Size = new System.Drawing.Size(23, 22);
            this.tsBtn_Thoat.Text = "Thoát";
            this.tsBtn_Thoat.Click += new System.EventHandler(this.tsBtn_Thoat_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLQUANAN.Properties.Resources.quanan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 641);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "QUẢN LÝ QUÁN ĂN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đặtMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslb_NgayGio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtn_QuanLyNhanVien;
        private System.Windows.Forms.ToolStripButton tsBtn_ThucDonMon;
        private System.Windows.Forms.ToolStripButton tsBtn_GoiMon;
        private System.Windows.Forms.ToolStripButton tsBtn_Thoat;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtn_GioiThieu;
    }
}