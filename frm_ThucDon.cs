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
    public partial class frm_ThucDon : Form
    {
        public frm_ThucDon()
        {
            InitializeComponent();
        }
        LopChung lopchung = new LopChung();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\HINH\";
        public void LoadTD()
        {
            string sql = "Select * from ThucDon";
            dataGridView1.DataSource = lopchung.LoadDL(sql);
        }
        public void LoadDM()
        {
            string sql = "Select * from DanhMuc";
            cb_TenDM.DataSource = lopchung.LoadDL(sql);
            cb_TenDM.DisplayMember = "TenDM";
            cb_TenDM.ValueMember = "TenDM";
        }
        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThucDon_Load(object sender, EventArgs e)
        {
            LoadTD();
            LoadDM();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaMon.Text != "")
            {
                string sql = "Delete ThucDon where MaMon = '" + txt_MaMon.Text + "'";
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
                LoadTD();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaMon.Text != "")
            {
                string sql = "UPDATE ThucDon SET TenMon = N'" + txt_TenMon.Text + "',TenDM = N'" + cb_TenDM.SelectedValue + "',Gia=N'" + txt_Gia.Text + "',Hinh = N'" + txt_Hinh.Text + "' where MaMon = '" + txt_MaMon.Text + "'";
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
                LoadTD();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaMon.Text != "" && txt_TenMon.Text != "" && txt_Gia.Text != "")
            {
                string sql = "Insert into ThucDon values(N'" + txt_MaMon.Text + "',N'" + txt_TenMon.Text + "',N'" + cb_TenDM.SelectedValue + "',N'" + txt_Gia.Text + "',N'" + txt_Hinh.Text + "')";
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
                LoadTD();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMon.Text = dataGridView1.CurrentRow.Cells["MaMon"].Value.ToString();
            txt_TenMon.Text = dataGridView1.CurrentRow.Cells["TenMon"].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
            cb_TenDM.SelectedValue = dataGridView1.CurrentRow.Cells["TenDM"].Value.ToString();
            txt_Hinh.Text = dataGridView1.CurrentRow.Cells["Hinh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_Hinh.Text;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from ThucDon where MaMon LIKE N'%" + txt_TimKiem.Text + "%' or  TenMon LIKE N'%" + txt_TimKiem.Text + "%' or TenDM LIKE N'%" + txt_TimKiem.Text + "%'";
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
