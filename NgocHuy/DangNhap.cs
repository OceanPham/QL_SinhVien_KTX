using QuanLySV_KTX.NgocHuy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV_KTX
{
    public partial class frmDangNhap : Form
    {

        frmTrangChuQLSV fQLSV = new frmTrangChuQLSV();
        frmTrangChu_QLKTX fQLKTX = new frmTrangChu_QLKTX();
        frmTrangChu_QTHT fQTHT = new frmTrangChu_QTHT();
        frmDangKy fDangKy = new frmDangKy();

        string userName = "KTPM2";
        string Password = "123456";
       
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Đăng_Ký(object sender, EventArgs e)
        {
            fDangKy.ShowDialog();
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == userName && txtMatKhau.Text == Password && rdbQLSV.Checked)
            {
                fQLSV.ShowDialog();
            }
            else if (txtTenDangNhap.Text == userName && txtMatKhau.Text == Password && rdbQLKTX.Checked)
            {
                fQLKTX.ShowDialog();
            }
            else if (txtTenDangNhap.Text == userName && txtMatKhau.Text == Password && rdbQTHT.Checked)
            {
                fQTHT.ShowDialog();
            }
            else
                MessageBox.Show("Loi dang nhap", "Error");
        }
    }
}
