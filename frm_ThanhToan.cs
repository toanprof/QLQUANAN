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
    public partial class frm_ThanhToan : Form
    {
        public frm_ThanhToan()
        {
            InitializeComponent();
        }
        public string tongtientt;
        string thongbao;

        public string Thongbao { get => thongbao; set => thongbao = value; }

        public void LoadTien()
        {
            if (tongtientt != "")
            {
                lbl_TienThanhToan.Text = tongtientt;
            }
        }
        private void frm_ThanhToan_Load(object sender, EventArgs e)
        {
            lbl_TenKH.Text = thongbao;
            string s = lbl_TenKH.Text.Trim();
            while (s.IndexOf("  ") >= 0)
            {
                s = s.Replace("  ", " ");
            }
            lbl_TenKH.Text = s.ToString();
            LoadTien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_GoiMon goimon = new frm_GoiMon();
            goimon.Show();
        }
    }
}
