using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLiTour;

namespace QuanLiTour
{
    public partial class MH_DangNhap : Form
    {
        NguoiDung CauHinh = new NguoiDung();
        BUS_QLNguoiDung nd = new BUS_QLNguoiDung();
        public MH_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lbl_TenDangNhap.Text.ToLower());
                this.txt_TenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txt_MatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống " + lbl_MatKhau.Text.ToLower());
                this.txt_MatKhau.Focus();
                return;
            }
            if (CauHinh.Check_Config() == 0)
            {
                int n = CauHinh.Check_User(txt_TenDangNhap.Text, txt_MatKhau.Text);
                if (n == 0)
                    MessageBox.Show("Tên đăng nhập không tồn tại !");
                if (n == 1)
                {
                    MessageBox.Show("Đăng nhâp thành công !");
                    List<string> a = CauHinh.getDatatable(txt_TenDangNhap.Text.Trim());
                    panel1.Hide();
                    //CauHinh.PhanQuyen(ribbonControl_menu, a);
                }
                if (n == 2)
                    MessageBox.Show("Tài khoản không hoạt động !");
            }
            if (CauHinh.Check_Config() == 1)
            {
                CauHinhServer a = new CauHinhServer();
                a.Show();
            }
            if (CauHinh.Check_Config() == 2)
            {
                CauHinhServer a = new CauHinhServer();
                a.Show();
            }
        }
    }
}
