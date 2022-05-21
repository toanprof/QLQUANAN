using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace QLQUANAN
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        LopChung lopchung = new LopChung();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Hinh\";
        public void LoadNV()
        {
            string sql = "Select * from NhanVien";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }
        public void LoadCV()
        {
            string sql = "Select * from ChucVu";
            cb_ChucVu.DataSource = lopchung.LoadDL(sql);
            cb_ChucVu.DisplayMember = "TenCV";
            cb_ChucVu.ValueMember = "TenCV";
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text != "" && txt_HoTen.Text != "" && txt_DiaChi.Text != "")
            {
                string sql = "Insert into NhanVien values(N'" + txt_MaNV.Text + "',N'" + txt_HoTen.Text + "',N'" + cb_ChucVu.SelectedValue + "',N'" + txt_DiaChi.Text + "',Convert(DateTime,'" + dtP_NgaySinh.Text + "',103),N'" + txt_Hinh.Text + "')";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Thêm thành công");
                    try
                    {
                        pictureBox1.Image.Save(duongdan + txt_Hinh.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không có hình ảnh");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                LoadNV();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
            LoadCV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text != "")
            {
                string sql = "Delete NhanVien where MaNV = '" + txt_MaNV.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Xóa thành công");
                    try
                    {
                        File.Delete(duongdan + txt_Hinh.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không có hình ảnh để xóa");
                    }
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                LoadNV();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text != "")
            {
                string sql = "UPDATE NhanVien SET HoTen = N'" + txt_HoTen.Text + "',MaCV = N'" + cb_ChucVu.SelectedValue + "',DiaChi=N'" + txt_DiaChi.Text + "',NgaySinh = Convert(DateTime, '" + dtP_NgaySinh.Text + "', 103),Hinh = N'" + txt_Hinh.Text + "' where MaNV = '" + txt_MaNV.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Sửa thành công");
                    try
                    {
                        pictureBox1.Image.Save(duongdan + txt_Hinh.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không có hình ảnh");
                    }
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
                LoadNV();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            cb_ChucVu.SelectedValue = dataGridView1.CurrentRow.Cells["MaCV"].Value.ToString();
            dtP_NgaySinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_Hinh.Text = dataGridView1.CurrentRow.Cells["Hinh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_Hinh.Text;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from NhanVien where MaNV LIKE N'%" + txt_TimKiem.Text + "%' or  HoTen LIKE N'%" + txt_TimKiem.Text + "%' or MaCV LIKE N'%" + txt_TimKiem.Text + "%'or DiaChi LIKE N'%" + txt_TimKiem.Text + "%'";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Mời bạn chọn ảnh";
            open.Filter = "JEPG|*.jepg|BMP|*.bmp|Tất cả|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
