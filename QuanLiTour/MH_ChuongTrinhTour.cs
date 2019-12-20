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
using DTO_QuanLiTour;
using DAL_QuanLiTour;

namespace QuanLiTour
{
    public partial class MH_ChuongTrinhTour : Form
    {
        XuLiData xuli = new XuLiData();
        BUS_KhachSan busKS = new BUS_KhachSan();
        BUS_ChiTietChuongTrinh busct = new BUS_ChiTietChuongTrinh();
        BUS_ChuongTrinhTour bus = new BUS_ChuongTrinhTour();
        BUS_Tours bustour = new BUS_Tours();
        private string ma;
        bool check = true;
        bool check2 = true;
        public MH_ChuongTrinhTour(string matour)
        {
            InitializeComponent();
            this.ma = matour;
        }
        private void Loaddata()
        {
            gridControl_CTTour.DataSource = bus.getListChuongTrinhTour(this.ma);
            loaddatatotext();
            xuli.DongText(tableLayoutPanel_CTChuongtrinh, gridControl_CTChuongtrinh);
            loadComBoBox();
        }
        private void loadComBoBox()
        {
            cbo_TenKhachSan.DataSource = busKS.getKhachSan();
            cbo_TenKhachSan.DisplayMember = "TENKHACHSAN";
            cbo_TenKhachSan.ValueMember = "MAKHACHSAN";
        }
        private void loaddatatotext()
        {
            cbo_MaChuongTrinh.DataBindings.Clear();
            cbo_MaChuongTrinh.DataBindings.Add("text", gridControl_CTTour.DataSource, "MACHUONGTRINH");

            cbo_TenTour.DataBindings.Clear();
            cbo_TenTour.DataBindings.Add("text", gridControl_CTTour.DataSource, "TENTOUR");

            cbo_TenKhachSan.DataBindings.Clear();
            cbo_TenKhachSan.DataBindings.Add("text", gridControl_CTTour.DataSource, "TENKHACHSAN");

            txt_TenChuongTrinh.DataBindings.Clear();
            txt_TenChuongTrinh.DataBindings.Add("text", gridControl_CTTour.DataSource, "TENCHUONGTRINH");

            dateEdit_Ngay.DataBindings.Clear();
            dateEdit_Ngay.DataBindings.Add("text", gridControl_CTTour.DataSource, "NGAY");

            txt_ChiTiet.DataBindings.Clear();
            txt_ChiTiet.DataBindings.Add("text", gridControl_CTTour.DataSource, "GHICHU");
        }
        
        private void MH_ChuongTrinhTour_Load(object sender, EventArgs e)
        {
            xuli.DongText(tableLayoutPanel_TTCTTours, gridControl_CTTour);
            xuli.DongText(tableLayoutPanel_CTChuongtrinh, gridControl_CTChuongtrinh);
            Loaddata();
            btn_Luu.Enabled = false;
            btn_Huy.Enabled = false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            xuli.MoVaXoaText(tableLayoutPanel_TTCTTours, gridControl_CTTour);
            cbo_MaChuongTrinh.Enabled = false;
            //cbo_TenTour.Enabled = false;
            cbo_MaChuongTrinh.Text = bus.getMaChuongTrinh();
            cbo_TenTour.Text = this.ma;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (xuli.checkInput(tableLayoutPanel_TTCTTours))
            {
                if (check == true)
                {
                    DateTime dt = Convert.ToDateTime(dateEdit_Ngay.EditValue);
                    CHUONGTRINHTOUR add = new CHUONGTRINHTOUR();
                    add.MACHUONGTRINH = cbo_MaChuongTrinh.Text;
                    add.MATOUR = cbo_TenTour.SelectedValue.ToString();
                    add.TENCHUONGTRINH = txt_TenChuongTrinh.Text.Trim();
                    add.NGAY = dt;
                    add.MAKHACHSAN = cbo_TenKhachSan.SelectedValue.ToString();
                    add.GHICHU = txt_ChiTiet.Text.Trim();
                    if (bus.addCTTour(add))
                        MessageBox.Show("Thêm chương trình tour thành công");
                    else
                        MessageBox.Show("Thêm chương trình tour không thành công");
                }
                else
                {
                    DateTime dt = Convert.ToDateTime(dateEdit_Ngay.EditValue);
                    CHUONGTRINHTOUR update = new CHUONGTRINHTOUR();
                    update.MACHUONGTRINH = cbo_MaChuongTrinh.Text;
                    update.MATOUR = this.ma;
                    update.MAKHACHSAN = cbo_TenKhachSan.SelectedValue.ToString();
                    update.TENCHUONGTRINH = txt_TenChuongTrinh.Text;
                    update.NGAY = dt;
                    update.GHICHU = txt_ChiTiet.Text;

                    if (bus.editCTTour(update))
                        MessageBox.Show("Cập nhật tour thành công");
                    else
                        MessageBox.Show("Cập nhật tour không thành công");
                }
            }
            Loaddata();
            gridControl_CTTour.DataSource = bus.getAllChuongTrinhTour();
            xuli.DongText(tableLayoutPanel_TTCTTours, gridControl_CTTour);
            btn_Huy.Enabled = false;
            btn_Luu.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            check = false;
            cbo_MaChuongTrinh.Enabled = false;
            xuli.MoText(tableLayoutPanel_TTCTTours, gridControl_CTTour);
            cbo_MaChuongTrinh.Enabled = false;
            cbo_TenTour.Enabled = false;
            btn_Luu.Enabled = true;
            btn_Huy.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int x = gridView_CTTour.FocusedRowHandle;// row selected
                string data = gridView_CTTour.GetRowCellValue(x, "MACHUONGTRINH").ToString(); // matour selected
                if (bus.deleteCTTour(data)) MessageBox.Show("Xóa thành công chương trình tour: " + data);
                else MessageBox.Show("Xóa không thành công chương trình tour: " + data);
                Loaddata();
            }
        }

