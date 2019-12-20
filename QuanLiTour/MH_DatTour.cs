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
    public partial class MH_DatTour : Form
    {
        XuLiData xuli = new XuLiData();
        private string matour;
        BUS_DatTour bus = new BUS_DatTour();
        BUS_Tours bustour = new BUS_Tours();
        BUS_LichKhoiHanh buslich = new BUS_LichKhoiHanh();
        BUS_DanhSachDiKiem busds = new BUS_DanhSachDiKiem();
        BUS_ThanhToan bustt = new BUS_ThanhToan();
        BUS_KhachHang buskh = new BUS_KhachHang();
        BUS_GiaTour busgia = new BUS_GiaTour();
        BUS_ChiTietDanhSach busctds = new BUS_ChiTietDanhSach();
        bool check = true;
        public MH_DatTour(string data)
        {
            this.matour = data;
            InitializeComponent();
        }
        public void LoadData()
        {
            loaddataToText();
        }
        private void MH_DatTour_Load(object sender, EventArgs e)
        {
            if (this.matour == "no")
            {
                gridControl_DatTour.DataSource = bus.getTourDat();
                LoadData();
                loaddataToText();
                txt_NgayDat.Enabled = false;
                xuli.DongText(tableLayoutPanel_TTTourDat, gridControl_DatTour);
            }
            else
            {
                btn_ThemTourDat_Click(sender, e);
                cbo_MaTour.Text = this.matour;
                cbo_MaTour.Enabled = false;
                cbo_MaTourDat.Enabled = false;
                xuli.MoText(tableLayoutPanel_TacVuDatTour, gridControl_DatTour);
            }
            
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }
        private void loaddataToText()
        {
            cbo_MaTourDat.DataBindings.Clear();
            cbo_MaTourDat.DataBindings.Add("text", gridControl_DatTour.DataSource, "MATOURDAT");

            cbo_MaTour.DataBindings.Clear();
            cbo_MaTour.DataBindings.Add("text", gridControl_DatTour.DataSource, "TENTOUR");

            cbo_MaLich.DataBindings.Clear();
            cbo_MaLich.DataBindings.Add("text", gridControl_DatTour.DataSource, "TENLICH");

            cbo_MaDanhSach.DataBindings.Clear();
            cbo_MaDanhSach.DataBindings.Add("text", gridControl_DatTour.DataSource, "TENDANHSACH");

            cbo_KhachHang.DataBindings.Clear();
            cbo_KhachHang.DataBindings.Add("text", gridControl_DatTour.DataSource, "TENKHACHHANG");

            cbo_LoaiTT.DataBindings.Clear();
            cbo_LoaiTT.DataBindings.Add("text", gridControl_DatTour.DataSource, "TENLOAITT");

            txt_DiemDon.DataBindings.Clear();
            txt_DiemDon.DataBindings.Add("text", gridControl_DatTour.DataSource, "DIEMDON");

            txt_NgayDat.DataBindings.Clear();
            txt_NgayDat.DataBindings.Add("text", gridControl_DatTour.DataSource, "NGAYDAT");

            cbo_TrangThai.DataBindings.Clear();
            cbo_TrangThai.DataBindings.Add("text", gridControl_DatTour.DataSource, "TRANGTHAI");

            txt_TongTien.DataBindings.Clear();
            txt_TongTien.DataBindings.Add("text", gridControl_DatTour.DataSource, "TONGTIEN");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_ThemTourDat_Click(object sender, EventArgs e)
        {
            string x = bus.getMaTourDat();
            xuli.MoVaXoaText(tableLayoutPanel_TTTourDat, gridControl_DatTour);
            cbo_MaTourDat.Text = x;
            gridControl_DatTour.Enabled = false;
            check = true;
            txt_NgayDat.Enabled = true;
        }

        private void btn_SuaTourDat_Click(object sender, EventArgs e)
        {
            check  =  false;
            txt_NgayDat.Enabled = true;
            xuli.MoText(tableLayoutPanel_TacVuDatTour, gridControl_DatTour);
        }

        private void btn_XoaTourDat_Click(object sender, EventArgs e)
        {

        }

        private void btn_LuuTourDat_Click(object sender, EventArgs e)
        {
            if (xuli.checkInput(tableLayoutPanel_TTTourDat))
            {
                try
                {
                    if(check)
                    {
                        TOURDAT a = new TOURDAT();
                        a.MATOURDAT = cbo_MaTourDat.Text.Trim();
                        a.MALICH = cbo_MaLich.SelectedValue.ToString();
                        a.MADANHSACH = cbo_MaDanhSach.SelectedValue.ToString();
                        a.MAKHACHHANG = cbo_KhachHang.SelectedValue.ToString();
                        a.MALOAITT = cbo_LoaiTT.SelectedValue.ToString();
                        a.DIEMDON = txt_DiemDon.Text.Trim();
                        DateTime dt = Convert.ToDateTime(txt_NgayDat.EditValue);
                        a.NGAYDAT = dt;
                        a.TRANGTHAI = cbo_TrangThai.Text.Trim();
                        a.TONGTIEN = float.Parse(txt_TongTien.Text.Trim());
                        if(bus.addTourDat(a))
                            MessageBox.Show("Đặt tuor thành công");
                        else
                            MessageBox.Show("Đặt tour không thành công");
                    }
                    else{
                        TOURDAT a = new TOURDAT();
                        a.MATOURDAT = cbo_MaTourDat.Text.Trim();
                        a.MALICH = cbo_MaLich.SelectedValue.ToString();
                        a.MADANHSACH = cbo_MaDanhSach.SelectedValue.ToString();
                        a.MAKHACHHANG = cbo_KhachHang.SelectedValue.ToString();
                        a.MALOAITT = cbo_LoaiTT.SelectedValue.ToString();
                        a.DIEMDON = txt_DiemDon.Text.Trim();
                        DateTime dt = Convert.ToDateTime(txt_NgayDat.EditValue);
                        a.NGAYDAT = dt;
                        a.TRANGTHAI = cbo_TrangThai.Text.Trim();
                        a.TONGTIEN = float.Parse(txt_TongTien.Text.Trim());
                        if (bus.updateTourDat(a))
                            MessageBox.Show("Cập nhật đặt tuor thành công");
                        else
                            MessageBox.Show("Cập nhật đặt tour không thành công");
                    }
                    xuli.DongText(tableLayoutPanel_TacVuDatTour, gridControl_DatTour);
                    LoadData();
                    btn_LuuTourDat.Enabled = false;
                    btn_Huy.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Đặt tuor không thành công");
                }
                txt_NgayDat.Enabled = false;
            }
        }

        private void btn_TimTourDat_Click(object sender, EventArgs e)
        {

        }

        private void cbo_MaLich_DropDown(object sender, EventArgs e)
        {
            cbo_MaLich.DataSource = buslich.getLichKhoiHanhTour(cbo_MaTour.Text);
            cbo_MaLich.DisplayMember = "TENLICH";
            cbo_MaLich.ValueMember = "MALICH";
        }

        private void cbo_MaTour_DropDown(object sender, EventArgs e)
        {
            cbo_MaTour.DataSource = bustour.getListTour();
            cbo_MaTour.DisplayMember = "TENTOUR";
            cbo_MaTour.ValueMember = "MATOUR";
        }

        private void cbo_MaTourDat_DropDown(object sender, EventArgs e)
        {
            cbo_MaTourDat.DataSource = bus.getTourDat();
            cbo_MaTourDat.DisplayMember = "MATOURDAT";
            cbo_MaTourDat.ValueMember = "MATOURDAT";
        }

        private void cbo_MaDanhSach_DropDown(object sender, EventArgs e)
        {
            cbo_MaDanhSach.DataSource = busds.getListDanhSachDiKem();
            cbo_MaDanhSach.DisplayMember = "TENDANHSACH";
            cbo_MaDanhSach.ValueMember = "MADANHSACH";
        }

        private void cbo_MaLoaiTT_DropDown(object sender, EventArgs e)
        {
            cbo_LoaiTT.DataSource = bustt.getThanhToan();
            cbo_LoaiTT.DisplayMember = "TENLOAITT";
            cbo_LoaiTT.ValueMember = "MALOAITT";
        }

        private void cbo_KhachHang_DropDown(object sender, EventArgs e)
        {
            cbo_KhachHang.DataSource = buskh.getKhachHang();
            cbo_KhachHang.DisplayMember = "TENKHACHHANG";
            cbo_KhachHang.ValueMember = "MAKHACHHANG";
        }

        private void btn_DanhSachDiKem_Click(object sender, EventArgs e)
        {
            MH_DanhSachDiKem frm = new MH_DanhSachDiKem();
            frm.Show();
        }

        private void cbo_MaDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            float tongtien = 0;
            string madanhsach = cbo_MaDanhSach.SelectedValue.ToString();
            string malich = cbo_MaLich.SelectedValue.ToString();
            string matour = buslich.getMaTour(malich);
            string magiave = bustour.getMaGiaVe(matour);
            List<CHITIETGIAVE> giave = busgia.getChiTietGia(magiave);
            List<CHITIETDIKEM> dikem = busctds.getListDiKem(madanhsach);
            foreach(CHITIETDIKEM item in dikem)
            {
                foreach (CHITIETGIAVE itemgia in giave)
                {
                    if (item.MALOAIKHACH == itemgia.MALOAIKHACH)
                    {
                        tongtien += float.Parse(itemgia.GIA.ToString());
                    }
                }
            }
            txt_TongTien.Text = tongtien.ToString();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                LoadData();
                xuli.DongText(tableLayoutPanel_TacVuDatTour, gridControl_DatTour);
            }
            btn_LuuTourDat.Enabled = false;
            btn_Huy.Enabled = false;
        }

    }
}
