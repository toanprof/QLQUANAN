using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQUANAN
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
  

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslb_NgayGio.Text = DateTime.Now.ToString();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nhanvien = new frm_NhanVien();
                nhanvien.MdiParent = this;
                nhanvien.Show();

            }
            else
            {
                Application.OpenForms["frm_NhanVien"].Activate();

            }
  
        }
        private void thựcĐơnMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThucDon"] == null)
            {
                frm_ThucDon thucdon = new frm_ThucDon();
                thucdon.MdiParent = this;
                thucdon.Show();
            }
            else
            {
                Application.OpenForms["frm_ThucDon"].Activate();

            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void đặtMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_GoiMon"] == null)
            {
                frm_GoiMon goimon = new frm_GoiMon();
                goimon.MdiParent = this;
                goimon.Show();
            }
            else
            {
                Application.OpenForms["frm_GoiMon"].Activate();
            }
        }

        private void tsBtn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nhanvien = new frm_NhanVien();
                nhanvien.MdiParent = this;
                nhanvien.Show();
            }
            else
            {
                Application.OpenForms["frm_NhanVien"].Activate();
            }
        }

        private void tsBtn_ThucDonMon_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThucDon"] == null)
            {
                frm_ThucDon thucdon = new frm_ThucDon();
                thucdon.MdiParent = this;
                thucdon.Show();
            }
            else
            {
                Application.OpenForms["frm_ThucDon"].Activate();
            }
        }

        private void tsBtn_GoiMon_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_GoiMon"] == null)
            {
                frm_GoiMon goimon = new frm_GoiMon();
                goimon.MdiParent = this;
                goimon.Show();
            }
            else
            {
                Application.OpenForms["frm_GoiMon"].Activate();

            }
        }

        private void tsBtn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GioiThieu"] == null)
            {
                frm_GioiThieu gt = new frm_GioiThieu();
                gt.MdiParent = this;
                gt.Show();
            }
            else
            {
                Application.OpenForms["GioiThieu"].Activate();

            }
        }

        private void tsBtn_GioiThieu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GioiThieu"] == null)
            {
                frm_GioiThieu gt = new frm_GioiThieu();
                gt.MdiParent = this;
                gt.Show();
            }
            else
            {
                Application.OpenForms["GioiThieu"].Activate();

            }
        }
    }
}