        private void gridControl_CTTour_Click(object sender, EventArgs e)
        {
            try
            {
                int x = gridView_CTTour.FocusedRowHandle;// row selected
                string data = gridView_CTTour.GetRowCellValue(x, "MACHUONGTRINH").ToString(); // matour selected
                gridControl_CTChuongtrinh.DataSource = busct.getListChuongTrinh(data);
                cbo_ChuongTrinh.Text = data;

            }
            catch
            {
                MessageBox.Show("Chưa có chương trình cho tour");
            }

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                MH_ChuongTrinhTour_Load(sender, e);
                btn_Luu.Enabled = false;
                btn_Huy.Enabled = false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ThemCT_Click(object sender, EventArgs e)
        {
            check2 = true;
            
            int x = gridView_CTTour.FocusedRowHandle;// row selected
            string data = gridView_CTTour.GetRowCellValue(x, "MACHUONGTRINH").ToString(); // matour selected
            cbo_ChuongTrinh.Text = data;
            xuli.MoText(tableLayoutPanel_CTChuongtrinh, gridControl_CTChuongtrinh);
            cbo_ChuongTrinh.Enabled = false;

        }

        private void btn_XoaCT_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int x = gridView_CTTour.FocusedRowHandle;// row selected
                string dd = gridView_CTTour.GetRowCellValue(x, "MADIADIEM").ToString(); // matour selected
                string ct = gridView_CTTour.GetRowCellValue(x, "MACHUONGTRINH").ToString(); // matour selected
                CHITIETCHUONGTRINH a = new CHITIETCHUONGTRINH();
                a.MACHUONGTRINH = ct;
                a.MADIADIEM = dd;
                a.GHICHU = txt_GhiChu.Text.Trim();
                if (busct.deleteCTChuongTrinh(a))
                    MessageBox.Show("Xóa thành công chương trình");
                else
                    MessageBox.Show("Xóa không thành công chương trình");
            }
        }

        private void btn_SuaCT_Click(object sender, EventArgs e)
        {
            check2 = false;
            xuli.MoText(tableLayoutPanel_CTChuongtrinh, gridControl_CTChuongtrinh);
            cbo_ChuongTrinh.Enabled = false;
        }

        private void btn_HuyCT_Click(object sender, EventArgs e)
        {

        }

        private void btn_LuuCT_Click(object sender, EventArgs e)
        {
            if (xuli.checkInput(tableLayoutPanel_CTChuongtrinh))
            {
                try
                {
                    if(check2)
                    {
                        CHITIETCHUONGTRINH a = new CHITIETCHUONGTRINH();
                        a.MACHUONGTRINH = cbo_ChuongTrinh.Text;
                        a.MADIADIEM = cbo_DiaDiem.SelectedValue.ToString();
                        a.GHICHU = txt_GhiChu.Text.Trim();
                        if(busct.addCTChuongTrinh(a))
                            MessageBox.Show("Thêm chi tiết chương trình thành công");
                        else
                            MessageBox.Show("Thêm chi tiêt chương trình thất bại");
                    }
                    else
                    {

                        CHITIETCHUONGTRINH a = new CHITIETCHUONGTRINH();
                        a.MACHUONGTRINH = cbo_ChuongTrinh.Text;
                        a.MADIADIEM = cbo_DiaDiem.SelectedValue.ToString();
                        a.GHICHU = txt_GhiChu.Text.Trim();
                        if (busct.editCTChuongTrinh(a))
                            MessageBox.Show("Cập nhật chi tiêt chương trình thành công");
                        else
                            MessageBox.Show("Cập nhật chi tiết chương trình thất bại");
                    }
                    Loaddata();
                    
                }
                catch
                {
                    MessageBox.Show("Thêm chương trình không thành công");
                }
            }
        }

        private void cbo_DiaDiem_DropDown(object sender, EventArgs e)
        {
                BUS_DiaDiem busdd = new BUS_DiaDiem();
                cbo_DiaDiem.DataSource = busdd.getAllDD();
                cbo_DiaDiem.DisplayMember = "TENDIADIEM";
                cbo_DiaDiem.ValueMember = "MADIADIEM";
        }

        private void cbo_TenTour_DropDown(object sender, EventArgs e)
        {
            cbo_TenTour.DataSource = bustour.getAll();
            cbo_TenTour.DisplayMember = "TENTOUR";
            cbo_TenTour.ValueMember = "MATOUR";
        }

        private void gridControl_CTChuongtrinh_Click(object sender, EventArgs e)
        {
            int x = gridView_CTTour.FocusedRowHandle;// row selected
            //string dd = gridView_CTTour.GetRowCellValue(x, "MADIADIEM").ToString(); // matour selected
        }
    }
}
