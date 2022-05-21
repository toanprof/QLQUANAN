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
    public partial class frm_DangKi : Form
    {
        public frm_DangKi()
        {
            InitializeComponent();
        }
        LopChung lopchung = new LopChung();

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            frm_DangNhap dangNhap = new frm_DangNhap();
            this.Close();
            dangNhap.Show();
        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text != string.Empty || txt_MatKhau.Text != string.Empty || txt_XacThucMK.Text != string.Empty)
            {

                if (txt_MatKhau.Text == txt_XacThucMK.Text)
                {
                    string sql = "Insert into ThongTinTaiKhoan values (N'" + txt_TaiKhoan.Text + "',N'" + txt_MatKhau.Text + "')";
                    int kq = lopchung.ThemXoaSua(sql);
                    if (kq >= 1)
                        MessageBox.Show("Đăng kí thành công");
                    else MessageBox.Show("Đăng kí thất bại");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập cả hai mật khẩu giống nhau ", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frm_DangNhap dangNhap = new frm_DangNhap();
            this.Close();
            dangNhap.Show();
        }
    }
}
