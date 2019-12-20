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
using DAL_QuanLiTour;

namespace QuanLiTour
{
    public partial class MH_LichKhoiHanh : Form
    {
        BUS_LichKhoiHanh bus = new BUS_LichKhoiHanh();
        BUS_Tours busTour = new BUS_Tours();
        bool check = true;
        XuLiData xuli = new XuLiData();
        public MH_LichKhoiHanh()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            gridControl_LichKH.DataSource = bus.getLichKhoiHanh();

            loadtotext();
        }
        public void loadtotext()
        {
            cbo_MaLich.DataBindings.Clear();
            cbo_MaLich.DataBindings.Add("text", gridControl_LichKH.DataSource, "MALICH");

            txt_TenLich.DataBindings.Clear();
            txt_TenLich.DataBindings.Add("text", gridControl_LichKH.DataSource, "TENLICH");

            //cbo_Tour.DataBindings.Clear();
            //cbo_Tour.DataBindings.Add("text", gridControl_LichKH.DataSource, "MATOUR");

            txt_SoChoTrong.DataBindings.Clear();
            txt_SoChoTrong.DataBindings.Add("text", gridControl_LichKH.DataSource, "SOCHOTRONG");

            //txt_NgayKhoiHanh.DataBindings.Clear();
            //txt_NgayKhoiHanh.DataBindings.Add("text", gridControl_LichKH.DataSource, "LICHKHOIHANH");
        }
        private void MH_LichKhoiHanh_Load(object sender, EventArgs e)
        {
            loaddata();
            xuli.DongText(tableLayoutPanel_TTLich, gridControl_LichKH);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            cbo_Tour.DataSource = busTour.getAllTour();
            cbo_Tour.DisplayMember = "TENTOUR";
            cbo_Tour.ValueMember = "MATOUR";
            cbo_Tour.SelectedIndex = 0;
            xuli.MoVaXoaText(tableLayoutPanel_TTLich, gridControl_LichKH);
            check = true;
            cbo_MaLich.Text = bus.getMaLich();
            cbo_MaLich.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_NgayKhoiHanh.Enabled = true;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (xuli.checkInput(tableLayoutPanel_TTLich))
            {
                try
                {
                    if (check)
                    {
                        LICHKHOIHANH a = new LICHKHOIHANH();
                        a.MALICH = cbo_MaLich.Text.Trim();
                        a.TENLICH = txt_TenLich.Text;
                        a.SOCHOTRONG = int.Parse(txt_SoChoTrong.Text);
                        DateTime dt = Convert.ToDateTime(txt_NgayKhoiHanh.EditValue);
                        a.MATOUR = cbo_Tour.SelectedValue.ToString();
                        a.LICHKHOIHANH1 = dt;
                        if (bus.addLichKhoiHanh(a))
                            MessageBox.Show("Thêm lịch thành công");
                        else
                            MessageBox.Show("Thêm lịch không thành công");
                    }
                    else
                    {
                        LICHKHOIHANH a = new LICHKHOIHANH();
                        a.MALICH = cbo_MaLich.Text.Trim();
                        a.TENLICH = txt_TenLich.Text;
                        a.SOCHOTRONG = int.Parse(txt_SoChoTrong.Text);
                        DateTime dt = Convert.ToDateTime(txt_NgayKhoiHanh.EditValue);
                        a.MATOUR = cbo_Tour.SelectedValue.ToString();
                        a.LICHKHOIHANH1 = dt;
                        if (bus.editLichKhoiHanh(a))
                            MessageBox.Show("Cập nhật lịch thành công");
                        else
                            MessageBox.Show("Cập nhật lịch không thành công");
                    }
                    xuli.DongText(tableLayoutPanel_TTLich, gridControl_LichKH);
                    loaddata();
                }
                catch
                {
                    MessageBox.Show("Lưu thất bại");
                }
                
            }
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
            txt_NgayKhoiHanh.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            check = false;
            xuli.MoText(tableLayoutPanel_TTLich, gridControl_LichKH);
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
            txt_NgayKhoiHanh.Enabled = true;
        }

        private void cbo_Tour_DropDown(object sender, EventArgs e)
        {
            
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                loaddata();
                btn_Luu.Enabled = false;
                btn_Huy.Enabled = false;
                xuli.DongText(tableLayoutPanel_TTLich, gridControl_LichKH);
                txt_NgayKhoiHanh.Enabled = false;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void gridControl_LichKH_Click(object sender, EventArgs e)
        {

        }
    }
}
