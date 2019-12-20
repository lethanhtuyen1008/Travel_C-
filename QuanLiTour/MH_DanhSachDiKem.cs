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
    public partial class MH_DanhSachDiKem : Form
    {
        BUS_DanhSachDiKiem bus = new BUS_DanhSachDiKiem();
        BUS_ChiTietDanhSach busct = new BUS_ChiTietDanhSach();
        DAL_LoaiKhachHang buslk = new DAL_LoaiKhachHang();
        XuLiData xuli = new XuLiData();
        bool check = false;
        bool check2 = false;
        public MH_DanhSachDiKem()
        {
            InitializeComponent();
        }
        public  void loadData()
        {
            gridControl_DanhSach.DataSource = bus.getListDanhSachDiKem();
            loadTxtDS();
        }
        public void loadTxtDS()
        {
            cbo_DanhSach.DataBindings.Clear();
            cbo_DanhSach.DataBindings.Add("text", gridControl_DanhSach.DataSource, "MADANHSACH");

            txt_TenDS.DataBindings.Clear();
            txt_TenDS.DataBindings.Add("text", gridControl_DanhSach.DataSource, "TENDANHSACH");
        }
        public void loadTxtCT()
        {
            txt_MaChiTiet.DataBindings.Clear();
            txt_MaChiTiet.DataBindings.Add("text", gridControl_ChiTietDS.DataSource, "MACHITIET");
            cbo_MaDanhSach.DataBindings.Clear();
            cbo_MaDanhSach.DataBindings.Add("text", gridControl_ChiTietDS.DataSource, "MADANHSACH");
            cbo_MaLoaiKhach.DataBindings.Clear();
            cbo_MaLoaiKhach.DataBindings.Add("text", gridControl_ChiTietDS.DataSource, "MALOAIKHACH");
            txt_HoTen.DataBindings.Clear();
            txt_HoTen.DataBindings.Add("text", gridControl_ChiTietDS.DataSource, "HOTEN");
            txt_NamSinh.DataBindings.Clear();
            txt_NamSinh.DataBindings.Add("text", gridControl_ChiTietDS.DataSource, "NAMSINH");
            cbo_GioiTinh.DataBindings.Clear();
            cbo_GioiTinh.DataBindings.Add("text", gridControl_ChiTietDS.DataSource, "GIOITINH");

        }
        private void MH_DanhSachDiKem_Load(object sender, EventArgs e)
        {
            loadData();
            xuli.DongText(tableLayoutPanel_DS, gridControl_DanhSach);
            xuli.DongText(tableLayoutPanel_CTDS, gridControl_ChiTietDS);
            gridControl_ChiTietDS.Enabled = true;

            cbo_MaDanhSach.DataSource = bus.getListDanhSachDiKem();
            cbo_MaDanhSach.DisplayMember = "TENDANHSACH";
            cbo_MaDanhSach.ValueMember = "MADANHSACH";

            cbo_MaLoaiKhach.DataSource = buslk.getLoaiKhach();
            cbo_MaLoaiKhach.DisplayMember = "TENLOAIKHACH";
            cbo_MaLoaiKhach.ValueMember = "MALOAIKHACH";
        }

        private void gridControl_DanhSach_Click(object sender, EventArgs e)
        {
            int x = gridView_DS.FocusedRowHandle;// row selected
            string data = gridView_DS.GetRowCellValue(x, "MADANHSACH").ToString(); // matour selected
            gridControl_ChiTietDS.DataSource = busct.getListDiKem(data);
            loadTxtCT();
        }

        private void btn_ThemDS_Click(object sender, EventArgs e)
        {
            xuli.MoVaXoaText(tableLayoutPanel_DS, gridControl_DanhSach);
            string ma = bus.getMaDS();
            cbo_DanhSach.Text = ma;
            btn_HuyDS.Enabled = true;
            btn_LuuDS.Enabled = true;
            check = true;
            cbo_DanhSach.Enabled = false;
        }

        private void btn_SuaDS_Click(object sender, EventArgs e)
        {
            check = false;
            xuli.MoVaXoaText(tableLayoutPanel_DS, gridControl_DanhSach);
            btn_LuuDS.Enabled = true;
            btn_HuyDS.Enabled = true;
            cbo_DanhSach.Enabled = false;
        }

        private void btn_XoaDS_Click(object sender, EventArgs e)
        {
            int x = gridView_DS.FocusedRowHandle;// row selected
            string data = gridView_DS.GetRowCellValue(x, "MADANHSACH").ToString(); // matour selected
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (bus.deleteDanhSachDiKem(data)) MessageBox.Show("Xóa thành công danh sách tour: " + data);
                else MessageBox.Show("Xóa không thành công danh sách: " + data);
                loadData();
            }
            btn_LuuDS.Enabled = false;
            btn_HuyDS.Enabled = false;
        }

        private void btn_LuuDS_Click(object sender, EventArgs e)
        {
            if(xuli.checkInput(tableLayoutPanel_DS))
            {
                try
                {
                    if (check)
                    {
                        DANHSACHNGUOIDIKEM a = new DANHSACHNGUOIDIKEM();
                        a.TENDANHSACH = txt_TenDS.Text.Trim();
                        a.MADANHSACH = cbo_DanhSach.Text.Trim();
                        if (bus.addDanhSachDiKem(a))
                            MessageBox.Show("Thêm danh sach đi kèm thành công");
                        else
                            MessageBox.Show("Thêm danh sach đi kèm thất bại");
                    }
                    else
                    {
                        DANHSACHNGUOIDIKEM a = new DANHSACHNGUOIDIKEM();
                        a.TENDANHSACH = txt_TenDS.Text.Trim();
                        a.MADANHSACH = cbo_DanhSach.Text.Trim();
                        if (bus.editDanhSachDiKem(a))
                            MessageBox.Show("Cập nhật danh sach đi kèm thành công");
                        else
                            MessageBox.Show("Cập nhật danh sach đi kèm thất bại");
                    }
                }
                catch {
                    MessageBox.Show("Thêm danh sách không thành công");
                }
                xuli.DongText(tableLayoutPanel_DS, gridControl_DanhSach);
                loadData();
            }
        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {
            xuli.MoVaXoaText(tableLayoutPanel_CTDS, gridControl_ChiTietDS);
            check2 = true;
            txt_MaChiTiet.Text = busct.getMaCTDS();
            txt_MaChiTiet.Enabled = false;
            btn_HuyCT.Enabled = true;
            btn_LuuCT.Enabled = true;
        }

        private void btn_XoaCT_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int x = gridView_CTDS.FocusedRowHandle;// row selected
                string data = gridView_CTDS.GetRowCellValue(x, "MACHITIET").ToString(); // matour selected
                CHITIETDIKEM a = new CHITIETDIKEM();
                a.MACHITIET = txt_MaChiTiet.Text;
                a.MADANHSACH = cbo_MaDanhSach.Text;
                a.MALOAIKHACH = cbo_MaLoaiKhach.Text;
                a.HOTEN = txt_HoTen.Text.Trim();
                a.NAMSINH = int.Parse(txt_NamSinh.Text.Trim());
                a.GIOITINH = cbo_GioiTinh.Text.Trim();
                if (busct.deleteCTDS(a))
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Xóa không thành công");
                loadData();
                xuli.DongText(tableLayoutPanel_CTDS, gridControl_ChiTietDS);
                btn_HuyCT.Enabled = false;
                
                btn_LuuCT.Enabled = false;
            }
        }

        private void btn_SuaCT_Click(object sender, EventArgs e)
        {
            check2 = false;
            xuli.MoText(tableLayoutPanel_CTDS, gridControl_ChiTietDS);
            txt_MaChiTiet.Enabled = false;
            btn_HuyCT.Enabled = true;
            btn_LuuCT.Enabled = true;
        }

        private void btn_HuyCT_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                xuli.DongText(tableLayoutPanel_CTDS, gridControl_ChiTietDS);
                btn_HuyCT.Enabled = false;
                btn_LuuCT.Enabled = false;
            }
        }

        private void btn_LuuCT_Click(object sender, EventArgs e)
        {
            try
            {

                if (xuli.checkInput(tableLayoutPanel_CTDS))
                {
                    try
                    {
                        if (check2)
                        {
                            CHITIETDIKEM a = new CHITIETDIKEM();
                            a.MACHITIET = txt_MaChiTiet.Text;
                            a.MADANHSACH = cbo_MaDanhSach.SelectedValue.ToString();
                            a.MALOAIKHACH = cbo_MaLoaiKhach.SelectedValue.ToString();
                            a.HOTEN = txt_HoTen.Text.Trim();
                            a.NAMSINH = int.Parse(txt_NamSinh.Text.Trim());
                            a.GIOITINH = cbo_GioiTinh.Text.Trim();

                            if (busct.addCTDS(a))
                                MessageBox.Show("Thêm người đi kèm thành công");
                            else
                                MessageBox.Show("Thêm người đi kèm thất bại");
                        }
                        else
                        {
                            CHITIETDIKEM a = new CHITIETDIKEM();
                            a.MADANHSACH = cbo_MaDanhSach.SelectedValue.ToString();
                            a.MALOAIKHACH = cbo_MaLoaiKhach.SelectedValue.ToString();
                            a.HOTEN = txt_HoTen.Text.Trim();
                            a.NAMSINH = int.Parse(txt_NamSinh.Text.Trim());
                            a.GIOITINH = cbo_GioiTinh.Text.Trim();
                            if (busct.editCTDS(a))
                                MessageBox.Show("Cập nhật người đi kèm thành công");
                            else
                                MessageBox.Show("Cập nhật người đi kèm thất bại");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lưu thất bại");
                    }
                    loadData();
                    xuli.DongText(tableLayoutPanel_CTDS, gridControl_ChiTietDS);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void labelIP5_Click(object sender, EventArgs e)
        {

        }

        private void cbo_MaDanhSach_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cbo_MaLoaiKhach_DropDown(object sender, EventArgs e)
        {
           
        }

        private void gridControl_ChiTietDS_Click(object sender, EventArgs e)
        {
            loadTxtCT();
        }

        private void btn_HuyDS_Click(object sender, EventArgs e)
        {

        }
    }
}
