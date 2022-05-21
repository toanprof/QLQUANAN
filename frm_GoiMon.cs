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
    public partial class frm_GoiMon : Form
    {
        public frm_GoiMon()
        {
            InitializeComponent();

        }
        LopChung chung = new LopChung();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\HINH\";
        private void cb_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cb_DanhMuc.Text;
            string sql = "select * from ThucDon where TenDM = N'" + a + "'";
            dataGridView1.DataSource = chung.LoadDL(sql);
        }

        private void frm_GoiMon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = chung.LoadDL("select * from Thucdon");
            string sql = "Select * from DanhMuc";
            cb_DanhMuc.DataSource = chung.LoadDL(sql);
            cb_DanhMuc.DisplayMember = "TenDM";
            cb_DanhMuc.ValueMember = "MaDM";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenMon.Text = dataGridView1.CurrentRow.Cells["TenMon"].Value.ToString();
            txt_Gia.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
            txt_Hinh.Text = dataGridView1.CurrentRow.Cells["Hinh"].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_Hinh.Text;
            num_SoLuong.Value = 0;
            txt_ThanhTien.ResetText();
        }

        private void num_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            int soluong = int.Parse(num_SoLuong.Value.ToString());
            int gia = int.Parse(txt_Gia.Text);
            txt_ThanhTien.Text = (soluong * gia).ToString();

        }
        protected int n, tong = 0;
        int soluong;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                soluong = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from ThucDon where MaMon LIKE N'%" + txt_TimKiem.Text + "%' or  TenMon LIKE N'%" + txt_TimKiem.Text + "%' or TenDM LIKE N'%" + txt_TimKiem.Text + "%'";
            dataGridView1.DataSource = chung.LoadDL(sql);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);

            }
            catch { }
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(rowIndex);
            tong -= soluong;
            lb_TongTien.Text = tong + " VNĐ";
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            frm_ThanhToan thanhtoan = new frm_ThanhToan();
            thanhtoan.Thongbao = txt_TenKH.Text;
            string tongtientt;
            tongtientt = lb_TongTien.Text;
            thanhtoan.tongtientt = tongtientt;
            thanhtoan.Show();
            tong = 0;
            dataGridView2.Rows.Clear();
            lb_TongTien.Text = tong + " VNĐ";
            this.Refresh();
            this.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenKH.Text != "")
            {
                if (txt_ThanhTien.Text != "0" && txt_ThanhTien.Text != "")
                {
                    n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = txt_TenMon.Text;
                    dataGridView2.Rows[n].Cells[1].Value = txt_Gia.Text;
                    dataGridView2.Rows[n].Cells[2].Value = num_SoLuong.Value;
                    dataGridView2.Rows[n].Cells[3].Value = txt_ThanhTien.Text;

                    tong += int.Parse(txt_ThanhTien.Text);
                    lb_TongTien.Text = tong + " VNĐ";
                }
                else
                {
                    MessageBox.Show("Chọn số lượng lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
