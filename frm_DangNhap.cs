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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        LopChung lopchung = new LopChung();
        int dem = 0;
        private void lb_DangKi_Click(object sender, EventArgs e)
        {
            frm_DangKi dk = new frm_DangKi();
            dk.Show();
            this.Hide();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from ThongTinTaiKhoan where TaiKhoan = '" + txt_TaiKhoan.Text + "' and MatKhau = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopchung.TraVeGT(sql);
            if (kq >= 1)
            {
                frm_Main main = new frm_Main();
                MessageBox.Show("Đăng nhập thành công");
                main.Show();
                this.Hide();
            }
            else
            {
                dem++;
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ck_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_HienThi.Checked == true)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
